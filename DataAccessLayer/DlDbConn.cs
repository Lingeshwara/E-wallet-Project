using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    class DlDbConn
    {
        public DlDbConn()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public SqlConnection GetConnection()
        {
            SqlConnection dbConn;

            dbConn = new SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|FFTHDatabase.mdf; Integrated Security=True;Connect Timeout=30;User Instance=True ");

            return dbConn;
        }
    }
}
