using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Circulo : Figura
    {
        private double radio;
        private int lados = 4;

        double Figura.CalcularArea()
        {
            return (this.radio * this.radio * Math.PI);
        }

        double Figura.CalcularPerimetro()
        {
            return (this.radio * Math.PI * Math.PI);
        }

        public void setRadio(double radio)
        {
            this.radio = radio;
        }

    }
}
