using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interfaces: definicion abstracta es como un contrato en la cual
            // las dos partes tienen que Cumplir para que este todo bien.
            // La clase tiene que cumplir lo que ese contrato define 
            //Que define el contrato:  Un COMPORTAMIENTO, define el que pero no el como
            //yo puedo definir que una clase debe implementar determinada funcionalidad
            //pero no le puedo decir como,El como lo define la misma clase...
            //Firma de la interfaz tipo nombre y parametros

            //Otra de las funcionalidades de las interfaces es segmentar Objetos
            //Puedo clasificar diferentes objetos bajo distintos patrones...
             

            //queremos saber cuales son los animales que puden volar...
            List<Animal> animales = new List<Animal>(); 

            animales.Add(new Aguila());
            animales.Add(new Canario());
            animales.Add(new Gato());
            animales.Add(new perro());
            animales.Add(new Aguila());
            animales.Add(new Canario());

            // Crear una coleccion de solo animales que puedan volar
            List<Flayable> listaVoladores = new List<Flayable>();//Estoy creando una instancia de una lista 
            
            // Flayable no es una clase 
            // Flayable f1 = new Flayable(); no se puede instanciar 

            listaVoladores.Add(new Canario());//Canario es una clase que implementa Flayable
            listaVoladores.Add(new Aguila());
            //No le puedo agregar cualqier animal solo animales que puedan Volar
            //listaVoladores.Add(new perro());
        }
    }
}
