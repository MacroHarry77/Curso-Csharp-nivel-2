using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Persona
    {
        // Persona: Edad, sueldo, Nombre
        // Atributos o Miembros...
        // encapsulamiento un miembro de una clase no debe ser accedido desde el exterior

        private int edad;
        private float sueldo;
        private string nombre;
        //modificadores de visibilidad:  public private internal etc

        //Funcion metodo

        public void setEdad(int e) 
        { 
            edad = e;
        }

        public int getEdad() 
        { 
            return edad;
        }
    }
}
