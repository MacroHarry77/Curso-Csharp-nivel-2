using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Herencia posibilidad de reutilizar el codigo
            //relacion entre clases, familias de clases una clase hija
            //va aobtener algunas particularidades de la clase padre

            // Persona > Lider > Developer > Tester

            Persona P1 = new Persona();
            Developer developer = new Developer();
            Lider lider = new Lider();

            //P1.Nombre
            //developer.Id
            //lider.Apellido

            Persona p2 = new Developer();

            SubLider p3 = new SubLider();
            
            //p3.Nombre
            

        }
    }
}
