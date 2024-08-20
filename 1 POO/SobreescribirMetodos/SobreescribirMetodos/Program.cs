using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescribirMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Agarrar un metodo que ya existe y redefinirlo
             ese comportamiento que quiero replantear es un metodo 
            que va a ser heredado, 
             */

            //Creaciond de la instancia del objeto

            AnimalesDomesticos a1 = new AnimalesDomesticos();

            Perro p1 = new Perro();

            p1.Nombre = "Shaggy";
            a1.Nombre = "Pinky";

            //Vamos a redefinir el metodo ToString para que muestre el nombre
            Console.WriteLine(/*a1.ToString())*/a1.Comunicarse());
            //Sobreescribimo el metodo Comunicarse para que el Ruido
            //sea diferente para cada animal...
            Console.WriteLine(p1.Comunicarse());



            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(new Tigre());
            animales.Add(new Aguila());
            animales.Add(new Gato());
            //...

            Animal b1 = p1;//Guardar la referencia del perro en un animal
            //Animal no tiene nombre el nivel de herencia es de abajo hacia arriba
            // El que tiene nombre es la clase AnimalDomestico que hereda de Animal
            //Pero animal no puede leer lo que contiene AnimalDomestico.

            //para poder ver el nombre desde animal:
            Perro p8 = (Perro)b1;// como estoy seguro de que b1 es un perro le digo al compilador
            //que lo trate como un perro (casteo explicito)

            p8.Nombre = "scooby";
            Console.WriteLine(p1.Nombre);
            Console.WriteLine("Comunicacion...");
            foreach (Animal animal in animales)
            {
                Console.WriteLine(animal.Comunicarse());
                //Polimorfismo Caracteristica que tienen los objetos
                //DE frente a un mismo estimulo comportarse de manera
                //Distinta


            }
        }
    }
}
