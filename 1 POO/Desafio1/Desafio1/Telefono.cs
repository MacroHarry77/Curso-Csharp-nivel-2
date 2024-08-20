using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {
        public Telefono(string modelo, string marca) 
        {
            this.Modelo = modelo;
            this.Marca = marca;
        }

        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string NumeroTelefonico { get; set; }

        private int CodigoOp;
        public int CodigoOperador 
        {
            get { return CodigoOp; }

            set 
            {
                if (value > 0 && value <= 3) 
                { 
                    CodigoOp = value;
                }else
                    CodigoOp = 0;
            }
        }

        public string Llamar() 
        { 
            return "Realizando llamada/.............. ";
        }

        public string Llamar(string Name) 
        {
            return " llamando a " + Name ;
        }
    }
}
