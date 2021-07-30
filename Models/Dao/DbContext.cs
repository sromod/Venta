using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Ventas.Models.Context
{
    public class DbContext
    {
        protected SqlConnection Connection = new SqlConnection(
            ConfigurationManager.ConnectionStrings["connSql"].ConnectionString);

        //public static SqlConnection Connect()
        //{
        //    SqlConnection Connection = new SqlConnection(
        //    ConfigurationManager.ConnectionStrings["connSql"].ConnectionString);
        //    Connection.Open();
        //    return Connection;
        //}

    }
}
