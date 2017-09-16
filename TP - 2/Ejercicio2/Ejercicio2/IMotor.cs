using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    interface IMotor
    {
        void iniciar();
        void frenar();

        double cilindrada
        {
            get;
            set;
        }
    }
}
