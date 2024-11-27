using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perpustakaan
{
    class connection
    {
        //public static string connect = "Data Source=LAPTOP-D6TLPBNE\\SQLEXPRESS;Initial Catalog=aryya_perpusdb;Integrated Security=True;TrustServerCertificate=True";
        public static string connect = "Data Source=LAPTOP-WARKOP-P\\SQLEXPRESS;Initial Catalog=vanya_perpusdb;Integrated Security=True;TrustServerCertificate=True";
        public static SqlConnection konek = new SqlConnection(connect);
    }

    class ManageConnection
    {
        public static void RestartConn()
        {
            if(connection.konek.State == ConnectionState.Open)
            {
                connection.konek.Close();
            }
            connection.konek.Open();
        }

        public static void OpenConn()
        {
            if (connection.konek.State == ConnectionState.Open)
                connection.konek.Open();
        }

        public static void CloseConn()
        {
            if (connection.konek.State != ConnectionState.Closed)
        
                connection.konek.Close();
        }

        public static ConnectionState GetState()
        {
            return connection.konek.State;
        }
    } 
}
