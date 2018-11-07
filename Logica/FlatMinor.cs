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

        public List<Cliente> ObtenerClientes(int? id)
        {
            LeerClientes();
            return ListaClientes.Where(x => id.HasValue ? x.ID == id : true).ToList();
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
                    ListaClientes.Add(nuevocliente);
                    GuardarClientes(ListaClientes);
                    resultado.Resultado = true;
                    return resultado;
                }
            }
            else
            {
                resultado.Mensaje = "Campos incompletos.";
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
                return new ResultadoOp(false, "Campos incompletos.");
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
                return new ResultadoOp(false, "Campos incompletos.");
            }
        }

        public ResultadoOp AltaComercio(string ciudad, string direccion, int cP, string razonSocial)
        {
            LeerComercios();
            var nuevo_comercio = new Comercio(ListaComercios.Count + 1, ciudad, direccion, cP, razonSocial);

            if (nuevo_comercio.ValidarObligatorios())
            {
                ListaComercios.Add(nuevo_comercio);
                GuardarComercios(ListaComercios);
                return new ResultadoOp();
            }
            else
            {
                return new ResultadoOp(false, "Campos incompletos.");
            }
        }

        public ResultadoOp AltaLugaresDePago(string ciudad, string direccion, int cP, string razonSocial, bool esSucursal)
        {
            LeerLugaresDePago();
            var nuevo_lugardepago = new LugarDePago(ListaLugaresDePago.Count + 1, ciudad, direccion, cP, razonSocial, esSucursal);

            if (nuevo_lugardepago.ValidarObligatorios())
            {
                ListaLugaresDePago.Add(nuevo_lugardepago);
                GuardarLugaresDePago(ListaLugaresDePago);
                return new ResultadoOp();
            }
            else
            {
                return new ResultadoOp(false, "Campos incompletos.");
            }
        }

        //////////////////
        //MODIFICACIONES//
        //////////////////

        //public void ModificarCliente(Cliente clienteamodificar, TipoDocumento tipoDocumento, int nroDocumento, string nombre, string correo, string celular, DateTime fNac, Sexo sexo, string domicilio, int cP, TipoCliente tipoCliente, int montoMaximo)
        //{
        //    foreach (var item in ListaClientes)
        //    {
        //        if (item == clienteamodificar)
        //        {
        //            item.TipoDocumento = tipoDocumento;
        //            item.NroDocumento = nroDocumento;
        //            item.Nombre = nombre;
        //            item.Correo = correo;
        //            item.Celular = celular;
        //            item.FNac = fNac;
        //            item.Sexo = sexo;
        //            item.Domicilio = domicilio;
        //            item.CP = cP;
        //            item.TipoCliente = tipoCliente;
        //            item.MontoMaximo = montoMaximo;
        //            break;
        //        }
        //    }
        //}

        public ResultadoOp ModificacionCliente(Cliente nuevoCliente, bool eliminar)
        {
            ResultadoOp resultado = new ResultadoOp();

            if (!eliminar) //Modificación de paciente
            {
                Cliente cliente = ListaClientes.FirstOrDefault(x => x.ID == nuevoCliente.ID);
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
            else //Eliminación de paciente
            {
                foreach (Cliente item in ListaClientes)
                {
                    if (item.ID==nuevoCliente.ID)
                    {
                        item.Activo = false;
                    }
                }
            }

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
