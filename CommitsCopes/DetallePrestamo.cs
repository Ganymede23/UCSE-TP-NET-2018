using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DetallePrestamo
    {
        public DetallePrestamo(int nroCuota, double montoCuota, DateTime fechaPago, double montoPago, string lugarPago)
        {
            NroCuota = nroCuota;
            MontoCuota = montoCuota;
            FechaPago = fechaPago;
            MontoPago = montoPago;
            LugarPago = lugarPago;
        }

        public int NroCuota { get; set; }
        public double MontoCuota { get; set; }
        public DateTime FechaPago { get; set; }
        public double MontoPago { get; set; }
        public string LugarPago { get; set; }
    }
}
