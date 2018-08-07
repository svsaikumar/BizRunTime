using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Web_App
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("page load event fired <br>");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("cached event text box changed event fired <br>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("post back event button click event fired");
        }
    }
}