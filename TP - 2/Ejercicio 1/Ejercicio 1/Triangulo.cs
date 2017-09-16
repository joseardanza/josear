using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Triangulo : Figura
    {
        private double baseTriangulo;
        private double altura;
        private double ladoTriangulo1;
        private double ladoTriangulo2;

        double Figura.CalcularArea()
        {
            return (this.baseTriangulo * this.altura);
        }

        double Figura.CalcularPerimetro()
        {
            return (this.baseTriangulo + this.ladoTriangulo1 + this.ladoTriangulo2);
        }

       
        public void setBaseTriangulo(double baseT) {
            this.baseTriangulo = baseT;
        }

        public void setAltura(double altura) {
            this.altura = altura;
        }

        public void setLadoTriangulo1(double ladoTriangulo1)
        {
            this.ladoTriangulo1 = ladoTriangulo1;
        }

        public void setLadoTriangulo2(double ladoTriangulo2)
        {
            this.ladoTriangulo2 = ladoTriangulo2;
        }

    }
}
