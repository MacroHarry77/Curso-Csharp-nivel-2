using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Biblioteca
    {
       public List<Libro> Libros { get; set; }

        public Biblioteca()
        { Libros = new List<Libro>(); }

        public void AgregarLibro(Libro libro)
        {
            Libros.Add(libro);
            Console.WriteLine($"Libro '{libro.Titulo}' agregado a la biblioteca.");
        }

        public void quitarLibro(Libro libro) 
        {
            if (Libros.Contains(libro))
            {
                Libros.Remove(libro);
                Console.WriteLine($"Libro '{libro.Titulo}' removido de la biblioteca.");
            }else
                Console.WriteLine($"El libro '{libro.Titulo}' no se encontró en la biblioteca."); 
        }
        public void LibrosDisponibles()
        {
            Console.WriteLine("Libros disponibles en la biblioteca");

            foreach (var libro in Libros)
            {
                if (libro.Estado == "Disponible")
                {
                    Console.WriteLine($"{libro.Titulo} por {libro.Autor.name}");
                }
            }
        }
    }
}
