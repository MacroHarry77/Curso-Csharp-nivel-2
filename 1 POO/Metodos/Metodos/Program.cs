using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Zenith",234556);
            Console.WriteLine(p1.Saludar());
            Console.WriteLine(p1.CalcularEdad(1998,3,30));

            Botella b1 = new Botella("rojo", "Plastico");

            Console.WriteLine("Capacidad de la botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CantidadActual);


        }
    }
}
