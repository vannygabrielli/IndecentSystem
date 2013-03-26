using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace WebApplication1.Paginas
{
    public partial class Lista_Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Modelos.DBProyectoEntities context = new Modelos.DBProyectoEntities();

            //var usuario = from usu in context.CO_USUARIO select usu;

            //gv_lista_usu.DataSource = usuario;
            //gv_lista_usu.DataBind();

        }

        protected void btn_nuevo_Click(object sender, EventArgs e)
        {
            Server.Transfer(@"..\Paginas\Reg_Usuario.aspx", true);
        }
    }
}