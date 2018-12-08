using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public partial class Zapatos
    {
        public double? PrecioBruto { get {
                double? resultado = 0.0;
                if (Estilo.Contains("Niño") || Estilo.Contains("Niña") || Estilo.Contains("boy") || Estilo.Contains("girl") || Estilo.Contains("child"))
                {
                    resultado = PrecioUnitario * 0.20;
                    resultado = PrecioUnitario - resultado;
                }
                if (Estilo.Contains("Dama") || Estilo.Contains("Mujer") || Estilo.Contains("Woman"))
                {
                    resultado = PrecioUnitario * 0.10;
                    resultado = PrecioUnitario + resultado;
                }
                if (Estilo.Contains("Caballero") || Estilo.Contains("Hombre") || Estilo.Contains("Man"))
                {
                    resultado = PrecioUnitario * 0.19;
                    resultado = PrecioUnitario - resultado;
                }
                if (Extento !=true)
                {
                    resultado = resultado +(resultado * 0.13);
                }
                return resultado;
            }

            set { }
        }

      
    }



}
