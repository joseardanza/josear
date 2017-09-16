using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Rueda : IRueda
    {
        private double diametro;

        double IRueda.diametro { get => this.diametro; set => this.diametro = value; }

        void IRueda.frenar()
        {
            throw new NotImplementedException();
        }

        void IRueda.iniciar()
        {
            throw new NotImplementedException();
        }
    }
}
