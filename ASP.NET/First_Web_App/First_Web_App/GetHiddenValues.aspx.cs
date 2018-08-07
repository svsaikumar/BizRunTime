using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Web_App
{
    public partial class GetHiddenValues : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Value = Request.Form["hfCount"];
            Response.Write("Your Current Count is:" + Value);
        }
    }
}