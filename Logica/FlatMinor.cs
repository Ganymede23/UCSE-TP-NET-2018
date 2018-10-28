using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class FlatMinor
    {
        public List<Prestamo> ListaPrestamos { get; set; }
        public List<Sucursal> ListaSucursales { get; set; }
        public List<Comercio> ListaComercios { get; set; }
        public List<LugarDePago> ListaLugaresDePago { get; set; }
        public List<Cliente> ListaClientes { get; set; }

        /////////
        //ALTAS//
        /////////

        public string AltaClientes(TipoDocumento tipoDocumento, int nroDocumento, string nombre, string correo, int celular, DateTime fNac, char sexo, string domicilio, int cP, TipoCliente tipoCliente, int montoMaximo)
        {
            var NuevoCliente = new Cliente(tipoDocumento, nroDocumento, nombre, correo, celular, fNac, sexo, domicilio, cP, tipoCliente, montoMaximo);

            //FALTAN VALIDACIONES

            if (ListaClientes.Where(x => x.NroDocumento == nroDocumento & x.TipoDocumento == tipoDocumento).FirstOrDefault() != null)
            {
                return ("Este nro de documenta ya esta registrado");
            }
            else
            {
                ListaClientes.Add(NuevoCliente);
                return ("Se ha registrado correctamente el Cliente");
            }

        }

        public string AltaPrestamos(Cliente cliente, Comercio comercioAdherido, Sucursal sucursal, int montoCredito, double montoCuota, int cantidadCuotas)
        {
            double montototal = (montoCredito + ((montoCredito * sucursal.TasaInteres) / 100));
            montoCuota = montototal / cantidadCuotas;

            var NuevoPrestamo = new Prestamo(cliente, ListaPrestamos.Count+1, comercioAdherido, sucursal, montoCredito, montoCuota, cantidadCuotas);

            //FALTAN VALIDADCIONES

            if (NuevoPrestamo.MontoCredito < montototal && cantidadCuotas == 0)
            {
                return ("El monto regristrado es mayor al monto de credito que dispone o la cantidad de cuotas fue mal ingresada");
            }
            else
            {
                ListaPrestamos.Add(NuevoPrestamo);
                return ("Se ha registrado su prestamo");
            }
        }

        public void AltaSucursal(string ciudad, string direccion, int cP, double tasaInteres)
        {
            var nueva_sucursal = new Sucursal(ListaSucursales.Count+1, ciudad, direccion, cP, tasaInteres);

            //VALIDAR OBLIGATORIOS 

            ListaSucursales.Add(nueva_sucursal);
        }

        public void AltaComercio(string ciudad, string direccion, int cP, string razonSocial)
        {
            var nuevo_comercio = new Comercio(ListaComercios.Count + 1, ciudad, direccion, cP, razonSocial);

            //VALIDAR OBLIGATORIOS 

            ListaComercios.Add(nuevo_comercio);
        }

        public void AltaLugaresDePago(string ciudad, string direccion, int cP, string razonSocial, bool esSucursal)
        {
            var nuevo_lugardepago = new LugarDePago(ListaLugaresDePago.Count + 1, ciudad, direccion, cP, razonSocial, esSucursal);

            //VALIDAR OBLIGATORIOS

            ListaLugaresDePago.Add(nuevo_lugardepago);
        }

        //////////////////
        //MODIFICACIONES//
        //////////////////

        public void ModificarCliente(Cliente clienteamodificar, TipoDocumento tipoDocumento, int nroDocumento, string nombre, string correo, int celular, DateTime fNac, char sexo, string domicilio, int cP, TipoCliente tipoCliente, int montoMaximo)
        {
            foreach (var item in ListaClientes)
            {
                if (item == clienteamodificar)
                {
                    item.TipoDocumento = tipoDocumento;
                    item.NroDocumento = nroDocumento;
                    item.Nombre = nombre;
                    item.Correo = correo;
                    item.Celular = celular;
                    item.FNac = fNac;
                    item.Sexo = sexo;
                    item.Domicilio = domicilio;
                    item.CP = cP;
                    item.TipoCliente = tipoCliente;
                    item.MontoMaximo = montoMaximo;
                    break;
                }
            }
        }

        public void ModificacionSucursal(Sucursal sucursal_a_modificar, string ciudad, string direccion, int cP, double tasaInteres)
        {
            foreach (Sucursal item in ListaSucursales)
            {
                if (item==sucursal_a_modificar)
                {
                    //item.ID = item.ID;
                    item.Ciudad = ciudad;
                    item.Direccion = direccion;
                    item.CP = cP;
                    item.TasaInteres = tasaInteres;
                    break;
                }
            }
            //VALIDAR OBLIGATORIOS
        }

        public void ModificacionComercio(Comercio comercio_a_modificar, string ciudad, string direccion, int cP, string razonSocial)
        {
            foreach (Comercio item in ListaComercios)
            {
                if (item==comercio_a_modificar)
                {
                    //item.ID = item.ID;
                    item.Ciudad = ciudad;
                    item.Direccion = direccion;
                    item.CP = cP;
                    item.RazonSocial = razonSocial;
                }
            }
            //VALIDAR OBLIGATORIOS 
        }

        public void ModificacionLugaresDePago(LugarDePago lugar_a_modificar, string ciudad, string direccion, int cP, string razonSocial, bool esSucursal)
        {
            foreach (LugarDePago item in ListaComercios)
            {
                if (item == lugar_a_modificar)
                {
                    //item.ID = item.ID;
                    item.Ciudad = ciudad;
                    item.Direccion = direccion;
                    item.CP = cP;
                    item.RazonSocial = razonSocial;
                    item.EsSucursal = esSucursal;
                }
            }
            //VALIDAR OBLIGATORIOS 
        }

        /////////
        //BAJAS//
        /////////

        public void EliminarCliente(Cliente clienteaeliminar)
        {
            foreach (var item in ListaClientes)
            {
                if (item == clienteaeliminar)
                {
                    ListaClientes.Remove(item);
                    break;
                }
            }
        }

        public void BajaSucursal(Sucursal sucursal_a_eliminar)
        {
            ListaSucursales.Remove(sucursal_a_eliminar);
        }

        public void BajaComercio(Comercio comercio_a_eliminar)
        {
            ListaComercios.Remove(comercio_a_eliminar);
        }

        public void BajaLugaresDePago(LugarDePago lugar_a_eliminar)
        {
            ListaLugaresDePago.Remove(lugar_a_eliminar);
        }

        /////////
        //OTROS//
        /////////

        public void ReporteDePagos()
        {
            int MontoTotalPrestado = ListaPrestamos.Sum(x => x.MontoCredito);
            double PromedioTasas = ListaPrestamos.Average(x => x.Tasa);
            foreach (Prestamo item in ListaPrestamos)
            {
                double TotalCuotasPagadas = item.CuotasPagadas * item.MontoCuota;
            }
        }
    }
}
