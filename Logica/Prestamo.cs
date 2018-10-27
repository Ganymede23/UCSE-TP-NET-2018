using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Prestamo
    {
        public Cliente Cliente { get; set; }
        public int ID { get; set; }
        public DateTime FCredito { get; set; }
        public Comercio ComercioAdherido { get; set; }
        public Sucursal Sucursal { get; set; }
        public int MontoCredito { get; set; }
        public double Tasa { get; set; }
        public double MontoCuota { get; set; }
        public int CantidadCuotas { get; set; }
        public int CuotasPagadas { get; set; }
        public int CuotasFaltantes { get; set; }
        public Pago ListaPagos { get; set; }

        public Prestamo(Cliente cliente, int iD, Comercio comercioAdherido, Sucursal sucursal, int montoCredito, double montoCuota, int cantidadCuotas)
        {
            Cliente = cliente;
            ID = iD;
            FCredito = DateTime.Today;
            ComercioAdherido = comercioAdherido;
            Sucursal = sucursal;
            MontoCredito = montoCredito;
            Tasa = this.Sucursal.TasaInteres;
            MontoCuota = montoCuota;
            CantidadCuotas = cantidadCuotas;
            CuotasPagadas = 0;
            CuotasFaltantes = CantidadCuotas;
        }

        public void RegistroPagos(LugarDePago lugar_de_pago)
        {
            if (CuotasFaltantes==0)
                Console.WriteLine("El crédito no tiene cuotas impagas.");
            else

        }
    }
}
