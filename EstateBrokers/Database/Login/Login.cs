using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Database.Login
{
    class Login
    {


        private static string sqlConn = ConfigurationManager.AppSettings.Get("sqlConnectionstring");

        public static void AuthLogin(string username, string password)
        {

            //Tjek om username er i databasen



            //Hvis ja 
            //Tjek om koden passer til det username 

            //Hvis nej
            //Username eller password forkert

            SqlConnection conn = new SqlConnection(sqlConn);

            using (SqlCommand com = new SqlCommand())
            {

                conn.Open();

                com.CommandText = "CheckUsername";
                com.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;

                com.ExecuteScalar();
                int UserExist = 0;
                var test = com.ExecuteScalar();

                //IF EXISTS(Select* from LoginData where Username = 'Martin')
                //BEGIN
                //Select ConfidentialID,
                //Password, 
                //Case Password
                //when HASHBYTES('SHA2_512', 'AndersKode') 
                //THEN 'Authorized User'
                //else 'Not Authorized'
                //end As Status from Confidentials
                //END


                conn.Close();






            }

        }
        public static void ExecuteCommand(string StoredProcedureName)
        {
            var conn = new SqlConnection(sqlConn);
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
