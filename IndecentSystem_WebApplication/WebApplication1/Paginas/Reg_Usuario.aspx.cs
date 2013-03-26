using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Paginas
{
    public partial class Reg_Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Aceptar_Click(object sender, EventArgs e)
        {


            if (txt_login.Text == "") {
                lbl_Mensaje.Text = "Ingrese el Login";
                return;
            }

            if (txt_pwd.Text == "")
            {
                lbl_Mensaje.Text = "Ingrese el password";
                return;
            }

            if (txt_pwd2.Text == "")
            {
                lbl_Mensaje.Text = "Ingrese el password 2";
                return;
            }


            if (txt_des.Text == "")
            {
                lbl_Mensaje.Text = "Ingrese la descripcion del usuario";
                return;
            }


            if (txt_pwd.Text.Trim() != txt_pwd2.Text.Trim()) 
            {

                lbl_Mensaje.Text = "Las contraseñas no son iguales";
                return;
            }

            Modelos.CO_USUARIO usu = new Modelos.CO_USUARIO
            {
                LOGIN = txt_login.Text.Trim(),
                PWD = txt_pwd.Text.Trim(),
                DESCRIPCION = txt_des.Text.Trim(),
                NOMBRES = txt_nombres.Text.Trim(),
                ESTADO = 1
            
                
            };

            Modelos.DBProyectoEntities db = new Modelos.DBProyectoEntities();
            //db.CO_USUARIO.AddObject(usu);
            db.AddToCO_USUARIO(usu);
            db.SaveChanges();

            Server.Transfer(@"..\Paginas\Lista_Usuario.aspx", true);
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Server.Transfer(@"..\Paginas\Lista_Usuario.aspx", true);
        }
    }
}