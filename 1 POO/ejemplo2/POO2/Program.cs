using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulos = new Articulo[10];

            for (int i = 0; i < 10; i++)
            {
                articulos[i] = new Articulo();


                Console.WriteLine("Ingrese los datos de producto: ");
                Console.WriteLine("Codigo ");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());

                Console.WriteLine("precio ");
                articulos[i].Precio = float.Parse(Console.ReadLine());

                Console.WriteLine("Marca 1 a 10");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());
            }
            //Ya se cargaron los 10 articulos en el vector 

            Ventas venta = new Ventas();
            Console.WriteLine("Codigo del cliente ");
            venta.CodCliente = int.Parse(Console.ReadLine());

            while (venta.CodCliente != 0)
            {
                Console.WriteLine("Codigo de articulo ");
                venta.CodArticulo = int.Parse(Console.ReadLine());

                Console.WriteLine("Cantidad ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //trabajamos...

                //pido clientes nuevamente 
            }
        }
    }
}
