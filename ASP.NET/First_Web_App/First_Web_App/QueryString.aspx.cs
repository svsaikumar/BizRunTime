using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Web_App
{
    public partial class QueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                txtName.Focus();
        }

        protected void Loginbtn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == txtPassword.Text)
                Response.Redirect("~/HomePage.aspx?txtName=" + txtName.Text);
            else
                lblStatus.Text = "Invalid user credentials.Login failed";
        }

        protected void Resetbtn_Click(object sender, EventArgs e)
        {

        }
    }
}