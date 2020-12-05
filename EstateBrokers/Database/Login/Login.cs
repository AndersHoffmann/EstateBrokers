using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Database.Login
{
    public class Login : ILoginInput
    {

        public static ILoginOutput LoginOutput;
        public static LoginRequestModel RequestModel;

        public Login(ILoginOutput loginOutput)
        {
            LoginOutput = loginOutput;
            
        }

        public void Auth(LoginRequestModel request)
        {
            var response = new LoginResponseModel();

            var thread = new Thread(() =>
            {
                response.LoginSucess = AuthLogin(request);

            });
            thread.Start();
            thread.Join();

            LoginOutput.ConfirmLogin(response);
        }

        private static string sqlConn = ConfigurationManager.AppSettings.Get("sqlConnectionstring");

        public static bool AuthLogin(LoginRequestModel request)
        {
         
                SqlConnection conn = new SqlConnection(sqlConn);
                using (SqlCommand cmd = new SqlCommand())
                {
                    Thread.CurrentThread.IsBackground = true;

                    cmd.Connection = conn;

                    cmd.CommandText = "spLoginCheck_UserNameAndPassword";

                    cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = request.username;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = request.password;

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
