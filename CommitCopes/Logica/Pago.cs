using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Pago
    {
        public Pago()
        {
        }

        public int NumeroCuota { get; set; }
        public double MontoCuota { get; set; }
        public double MontoPago { get; set; }
        public DateTime FechaPago { get; set; }
        public LugarDePago LugarPago { get; set; }


    }
}
