using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProgaIV.AW.Products.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WcfAWProductos : IAWProductos
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
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

        public IList<PrograIV.AW.Products.Model.Product> ListarProductosPorColor(string elColor)
        {
            var elRepositorio = new Repositorio.Productos();
            var elResultado = elRepositorio.ListarProductosPorColor(elColor);
            return (elResultado);
            
        }

        public void ListarProductosPorNombreDeCategoria(string laCtegoria)
        {
            throw new NotImplementedException();
        }

        public IList<PrograIV.AW.Products.Model.Product> ListarProductosPorRangoDePrecio(decimal precioInferior, decimal PrecioSuperior)
        {
            throw new NotImplementedException();
        }

        string IAWProductos.GetData(int value)
        {
            throw new NotImplementedException();
        }

        CompositeType IAWProductos.GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }

        IList<PrograIV.AW.Products.Model.Product> IAWProductos.ListarProductosPorColor(string elColor)
        {
            throw new NotImplementedException();
        }

        IList<PrograIV.AW.Products.Model.Product> IAWProductos.ListarProductosPorNombreDeCategoria(string laCtegoria)
        {
            throw new NotImplementedException();
        }

        IList<PrograIV.AW.Products.Model.Product> IAWProductos.ListarProductosPorRangoDePrecio(decimal precioInferior, decimal PrecioSuperior)
        {
            throw new NotImplementedException();
        }
    }
}
