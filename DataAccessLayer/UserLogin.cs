using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class UserLogin
    {
        private string _connStr = Properties.Settings.Default.DBConnStr;
        private string _username;
        private string _password;

        //Default Contstructor
        public UserLogin()
        {
        }

        //Constructor that takes in all the required Login Credentials
        public UserLogin(string username, string password) 
        {
            _username = username;
            _password = password;
        }

        //Setters & Getters
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int checkLogin()
        {
            string queryStr = "SELECT * FROM USERACCOUNTS WHERE userID ='" + username + "' AND pass ='" + password + "' ";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);

            conn.Open();
            int noOfRow = 0;

            SqlDataReader sDr = cmd.ExecuteReader();

            if (sDr.Read())
            {
                noOfRow += 1;
            }
            else 
            {
                noOfRow += 0;
            }

            conn.Close();

            return noOfRow;
        }
    }
}
