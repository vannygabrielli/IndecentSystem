using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1.Ficheros
{
    public partial class CO_MA_Deudor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txt_dni.Focus();
        }

        protected void btn_Consultar_Click(object sender, EventArgs e)
        {

            if (txt_dni.Text.Trim().Length == 0)
            {
                lbl_aviso.Text = "Ingrese el Dni del cliente";

                txt_iddeuda.Text = string.Empty;
                txt_cartera.Text = string.Empty;
                txt_nro_cta.Text = string.Empty;
                txt_conyuge.Text = string.Empty;
                txt_situ_deudor.Text = string.Empty;
                txt_aval.Text = string.Empty;
                txt_grupo.Text = string.Empty;
                txt_titular.Text = string.Empty;
                txt_est_judi.Text = string.Empty;
                txt_situ_deuda.Text = string.Empty;
                txt_cliente.Text = string.Empty;
                txt_fec_mod.Text = string.Empty;
                txt_calificacion.Text = string.Empty;
                txt_deuda_total.Text = string.Empty;

                return;
            }


            DataTable dt_tmp;
            DataTable dt_cliente;
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            dt_tmp = x.get_Deuda_x_Cliente(txt_dni.Text.Trim());
            dt_cliente = x.get_Datos_Cliente(txt_dni.Text.Trim());

            lbl_mensaje.Text = "";

            if (dt_cliente.Rows.Count > 0)
            {

                lbl_mensaje.Text = "Cliente : "+dt_cliente.Rows[0]["NOMBRES"].ToString() + " " + dt_cliente.Rows[0]["APELLIDOS"].ToString();
            }

            if (dt_tmp.Rows.Count > 0)
            {
                DataRow fila = dt_tmp.Rows[0];

                txt_iddeuda.Text = fila["ID_DEUDA"].ToString();
                txt_cartera.Text = fila["IDCARTERA"].ToString();
                txt_nro_cta.Text = fila["NRO_CTA"].ToString();
                txt_conyuge.Text = fila["CONYUGE"].ToString();
                txt_situ_deudor.Text = fila["SITU_DEUDOR"].ToString();
                txt_aval.Text = fila["AVAL"].ToString();
                txt_grupo.Text = fila["GRUPO"].ToString();
                txt_titular.Text = fila["TITULAR"].ToString();
                txt_est_judi.Text = fila["EST_JUDI"].ToString();
                txt_situ_deuda.Text = fila["SITU_DEUDA"].ToString();
                txt_cliente.Text = fila["IDCLIENTE"].ToString();
                txt_fec_mod.Text = fila["FEC_MOD"].ToString();
                txt_calificacion.Text = fila["CALIFICACION"].ToString();
                txt_deuda_total.Text = fila["DEUDA_TOTAL"].ToString();
                lbl_aviso.Text = "";

            }
            else
            {
                txt_iddeuda.Text = string.Empty;
                txt_cartera.Text = string.Empty;
                txt_nro_cta.Text = string.Empty;
                txt_conyuge.Text = string.Empty;
                txt_situ_deudor.Text = string.Empty;
                txt_aval.Text = string.Empty;
                txt_grupo.Text = string.Empty;
                txt_titular.Text = string.Empty;
                txt_est_judi.Text = string.Empty;
                txt_situ_deuda.Text = string.Empty;
                txt_cliente.Text = string.Empty;
                txt_fec_mod.Text = string.Empty;
                txt_calificacion.Text = string.Empty;
                txt_deuda_total.Text = string.Empty;

                
                lbl_mensaje.Text = "No se encontraron datos.";
            }

            x.Close();

            gv_Detalle.DataSource = null;
            gv_Detalle.DataBind();

        }

        protected void btn_llamadas_Click(object sender, EventArgs e)
        {

            if (txt_dni.Text.Trim().Length == 0)
            {
                lbl_aviso.Text = "Ingrese el Dni del cliente";
                return;
            }
            DataTable dt_tmp;
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            dt_tmp = x.get_Datos_Llamadas_x_Dni(txt_dni.Text.Trim(), int.Parse(txt_iddeuda.Text.Trim()));
            gv_Detalle.DataSource = dt_tmp;
            gv_Detalle.DataBind();
            x.Close();
            lbl_aviso.Text = "";
           

        }

        protected void btn_deudas_Click(object sender, EventArgs e)
        {
            if(txt_dni.Text.Trim().Length==0){
                lbl_aviso.Text = "Ingrese el Dni del cliente";
                return;
            }

            DataTable dt_tmp;
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            dt_tmp = x.get_Deuda_Detalle_x_Dni(txt_dni.Text.Trim(), int.Parse(txt_iddeuda.Text.Trim()));
            gv_Detalle.DataSource = dt_tmp;
            gv_Detalle.DataBind();
            x.Close();
            lbl_aviso.Text = "";
            lbl_Tit_Det.Text = "Informacion Detalle : Deudas del Cliente";
        }

        protected void btn_telefono_Click(object sender, EventArgs e)
        {
            if (txt_dni.Text.Trim().Length == 0)
            {
                lbl_aviso.Text = "Ingrese el Dni del cliente";
                return;
            }

            DataTable dt_tmp;
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            dt_tmp = x.get_Deuda_Telefonos_x_Dni(txt_dni.Text.Trim());
            gv_Detalle.DataSource = dt_tmp;
            gv_Detalle.DataBind();
            x.Close();
            lbl_aviso.Text = "";
            lbl_Tit_Det.Text = "Informacion Detalle : Telefonos del Cliente";
        }

        protected void btn_dir_Click(object sender, EventArgs e)
        {
            if (txt_dni.Text.Trim().Length == 0)
            {
                lbl_aviso.Text = "Ingrese el Dni del cliente";
                return;
            }

            DataTable dt_tmp;
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            dt_tmp = x.get_Deuda_Direccion_x_Dni(txt_dni.Text.Trim());
            gv_Detalle.DataSource = dt_tmp;
            gv_Detalle.DataBind();
            x.Close();
            lbl_aviso.Text = "";
            lbl_Tit_Det.Text = "Informacion Detalle : Direcciones del Cliente";
        }

        protected void btn_visitas_Click(object sender, EventArgs e)
        {
            if (txt_dni.Text.Trim().Length == 0)
            {
                lbl_aviso.Text = "Ingrese el Dni del cliente";
                return;
            }

            DataTable dt_tmp;
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            dt_tmp = x.get_Deuda_Visitas_x_Dni_Deuda(txt_dni.Text.Trim(), int.Parse(txt_iddeuda.Text.Trim()));
            gv_Detalle.DataSource = dt_tmp;
            gv_Detalle.DataBind();
            x.Close();
            lbl_aviso.Text = "";
            lbl_Tit_Det.Text = "Informacion Detalle : Visitas del Cliente";
        }

        protected void btn_pagos_Click(object sender, EventArgs e)
        {
            if (txt_dni.Text.Trim().Length == 0)
            {
                lbl_aviso.Text = "Ingrese el Dni del cliente";
                return;
            }

            DataTable dt_tmp;
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            dt_tmp = x.get_Deuda_Pagos_x_Dni_Deuda(txt_dni.Text.Trim(), int.Parse(txt_iddeuda.Text.Trim()));
            gv_Detalle.DataSource = dt_tmp;
            gv_Detalle.DataBind();
            x.Close();
            lbl_aviso.Text = "";
            lbl_Tit_Det.Text = "Informacion Detalle : Pagos Realizados del Cliente";
        }
    }
}