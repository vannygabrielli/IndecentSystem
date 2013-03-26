using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace TestWScobranzas
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Consulta_Deudor_x_Dni_ConDatos()
        {
            DataTable dt_tmp;
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            dt_tmp = x.get_Deuda_x_Cliente("43619045");
            Assert.AreEqual(1, dt_tmp.Rows.Count);
            x.Close();
        }

        [TestMethod]
        public void Consulta_Deudor_x_Dni_SinDatos()
        {
            DataTable dt_tmp;
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            dt_tmp = x.get_Deuda_x_Cliente("00055");
            Assert.AreEqual(0, dt_tmp.Rows.Count);
            x.Close();
        }

        [TestMethod]
        public void Consulta_Datos_Cliente()
        {
            DataTable dt_tmp;
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            dt_tmp = x.get_Datos_Cliente("43619045");
            Assert.AreEqual(1, dt_tmp.Rows.Count);
            x.Close();
        }


        [TestMethod]
        public void Tiene_Detalle_Deuda()
        {
            DataTable dt_tmp;
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            dt_tmp = x.get_Deuda_Detalle_x_Dni("43619045",101);
            Assert.AreEqual(1, dt_tmp.Rows.Count);
            x.Close();
        }

        [TestMethod]
        public void Listado_Telefonos_de_cliente()
        {
            DataTable dt_tmp;
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            dt_tmp = x.get_Deuda_Telefonos_x_Dni("43619045");
            Assert.AreEqual(3, dt_tmp.Rows.Count);
            x.Close();
        }

        [TestMethod]
        public void Visitas_de_Cobradores()
        {
            DataTable dt_tmp;
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            dt_tmp = x.get_Deuda_Visitas_x_Dni_Deuda("43619045",101);
            Assert.AreEqual(2, dt_tmp.Rows.Count);
            x.Close();
        }

        [TestMethod]
        public void llamadas_realizadas()
        {
            DataTable dt_tmp;
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            dt_tmp = x.get_Datos_Llamadas_x_Dni("43619045",101);
            Assert.AreEqual(2, dt_tmp.Rows.Count);
            x.Close();
        }


        [TestMethod]
        public void llamadas_realizadas_sin_Datos()
        {
            DataTable dt_tmp;
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            dt_tmp = x.get_Datos_Llamadas_x_Dni("44141414", 104);
            Assert.AreEqual(0, dt_tmp.Rows.Count);
            x.Close();
        }


        
    }
}
