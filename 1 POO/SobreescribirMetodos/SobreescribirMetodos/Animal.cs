using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescribirMetodos
{
    internal class Animal
    {
        //Para que un metodo pueda ser sobreescribible overraidiable...
        // Tiene que ser Virtual
        public virtual string Comunicarse() 
        {
            return "Ruidoo.....Ruidoooo";
        }
    }
}
