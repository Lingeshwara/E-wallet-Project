using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;

namespace FoodFromTheHeart
{
    public partial class Location : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string locationName = this.txtLName.Text;
            string postalCode = this.txtPCode.Text;
            string venue = this.txtVenue.Text;
            string unitNo = this.txtUNo.Text;

            LocationBLL addLocation;
            addLocation = new LocationBLL();
            int x = addLocation.ILocation(locationName, postalCode, venue, unitNo);

            if (x > 0)
            {
                ShowAlert("Product successfully added");
            }
            else
            {
                ShowAlert("Product added unsuccessfully");
            }

        }
        private void ShowAlert(string msg)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("alert('");
            sb.Append(msg.Replace("\n", "\\n").Replace("\r", "").Replace("'", "\\'"));
            sb.Append("');");
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "showalert", sb.ToString(), true);
        }
    }
}