using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public partial class Tiendas
    {
        public string Direccion
        {
            get
            {

                string resultado = Provincia +"-"+ Canton+"-"+ Distrito;
                if (Distrito == null)
                {
                    resultado = Provincia + "-" + Canton + ".";
                    
                }
                return resultado;
            }
            set { }
        }
    }
}
