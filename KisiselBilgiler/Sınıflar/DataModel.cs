using KisiselBilgiler.Sınıflar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselBilgiler
{
    public class DataModel
    {
        #region Global Tanımlamalar
        SqlConnection con; SqlCommand cmd;
        SqlConnection con2; SqlCommand cmd2;
        List<Sehir> Sehirler;
        List<Ilce> Ilceler;
        List<Universite> Universiteler;
        List<Fakulte> Fakulteler;
        List<Bolum> Bolumler;
      
        #endregion

        #region Yapıcı Metot
        public DataModel()
        {
            con = new SqlConnection(ConnectionString.ConStr);
            cmd = con.CreateCommand();
            con2 = new SqlConnection(ConnectionString.ConStr2);
            cmd2 = con2.CreateCommand();

        }
        #endregion

        #region VeriÇekme Methodları

        /// <summary>
        /// Veritabanından Sehir verilerini getirmemize yarar.
        /// </summary>
        /// <returns></returns>
        public List<Sehir> SehirGetir()
        {
            Sehirler = new List<Sehir>();
            try
            {
                cmd2.CommandText = "SELECT ID,Isim FROM Sehirler";
                cmd2.Parameters.Clear();
                con2.Open();
                SqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    Sehir s = new Sehir();
                    s.ID = reader.GetInt32(0);
                    s.Sehir_Isim = reader.GetString(1);
                    Sehirler.Add(s);
                }
                return Sehirler;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Hata=>" + ex.Message);
                return null;
            }
            finally
            {
                con2.Close();
            }
        }
        /// <summary>
        /// Veritabanından İlçe verilerini sehirID'ne göre getirmemize yarar.
        /// </summary>
        /// <returns></returns>
        public List<Ilce> IlceGetir(int SehirID)
        {
            Ilceler = new List<Ilce>();
            try
            {
                cmd2.CommandText = "SELECT ID,SehirID,Isim FROM Ilceler WHERE SehirID=@id";
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@id", SehirID);
                con2.Open();
                SqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    Ilce i = new Ilce();
                    i.ID = reader.GetInt32(0);
                    i.Sehir_ID = reader.GetInt32(1);
                    i.Ilce_Isim = reader.GetString(2);
                    Ilceler.Add(i);
                }
                return Ilceler;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Hata=>" + ex.Message);
                return null;
            }
            finally
            {
                con2.Close();
            }
        }
        /// <summary>
        /// Veritabanından Universite verilerini getirmemize yarar.
        /// </summary>
        /// <returns></returns>
        public List<Universite> UniversiteGetir()
        {
            Universiteler = new List<Universite>();
            try
            {
                cmd2.CommandText = "SELECT ID,Isim FROM yok_universiteler";
                cmd2.Parameters.Clear();
                con2.Open();
                SqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    Universite u = new Universite();
                    u.ID = reader.GetInt32(0);
                    u.Universite_Isim = reader.GetString(1);
                    Universiteler.Add(u);
                }
                return Universiteler;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Hata=>" + ex.Message);
                return null;
            }
            finally
            {
                con2.Close();
            }
        }
        /// <summary>
        /// Veritabanından Fakülte verilerini Universite'ye göre getirmemize yarar.
        /// </summary>
        /// <returns></returns>
        public List<Fakulte> FakulteGetir(int Uni_ID)
        {
            Fakulteler = new List<Fakulte>();
            try
            {
                cmd2.CommandText = "SELECT ID,UniversiteID,Isim FROM yok_fakulteler WHERE UniversiteID=@id";
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@id", Uni_ID);
                con2.Open();
                SqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    Fakulte f = new Fakulte();
                    f.ID = reader.GetString(0);
                    f.Universite_ID = reader.GetInt32(1);
                    f.Fakulte_Isim = reader.GetString(2);
                    Fakulteler.Add(f);
                }
                return Fakulteler;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Hata=>" + ex.Message);
                return null;
            }
            finally
            {
                con2.Close();
            }
        }
        /// <summary>
        /// Veritabanından Bölüm verilerini Universite'ye göre ve Fakülteye göre getirmemize yarar.
        /// </summary>
        /// <returns></returns>
        public List<Bolum> BolumGetir(int Uni_ID, int Fak_ID)
        {
            Bolumler = new List<Bolum>();
            try
            {
                cmd2.CommandText = "SELECT ID,fakulteID,UniversiteID,Isim FROM yok_bolumler WHERE UniversiteID=@UID and fakulteID=@FID";
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@UID", Uni_ID);
                cmd2.Parameters.AddWithValue("@FID", Fak_ID);
                con2.Open();
                SqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    Bolum b = new Bolum();
                    b.ID = reader.GetInt32(0);
                    b.Fakulte_ID = reader.GetString(1);
                    b.Universite_ID = reader.GetInt32(2);
                    b.Isim = reader.GetString(3);
                    Bolumler.Add(b);
                }
                return Bolumler;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Hata=>" + ex.Message);
                return null;
            }
            finally
            {
                con2.Close();
            }
        }

        #endregion

        #region Veri Atma
        public bool KisiEkle(Kisi k)
        {
           
            try
            {
                cmd.CommandText = "INSERT INTO KisiselBilgiler(Isim,SoyIsim,Telefon,TC,Sehirler,Ilceler,Adres,Universite,Fakulteler,Bolumler) VALUES (@ad,@soyad,@tel,@tc,@sehir,@ilce,@adres,@universite,@fakulte,@bolum)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ad", k.Isim);
                cmd.Parameters.AddWithValue("@soyad", k.SoyIsim);
                cmd.Parameters.AddWithValue("@tel", k.Telefon);
                cmd.Parameters.AddWithValue("@tc", k.TC_No);
                cmd.Parameters.AddWithValue("@sehir", k.Sehir);
                cmd.Parameters.AddWithValue("@ilce", k.Ilce);
                cmd.Parameters.AddWithValue("@adres", k.Adres);
                cmd.Parameters.AddWithValue("@universite", k.Universite);
                cmd.Parameters.AddWithValue("@fakulte", k.Fakulte);
                cmd.Parameters.AddWithValue("@bolum", k.Bolum);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt eklendi");
                return true;
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata=>" + ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool TCKontrol(string TC)
        {
            int[] sayilar = new int[11];
            for (int i = 0; i < TC.Length; i++)
            {
                sayilar[i] = Int32.Parse(TC[i].ToString());
            }
            int toplam = 0;
            for (int i = 0; i < TC.Length - 1; i++)
            {
                toplam += sayilar[i];
            }
            if (toplam.ToString()[1].ToString() == sayilar[10].ToString() & sayilar[10] % 2 == 0)
            {

                return true;
            }
            else
            {
                MessageBox.Show("Girilen Tc Kimlik No yanlıştır!\nLütfen kontrol ediniz.");
                return false;
            }
            #endregion


        }
    }
}