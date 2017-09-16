using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Motor : IMotor
    {
        void IMotor.frenar()
        {
            throw new NotImplementedException();
        }

        void IMotor.iniciar()
        {
            throw new NotImplementedException();
        }

        private double cilindrada;

        double IMotor.cilindrada { get => this.cilindrada; set => this.cilindrada = value; }

    }
}
