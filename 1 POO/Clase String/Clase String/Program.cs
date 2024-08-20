using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            name = "Hello word";
            
            int cant = name.Length;// Propiedad de la clase string devuelve cantidad de caracteres

            name = name.ToUpper();//Todo en MAYUSCULAS

            name = name.ToLower();//Todo en minusculas

            name = name.Replace('a', 'e');//Cambio de caracteres todos los a seran e 

            //Con Ctrl se puede ver todo el codigo detras de String


        }
    }
}
