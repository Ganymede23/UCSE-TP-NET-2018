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

        public void CrearArchivos()
        {
            if (!File.Exists(@"C:\Datos\Prestamos.txt"))
                File.Create(@"C:\Datos\Prestamos.txt");
            if (!File.Exists(@"C:\Datos\Sucursales.txt"))
                File.Create(@"C:\Datos\Sucursales.txt");
            if (!File.Exists(@"C:\Datos\Comercios.txt"))
                File.Create(@"C:\Datos\Comercios.txt");
            if (!File.Exists(@"C:\Datos\LugaresDePago.txt"))
                File.Create(@"C:\Datos\LugaresDePago.txt");
            if (!File.Exists(@"C:\Datos\Clientes.txt"))
                File.Create(@"C:\Datos\Clientes.txt");
        }

        public void LeerClientes()
        {
            using (StreamReader reader = new StreamReader(@"C:\Datos\Clientes.txt"))
            {
                string contenido = reader.ReadToEnd();
                ListaClientes = JsonConvert.DeserializeObject<List<Cliente>>(contenido);
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
        }
        public void GuardarLugaresDePago(List<LugarDePago> listalugaresdepago)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Datos\LugaresDePago.txt", false))
            {
                string jsonLugaresDePago = JsonConvert.SerializeObject(listalugaresdepago);
                writer.Write(jsonLugaresDePago);
            }
        }


        /////////
        //ALTAS//
        /////////

        public ResultadoAlta AltaClientes(TipoDocumento tipoDocumento, int nroDocumento, string nombre, string correo, int celular, DateTime fNac, char sexo, string domicilio, int cP, TipoCliente tipoCliente, int montoMaximo)
        {
            LeerClientes();
            var NuevoCliente = new Cliente(tipoDocumento, nroDocumento, nombre, correo, celular, fNac, sexo, domicilio, cP, tipoCliente, montoMaximo);

            if (NuevoCliente.ValidarObligatorios())
            {
                if (ListaClientes.Where(x => x.NroDocumento == nroDocumento & x.TipoDocumento == tipoDocumento).FirstOrDefault() != null) //Verifica la combinacion de tipo y nro de documento.
                {
                    return new ResultadoAlta(false,"El tipo y numero de documento ingresado ya está registrado.");
                }
                else
                {
                    ListaClientes.Add(NuevoCliente);
                    GuardarClientes(ListaClientes);
                    return new ResultadoAlta(true);
                }
            }
            else
            {
                return new ResultadoAlta(false, "Campos incompletos.");
            }
        }

        public ResultadoAlta AltaPrestamos(Cliente cliente, Comercio comercioAdherido, Sucursal sucursal, int montoCredito, double montoCuota, int cantidadCuotas)
        {
            LeerPrestamos();
            var NuevoPrestamo = new Prestamo(cliente, ListaPrestamos.Count+1, comercioAdherido, sucursal, montoCredito, cantidadCuotas);

            if (NuevoPrestamo.ValidarObligatorios())
            {
                if (NuevoPrestamo.MontoTotal > NuevoPrestamo.Cliente.MontoMaximo)
                {
                    return new ResultadoAlta(false, "El monto total del crédito excede el monto máximo autorizado del cliente.");
                }
                else
                {
                    ListaPrestamos.Add(NuevoPrestamo);
                    GuardarPrestamos(ListaPrestamos);
                    return new ResultadoAlta(true);
                }
            }
            else
            {
                return new ResultadoAlta(false, "Campos incompletos.");
            }
        }

        public ResultadoAlta AltaSucursal(string ciudad, string direccion, int cP, double tasaInteres)
        {
            LeerSucursales();
            var nueva_sucursal = new Sucursal(ListaSucursales.Count+1, ciudad, direccion, cP, tasaInteres);

            if (nueva_sucursal.ValidarObligatorios())
            {
                ListaSucursales.Add(nueva_sucursal);
                GuardarSucursales(ListaSucursales);
                return new ResultadoAlta(true);
            }
            else
            {
                return new ResultadoAlta(false, "Campos incompletos.");
            }
        }

        public ResultadoAlta AltaComercio(string ciudad, string direccion, int cP, string razonSocial)
        {
            LeerComercios();
            var nuevo_comercio = new Comercio(ListaComercios.Count + 1, ciudad, direccion, cP, razonSocial);

            if (nuevo_comercio.ValidarObligatorios())
            {
                ListaComercios.Add(nuevo_comercio);
                GuardarComercios(ListaComercios);
                return new ResultadoAlta(true);
            }
            else
            {
                return new ResultadoAlta(false, "Campos incompletos.");
            }
        }

        public ResultadoAlta AltaLugaresDePago(string ciudad, string direccion, int cP, string razonSocial, bool esSucursal)
        {
            LeerLugaresDePago();
            var nuevo_lugardepago = new LugarDePago(ListaLugaresDePago.Count + 1, ciudad, direccion, cP, razonSocial, esSucursal);

            if (nuevo_lugardepago.ValidarObligatorios())
            {
                ListaLugaresDePago.Add(nuevo_lugardepago);
                GuardarLugaresDePago(ListaLugaresDePago);
                return new ResultadoAlta(true);
            }
            else
            {
                return new ResultadoAlta(false, "Campos incompletos.");
            }
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
