using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado();
            cuadrado.setLado(3.4);
            testArea(cuadrado,"Cuadrado");
            testPerimetro(cuadrado, "Cuadrado");

            Triangulo triangulo = new Triangulo();
            triangulo.setAltura(4);
            triangulo.setBaseTriangulo(10);
            triangulo.setLadoTriangulo1(12);
            triangulo.setLadoTriangulo2(12);
            testArea(triangulo, "Triangulo");
            testPerimetro(triangulo, "Triangulo");

            Circulo circulo = new Circulo();
            circulo.setRadio(12.3);
            testArea(circulo, "Circulo");
            testPerimetro(circulo, "Circulo");

            Console.ReadKey();
        }

        public static void testArea(Figura figura,String textoFigura)
        {
            Console.WriteLine("Area de "+textoFigura + " es: " + figura.CalcularArea());

        }

        public static void testPerimetro(Figura figura, String textoFigura)
        {
            Console.WriteLine("Perímetro de " + textoFigura + " es: " + figura.CalcularPerimetro());
        }
    }
}
