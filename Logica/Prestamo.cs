﻿using System;
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
        public decimal Tasa { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal MontoCuota { get; set; }
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

        public Prestamo()
        {
            FCredito = DateTime.Today;
            CuotasPagadas = 0;
        }

        public bool ValidarObligatorios()
        {
            if (Cliente!=null && ComercioAdherido!=null && Sucursal!=null && MontoCredito>0 && CantidadCuotas > 0)
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
            this.ListaPagos = new List<Pago>();
            DateTime fecha_pago = FCredito.AddDays(60); //Suma 60 dias a la fecha del credito para la fecha del pago inicial

            for (int i = 0; i < CantidadCuotas; i++)
            {
                var nuevo_pago = new Pago();
                if (i == 0) //Si es el primer pago, se le coloca la fecha a 60 dias.
                    nuevo_pago.FechaPago = fecha_pago;
                else
                {
                    fecha_pago = fecha_pago.AddMonths(1);
                    nuevo_pago.FechaPago = fecha_pago; //los demas pagos ocurren 1 mes luego anterior
                }
                    
                nuevo_pago.MontoCuota = this.MontoCuota;
                //nuevo_pago.MontoPago = this.MontoCuota;
                nuevo_pago.NumeroCuota = i + 1;
                this.ListaPagos.Add(nuevo_pago);
            }
            return ListaPagos;
        }

        public DetallePrestamo MostrarDetalles()
        {
            var DetallePrestamo = new DetallePrestamo(this.Cliente, this.Sucursal, this.ComercioAdherido, ID, MontoCredito, Tasa, MontoTotal, CantidadCuotas, this.ListaPagos);
            return DetallePrestamo;
        }
    }
}
