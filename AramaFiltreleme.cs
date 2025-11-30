using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Yazlab1.DataAcsess;
using Yazlab1.Models;

namespace Yazlab1
{
    public partial class AramaFiltreleme : Form
    {
        private List<string> ingredientsList = new List<string>();
        private List<Tuple<double, string>> quantitiesAndUnitsList = new List<Tuple<double, string>>();
        private DataBase db = new DataBase();


        public AramaFiltreleme()
        {
            InitializeComponent();
            dataGridEslestirilenTarifler.CellFormatting += DataGridEslestirilenTarifler_CellFormatting;
        }

        private void MalzmEkleBtn_Click(object sender, EventArgs e)
        {
            string ingredient = MalzemeTxt.Text;
            string unit = MalzemeBirimiCmb.SelectedItem?.ToString();
            double quantity;

            if (double.TryParse(MalzemeMiktar.Text, out quantity) && !string.IsNullOrWhiteSpace(ingredient) && !string.IsNullOrWhiteSpace(unit))
            {
               
                Malzeme_Listesi.Items.Add($"{ingredient} - {quantity} {unit}");

                
                ingredientsList.Add(ingredient);

                
                quantitiesAndUnitsList.Add(new Tuple<double, string>(quantity, unit));

                MalzemeTxt.Clear();
                MalzemeMiktar.Clear();
                MalzemeBirimiCmb.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir malzeme, miktar ve birim girin.");
            }
        }
        private void MzmAraBtn_Click(object sender, EventArgs e)
        {
           
            List<string> kullaniciMalzemeleri = ingredientsList.ToList();

            
            TarifEslestirici eslestirici = new TarifEslestirici();
            List<Tuple<string, double>> eslesenTarifler = eslestirici.TarifleriEslestir(kullaniciMalzemeleri);

            
            dataGridEslestirilenTarifler.Rows.Clear();
            dataGridEslestirilenTarifler.Columns.Clear();

            
            dataGridEslestirilenTarifler.Columns.Add("TarifAdi", "Tarif Adı");
            dataGridEslestirilenTarifler.Columns.Add("EslesmeYuzdesi", "Eşleşme Yüzdesi");

            
            foreach (var tarif in eslesenTarifler)
            {
                dataGridEslestirilenTarifler.Rows.Add(tarif.Item1, $"{tarif.Item2:F2}%");
            }
        }

        private void TarifArabtn_Click(object sender, EventArgs e)
        {
            
            string aramaTerimi = TarifAdıAraTxt.Text;

            
            if (!string.IsNullOrWhiteSpace(aramaTerimi))
            {
                List<string> eslesenTarifler = db.TarifleriAra(aramaTerimi);

                TarifleriGÖsterList.Items.Clear();
                if (eslesenTarifler.Count > 0)
                {
                    foreach (var tarif in eslesenTarifler)
                    {
                        TarifleriGÖsterList.Items.Add(tarif);
                    }
                }
                else
                {
                    MessageBox.Show("Eşleşen tarif bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir arama terimi girin.");
            }
        }

        private void HazırlanmaSuresiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTime = HazırlanmaSuresiComboBox.SelectedItem.ToString();
            DataTable tariflerDataTable = db.GetTarifAllList();
            DataView filtrelenmisTarifler;

            switch (selectedTime)
            {
                case "En Hızlıdan En Yavaşa":
                    filtrelenmisTarifler = new DataView(tariflerDataTable);

                    filtrelenmisTarifler.Sort = "HazirlanmaSuresi ASC";
                    break;
                case "En Yavaşdan En Hızlıya":
                    filtrelenmisTarifler = new DataView(tariflerDataTable);

                    filtrelenmisTarifler.Sort = "HazirlanmaSuresi DESC";
                    break;
                case "Tüm Tarifler":
                default:
                    filtrelenmisTarifler = new DataView(tariflerDataTable);
                    filtrelenmisTarifler.Sort = "HazirlanmaSuresi ASC";
                    break;
            }

            Filtreleme.Items.Clear();

            foreach (DataRowView row in filtrelenmisTarifler)
            {
                string tarifAdı = row["TarifAdi"].ToString();
                string hazirlanmaSüresi = row["HazirlanmaSuresi"].ToString();
                string listele = $"{tarifAdı} - {hazirlanmaSüresi} ";
                Filtreleme.Items.Add(listele);
            }

        }

        private void KategoriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = KategoriComboBox.SelectedItem.ToString();
            DataTable tariflerDataTable = db.GetTarifAllList();
            DataView filtrelenmisTarifler;

            filtrelenmisTarifler = new DataView(tariflerDataTable)
            {
                RowFilter = $"Kategori = '{selectedCategory}'" 
            };

            Filtreleme.Items.Clear();

