﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescribirMetodos
{
    internal class Tigre : AnimalSalvaje
    {
        public override string Comunicarse()
        {
            return "wrao.. miau";
        }
    }
}
