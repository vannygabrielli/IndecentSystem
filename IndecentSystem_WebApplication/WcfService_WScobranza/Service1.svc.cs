using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; 

namespace WcfService_WScobranza
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        
        public DataTable get_Deuda_x_Cliente(string str_dni_)
        {

            var sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CF"].ConnectionString);
            var strSQL = "SELECT * FROM CO_DEUDA WHERE IDCLIENTE = '" + str_dni_ + "' ";
            var cmd = new SqlCommand(strSQL, sqlConn);
            var ds = new DataSet();
            var da = new SqlDataAdapter(cmd);

            sqlConn.Open();

            da.Fill(ds, "deuda");
            sqlConn.Close();

            var dt = ds.Tables[0];
            
            return dt;

        }

        public DataTable get_Datos_Cliente(string str_dni_) {

            var sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CF"].ConnectionString);
            var strSQL = "SELECT * FROM CO_CLIENTE WHERE DNI = '" + str_dni_ + "' ";
            var cmd = new SqlCommand(strSQL, sqlConn);
            var ds = new DataSet();
            var da = new SqlDataAdapter(cmd);

            sqlConn.Open();

            da.Fill(ds, "clientes");
            sqlConn.Close();

            var dt = ds.Tables[0];

            return dt;
        }

        public DataTable get_Datos_Llamadas_x_Dni(string str_dni_,int nro_deuda_) 
        {
            var sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CF"].ConnectionString);
            var strSQL = "SELECT CONVERT (char(10), FECHA, 103) as 'FECHA' ,TIPO_GT,TELEFONO,LUGAR,CONTACTO,RESULTADO,COMENTARIO,CONVERT (char(10), FEC_CP, 103)  as 'FEC_CP',MONTO_CP," + 
                        "HORA_REG,USU_MOD FROM CO_LLAMADAS WHERE IDCLIENTE = '" + str_dni_ + "' AND IDDEUDA = " + nro_deuda_;

            var cmd = new SqlCommand(strSQL, sqlConn);
            var ds = new DataSet();
            var da = new SqlDataAdapter(cmd);

            sqlConn.Open();

            da.Fill(ds, "llamadas");
            sqlConn.Close();

            var dt = ds.Tables[0];

            return dt;
        }

        public DataTable get_Deuda_Detalle_x_Dni(string str_dni_, int nro_deuda_) {
            var sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CF"].ConnectionString);
            var strSQL = "select DIAS,PRESTAMO,MONEDA as 'MON',SALDO_INI AS 'SALDO',PRODUCTO,CAMPAÑA,CONVERT (char(10), FEC_DESEMBOLSO, 103)  AS 'DESEMB',CONVERT (char(10), FEC_VEN, 103)  AS 'VENCI',CONVERT (char(10), FEC_CASTIGO, 103)  AS 'CASTIGO',TIPO_CUOTA_PERIODO AS 'TIP_CUOTA',VAL_COUTA,ESTADO,CONVERT (char(10), FEC_MOD, 103) as 'FEC_MOD' 	from co_deuda_cliente	where idcliente = '" + str_dni_ + "' and iddeuda = " + nro_deuda_.ToString();

            var cmd = new SqlCommand(strSQL, sqlConn);
            var ds = new DataSet();
            var da = new SqlDataAdapter(cmd);

            sqlConn.Open();

            da.Fill(ds, "deuda_det");
            sqlConn.Close();

            var dt = ds.Tables[0];

            return dt;
        }

        public DataTable get_Deuda_Telefonos_x_Dni(string str_dni_) {
            var sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CF"].ConnectionString);
            var strSQL = "SELECT ITEM,TELEFONO,TIPO,ESTADO,CONVERT (char(10), FEC_MOD, 103)as 'FEC_MOD',USU_MOD FROM CO_TELEFONO WHERE IDCLIENTE = " + str_dni_;

            var cmd = new SqlCommand(strSQL, sqlConn);
            var ds = new DataSet();
            var da = new SqlDataAdapter(cmd);

            sqlConn.Open();

            da.Fill(ds, "telefonos");
            sqlConn.Close();

            var dt = ds.Tables[0];

            return dt;
        }

        public DataTable get_Deuda_Direccion_x_Dni(string str_dni_) {

            var sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CF"].ConnectionString);
            var strSQL = "SELECT ITEM,DIRECCION,DST,PV,DPTO,ESTADO,CONVERT (char(10), FEC_MOD, 103) AS 'FEC_MOD',USU_MOD FROM CO_DIR_CLIENTE where IDCLIENTE = '" + str_dni_ + "'";

            var cmd = new SqlCommand(strSQL, sqlConn);
            var ds = new DataSet();
            var da = new SqlDataAdapter(cmd);

            sqlConn.Open();

            da.Fill(ds, "direcciones");
            sqlConn.Close();

            var dt = ds.Tables[0];

            return dt;

        }
        
        public DataTable get_Deuda_Pagos_x_Dni_Deuda(string str_dni_, int nro_deuda_) {

            var sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CF"].ConnectionString);
            var strSQL = "SELECT CONVERT (char(10), FEC_PAGO, 103) AS 'FEC_PAGO',MONEDA,ABONO,CONVERT (char(10), FEC_MOD, 103) AS 'FEC_MOD' FROM CO_PAGOS_CLIENTE WHERE IDCLIENTE = '" + str_dni_ + "' AND IDDEUDA = " + nro_deuda_.ToString();

            var cmd = new SqlCommand(strSQL, sqlConn);
            var ds = new DataSet();
            var da = new SqlDataAdapter(cmd);

            sqlConn.Open();

            da.Fill(ds, "pagos");
            sqlConn.Close();

            var dt = ds.Tables[0];

            return dt;
        }

        public DataTable get_Deuda_Visitas_x_Dni_Deuda(string str_dni_, int nro_deuda_) {
            
            var sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CF"].ConnectionString);
            var strSQL = "SELECT ITEM,CONVERT (char(10), FEC_VISITA, 103) AS 'FEC_VISITA',PERSONAL,DIRECCION,OBSERVACION FROM CO_VISITAS WHERE IDCLIENTE = '" + str_dni_ + "' AND IDDEUDA = " + nro_deuda_.ToString();

            var cmd = new SqlCommand(strSQL, sqlConn);
            var ds = new DataSet();
            var da = new SqlDataAdapter(cmd);

            sqlConn.Open();

            da.Fill(ds, "visitas");
            sqlConn.Close();

            var dt = ds.Tables[0];

            return dt;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
