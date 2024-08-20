using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asociacion
{
    internal class Auto: Vehiculo
    {
        public Auto() 
        {
            chasis = new chasis();
        }
        public int Ano {  get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        //Composicion
        public chasis chasis { get;}

        //Un auto va ha tener como una de sus propiedades un motor
        //Agregacion
        public  Motor Motor{ get; set; }

        //Asociacion: EL objeto tiene que nacer con ese otro objeto que lo compone como si fuera un costructor...
        //la Diferencia es el nivel de relacion o cercania que tiene el objeto Motor con Auto
        //El nivel de cercania se puede definir si por ejemplo el Objeto Auto puede nacer sin motor o tiene que nacer si o si con ese objeto. 
        //Agregacion Es el objeto que puede nacer despues es algo asi como que no se tiene que inicializar si o si el valor'

        //Definicion mas detallada:
        //Asociación:

        //Generalización: Es una relación entre dos objetos que pueden existir de manera independiente, pero uno necesita interactuar con el otro.
        //Ejemplo: Un Profesor y un Curso.Un profesor puede existir sin un curso específico, y un curso puede existir sin un profesor específico, pero hay una relación entre ellos.

        //Agregación:

        //En agregación, el objeto "contenedor" puede existir sin el objeto "contenido".
        //Ejemplo: Un Departamento y Empleado. Un departamento puede existir sin empleados (teóricamente) y un empleado puede existir sin pertenecer a un departamento específico.

        //Composición:

        //En composición, el objeto "contenedor" no puede existir sin el objeto "contenido" y viceversa.
        //Ejemplo: Un Coche y un Motor.Un coche no puede funcionar sin un motor, y un motor específico de un coche no tiene mucho sentido fuera del contexto del coche.

        // EN asociacion la palabra clave es "Tiene" un auto tiene un motor... . para definir herencias "Es" un Auto es un Vehiculo...
    }
}
