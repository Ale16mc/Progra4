using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograIV.AW.Products.Model
{
    public partial class Product
    {
        public string SizeInInches { get {
                string elResultado = Size;
                if (SizeUnitMeasureCode != null && SizeUnitMeasureCode == "CM")
                {
                    float elTamanoFloat = 0;
                    float.TryParse(Size, out elTamanoFloat);
                    elResultado = (elTamanoFloat / (float)2.54).ToString();
                }
                return elResultado;
            }
            set { }
        }
    }
}
