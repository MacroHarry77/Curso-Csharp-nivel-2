using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Canario : AnimalesDomesticos, Flayable //IComparable
    {
        //metodo de comparacion que me permite implementar la interfaz comparable
        public string Volar()
        {
            return "Vuela como un Canario ";
        }
    }
}

