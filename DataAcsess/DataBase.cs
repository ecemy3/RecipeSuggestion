using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Yazlab1.Models;

namespace Yazlab1.DataAcsess
{
    public class DataBase
    {
        public string ConnectionString { get; set; }
        public SqlConnection conn;

        public DataBase()
        {
            ConnectionString = "Server=BERIL;Database=Tarif;Integrated Security=True;";
        }
        public DataTable GetTarifList()
        {
            string query = @"
                SELECT 
                    T.TarifID,
                    T.TarifAdi,
                    T.HazirlanmaSuresi,
                    SUM(M.BirimFiyat * TM.MalzemeMiktar) AS ToplamMaliyet
                FROM 
                    Tarif T
                JOIN 
                    [Tarif-Malzeme] TM ON T.TarifID = TM.TarifID
                JOIN 
                    Malzeme M ON TM.MalzemeID = M.MalzemeID
                GROUP BY 
                   T.TarifID, T.TarifAdi, T.HazirlanmaSuresi;
            ";

            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Bağlantı başarılı!");

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    sda.Fill(dt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bir hata oluştu: " + ex.Message);
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

            return dt;
        }
        public bool AddTarif(Tarif tarif)
        {
            string query = @"
                INSERT INTO Tarif (TarifAdi, HazirlanmaSuresi, Talimatlar, Kategori)
                VALUES (@TarifAdi, @HazirlanmaSuresi, @Talimatlar, @Kategori)";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TarifAdi", tarif.TarifAdi);
                    cmd.Parameters.AddWithValue("@HazirlanmaSuresi", tarif.HazirlanmaSuresi);
                    cmd.Parameters.AddWithValue("@Talimatlar", tarif.Talimatlar);
                    cmd.Parameters.AddWithValue("@Kategori", tarif.Kategori);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tarif eklenirken hata oluştu: " + ex.Message);
                    return false;
                }
            }
        }
        public bool AddMalzeme(Malzeme malzeme)
        {
            string query = @"
        INSERT INTO Malzeme (MalzemeAdi, ToplamMiktar, MalzemeBirim, BirimFiyat)
        VALUES (@MalzemeAdi, @ToplamMiktar, @MalzemeBirim, @BirimFiyat)";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@MalzemeAdi", malzeme.MalzemeAdi);
                    cmd.Parameters.AddWithValue("@ToplamMiktar", malzeme.ToplamMiktar);
                    cmd.Parameters.AddWithValue("@MalzemeBirim", malzeme.MalzemeBirim);
                    cmd.Parameters.AddWithValue("@BirimFiyat", malzeme.BirimFiyat);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Malzeme eklenirken hata oluştu: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable GetTarifAllList()
        {
            string query = "SELECT * FROM Tarif";

            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    sda.Fill(dt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bir hata oluştu: " + ex.Message);
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

            return dt;
        }

        public bool CheckTarifExists(string tarifAdi)
        {
            string query = "SELECT COUNT(*) FROM Tarif WHERE TarifAdi = @TarifAdi";
            int count = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TarifAdi", tarifAdi);

                    count = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

            return count > 0;
        }

        public int GetTarifIDByName(string tarifAdi)
        {
            string query = "SELECT TarifID FROM Tarif WHERE TarifAdi = @TarifAdi";
            int tarifID = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TarifAdi", tarifAdi);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        tarifID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

            return tarifID;
        }

        public int GetMalzemeIDByName(string malzemeAdi)
        {
            string query = "SELECT MalzemeID FROM Malzeme WHERE MalzemeAdi = @MalzemeAdi";
            int malzemeID = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        malzemeID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

            return malzemeID;
        }

        public bool AddMalzemeToTarif(int tarifID, int malzemeID, float MalzemeMiktar)
        {
            string query = @"
                 SET IDENTITY_INSERT [Tarif-Malzeme] ON;
                 INSERT INTO [Tarif-Malzeme] (TarifID, MalzemeID, MalzemeMiktar)
                 VALUES (@TarifID, @MalzemeID, @MalzemeMiktar);
                 SET IDENTITY_INSERT [Tarif-Malzeme] OFF;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TarifID", tarifID);
                    cmd.Parameters.AddWithValue("@MalzemeID", malzemeID);
                    cmd.Parameters.AddWithValue("@MalzemeMiktar", MalzemeMiktar);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Malzeme eklenirken hata oluştu: " + ex.Message);
                    return false;
                }
            }
        }

        public List<string> TarifleriAra(string aramaTerimi)
        {
            List<string> tarifler = new List<string>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT TarifAdi FROM Tarif WHERE TarifAdi LIKE @aramaTerimi";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@aramaTerimi", "%" + aramaTerimi + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tarifAdi = reader["TarifAdi"].ToString();
                            tarifler.Add(tarifAdi);
                        }
                    }
                }
            }

            return tarifler;
        }
        public Tarif GetTarifById(int tarifId)
        {
            string query = @"
            SELECT 
                T.TarifID,
                T.TarifAdi, 
                T.HazirlanmaSuresi, 
                T.Talimatlar,     
                T.Kategori, 
                M.MalzemeAdi, 
                TM.MalzemeMiktar 
            FROM 
                Tarif T
            JOIN 
                [Tarif-Malzeme] TM ON T.TarifID = TM.TarifID
            JOIN 
                 Malzeme M ON TM.MalzemeID = M.MalzemeID
            WHERE 
                 T.TarifID = @TarifID";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TarifID", tarifId);
                SqlDataReader reader = cmd.ExecuteReader();

                Tarif tarif = null;

                if (reader.Read())
                {
                    tarif = new Tarif
                    {
                        TarifId = (int)reader["TarifID"],
                        TarifAdi = reader["TarifAdi"].ToString(),
                        HazirlanmaSuresi = (reader["HazirlanmaSuresi"].ToString()),
                        Talimatlar = reader["Talimatlar"].ToString(),
                        Kategori = reader["Kategori"].ToString(),
                        Malzemeler = new List<Malzeme>()
                    };
                    do
                    {
                        Malzeme malzeme = new Malzeme
                        {
                            MalzemeAdi = reader["MalzemeAdi"].ToString(),
                            ToplamMiktar = (reader["MalzemeMiktar"].ToString())
                        };
                        tarif.Malzemeler.Add(malzeme);
                    } while (reader.Read());
                }
                return tarif;
            }
        }

    //    public List<Tarif> Detay()
    //    {
    //        List<Tarif> tarifListesi = new List<Tarif>();
    //        string query = @"
    //SELECT 
    //    T.TarifID,
    //    T.TarifAdi, 
    //    T.HazirlanmaSuresi, 
    //    T.Talimatlar,     
    //    T.Kategori, 
    //    M.MalzemeAdi, 
    //    TM.MalzemeMiktar 
    //FROM 
    //    Tarif T
    //JOIN 
    //    [Tarif-Malzeme] TM ON T.TarifID = TM.TarifID
    //JOIN 
    //    Malzeme M ON TM.MalzemeID = M.MalzemeID";

    //        using (SqlConnection connection = new SqlConnection(ConnectionString))
    //        {
    //            try
    //            {
    //                connection.Open();
    //                SqlCommand cmd = new SqlCommand(query, connection);
    //                SqlDataReader reader = cmd.ExecuteReader();
    //                Dictionary<int, Tarif> tarifDictionary = new Dictionary<int, Tarif>();

    //                while (reader.Read())
    //                {
    //                    int tarifID = int.Parse(reader["TarifID"].ToString());

    //                    // Eğer tarif zaten eklenmediyse, yeni bir tarif oluştur
    //                    if (!tarifDictionary.ContainsKey(tarifID))
    //                    {
    //                        Tarif tarif = new Tarif
    //                        {
    //                            TarifId = tarifID,
    //                            TarifAdi = reader["TarifAdi"].ToString(),
    //                            HazirlanmaSuresi = (reader["HazirlanmaSuresi"].ToString()),
    //                            Talimatlar = reader["Talimatlar"].ToString(),
    //                            Kategori = reader["Kategori"].ToString(),
    //                            Malzemeler = new List<Malzeme>() // Boş bir malzeme listesi oluşturuyoruz
    //                        };
    //                        tarifDictionary[tarifID] = tarif;
    //                    }

    //                    // Malzemeyi oluştur ve tarifin malzeme listesine ekle
    //                    Malzeme malzeme = new Malzeme
    //                    {
    //                        MalzemeAdi = reader["MalzemeAdi"].ToString(),
    //                        ToplamMiktar = (reader["MalzemeMiktar"].ToString())
    //                    };

    //                    tarifDictionary[tarifID].Malzemeler.Add(malzeme);
    //                }

    //                // Tüm tarifleri listeye ekliyoruz
    //                tarifListesi = tarifDictionary.Values.ToList();
    //            }
    //            catch (Exception ex)
    //            {
    //                MessageBox.Show("Hata: " + ex.Message);
    //            }
    //        }

    //        return tarifListesi;
    //    }


    }
    public class TarifEslestirici
    {
        private string connectionString = "Server=BERIL;Database=Tarif;Integrated Security=True;";

        public List<Tuple<string, double>> TarifleriEslestir(List<string> kullaniciMalzemeleri)
        {
            Dictionary<string, List<Tuple<string, float>>> tariflerVeMalzemeler = TumTarifleriGetir();
            List<Tuple<string, double>> eslesenTarifler = new List<Tuple<string, double>>();

            foreach (var tarif in tariflerVeMalzemeler)
            {
                List<Tuple<string, float>> tarifMalzemeleri = tarif.Value;

                int eslesenMalzemeSayisi = tarifMalzemeleri
                    .Select(t => t.Item1)
                    .Intersect(kullaniciMalzemeleri)
                    .Count();

                double eslesmeYuzdesi = (double)eslesenMalzemeSayisi / tarifMalzemeleri.Count * 100;

                eslesenTarifler.Add(new Tuple<string, double>(tarif.Key, eslesmeYuzdesi));
            }

            eslesenTarifler = eslesenTarifler.OrderByDescending(t => t.Item2).ToList();
            return eslesenTarifler;
        }

        private Dictionary<string, List<Tuple<string, float>>> TumTarifleriGetir()
        {
            Dictionary<string, List<Tuple<string, float>>> tariflerVeMalzemeler = new Dictionary<string, List<Tuple<string, float>>>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sorgu = @"
                SELECT 
                    T.TarifAdi, 
                    M.MalzemeAdi, 
                    TM.MalzemeMiktar 
                FROM 
                    Tarif T
                JOIN 
                    [Tarif-Malzeme] TM ON T.TarifID = TM.TarifID
                JOIN 
                    Malzeme M ON TM.MalzemeID = M.MalzemeID";

                using (SqlCommand cmd = new SqlCommand(sorgu, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string tarifAdi = reader["TarifAdi"].ToString();
                        string malzemeAdi = reader["MalzemeAdi"].ToString();
                        float malzemeMiktar = float.Parse(reader["MalzemeMiktar"].ToString());

                        if (!tariflerVeMalzemeler.ContainsKey(tarifAdi))
                        {
                            tariflerVeMalzemeler[tarifAdi] = new List<Tuple<string, float>>();
                        }

                        tariflerVeMalzemeler[tarifAdi].Add(new Tuple<string, float>(malzemeAdi, malzemeMiktar));
                    }
                }
            }

            return tariflerVeMalzemeler;
        }

        public Dictionary<string, int> TumTarifleriMalzemeSayisinaGoreGetir()
        {
            Dictionary<string, int> tarifVeMalzemeSayilari = new Dictionary<string, int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sorgu = @"
            SELECT 
                T.TarifAdi, 
                COUNT(TM.MalzemeID) AS MalzemeSayisi
            FROM 
                Tarif T
            JOIN 
                [Tarif-Malzeme] TM ON T.TarifID = TM.TarifID
            GROUP BY 
                T.TarifAdi";

                using (SqlCommand cmd = new SqlCommand(sorgu, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string tarifAdi = reader["TarifAdi"].ToString();
                        int malzemeSayisi = Convert.ToInt32(reader["MalzemeSayisi"]);

                        tarifVeMalzemeSayilari.Add(tarifAdi, malzemeSayisi);
                    }
                }
            }

            return tarifVeMalzemeSayilari;
        }

        
    }

    public class Aramafiltreleme
    {
        private string connectionString = "Server=BERIL;Database=Tarif;Integrated Security=True;";

        public Dictionary<string, double> EksikMaliyetHesapla(List<Tuple<string, float>> kullaniciMalzemeleri)
        {
            Dictionary<string, List<Tuple<string, float, double>>> tariflerVeMalzemeler = TumTarifleriGetir();
            Dictionary<string, double> tarifEksikMaliyetleri = new Dictionary<string, double>();

            foreach (var tarif in tariflerVeMalzemeler)
            {
                string tarifAdi = tarif.Key;
                List<Tuple<string, float, double>> tarifMalzemeleri = tarif.Value;
                double eksikMaliyet = 0;

                foreach (var malzeme in tarifMalzemeleri)
                {
                    string malzemeAdi = malzeme.Item1;
                    float gerekenMiktar = malzeme.Item2;
                    double birimFiyat = malzeme.Item3;
                    var kullaniciMalzeme = kullaniciMalzemeleri.FirstOrDefault(m => m.Item1 == malzemeAdi);

                    if (kullaniciMalzeme != null)
                    {
                        float kullaniciMiktari = kullaniciMalzeme.Item2;
                        if (kullaniciMiktari < gerekenMiktar)
                        {
                            float eksikMiktar = gerekenMiktar - kullaniciMiktari;
                            eksikMaliyet += eksikMiktar * birimFiyat;
                        }
                    }
                    else
                    {
                        eksikMaliyet += gerekenMiktar * birimFiyat;
                    }
                }
                tarifEksikMaliyetleri.Add(tarifAdi, eksikMaliyet);
            }

            return tarifEksikMaliyetleri;
        }
        private Dictionary<string, List<Tuple<string, float, double>>> TumTarifleriGetir()
        {
            Dictionary<string, List<Tuple<string, float, double>>> tariflerVeMalzemeler = new Dictionary<string, List<Tuple<string, float, double>>>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query= @"
                SELECT 
                    T.TarifAdi, 
                    M.MalzemeAdi, 
                    TM.MalzemeMiktar,
                    M.BirimFiyat
                FROM 
                    Tarif T
                JOIN 
                    [Tarif-Malzeme] TM ON T.TarifID = TM.TarifID
                JOIN 
                    Malzeme M ON TM.MalzemeID = M.MalzemeID";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string tarifAdi = reader["TarifAdi"].ToString();
                    string malzemeAdi = reader["MalzemeAdi"].ToString();
                    float miktar = Convert.ToSingle(reader["MalzemeMiktar"]);
                    double birimFiyat = Convert.ToDouble(reader["BirimFiyat"]);

                    if (!tariflerVeMalzemeler.ContainsKey(tarifAdi))
                    {
                        tariflerVeMalzemeler[tarifAdi] = new List<Tuple<string, float, double>>();
                    }

                    tariflerVeMalzemeler[tarifAdi].Add(new Tuple<string, float, double>(malzemeAdi, miktar, birimFiyat));
                }
            }

            return tariflerVeMalzemeler;
        }
    }


}

