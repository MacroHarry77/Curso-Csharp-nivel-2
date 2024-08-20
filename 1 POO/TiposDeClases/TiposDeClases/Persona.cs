using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeClases
{
    //abstract class Persona //Clase abstracta no permite que se ejecute en el main esta clase o que no se pueda instanciar,..
    //sealed class Persona //Esta calse no puede ser herdada, Es como el final de una gerarquia
    static class Persona // No  permite heredar; En el main no se puede instanciar pero si se puede utilizar todos sus metodos EJ Console.Write
        //Se usa para poder ser utilizada al momento sin la necesidad de crear una instancia 
    {
       
        public static string saluda() 
        {
            return "Hello ";
        }  
    }
}
