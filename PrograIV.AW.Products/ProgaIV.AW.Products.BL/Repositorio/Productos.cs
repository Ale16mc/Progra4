using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgaIV.AW.Products.BL.Repositorio
{
    internal class Productos //es la que llega hasta la base de datos
    {
        private PrograIV.AW.Products.Model.AdventureWorks2016Entities _contexto = new PrograIV.AW.Products.Model.AdventureWorks2016Entities();

        public IList<PrograIV.AW.Products.Model.Product> ListarProductosPorColor(string elColor)
        {
            var elResultado = _contexto.Product.Where(p => p.Color.Contains(elColor)).ToList();
            return elResultado;
        }
    }
}