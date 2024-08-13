namespace Encapsulation_AccessModifier
{
    internal class AccountService
    {
        public LoginResponse Login(string username, string password)
        {
            LoginResponse response = new LoginResponse();
            if (username == "nihatss" && password == "niko123")
            {
                return new LoginResponse
                {
                    LoginMessage = "Login failed",
                    EmialMessage = SendEmail("Email for login failed")
                };

            }
            return new LoginResponse
            {
                LoginMessage = "Login failed",
                EmialMessage = SendEmail("Email for login failed")
            };

            //response.LoginMessage = "Login failed";
            //response.EmialMessage = SendEmail("Email for login failed");
            //return response;
        }
         public string SendEmail(string msj)
        {
            return msj;
        }
    }
}
