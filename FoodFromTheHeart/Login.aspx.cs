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
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            UserLoginBLL userLogin = new UserLoginBLL();

            string messageNotice = "";

            messageNotice = userLogin.UserLogin(tb_Username.Text, tb_Password.Text);

            lbl_messageNotice.Text = messageNotice;

            if (lbl_messageNotice.Text == "Log in successful! <br /> You will be redirected in 3 seconds.") 
            {
                btn_Submit.Visible = false;
                Response.AddHeader("REFRESH", "3;URL=HomePage.aspx");
            }
            
        }

    }
}
