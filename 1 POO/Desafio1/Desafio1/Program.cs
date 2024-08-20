using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Telefono xiaomi = new Telefono("Mi 9t pro","Xiaomi");

            xiaomi.NumeroTelefonico = "312312321";

            xiaomi.CodigoOperador = 4;

            Console.WriteLine("Marca: " + xiaomi.Marca + " Modelo: " + xiaomi.Modelo + " Telefono: " + xiaomi.NumeroTelefonico + " Operador: " + xiaomi.CodigoOperador);

            Console.WriteLine(xiaomi.Llamar() + xiaomi.Llamar("Xcosita"));

        }
    }
}
