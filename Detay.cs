using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Yazlab1.DataAcsess;
using Yazlab1.Models;

namespace Yazlab1
{
    public partial class Detay : Form
    {
        DataBase db = new DataBase();
        public Detay(int tarifId)
        {
            InitializeComponent();
            LoadTarifDetails(tarifId);
        }

        private void LoadTarifDetails(int tarifId)
        {
            var tarif = db.GetTarifById(tarifId);

            listBoxTarifDetay.Items.Clear();

            listBoxTarifDetay.Items.Add("Tarif Adı: " + tarif.TarifAdi);
            listBoxTarifDetay.Items.Add("Hazırlanma Süresi: " + tarif.HazirlanmaSuresi);
            listBoxTarifDetay.Items.Add("Kategori: " + tarif.Kategori);
            listBoxTarifDetay.Items.Add("Talimatlar: " + tarif.Talimatlar);

            listBoxTarifDetay.Items.Add("");
            listBoxTarifDetay.Items.Add("Malzemeler:");

            foreach (var malzeme in tarif.Malzemeler)
            {
                listBoxTarifDetay.Items.Add(malzeme.MalzemeAdi + " - Miktar: " + malzeme.ToplamMiktar+" "+malzeme.MalzemeBirim);
            }
        }
    }

}
