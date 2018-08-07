using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Web_App
{
    public partial class ContextHandler2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page lastpage = (Page)Context.Handler;
            TextBox1.Text = ((TextBox)lastpage.FindControl("txtName")).Text;
        }
    }
}