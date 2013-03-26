using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Paginas
{
    public partial class InicioLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Aceptar_Click(object sender, EventArgs e)
        {


            if (txt_Login.Text.Trim().Length == 0) {
                lbl_mensaje.Text = "Ingrese el nombre de usuario";
                return;
            }

            if (txt_pwd.Text.Trim().Length == 0)
            {
                lbl_mensaje.Text = "Ingrese la contraseña";
                return;
            }
            
            
            Modelos.DBProyectoEntities context = new Modelos.DBProyectoEntities();

            var usuario = from usu in context.CO_USUARIO select usu;

            foreach (var u in usuario)
            {
                if ((u.LOGIN == txt_Login.Text.Trim()) && (u.PWD == txt_pwd.Text.Trim()))
                {
                    if (u.ESTADO == 0)
                    {
                        lbl_mensaje.Text = "La cuenta de usuario esta desactivada";
                        return ;
                    }
                    else {

                        Session["Login_Des"] = u.DESCRIPCION;
                        Session["Login_Nom"] = u.NOMBRES;
                        Server.Transfer(@"..\Default.aspx", true);
                        break;
                    }
                    
                }

            }

            lbl_mensaje.Text = "Usuario y/o Contraseña Incorrecta";

        }
    }
}