using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        private string material;
        private int capacidad;
        private string liquido;

        //PROPIEDAD
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
    }
}
