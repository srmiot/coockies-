using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coockies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cc = new HttpCookie("Ricky");
            cc["name"] = "Hello TYIT";
            Response.Cookies.Add(cc);
            cc.Expires= DateTime.Now.AddSeconds(5);
            Response.Redirect("WebForm2.aspx");

        }
    }
}