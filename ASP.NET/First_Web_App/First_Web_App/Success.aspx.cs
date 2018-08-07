using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Collections.Specialized.BitVector32;

namespace First_Web_App
{
    public partial class Success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            //string name = Request.Form["txtUserName"];
           
            string name = ((TextBox)PreviousPage.FindControl("txtUserName")).Text;
            Response.Write("Hello " +  name);
        }
    }
}