using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Web_App
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Response.Write(this.IsPostBack + "<br>");
            if (this.IsPostBack)
                Response.Write("Value of textBox is:" + TextBox1.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Write(TextBox1.Text);
        }
    }
}