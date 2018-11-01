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
        public double MontoTotal { get; set; }
        public double MontoCuota { get; set; }
        public int CantidadCuotas { get; set; }
        public int CuotasPagadas { get; set; }
        public int CuotasFaltantes { get; set; }
        public List<Pago> ListaPagos { get; set; }

        public Prestamo(Cliente cliente, int iD, Comercio comercioAdherido, Sucursal sucursal, int montoCredito, int cantidadCuotas)
        {
            Cliente = cliente;
            ID = iD;
            FCredito = DateTime.Today;
            ComercioAdherido = comercioAdherido;
            Sucursal = sucursal;
            MontoCredito = montoCredito;
            Tasa = this.Sucursal.TasaInteres;
            MontoTotal = MontoCredito+(Tasa*MontoCredito/100);
            MontoCuota = MontoTotal/CantidadCuotas;
            CantidadCuotas = cantidadCuotas;
            CuotasPagadas = 0;
            CuotasFaltantes = CantidadCuotas;
            ListaPagos = this.ArmadoListaPagos();
        }

        public bool ValidarObligatorios()
        {
            if (ComercioAdherido!=null && Sucursal!=null && MontoCredito>0 && CantidadCuotas > 0 && MontoTotal <= Cliente.MontoMaximo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Pago> ArmadoListaPagos()
        {
            DateTime fecha_pago = FCredito.AddDays(60); //Suma 60 dias a la fecha del credito para la fecha del pago inicial
            for (int i = 0; i < CantidadCuotas; i++)
            {
                var nuevo_pago = new Pago();
                if (i == 0) //Si es el primer pago, se le coloca la fecha a 60 dias.
                    nuevo_pago.FechaPago = fecha_pago;
                else
                    nuevo_pago.FechaPago= fecha_pago.AddDays(30); //los demas pagos ocurren 30 dias luego del primero

                this.ListaPagos.Add(nuevo_pago);
            }
            return ListaPagos;
        }

        public void RegistroPagos(LugarDePago lugar_de_pago)
        {
            if (CuotasFaltantes == 0)
                Console.WriteLine("El crédito no tiene cuotas impagas.");
            else
                foreach (Pago item in ListaPagos) //CONSULTA - Paga de manera secuencial un pago a la vez. ¿Debe verificar fecha?
                {
                    if (item.Pagado == false)
                        item.Pagado = true;
                    CuotasPagadas++;
                    CuotasFaltantes--;
                    break;
                }
        }

        public DetallePrestamo MostrarDetalles() //ACTUALIZAR DEPENDIENDO DE COMO SE COMPONE LA CLASE DETALLE PRESTAMO
        {
            Pago pago = ListaPagos.Last();
            double montopago = CantidadCuotas * MontoCuota; //¿El monto de pago implica que se puede pagar cierto monto de una cuota? ¿O es la acumulación de las cuotas ya pagadas?
            var DetallePrestamo = new DetallePrestamo(CuotasPagadas, MontoCuota, pago.FechaPago, montopago, pago.LugarPago);
            return DetallePrestamo;
        }
    }
}
