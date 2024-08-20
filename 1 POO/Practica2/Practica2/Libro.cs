using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Libro
    {
        public Libro(string Titulo, Autor autor) 
        {
            this.Titulo = Titulo;  
            Autor = autor;
            Estado = "Disponible";
        }

         public string Titulo { get; set; }
         public  Autor Autor { get; set; }
         public string Estado { get; set; }
    }
}
