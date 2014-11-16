using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Location
    {
        private String errMsg;
        private DlDbConn dbConn;
       
       //  private string _connStr = Properties.Settings.Default.DBConnStr;
       // private string _locationID;
      //  private string _locationName;
     //   private string _postalCode;
     //   private string _venue;
     //   private string _unitNo;
        



        //Default Contstructor
        public Location()
        {
            dbConn = new DlDbConn();
        }

        //Constructor that takes in all the required Login Credentials
       /* public Location(string locationID, string locationName, string postalCode, string venue, string unitNo) 
        {
            _locationID= locationID;
            _locationName = locationName;
            _postalCode = postalCode;
            _venue = venue;
            _unitNo = unitNo;
        }

        //Setters & Getters
        public string locationID
        {
            get { return _locationID; }
            set { _locationID = value; }
        }
        public string locationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }

        public string postalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }

        public string venue
        {
            get { return _venue; }
            set { _venue = value; }
        }

        public string unitNo
        {
            get { return _unitNo; }
            set { _unitNo= value; }
        }
        public int checkLogin()
        {
            string queryStr = "SELECT * FROM LOCATION WHERE locationID ='" + locationID + "' AND locationName ='" + locationName + "' AND postalCode ='" + postalCode + "'AND venue ='" + venue + "' AND unitNo ='" + unitNo + "' ";

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
        * */
        public int ILocation(string locationName, string postalCode, string venue, string unitNo)
        {
            SqlConnection conn;
            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;

            conn = dbConn.GetConnection();
            sql = new StringBuilder();
            sql.AppendLine("INSERT INTO LOCATION (locationName, postalCode, venue, unitNo)");
            sql.AppendLine("VALUES (@locationName, @postalCode, @venue, @unitNo)");

            try
            {
                conn.Open();
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@locationName", locationName);
                sqlCmd.Parameters.AddWithValue("@postalCode", postalCode);
                sqlCmd.Parameters.AddWithValue("@venue", venue);
                sqlCmd.Parameters.AddWithValue("@unitNo", unitNo);
                result = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
    }
}
