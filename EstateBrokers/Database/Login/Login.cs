using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Database.Login
{
    public class Login : ILoginInput
    {

        static LoginResponseModel response = new LoginResponseModel();

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
            LoginOutput.ConfirmLogin(response);

        }

        private static string sqlConn = ConfigurationManager.AppSettings.Get("sqlConnectionstring");

        public static void AuthLogin()
        {

            SqlConnection conn = new SqlConnection(sqlConn);

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
    }
}
