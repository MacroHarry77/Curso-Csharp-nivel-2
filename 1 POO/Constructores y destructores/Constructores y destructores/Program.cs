using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores_y_destructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NEW palabra reservada: invoca al constructor de la clase se genera la intancia del objeto claseVacia;
            ClaseVacia clas = new ClaseVacia();//se crea el OBJETO CLAS
            //hija de la clase object hereda ciertas funcionalidades
            //clas.Equals(new ClaseVacia());
            //clas.GetType();
            //clas.ToString();

            Constructor cons = new Constructor("rojo","plastico");
            Constructor cons2 = new Constructor();


        }
    }
}
