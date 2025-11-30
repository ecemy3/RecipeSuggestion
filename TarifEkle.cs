using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Yazlab1.DataAcsess;
using Yazlab1.Models;

namespace Yazlab1
{
    public partial class TarifEkle : Form
    {
        private List<Malzeme> malzemeListesi = new List<Malzeme>();

        public TarifEkle()
        {
            InitializeComponent();
            LoadTarifler();

        }

        private void Tarif_ekle_Click(object sender, EventArgs e)
        {
            string tarifAdi = this.Tarif_adi.Text;
            DataBase db = new DataBase();

            if (db.CheckTarifExists(tarifAdi))
            {
                MessageBox.Show("Bu isimde bir tarif zaten mevcut!");
                return;
            }

            Tarif tarif = new Tarif
            {
                TarifAdi = tarifAdi,
                HazirlanmaSuresi = this.Hazirlanma.Text,
                Talimatlar = this.Talimatlar.Text,
                Kategori = kategori.Items[kategori.SelectedIndex].ToString()
            };

            bool result = db.AddTarif(tarif);

            if (result)
            {
                MessageBox.Show("Tarif başarıyla eklendi.");

                int tarifID = db.GetTarifIDByName(tarifAdi);
                AddMalzemeler(tarifID);

                LoadTarifler();
                ClearFormFields();
            }
            else
            {
                MessageBox.Show("Tarif eklenirken hata oluştu.");
            }
        }
        private void AddMalzemeler(int tarifID)
        {
            DataBase db = new DataBase();

            foreach (var malzeme in malzemeListesi)
            {
                int malzemeID = db.GetMalzemeIDByName(malzeme.MalzemeAdi);

                if (malzemeID != -1)
                {
                    if (float.TryParse(malzeme.ToplamMiktar, out float malzemeMiktar))
                    {
                        bool success = db.AddMalzemeToTarif(tarifID, malzemeID, malzemeMiktar);
                        if (!success)
                        {
                            MessageBox.Show($"{malzeme.MalzemeAdi} malzemesi eklenemedi.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Geçersiz miktar: {malzeme.ToplamMiktar}.");
                    }
                }
                else
                {
                    MessageBox.Show($"{malzeme.MalzemeAdi} isimli malzeme bulunamadı.");
                }
            }

            MessageBox.Show("Malzemeler başarıyla tarifle ilişkilendirildi.");
        }


        private void Malzeme_ekle_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            string malzemeAdi = this.Malzeme_adi.Text;
            string toplamMiktar = this.ToplamMiktar.Text;
            string malzemeBirim = Malzeme_birim.Items[Malzeme_birim.SelectedIndex].ToString();
            string birimFiyat = this.BirimFiyat.Text;

            Malzeme malzeme = new Malzeme
            {
                MalzemeAdi = malzemeAdi,
                ToplamMiktar = toplamMiktar,
                MalzemeBirim = malzemeBirim,
                BirimFiyat = birimFiyat
            };

            malzemeListesi.Add(malzeme);
            listBoxMalzemeler.Items.Add($"{malzemeAdi} - {toplamMiktar} {malzemeBirim} ({birimFiyat} birim fiyat)");

            bool result = db.AddMalzeme(malzeme);

            if (result)
            {
                MessageBox.Show("Malzeme başarıyla eklendi.");

            }
            else
            {
                MessageBox.Show("Malzeme eklenirken hata oluştu.");
            }

            ClearMalzemeFields();
        }

        private void ClearFormFields()
        {
            Tarif_adi.Clear();
            Hazirlanma.Clear();
            Talimatlar.Clear();
            kategori.SelectedIndex = -1;

            ClearMalzemeFields();
            malzemeListesi.Clear();
            listBoxMalzemeler.Items.Clear();
        }

        private void ClearMalzemeFields()
        {
            Malzeme_adi.Clear();
            ToplamMiktar.Clear();
            Malzeme_birim.SelectedIndex = -1;
            BirimFiyat.Clear();
            MalzemeMiktar.Clear();
        }
        private void LoadTarifler()
        {
            DataBase db = new DataBase();
            DataTable dt = db.GetTarifAllList(); 
            dataGridViewTarifekle.DataSource = dt;
          
        }
    }
}
