using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Web_App
{
    public partial class LoginFormPostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == txtPassword.Text)
            {
                Response.Write("Valid User");
            }
            else
            {
                Response.Write("Invalid User");
            }

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = txtPassword.Text = "";
            txtUserName.Focus();
            
        }
    }
}