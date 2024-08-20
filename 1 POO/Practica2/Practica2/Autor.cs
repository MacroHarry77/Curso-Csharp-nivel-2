using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Autor:Persona
    {
        public Autor(string name, int id, string edad, string nacionalidad)
            :base(name,id,edad)
        { 
            this.nacionalidad = nacionalidad;
        }
        public  string nacionalidad { get; set; }
    }
}
