﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescribirMetodos
{
    internal class Gato: AnimalesDomesticos
    {
        public override string Comunicarse()
        {
            return "miau.... miau..uwu";
        }
    }
}
