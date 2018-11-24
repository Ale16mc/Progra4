using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograIV.AW.Products.AccesoBL
{
    public class Productos
    {
        public IList<PrograIV.AW.Products.Model.Product> ListarProductosPorColor(string elColor)
        {
            var elClienteWcf = new SI.WcfProducto.AWProductosClient();
            

            var elResultado = elClienteWcf.ListarProductosPorColor(elColor);
            elClienteWcf.Close();
            return elResultado;
        }
    }
}
