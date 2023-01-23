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
    public class HargaService
    {
        SqlConnection ObjSqlConnection;
        SqlCommand ObjSqlCommand;

        public HargaService()
        {
            ObjSqlConnection = new SqlConnection
                (ConfigurationManager.ConnectionStrings["BarangConnection"].ConnectionString);
            ObjSqlCommand = new SqlCommand();
            ObjSqlCommand.Connection = ObjSqlConnection;
            ObjSqlCommand.CommandType = CommandType.StoredProcedure;
        }
    }
}
