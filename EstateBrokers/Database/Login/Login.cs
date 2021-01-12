using Gateways;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Database.Login
{
    public class Login : ILogin
    {
        private static string sqlConn = ConfigurationManager.AppSettings.Get("sqlConnectionstring");

        //SQLCLIENT
        public bool TryLogin(string username, string password)
        {

            SqlConnection conn = new SqlConnection(sqlConn);
            using (SqlCommand cmd = new SqlCommand())
            {
                Thread.CurrentThread.IsBackground = true;

                cmd.Connection = conn;

                cmd.CommandText = "spLoginCheck_UserNameAndPassword";

                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                var valid = cmd.ExecuteScalar();
                conn.Close();


                if (valid != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
