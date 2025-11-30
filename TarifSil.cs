using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yazlab1
{
    public partial class TarifSil : Form
    {
        public TarifSil()
        {
            InitializeComponent();
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            string tarifAdi = TarifAdıTxt.Text;
            string kategori = comboBox1.SelectedItem.ToString();

            string connectionString = "Server=BERIL;Database=Tarif;Integrated Security=True;";

            string selectTarifIdQuery = "SELECT TarifID FROM Tarif WHERE TarifAdi = @tarifAdi AND Kategori = @kategori";

            string deleteRelatedQuery = "DELETE FROM [Tarif-Malzeme] WHERE TarifID = @tarifID";

            string deleteTarifQuery = "DELETE FROM Tarif WHERE TarifID = @tarifID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    int tarifID = 0;
                    using (SqlCommand selectCommand = new SqlCommand(selectTarifIdQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@tarifAdi", tarifAdi);
                        selectCommand.Parameters.AddWithValue("@kategori", kategori);

                        object result = selectCommand.ExecuteScalar();
                        if (result != null)
                        {
                            tarifID = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen tarif bulunamadı.");
                            return;
                        }
                    }

                    using (SqlCommand relatedCommand = new SqlCommand(deleteRelatedQuery, connection))
                    {
                        relatedCommand.Parameters.AddWithValue("@tarifID", tarifID);
                        relatedCommand.ExecuteNonQuery();
                    }

                    using (SqlCommand tarifCommand = new SqlCommand(deleteTarifQuery, connection))
                    {
                        tarifCommand.Parameters.AddWithValue("@tarifID", tarifID);

                        int rowsAffected = tarifCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Tarif başarıyla silindi!");
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen tarif bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}