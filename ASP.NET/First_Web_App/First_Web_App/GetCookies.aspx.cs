using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Web_App
{
    public partial class GetCookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];         
            string Name = cookie["Name"];
            string Age = cookie["Age"];
            string City = cookie["City"];
            string Email = cookie["Email"];
            Response.Write(Name + "<br>");
            Response.Write(Age + "<br>");
            Response.Write(City + "<br>");
            Response.Write(Email);

        }
    }
}