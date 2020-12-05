using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Database.Login
{
    public class Login : ILoginInput
    {

        static LoginResponseModel response = new LoginResponseModel();

        public static ILoginOutput LoginOutput;
        public static LoginRequestModel RequestModel;

        public Login(ILoginOutput loginOutput)
        {
            LoginOutput = loginOutput;
        }

        public void Auth(LoginRequestModel request)
        {

            AuthLogin(request);


            LoginOutput.ConfirmLogin(response);
        }

        private static string sqlConn = ConfigurationManager.AppSettings.Get("sqlConnectionstring");

        public static void AuthLogin(LoginRequestModel request)
        {
            

            new Thread(() =>{

               
                SqlConnection conn = new SqlConnection(sqlConn);
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    cmd.CommandText = "spLoginCheck_UserNameAndPassword";

                    cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = request.username;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = request.password;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    var valid = cmd.ExecuteScalar();

                    if (valid != null)
                    {
                        response.LoginSucess = true;
                    }
                    else
                    {
                        response.LoginSucess = false;
                    }

                    conn.Close();
                }
                
            }).Start();

           
        }
    }
}