            foreach (DataRowView row in filtrelenmisTarifler)
            {
                string tarifAdı = row["TarifAdi"].ToString();
                string kategori = row["Kategori"].ToString();
                string listele = $"{tarifAdı} - {kategori}";
                Filtreleme.Items.Add(listele);
            }
        }

        private void MalzemeCOmboBOxx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = MalzemeCOmboBOxx.SelectedItem.ToString();
            TarifEslestirici eslestirici = new TarifEslestirici();

            var tarifVeMalzemeSayilari = eslestirici.TumTarifleriMalzemeSayisinaGoreGetir();

            List<KeyValuePair<string, int>> filtrelenmisTarifler = tarifVeMalzemeSayilari.ToList();

            switch (selectedOption)
            {
                case "Azalan Malzeme Sayısı":
                    filtrelenmisTarifler = filtrelenmisTarifler.OrderByDescending(t => t.Value).ToList();
                    break;
                case "Artan Malzeme Sayısı":
                    filtrelenmisTarifler = filtrelenmisTarifler.OrderBy(t => t.Value).ToList();
                    break;
                default:
                    break;
            }

            Filtreleme.Items.Clear();

            foreach (var tarif in filtrelenmisTarifler)
            {
                string tarifBilgisi = $"{tarif.Key} - Malzeme Sayısı: {tarif.Value}";
                Filtreleme.Items.Add(tarifBilgisi);
            }
        }

        private void DataGridEslestirilenTarifler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridEslestirilenTarifler.Columns[e.ColumnIndex].Name == "EslesmeYuzdesi")
            {
                if (e.Value != null)
                {
                    string eslesmeYuzdesiStr = e.Value.ToString().TrimEnd('%');

                    if (double.TryParse(eslesmeYuzdesiStr, out double eslesmeYuzdesi))
                    {
                        if (eslesmeYuzdesi == 100)
                        {
                            dataGridEslestirilenTarifler.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                            dataGridEslestirilenTarifler.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                        }
                        else
                        {
                            dataGridEslestirilenTarifler.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                            dataGridEslestirilenTarifler.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                        }
                    }
                }
            }
        }
        //private void btnMaliyetHesapla_Click(object sender, EventArgs e)
        //{
        //    Aramafiltreleme aramaFiltreleme = new Aramafiltreleme();

        //    List<Tuple<string, float>> kullaniciMalzemeleri = new List<Tuple<string, float>>();

        //    for (int i = 0; i < ingredientsList.Count; i++)
        //    {
        //        string malzemeAdi = ingredientsList[i];
        //        double miktar = quantitiesAndUnitsList[i].Item1;
        //        string birim = quantitiesAndUnitsList[i].Item2;

        //        kullaniciMalzemeleri.Add(new Tuple<string, float>(malzemeAdi, (float)miktar));
        //    }

        //    Dictionary<string, double> eksikMaliyetler = aramaFiltreleme.EksikMaliyetHesapla(kullaniciMalzemeleri);

        //    Eksikmaliyetlistbox.Items.Clear();
        //    foreach (var maliyet in eksikMaliyetler)
        //    {
        //        string item = $"Tarif: {maliyet.Key}, Eksik Maliyet: {maliyet.Value} TL";
        //        Eksikmaliyetlistbox.Items.Add(item);
        //    }
        //}
        private void btnMaliyetHesapla_Click(object sender, EventArgs e)
        {
            Aramafiltreleme aramaFiltreleme = new Aramafiltreleme();

            List<Tuple<string, float>> kullaniciMalzemeleri = new List<Tuple<string, float>>();

            for (int i = 0; i < ingredientsList.Count; i++)
            {
                string malzemeAdi = ingredientsList[i];
                double miktar = quantitiesAndUnitsList[i].Item1;
                string birim = quantitiesAndUnitsList[i].Item2;

                kullaniciMalzemeleri.Add(new Tuple<string, float>(malzemeAdi, (float)miktar));
            }

            Dictionary<string, double> eksikMaliyetler = aramaFiltreleme.EksikMaliyetHesapla(kullaniciMalzemeleri);

            // DataGridView'i temizleyin
            EksikmaliyetDataGridView.Rows.Clear();
            EksikmaliyetDataGridView.Columns.Clear();

            // DataGridView için gerekli kolonları ekleyin
            EksikmaliyetDataGridView.Columns.Add("Tarif", "Tarif");
            EksikmaliyetDataGridView.Columns.Add("EksikMaliyet", "Eksik Maliyet (TL)");

            // Eksik maliyet verilerini DataGridView'e ekleyin
            foreach (var maliyet in eksikMaliyetler)
            {
                EksikmaliyetDataGridView.Rows.Add(maliyet.Key, maliyet.Value);
            }
        }
    }
}
