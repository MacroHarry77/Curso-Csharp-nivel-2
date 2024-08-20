using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Persona
    {
        public Persona(string name, int id, string edad)    
        {
            this.name = name;  
            this.id = id;
            this.edad = edad;
        }    

        public string name { get; set; }
        public int id { get; set; }
        public string edad { get; set; }

    }
}
