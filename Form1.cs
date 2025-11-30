using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yazlab1.DataAcsess;
using System.Data.SqlClient;
using Yazlab1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Yazlab1
{
    public partial class Form1 : Form
    {
        DataBase db = new DataBase(); // Veritabaný sýnýfýný baþlat

        public Form1()
        {
            InitializeComponent();
            // DataGridView'e tarifleri yükle
            dataGridView1.DataSource = db.GetTarifList();
            // Detaylar butonu ekleme
            DataGridViewButtonColumn detayButtonColumn = new DataGridViewButtonColumn();
            detayButtonColumn.HeaderText = "Detaylar";
            detayButtonColumn.Name = "Detaylar";
            detayButtonColumn.Text = "Göster";
            detayButtonColumn.UseColumnTextForButtonValue = true; // Buton metnini kullan
            dataGridView1.Columns.Add(detayButtonColumn);
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void label3_Click(object sender, EventArgs e)
        {

        }

        public void Tarif_Ekle_Click(object sender, EventArgs e)
        {
            TarifEkle tarifEkle = new TarifEkle();
            tarifEkle.Show();

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Eðer týklanan sütun Detaylar sütunu ise
            if (e.ColumnIndex == dataGridView1.Columns["Detaylar"].Index && e.RowIndex >= 0)
            {
                // Seçili satýrdaki tarif bilgilerini al
                int selectedTarifId = (int)dataGridView1.Rows[e.RowIndex].Cells["TarifID"].Value; // Doðrudan int olarak al

                // Detay formunu aç
                Detay detayForm = new Detay(selectedTarifId);
                detayForm.Show(); // Detay formunu göster
            }
        }


        private void DetaylarButon_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int selectedTarifAdi = (int)dataGridView1.CurrentRow.Cells["TarifAdi"].Value; // Seçili tarifin ID'sini al
                Detay detayForm = new Detay(selectedTarifAdi); // Detay formunu aç
                detayForm.Show(); // Detay formunu göster
            }
            else
            {
                MessageBox.Show("Lütfen bir tarif seçin.");
            }
        }

        public void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Tarif_Güncelle_Click(object sender, EventArgs e)
        {
            TarifGuncelle tarifGuncelle = new TarifGuncelle();
            tarifGuncelle.Show();
        }

        private void Tarif_Sil_Click(object sender, EventArgs e)
        {
            TarifSil tarifsil = new TarifSil();
            tarifsil.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AramaFiltreleme aramaFiltreleme = new AramaFiltreleme();
            aramaFiltreleme.Show();
        }
    }
}