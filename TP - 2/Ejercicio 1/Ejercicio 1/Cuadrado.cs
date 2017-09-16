using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Cuadrado : Figura
    {
        private double lado;
        private int lados = 4;

        double Figura.CalcularArea()
        {
            return (this.lado * this.lado);
        }

        double Figura.CalcularPerimetro()
        {
            return (this.lado * this.lados);
        }

        public void setLado(double lado)
        {
            this.lado = lado;
        }
    }
}
