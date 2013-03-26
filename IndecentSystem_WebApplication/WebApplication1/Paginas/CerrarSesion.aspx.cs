using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Paginas
{
    public partial class CerrarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Login_Des"] = null;
            Session["Login_Nom"] = null;
            Session.Clear();
            Server.Transfer(@"..\Paginas\InicioLogin.aspx", true);
        }
    }
}