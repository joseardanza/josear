﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    interface IRueda
    {
        void iniciar();
        void frenar();

        double diametro
        {
            get;
            set;
        }
    }
}
