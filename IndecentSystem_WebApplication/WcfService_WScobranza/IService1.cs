using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

namespace WcfService_WScobranza
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        DataTable get_Deuda_x_Cliente(string str_dni_);

        [OperationContract]
        DataTable get_Datos_Cliente(string str_dni_);

        [OperationContract]
        DataTable get_Datos_Llamadas_x_Dni(string str_dni_, int nro_deuda_);

        [OperationContract]
        DataTable get_Deuda_Detalle_x_Dni(string str_dni_, int nro_deuda_);

        [OperationContract]
        DataTable get_Deuda_Telefonos_x_Dni(string str_dni_);

        [OperationContract]
        DataTable get_Deuda_Direccion_x_Dni(string str_dni_);

        [OperationContract]
        DataTable get_Deuda_Pagos_x_Dni_Deuda(string str_dni_, int nro_deuda_);

        [OperationContract]
        DataTable get_Deuda_Visitas_x_Dni_Deuda(string str_dni_, int nro_deuda_);

          
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
