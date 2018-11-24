using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProgaIV.AW.Products.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract] //clase
    public interface IAWProductos
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract] //para los metodos de la clase
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        IList<PrograIV.AW.Products.Model.Product> ListarProductosPorRangoDePrecio(decimal precioInferior, decimal PrecioSuperior);
        [OperationContract]
        IList<PrograIV.AW.Products.Model.Product> ListarProductosPorColor(string elColor);
        [OperationContract]
        IList<PrograIV.AW.Products.Model.Product> ListarProductosPorNombreDeCategoria(string laCtegoria);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract] //tipos de dato compuestos de los metodos de la clase
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember] //los atributos que están dentro del tipo compuesto utilizados dentro de los metodos de la clase
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
