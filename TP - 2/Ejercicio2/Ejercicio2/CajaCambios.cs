using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class CajaCambios : ICajaCambios
    {
        private Days days;
        private int cantCambios;

        int ICajaCambios.cantidadCambios { get => this.cantCambios; set => this.cantCambios = value; }
        Days ICajaCambios.tipo { get => this.days; set => this.days = value; }

        public enum Days { AUTOMATICA,MANUAL };
    }
}
