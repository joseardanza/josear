using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            IMotor motor1 = new Motor();
            motor1.cilindrada = 3;
            IMotor motor2 = new Motor();
            motor1.cilindrada = 4;
            IMotor motor3 = new Motor();
            motor1.cilindrada = 5;

            ICajaCambios caja1 = new CajaCambios();
            caja1.cantidadCambios = 5;
            caja1.tipo = CajaCambios.Days.AUTOMATICA;

            ICajaCambios caja2 = new CajaCambios();
            caja2.cantidadCambios = 4;
            caja2.tipo = CajaCambios.Days.MANUAL;

            ICajaCambios caja3 = new CajaCambios();
            caja2.cantidadCambios = 6;
            caja2.tipo = CajaCambios.Days.MANUAL;

            IRueda rueda1 = new Rueda();
            rueda1.diametro = 40;
            IRueda rueda2 = new Rueda();
            rueda1.diametro = 42;
            IRueda rueda3 = new Rueda();
            rueda1.diametro = 43;

            Auto auto1 = new Auto();
            auto1.agregarRueda(rueda1);
            auto1.agregarRueda(rueda2);
            auto1.agregarRueda(rueda3);
            auto1.setCajaCambios(caja1);
            auto1.setMotor(motor1);

            Auto auto2 = new Auto();
            auto2.agregarRueda(rueda1);
            auto2.agregarRueda(rueda2);
            auto2.agregarRueda(rueda3);
            auto2.agregarRueda(rueda3);
            auto2.agregarRueda(rueda3);

            auto2.setCajaCambios(caja2);
            auto2.setMotor(motor2);

            Auto auto3 = new Auto();
            auto3.agregarRueda(rueda1);
            auto3.agregarRueda(rueda2);
            auto3.agregarRueda(rueda3);
            auto3.agregarRueda(rueda3);
            auto3.setCajaCambios(caja3);
            auto3.setMotor(motor3);


            Auto auto4 = new Auto();
            auto4.agregarRueda(rueda1);
            auto4.agregarRueda(rueda2);
            auto4.agregarRueda(rueda3);
            auto4.agregarRueda(rueda3);
            auto4.agregarRueda(rueda3);
            //auto4.agregarRueda(rueda3);
            auto4.setCajaCambios(caja3);
            auto4.setMotor(motor3);
        }
    }
}
