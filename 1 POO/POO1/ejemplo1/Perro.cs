using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Perro
    {
        //Atributos
        private string nombre;
        private string color;
        private string origen;

        //Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //metodos
        public void SetOrigen(string name)
        {
            origen = name;
        }

        public string Getorigen()
        {
            return origen;
        }
    }
}
