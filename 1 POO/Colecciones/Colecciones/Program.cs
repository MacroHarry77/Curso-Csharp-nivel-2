using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creacion de la coleccion 
            Vehiculo v1 = new Vehiculo();
            Vehiculo v2 = new Vehiculo();
            Vehiculo v3 = new Vehiculo();

            v1.color = "Azul";
            v2.color = "Amarillo";
            v3.color = "Morado";

            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            listaVehiculos.Add(v1);
            listaVehiculos.Add(v2);
            listaVehiculos.Add(v3);

            //Console.WriteLine("La cantidad de vehiculos es: " + listaVehiculos.Count);

            //v2.color = "Verdoso";
            //listaVehiculos[1].color = "Negro";

            //Console.WriteLine("El color es: " + listaVehiculos[1].color);

            // listaVehiculos.Remove(v1);//remueve un element de listaVehiculos

            foreach (Vehiculo item in listaVehiculos)
            {
                Console.WriteLine("color: " + item.color);
            }

        }
    }
}
