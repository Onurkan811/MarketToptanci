using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketToptanci.BL;
using MySql.Data.MySqlClient;

namespace MarketToptanci.DL
{
    public static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "127.0.0.1",
                Database = "onurkan",
                UserID = "root",
                Password = "1234",


            }.ConnectionString
            );
        public static int MarketEkle(Market m)
        {
            try 
            {
                if(conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                
                MySqlCommand komut = new MySqlCommand("MarketEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_ID", m.ID);
                komut.Parameters.AddWithValue("@p_Ad", m.Ad);
                komut.Parameters.AddWithValue("@p_Adres", m.Adres);
                komut.Parameters.AddWithValue("@p_Tel", m.Tel);
                komut.Parameters.AddWithValue("@p_Email", m.Email);

                int res = komut.ExecuteNonQuery();
                return res;
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return -1;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
               
            }
        }

        internal static int FirmaDuzenle(Firma f)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("FirmaDuzenle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_ID", f.ID);
                komut.Parameters.AddWithValue("@p_Ad", f.Ad);
                komut.Parameters.AddWithValue("@p_Adres", f.Adres);
                komut.Parameters.AddWithValue("@p_Tel", f.Tel);
                komut.Parameters.AddWithValue("@p_Email", f.Email);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return -1;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int FirmaEkle(Firma f)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("FirmaEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_ID", f.ID);
                komut.Parameters.AddWithValue("@p_Ad", f.Ad);
                komut.Parameters.AddWithValue("@p_Adres", f.Adres);
                komut.Parameters.AddWithValue("@p_Tel", f.Tel);
                komut.Parameters.AddWithValue("@p_Email", f.Email);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return -1;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static DataSet FirmaGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("FirmaHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("FirmaBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataset);

                return dataset;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return null;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int FirmaSil(Guid id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("FirmaSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_ID", id);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return -1;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int MarketDuzenle(Market m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("MarketDuzenle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_ID", m.ID);
                komut.Parameters.AddWithValue("@p_Ad", m.Ad);
                komut.Parameters.AddWithValue("@p_Adres", m.Adres);
                komut.Parameters.AddWithValue("@p_Tel", m.Tel);
                komut.Parameters.AddWithValue("@p_Email", m.Email);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return -1;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static DataSet MarketGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open) 
                { 
                    conn.Open();
                }

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("MarketHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("MarketBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataset);

                return dataset;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return null;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int MarketSil(Guid id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("MarketSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_ID", id);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return -1;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int UrunEkle(Urun u)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("UrunEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_ID", u.ID);
                komut.Parameters.AddWithValue("@p_Ad", u.Ad);
                komut.Parameters.AddWithValue("@p_Kategori", u.Kategori);
                komut.Parameters.AddWithValue("@p_Firma", u.Firma);
                komut.Parameters.AddWithValue("@p_Fiyat", u.Fiyat);
                komut.Parameters.AddWithValue("@p_Miktar", u.Miktar);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                return -1;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static DataSet UrunGetir(string filtre)
        {
            throw new NotImplementedException();
        }
    }
}
