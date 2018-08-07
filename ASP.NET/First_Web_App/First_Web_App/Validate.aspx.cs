using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Web_App
{
    public partial class Validate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Name = Request.Form["txtUserName"];
            string Password = Request.Form["txtPassword"];
            if (Name == Password)
                Response.Write("Valid user");
            else
                Response.Write("invalid User");
        }
    }
}