using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Web_App
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie["Name"] = txtName.Text;
            cookie["Age"] = txtAge.Text;
            cookie["City"] = txtCity.Text;
            cookie["Email"] = txtEmail.Text;

            cookie.Expires = DateTime.Now.AddSeconds(60);
            Response.Cookies.Add(cookie);
            
            Response.Redirect("~/GetCookies.aspx");
        }
    }
}