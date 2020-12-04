using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Database.Login
{
    public class Login : ILoginInput
    {

      

        static Thread thd;
        public static ILoginOutput LoginOutput;
        public static LoginRequestModel RequestModel;

        public Login(ILoginOutput loginOutput)
        {
            LoginOutput = loginOutput;
        }

        public void RunAuthLogin(LoginRequestModel request)
        {
            RequestModel = request;
            thd = new Thread(new ThreadStart(AuthLogin));
            thd.Start();

           
        }

        private static string sqlConn = ConfigurationManager.AppSettings.Get("sqlConnectionstring");

        public static void AuthLogin()
        {

            LoginResponseModel response = new LoginResponseModel();

            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    cmd.CommandText = "spLoginCheck_UserNameAndPassword";

                    cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = RequestModel.username;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = RequestModel.password;

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
            }
            catch (System.Exception)
            {

                response.LoginSucess = false;
            }

            LoginOutput.ConfirmLogin(response);
        }
    }
}
