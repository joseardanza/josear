using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Auto
    {
        private List<IRueda> ruedas = new List<IRueda>();
        private IMotor motor = new Motor();
        private ICajaCambios cajacambios = new CajaCambios();

        public void agregarRueda(IRueda rueda)
        {
            if (this.ruedas.Count == 5)
            {
                throw new Exception("Máximo 5 ruedas");
            }
            this.ruedas.Add(rueda);
        }

        public List<IRueda> getRuedas()
        {
            return this.ruedas;
        }

        public void setMotor(IMotor motor)
        {
            this.motor = motor;
        }

        public IMotor getMotor()
        {
            return this.motor;
        }

        public void setCajaCambios(ICajaCambios caja)
        {
            this.cajacambios = caja;
        }

        public ICajaCambios getCajacambios()
        {
            return this.cajacambios;
        }
    }
}
