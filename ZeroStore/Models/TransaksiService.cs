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
    public class TransaksiService
    {
        SqlConnection ObjSqlConnection;
        SqlCommand ObjSqlCommand;

        public TransaksiService()
        {
            ObjSqlConnection = new SqlConnection
                (ConfigurationManager.ConnectionStrings["BarangConnection"].ConnectionString);
            ObjSqlCommand = new SqlCommand();
            ObjSqlCommand.Connection = ObjSqlConnection;
            ObjSqlCommand.CommandType = CommandType.StoredProcedure;
        }

        public List<Transaksi> GetAll()
        {
            List<Transaksi> ObjTransaksiList = new List<Transaksi>();
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "selecttransaksi";
                ObjSqlConnection.Open();
                var ObjSqlDataReader = ObjSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    Transaksi ObjTransaksi = null;
                    while (ObjSqlDataReader.Read())
                    {
                        ObjTransaksi = new Transaksi();
                        ObjTransaksi.Id_konsumen = ObjSqlDataReader.GetString(0);
                        ObjTransaksi.Nama_konsumen = ObjSqlDataReader.GetString(1);
                        ObjTransaksi.Alamat_konsumen = ObjSqlDataReader.GetString(2);
                        ObjTransaksi.Id_transaksi = ObjSqlDataReader.GetString(3);
                        ObjTransaksi.Id = ObjSqlDataReader.GetInt32(4);
                        ObjTransaksi.tanggal = ObjSqlDataReader.GetDateTime(6);
                        ObjTransaksi.keterangan = ObjSqlDataReader.GetString(7);
                        ObjTransaksiList.Add(ObjTransaksi);
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
            return ObjTransaksiList;
        }
        internal object Add(Transaksi currentTransaksi)
        {
            throw new NotImplementedException();
        }
    }
}
