using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                lbl_des.Text = Session["Login_Des"].ToString();
                lbl_nom.Text = Session["Login_Nom"].ToString();
            }
            catch { }
            
        }
    }
}
