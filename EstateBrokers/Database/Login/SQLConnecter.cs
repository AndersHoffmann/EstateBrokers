using System;
using System.Data;
using System.Data.SqlClient;

namespace Database.Login
{
    class SQLConnecter
    {



        public static void ExecuteCommand(String StoredProcedureName)
        {
            var conn = new SqlConnection();
            conn.Open();
            var com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = StoredProcedureName;
            com.CommandType = CommandType.StoredProcedure;
            com.ExecuteNonQuery();
            conn.Close();
        }

    }

}

