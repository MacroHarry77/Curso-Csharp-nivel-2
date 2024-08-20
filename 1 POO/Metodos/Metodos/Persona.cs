using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Persona
    {
        //metodo es una funcion, que va adentro de una clase que da 
        //alguna accion sobre el objeto en el que trabaja.

        //ATRIBUTOS:
        private int edad;
        private string name;
        private int id;

        //Constructor
        public Persona(string name, int id)
        {
            this.name = name;
            this.id = id;
        }



        //Metodos Comportamiento de lo que va a ser el objeto persona
        public string Saludar()
        {
            return "Hola como estas " + name;
        }

        public string CalcularEdad(int a, int m, int d)
        {
            int ac = 2024, mc = 06, dc = 27, aux = 0, aux2 = 0;
            
            edad = ac - a;
            if (mc < m)
            {
                edad -= 1;
            }
            else if (mc == m && dc < d)
            {
                edad -= 1;
            }

            aux = mc - m;
            if (aux < 0)
                aux *= -1;
            aux2 = dc - d;
            if (aux2 < 0)
                aux2 *= -1;

            return "La edad es " + edad + " con " + aux + " Mes(es) " + aux2 + " Dia(s)";
        }
    }
}
