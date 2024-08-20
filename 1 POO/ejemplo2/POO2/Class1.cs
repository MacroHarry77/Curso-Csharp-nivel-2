using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    class Articulo
    {
        //codigo articulo 3 digitos 
        //precio
        //codigo marca

        //PROPIEDAD AUTOMATICA:
        // Forma corta para crear el atributo y la propiedad,
        // no se puede manipular el get y el set solo esta limitado
        // aL ACCESO Y MUTADOR;
        public int CodigoArticulo  { get; set; }

        public float Precio { get; set; }

        private int CodMarca;

        public int CodigoMarca
        {
            get { return CodMarca; }
            set
            {
                if (value > 0 && value < 11)
                {
                    CodMarca = value;
                }
                else { CodMarca = -1; }
            }
        }
    }
}
