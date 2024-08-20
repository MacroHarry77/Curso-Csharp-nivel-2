using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.setEdad(20);
            Console.WriteLine("La edad de la persona es: " + p1.getEdad());

            Botella b1 = new Botella();
            b1.Capacidad = 200;

            int algo = b1.Capacidad;

            Perro perro1 = new Perro();

            string nombre = "CHIHUAHUA";
            perro1.SetOrigen(nombre);

            Console.WriteLine("El Origen de tu perro es: " + perro1.Getorigen());

            Console.WriteLine("El color de tu perro es: " + (perro1.Color = "negro"));

            perro1.Nombre = "Pinky";

            Console.WriteLine("El nombre de tu perro es: " + perro1.Nombre);
        }
    }
}
