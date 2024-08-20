using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Cliente:Persona
    {
        public int numeroCliente { get; set; }
        public List<Libro> libroPrestado { get; set; }
        public Cliente(string name, int id, string edad, int numeroCliente)
            : base(name,id,edad)
        {
            this.numeroCliente = numeroCliente;
            libroPrestado = new List<Libro> ();
        }
        public void Prestarlibro(Libro libro)
        {
            if (libro.Estado == "Disponible")
            {
                libro.Estado = "Prestado";
                libroPrestado.Add(libro);
                Console.WriteLine($"Libro '{libro.Titulo}' prestado a {name} numero de cliente {numeroCliente}.");
            }
            else
                Console.WriteLine("Libro no disponible");
        }

        public void Devolverlibro(Libro libro)
        {
            if (libro.Estado == "Prestado")
            {
                libro.Estado = "Disponible";
                libroPrestado.Remove(libro);
                Console.WriteLine($"Libro '{libro.Titulo}' devuelto por {name} numero de cliente {numeroCliente}.");
            }
            else
                Console.WriteLine("Libro no esta prestado ");
        }

    }
}
