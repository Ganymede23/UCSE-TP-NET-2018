using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

        public ResultadoOp CrearArchivos()
        {
            if (!File.Exists(@"C:\Datos\Prestamos.txt"))
                File.Create(@"C:\Datos\Prestamos.txt").Close();
            if (!File.Exists(@"C:\Datos\Sucursales.txt"))
                File.Create(@"C:\Datos\Sucursales.txt").Close();
            if (!File.Exists(@"C:\Datos\Comercios.txt"))
                File.Create(@"C:\Datos\Comercios.txt").Close();
            if (!File.Exists(@"C:\Datos\LugaresDePago.txt"))
                File.Create(@"C:\Datos\LugaresDePago.txt").Close();
            if (!File.Exists(@"C:\Datos\Clientes.txt"))
                File.Create(@"C:\Datos\Clientes.txt").Close();

            ListaPrestamos = new List<Prestamo>();
            ListaSucursales = new List<Sucursal>();
            ListaComercios = new List<Comercio>();
            ListaLugaresDePago = new List<LugarDePago>();
            ListaClientes = new List<Cliente>();

            var resultado = new ResultadoOp(true,"");
            return resultado;
        }

        public void LeerClientes()
        {
            using (StreamReader reader = new StreamReader(@"C:\Datos\Clientes.txt"))
            {
                string contenido = reader.ReadToEnd();
                ListaClientes = JsonConvert.DeserializeObject<List<Cliente>>(contenido);

                if (ListaClientes==null)
                {
                    ListaClientes = new List<Cliente>();
                }
            }
        }
        public void GuardarClientes(List<Cliente> listaclientes)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Datos\Clientes.txt", false))
            {
                string jsonClientes = JsonConvert.SerializeObject(listaclientes);
                writer.Write(jsonClientes);
            }
        }

        public void LeerPrestamos()
        {
            using (StreamReader reader = new StreamReader(@"C:\Datos\Prestamos.txt"))
            {
                string contenido = reader.ReadToEnd();
                ListaPrestamos = JsonConvert.DeserializeObject<List<Prestamo>>(contenido);

                if (ListaPrestamos == null)
                {
                    ListaPrestamos = new List<Prestamo>();
                }
            }
        }
        public void GuardarPrestamos(List<Prestamo> listaprestamos)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Datos\Prestamos.txt", false))
            {
                string jsonPrestamos = JsonConvert.SerializeObject(listaprestamos);
                writer.Write(jsonPrestamos);
            }
        }

        public void LeerSucursales()
        {
            using (StreamReader reader = new StreamReader(@"C:\Datos\Sucursales.txt"))
            {
                string contenido = reader.ReadToEnd();
                ListaSucursales = JsonConvert.DeserializeObject<List<Sucursal>>(contenido);

                if (ListaSucursales==null)
                {
                    ListaSucursales = new List<Sucursal>();
                }
            }
        }
        public void GuardarSucursales(List<Sucursal> listasucursales)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Datos\Sucursales.txt", false))
            {
                string jsonSucursales = JsonConvert.SerializeObject(listasucursales);
                writer.Write(jsonSucursales);
            }
        }

        public void LeerComercios()
        {
            using (StreamReader reader = new StreamReader(@"C:\Datos\Comercios.txt"))
            {
                string contenido = reader.ReadToEnd();
                ListaComercios = JsonConvert.DeserializeObject<List<Comercio>>(contenido);

                if (ListaComercios==null)
                {
                    ListaComercios = new List<Comercio>();
                }
            }
        }
        public void GuardarComercios(List<Comercio> listacomercios)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Datos\Comercios.txt", false))
            {
                string jsonComercios = JsonConvert.SerializeObject(listacomercios);
                writer.Write(jsonComercios);
            }
        }

        public void LeerLugaresDePago()
        {
            using (StreamReader reader = new StreamReader(@"C:\Datos\LugaresDePago.txt"))
            {
                string contenido = reader.ReadToEnd();
                ListaLugaresDePago = JsonConvert.DeserializeObject<List<LugarDePago>>(contenido);
            }

            if (ListaLugaresDePago==null)
            {
                ListaLugaresDePago = new List<LugarDePago>();
            }
        }
        public void GuardarLugaresDePago(List<LugarDePago> listalugaresdepago)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Datos\LugaresDePago.txt", false))
            {
                string jsonLugaresDePago = JsonConvert.SerializeObject(listalugaresdepago);
                writer.Write(jsonLugaresDePago);
            }
        }

        public List<Cliente> ObtenerClientes()
        {
            LeerClientes();
            return ListaClientes.Where(x => x.Activo == true).ToList();
        }
        public List<Comercio> ObtenerComercios()
        {
            LeerComercios();
            return ListaComercios.Where(x => x.Activo == true).ToList();
        }
        public List<LugarDePago> ObtenerLugares()
        {
            LeerLugaresDePago();
            return ListaLugaresDePago.Where(x => x.Activo == true).ToList();
        }
        /////////
        //ALTAS//
        /////////

        public ResultadoOp AltaClientes(Cliente nuevocliente)
        {
            LeerClientes();

            ResultadoOp resultado = new ResultadoOp();
            bool condicion = false;

            if (nuevocliente.ValidarObligatorios())
            {
                foreach (Cliente item in ListaClientes) //Verifica la combinacion de tipo y nro de documento.
                {
                    if (item.TipoDocumento==nuevocliente.TipoDocumento && item.NroDocumento==nuevocliente.NroDocumento)
                    {
                        condicion = true;
                        break;
                    }
                }
                if (condicion==true) 
                {
                    resultado.Mensaje = "El tipo y numero de documento ingresado ya está registrado.";
                    resultado.Resultado = false;
                    return resultado;
                }
                else
                {
                    nuevocliente.ID = ListaClientes.Count + 1;
                    //nuevocliente.Activo = true;
                    ListaClientes.Add(nuevocliente);
                    GuardarClientes(ListaClientes);
                    resultado.Resultado = true;
                    return resultado;
                }
            }
            else
            {
                resultado.Mensaje = "Campos obligatorios (*) incompletos.";
                resultado.Resultado = false;
                return resultado;
            }
        }

        public ResultadoOp AltaPrestamos(Cliente cliente, Comercio comercioAdherido, Sucursal sucursal, int montoCredito, double montoCuota, int cantidadCuotas)
        {
            LeerPrestamos();
            var NuevoPrestamo = new Prestamo(cliente, ListaPrestamos.Count+1, comercioAdherido, sucursal, montoCredito, cantidadCuotas);

            if (NuevoPrestamo.ValidarObligatorios())
            {
                if (NuevoPrestamo.MontoTotal > NuevoPrestamo.Cliente.MontoMaximo)
                {
                    return new ResultadoOp(false, "El monto total del crédito excede el monto máximo autorizado del cliente.");
                }
                else
                {
                    ListaPrestamos.Add(NuevoPrestamo);
                    GuardarPrestamos(ListaPrestamos);
                    return new ResultadoOp();
                }
            }
            else
            {
                return new ResultadoOp(false, "Campos obligatorios (*) incompletos.");
            }
        }

        public ResultadoOp AltaSucursal(string ciudad, string direccion, int cP, double tasaInteres)
        {
            LeerSucursales();
            var nueva_sucursal = new Sucursal(ListaSucursales.Count+1, ciudad, direccion, cP, tasaInteres);

            if (nueva_sucursal.ValidarObligatorios())
            {
                ListaSucursales.Add(nueva_sucursal);
                GuardarSucursales(ListaSucursales);
                return new ResultadoOp();
            }
            else
            {
                return new ResultadoOp(false, "Campos obligatorios (*) incompletos.");
            }
        }

        public ResultadoOp AltaComercios(Comercio nuevoComercio)
        {
            LeerClientes();

            ResultadoOp resultado = new ResultadoOp();

            if (nuevoComercio.ValidarObligatorios())
            {
                nuevoComercio.ID = ListaComercios.Count + 1;
                ListaComercios.Add(nuevoComercio);
                GuardarComercios(ListaComercios);
                resultado.Resultado = true;
                return resultado;
            }
            else
            {
                resultado.Mensaje = "Campos obligatorios (*) incompletos.";
                resultado.Resultado = false;
                return resultado;
            }
        }

        public ResultadoOp AltaLugaresDePago(LugarDePago nuevoLugar)
        {
            LeerLugaresDePago();

            ResultadoOp resultado = new ResultadoOp();

            if (nuevoLugar.ValidarObligatorios())
            {
                nuevoLugar.ID = ListaComercios.Count + 1;
                ListaLugaresDePago.Add(nuevoLugar);
                GuardarLugaresDePago(ListaLugaresDePago);
                resultado.Resultado = true;
                return resultado;
            }
            else
            {
                resultado.Mensaje = "Campos obligatorios (*) incompletos.";
                resultado.Resultado = false;
                return resultado;
            }
        }



        //////////////////
        //MODIFICACIONES//
        //////////////////

        public ResultadoOp ModificacionCliente(Cliente nuevoCliente, bool eliminar)
        {
            ResultadoOp resultado = new ResultadoOp();
            Cliente cliente = ListaClientes.FirstOrDefault(x => x.ID == nuevoCliente.ID);
            if (!eliminar) //Modificación 
            {
                
                cliente.TipoDocumento = nuevoCliente.TipoDocumento;
                cliente.NroDocumento = nuevoCliente.NroDocumento;
                cliente.Nombre = nuevoCliente.Nombre;
                cliente.Correo = nuevoCliente.Correo;
                cliente.Celular = nuevoCliente.Celular;
                cliente.FNac = nuevoCliente.FNac;
                cliente.Sexo = nuevoCliente.Sexo;
                cliente.Domicilio = nuevoCliente.Domicilio;
                cliente.CP = nuevoCliente.CP;
                cliente.TipoCliente = nuevoCliente.TipoCliente;
                cliente.MontoMaximo = nuevoCliente.MontoMaximo;
            }
            else //Eliminación
            {
                cliente.Activo = nuevoCliente.Activo;
            }
            GuardarClientes(ListaClientes);
            return resultado;
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

        public ResultadoOp ModificacionComercio(Comercio nuevoComercio, bool eliminar)
        {
            ResultadoOp resultado = new ResultadoOp();
            Comercio comercio = ListaComercios.FirstOrDefault(x => x.ID == nuevoComercio.ID);
            if (!eliminar) //Modificación 
            {
                comercio.Ciudad = nuevoComercio.Ciudad;
                comercio.Direccion = nuevoComercio.Direccion;
                comercio.CP = nuevoComercio.CP;
                comercio.RazonSocial = nuevoComercio.RazonSocial;
            }
            else //Eliminación
            {
                comercio.Activo = nuevoComercio.Activo;
            }
            GuardarComercios(ListaComercios);
            return resultado;
        }

        public ResultadoOp ModificacionLugaresDePago(LugarDePago nuevoLugar, bool eliminar)
        {
            ResultadoOp resultado = new ResultadoOp();
            LugarDePago lugar = ListaLugaresDePago.FirstOrDefault(x => x.ID == nuevoLugar.ID);
            if (!eliminar) //Modificación 
            {
                lugar.Ciudad = nuevoLugar.Ciudad;
                lugar.Direccion = nuevoLugar.Direccion;
                lugar.CP = nuevoLugar.CP;
                lugar.RazonSocial = nuevoLugar.RazonSocial;
                lugar.EsSucursal = nuevoLugar.EsSucursal;
            }
            else //Eliminación
            {
                lugar.Activo = nuevoLugar.Activo;
            }
            GuardarLugaresDePago(ListaLugaresDePago);
            return resultado;
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
                    item.Activo = false;
                    break;
                }
            }
        }

        public void BajaSucursal(Sucursal sucursal_a_eliminar)
        {
            foreach (var item in ListaSucursales)
            {
                if (item == sucursal_a_eliminar)
                {
                    item.Activo = false;
                    break;
                }
            }
        }

        public void BajaComercio(Comercio comercio_a_eliminar)
        {
            foreach (var item in ListaComercios)
            {
                if (item == comercio_a_eliminar)
                {
                    item.Activo = false;
                    break;
                }
            }
        }

        public void BajaLugaresDePago(LugarDePago lugar_a_eliminar)
        {
            foreach (var item in ListaLugaresDePago)
            {
                if (item == lugar_a_eliminar)
                {
                    item.Activo = false;
                    break;
                }
            }
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

        public List<Prestamo> FiltrarPrestamosxFecha(DateTime desde, DateTime hasta)
        {
            List<Prestamo> PrestamosFiltrados = ListaPrestamos.Where(x => x.FCredito >= desde && x.FCredito <= hasta).ToList();

            return PrestamosFiltrados;
        }

        //FALTA FILTRAR POR NOMBRE DE CLIENTE
    }
}
