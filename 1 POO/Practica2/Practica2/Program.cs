using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sistema gestion de biblioteca

            Autor a1 = new Autor("HarryLorayne",01800,"40","EstadosUnidos");
            Autor a2 = new Autor("VonNiuman", 01830, "40", "EstadosUnidos");
            Autor a3 = new Autor("DanielKhaneman", 02800, "40", "EstadosUnidos");

            Libro l1 = new Libro("Supermemoria",a1);
            Libro l2 = new Libro("HabitosAtomicos", a2);
            Libro l3 = new Libro("PensarRapidoPenarDespacio", a3);

            Biblioteca biblioteca = new Biblioteca();

            biblioteca.AgregarLibro(l1);
            biblioteca.AgregarLibro(l2);
            biblioteca.AgregarLibro(l3);

           
            Console.WriteLine("Libro en la posicion 2 " + biblioteca.Libros[1].Titulo);
            //

            //v2.color = "Verdoso";
            //listaVehiculos[1].color = "Negro";

            //Console.WriteLine("El color es: " + listaVehiculos[1].color);

            // listaVehiculos.Remove(v1);//remueve un element de listaVehiculos

            biblioteca.LibrosDisponibles();

            Cliente c1 = new Cliente("Harry",18492,"21",1);
            Cliente c2 = new Cliente("Paul", 12492, "25", 2);

            c1.Prestarlibro(l1);
            c2.Prestarlibro(l1);

            c1.Devolverlibro(l1);

            biblioteca.quitarLibro(l1);

            c2.Prestarlibro(l1);

            
        }
    }
}
