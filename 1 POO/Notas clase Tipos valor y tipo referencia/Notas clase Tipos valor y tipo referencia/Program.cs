using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_clase_Tipos_valor_y_tipo_referencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Tipo referencial
            Cuando se crea una objeto: Vehiculo v1 = new Vehiculo();
            SE Tiene que ejecutar la palabra reservada NEW que llama al constructor
            que genera la instancia del objeto y que asigna esa instancia del objeto a
            la variable de tipo vehiculo

            yo puedo crear una variable: Vehiculo v1; con esto estoy creando una variable de
            tipo vehiculo PERO no un OBJETO

            cuando se habla de objetos nos referimos a una instancia de algo que esta vivo en la
            memoria

            vehiculo v1 = new vehiculo();

            Se crean vamos a decir dos secciones en memoria

            En la seccion 1                 referencia          seccion 2
            esta v1 la variable   ------------------------->   esta new vehiculo objeto
                                                               instancia del objeto

            por ejemplo 
            vehiculo v2; Esta es una variable de referencia NULL(nula)

            Si se pisa el valor de la variable con otro valor se elimina la referencia al primero objeto y se crea otro
            ejemplo

            vehiculo v1 =  new vehiculo();

            vehiculo v1 =  new vehiculo();
            seccion 1                   seccion2
            v1 ----------XXX--------->    obj1
               \______________________>    obj2

             

             */

        }
    }
}
