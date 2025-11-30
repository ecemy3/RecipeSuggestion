using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Yazlab1
{
    public partial class TarifGuncelle : Form
    {
        private string connectionString = "Data Source=BERIL;Initial Catalog=Tarif;Integrated Security=True";

        public TarifGuncelle()
        {
            InitializeComponent();
            LoadTarifAdlari();
        }

        private void LoadTarifAdlari()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT TarifAdi FROM Tarif";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        TarifAdiCombo.Items.Add(reader["TarifAdi"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void TarifAdiCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTarif = TarifAdiCombo.SelectedItem.ToString();
            LoadTarifAndMalzemeDetails(selectedTarif);
        }

        private void LoadTarifAndMalzemeDetails(string tarifAdi)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                 SELECT 
                   t.TarifID, t.TarifAdi, t.Kategori, t.HazirlanmaSuresi, t.Talimatlar,
                   m.MalzemeID, m.MalzemeAdi, tm.MalzemeMiktar, 
                   m.ToplamMiktar, m.MalzemeBirim, m.BirimFiyat
                 FROM 
                   Tarif t 
                 JOIN 
                   [Tarif-Malzeme] tm ON t.TarifID = tm.TarifID
                 JOIN 
                   Malzeme m ON tm.MalzemeID = m.MalzemeID
                 WHERE 
                   t.TarifAdi = @TarifAdi";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TarifAdi", tarifAdi);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                GuncelleGrid.DataSource = dataTable;
                GuncelleGrid.Columns["TarifID"].Visible = false;
                GuncelleGrid.Columns["MalzemeID"].Visible = false;
            }
        }

        private void GuncelleGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (DataGridViewRow row in GuncelleGrid.Rows)
                {
                    if (row.IsNewRow) continue;

                    int malzemeID = Convert.ToInt32(row.Cells["MalzemeID"].Value);
                    string malzemeAdi = row.Cells["MalzemeAdi"].Value.ToString();
                    int malzemeMiktari = Convert.ToInt32(row.Cells["MalzemeMiktar"].Value);
                    int toplamMiktar = Convert.ToInt32(row.Cells["ToplamMiktar"].Value);
                    string malzemeBirim = row.Cells["MalzemeBirim"].Value.ToString();
                    decimal birimFiyat = Convert.ToDecimal(row.Cells["BirimFiyat"].Value);

                    string queryMalzeme = @"
                                     UPDATE 
                                       Malzeme 
                                     SET 
                                       MalzemeAdi = @MalzemeAdi,
                                       ToplamMiktar = @ToplamMiktar,
                                       MalzemeBirim = @MalzemeBirim,
                                       BirimFiyat = @BirimFiyat
                                     WHERE 
                                       MalzemeID = @MalzemeID";

                    using (SqlCommand cmd = new SqlCommand(queryMalzeme, conn))
                    {
                        cmd.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                        cmd.Parameters.AddWithValue("@ToplamMiktar", toplamMiktar);
                        cmd.Parameters.AddWithValue("@MalzemeBirim", malzemeBirim);
                        cmd.Parameters.AddWithValue("@BirimFiyat", birimFiyat);
                        cmd.Parameters.AddWithValue("@MalzemeID", malzemeID);
                        cmd.ExecuteNonQuery();
                    }

                    int tarifID = Convert.ToInt32(row.Cells["TarifID"].Value);
                    string queryTarifMalzeme = @"
                                             UPDATE [Tarif-Malzeme]
                                             SET MalzemeMiktar = @MalzemeMiktar
                                             WHERE MalzemeID = @MalzemeID AND TarifID = @TarifID";

                    using (SqlCommand cmd = new SqlCommand(queryTarifMalzeme, conn))
                    {
                        cmd.Parameters.AddWithValue("@MalzemeMiktar", malzemeMiktari);
                        cmd.Parameters.AddWithValue("@MalzemeID", malzemeID);
                        cmd.Parameters.AddWithValue("@TarifID", tarifID);
                        cmd.ExecuteNonQuery();
                    }

                    string tarifAdi = row.Cells["TarifAdi"].Value.ToString();
                    string kategori = row.Cells["Kategori"].Value.ToString();
                    string hazirlanmaSuresi = row.Cells["HazirlanmaSuresi"].Value.ToString();
                    string talimatlar = row.Cells["Talimatlar"].Value.ToString();

                    string queryTarif = @"
                                      UPDATE 
                                       Tarif 
                                      SET 
                                       TarifAdi = @TarifAdi,
                                       Kategori = @Kategori,
                                       HazirlanmaSuresi = @HazirlanmaSuresi,
                                       Talimatlar = @Talimatlar
                                      WHERE 
                                       TarifID = @TarifID";

                    using (SqlCommand cmd = new SqlCommand(queryTarif, conn))
                    {
                        cmd.Parameters.AddWithValue("@TarifAdi", tarifAdi);
                        cmd.Parameters.AddWithValue("@Kategori", kategori);
                        cmd.Parameters.AddWithValue("@HazirlanmaSuresi", hazirlanmaSuresi);
                        cmd.Parameters.AddWithValue("@Talimatlar", talimatlar);
                        cmd.Parameters.AddWithValue("@TarifID", tarifID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Güncelleme başarılı!");
            }
        }
    }
}
