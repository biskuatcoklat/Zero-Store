using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroStore.Models
{
    public class BarangService
    {
        SqlConnection ObjSqlConnection;
        SqlCommand ObjSqlCommand;

        public BarangService()
        {
            ObjSqlConnection = new SqlConnection
                (ConfigurationManager.ConnectionStrings["BarangConnection"].ConnectionString);
            ObjSqlCommand = new SqlCommand();
            ObjSqlCommand.Connection = ObjSqlConnection;
            ObjSqlCommand.CommandType = CommandType.StoredProcedure;
        }
        public List<Barang> GetAll()
        {
            List<Barang> ObjBarangList = new List<Barang>();
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "SelectAllBarang";
                ObjSqlConnection.Open();
                var ObjSqlDataReader = ObjSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    Barang ObjBarang = null;
                    while (ObjSqlDataReader.Read())
                    {
                        ObjBarang = new Barang();
                        ObjBarang.Id = ObjSqlDataReader.GetInt32(0);
                        ObjBarang.Namebarang = ObjSqlDataReader.GetString(1);
                        ObjBarang.Statusbarang = ObjSqlDataReader.GetString(2);
                        ObjBarang.Id_harga = ObjSqlDataReader.GetString(3);
                        ObjBarang.hargabarang = ObjSqlDataReader.GetString(5);

                        ObjBarangList.Add(ObjBarang);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ObjSqlConnection.Close();
            }
            return ObjBarangList;
        }

        public bool Tambah(Barang ObjNewBarang)
        {
            bool IsAdded = false;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "InsertBarang";
                ObjSqlCommand.Parameters.AddWithValue("@Id", ObjNewBarang.Id);
                ObjSqlCommand.Parameters.AddWithValue("@Namebarang", ObjNewBarang.Namebarang);
                ObjSqlCommand.Parameters.AddWithValue("@Statusbarang", ObjNewBarang.Statusbarang);

                ObjSqlConnection.Open();
                int NoOfRowsAffected = ObjSqlCommand.ExecuteNonQuery();
                IsAdded = NoOfRowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ObjSqlConnection.Close();
            }
            return IsAdded;
        }

        public bool Update(Barang ObjBarangUpdate)
        {
            bool IsUpdated = false;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "UpdateBarang";
                ObjSqlCommand.Parameters.AddWithValue("@Id", ObjBarangUpdate.Id);
                ObjSqlCommand.Parameters.AddWithValue("@Namebarang", ObjBarangUpdate.Namebarang);
                ObjSqlCommand.Parameters.AddWithValue("@Statusbarang", ObjBarangUpdate.Statusbarang);

                ObjSqlConnection.Open();
                int NoOfRowsAffected = ObjSqlCommand.ExecuteNonQuery();
                IsUpdated = NoOfRowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ObjSqlConnection.Close();
            }
            return IsUpdated;
        }

        public bool Hapus(int id)
        {
            bool IsDeleted = false;
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "DeleteBarang";
                ObjSqlCommand.Parameters.AddWithValue("@Id", id);
                ObjSqlConnection.Open();
                int NoOfRowsAffected = ObjSqlCommand.ExecuteNonQuery();
                IsDeleted = NoOfRowsAffected > 0;
            }

            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ObjSqlConnection.Close();
            }
            return IsDeleted;
        }

        public Barang Search(int id)
        {
            Barang ObjBarang = null;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "SelectBarangById";
                ObjSqlCommand.Parameters.AddWithValue("@Id", id);

                ObjSqlConnection.Open();
                var ObjSqlDataReader = ObjSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    ObjSqlDataReader.Read();
                    ObjBarang = new Barang();
                    ObjBarang.Id = ObjSqlDataReader.GetInt32(0);
                    ObjBarang.Namebarang = ObjSqlDataReader.GetString(1);
                    ObjBarang.Statusbarang = ObjSqlDataReader.GetString(2);
                }
                ObjSqlDataReader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ObjSqlConnection.Close();
            }
            return ObjBarang;
        }
        internal object Add(Barang currentBarang)
        {
            throw new NotImplementedException();
        }
    }
}
