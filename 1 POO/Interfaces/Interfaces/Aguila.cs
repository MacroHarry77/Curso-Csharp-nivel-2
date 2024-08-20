using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Aguila : AnimalesDomesticos, Flayable
    {
        public string Volar()
        {
            return "Vuela como un Aguila ";
        }
    }
}
