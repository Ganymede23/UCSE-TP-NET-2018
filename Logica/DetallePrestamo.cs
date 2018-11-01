using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DetallePrestamo
    {
        public DetallePrestamo(Cliente cliente, Sucursal sucursal, Comercio comercio, int iD, double montoCredito, double tasa, double montoTotal, int cantidadCuotas, List<Pago> listaPagos)
        {
            Cliente = cliente;
            Sucursal = sucursal;
            Comercio = comercio;
            ID = iD;
            MontoCredito = montoCredito;
            Tasa = tasa;
            MontoTotal = montoTotal;
            CantidadCuotas = cantidadCuotas;
            ListaPagos = listaPagos;
        }

        public Cliente Cliente { get; set; }
        public Sucursal Sucursal { get; set; }
        public Comercio Comercio { get; set; }
        public int ID { get; set; }
        public double MontoCredito { get; set; }
        public double Tasa { get; set; }
        public double MontoTotal { get; set; }
        public int CantidadCuotas { get; set; }
        public List<Pago> ListaPagos { get; set; }

        //public Prestamo Prestamo { get; set; }

        ////CLIENTE
        //public string Nombre { get; set; }
        //public TipoDocumento TipoDocumento { get; set; }
        //public int NroDocumento { get; set; }
        //public TipoCliente TipoCliente { get; set; }

        ////SUCURSAL
        //public int IDsucursal { get; set; }
        //public string CiudadSuc { get; set; }
        //public string DireccionSuc { get; set; }
        //public int CPSuc { get; set; }

        ////COMERCIO
        //public int IDcomercio { get; set; }
        //public string CiudadCom { get; set; }
        //public string DireccionCom { get; set; }
        //public int CPCom { get; set; }
        //public string RazonSocial { get; set; }

        ////PRESTAMO
        //public int IDprestamo { get; set; }
        //public DateTime FCredito { get; set; }
        //public Comercio ComercioAdherido { get; set; }
        //public Sucursal Sucursal { get; set; }
        //public int MontoCredito { get; set; }
        //public double Tasa { get; set; }

        ////CUOTAS
        //public int NroCuota { get; set; }
        //public double MontoCuota { get; set; }
        //public DateTime FechaPago { get; set; }
        //public double MontoPago { get; set; }
        //public LugarDePago LugarPago { get; set; }
    }
}
