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
    public class KonsumenService
    {
        SqlConnection ObjSqlConnection;
        SqlCommand ObjSqlCommand;

        public KonsumenService()
        {
            ObjSqlConnection = new SqlConnection
                (ConfigurationManager.ConnectionStrings["BarangConnection"].ConnectionString);
            ObjSqlCommand = new SqlCommand();
            ObjSqlCommand.Connection = ObjSqlConnection;
            ObjSqlCommand.CommandType = CommandType.StoredProcedure;
        }

        public List<Konsumen> GetAll()
        {
            List<Konsumen> ObjKonsumenList = new List<Konsumen>();
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "selectKonsumen";
                ObjSqlConnection.Open();
                var ObjSqlDataReader = ObjSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    Konsumen ObjKonsumen = null;
                    while (ObjSqlDataReader.Read())
                    {
                        ObjKonsumen = new Konsumen();
                        ObjKonsumen.Id_konsumen = ObjSqlDataReader.GetString(0);
                        ObjKonsumen.Nama_konsumen = ObjSqlDataReader.GetString(1);
                        ObjKonsumen.Alamat_konsumen = ObjSqlDataReader.GetString(2);

                        ObjKonsumenList.Add(ObjKonsumen);
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
            return ObjKonsumenList;
        }

        public bool Tambah(Konsumen ObjNewKonsumen)
        {
            bool IsAdded = false;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "InsertKonsumen";
                ObjSqlCommand.Parameters.AddWithValue("@Id_konsumen", ObjNewKonsumen.Id_konsumen);
                ObjSqlCommand.Parameters.AddWithValue("@Nama_konsumen", ObjNewKonsumen.Nama_konsumen);
                ObjSqlCommand.Parameters.AddWithValue("@Alamat_konsumen", ObjNewKonsumen.Alamat_konsumen);

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

        public bool Update(Konsumen ObjKonsumenUpdate)
        {
            bool IsUpdated = false;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "UpdateKonsumen";
                ObjSqlCommand.Parameters.AddWithValue("@Id_konsumen", ObjKonsumenUpdate.Id_konsumen);
                ObjSqlCommand.Parameters.AddWithValue("@Nama_konsumen", ObjKonsumenUpdate.Nama_konsumen);
                ObjSqlCommand.Parameters.AddWithValue("@Alamat_konsumen", ObjKonsumenUpdate.Alamat_konsumen);

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

        public bool Hapus(string id_konsumen)
        {
            bool IsDeleted = false;
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "DeleteKonsumen";
                ObjSqlCommand.Parameters.AddWithValue("@Id_konsumen", id_konsumen);
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

        public Konsumen Search(string id_konsumen)
        {
            Konsumen ObjKonsumen = null;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "SelectKonsumenById";
                ObjSqlCommand.Parameters.AddWithValue("@Id_konsumen", id_konsumen);

                ObjSqlConnection.Open();
                var ObjSqlDataReader = ObjSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    ObjSqlDataReader.Read();
                    ObjKonsumen = new Konsumen();
                    ObjKonsumen.Id_konsumen = ObjSqlDataReader.GetString(0);
                    ObjKonsumen.Nama_konsumen = ObjSqlDataReader.GetString(1);
                    ObjKonsumen.Alamat_konsumen = ObjSqlDataReader.GetString(2);
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
            return ObjKonsumen;
        }

        internal object Add(Konsumen currentKonsumen)
        {
            throw new NotImplementedException();
        }
    }
}
