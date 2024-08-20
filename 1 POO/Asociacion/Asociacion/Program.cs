using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asociacion o composicion; es un tipo de relacion entre clases, cuando una clase dentro de su definicion
            //Tiene uno de los atributos cuyo tipo corresponde a otra clase,

            Auto a1  = new Auto();  

            a1.Motor = new Motor();
           
        }
    }
}
