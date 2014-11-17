using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class UserLoginBLL
    {
        public string UserLogin(string username, string password) 
        {
            string returnMessage = "";

            if (username.Length < 0) { returnMessage += "Username cannot be empty!!!"; }
            if (password.Length < 0) { returnMessage += "Password cannot be empty!"; }
               
                if (returnMessage.Length == 0)
                {
                    UserLogin userLog = new UserLogin(username, password);

                    int noOfRows = 0;
                    noOfRows = userLog.checkLogin();

                    if (noOfRows == 1)
                    {
                        returnMessage += "Log in successful! <br /> You will be redirected in 3 seconds.";
                    }
                    else 
                    {
                        returnMessage += "Please enter correct credentials!";
                    }
                }
                return returnMessage;
        }
    }
}
