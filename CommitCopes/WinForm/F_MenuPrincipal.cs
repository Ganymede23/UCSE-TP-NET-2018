using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace WinForm
{
    public partial class F_MenuPrincipal : Form, I_MenuPrincipal
    {
        private FlatMinor FlatMinor { get; set; }

        public F_MenuPrincipal()
        {
            FlatMinor = new FlatMinor();

            InitializeComponent(); 
        }

        public ResultadoOp CrearArchivos()
        {
            return FlatMinor.CrearArchivos();
        }

        private void F_MenuPrincipal_Load(object sender, EventArgs e)
        {
            FlatMinor.CrearArchivos();
        }

        //CLIENTES

        private void AltaClienteStripMenu_Click(object sender, EventArgs e) //ALTA CLIENTES
        {
            var Crear_F_AltasClientes = new F_AltasClientes(new Cliente()) { Owner = this };
            Crear_F_AltasClientes.ShowDialog();
        }

        private void GrillaClientesStripMenu_Click(object sender, EventArgs e) //GRILLA CLIENTES
        {
            var Crear_F_GrillaClientes = new F_GrillaClientes { Owner = this };
            Crear_F_GrillaClientes.ShowDialog();
        }

        //PRESTAMOS

        private void AgregarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Crear_F_AltasPrestamos = new F_AltasPrestamos(new Prestamo()) { Owner = this };
            Crear_F_AltasPrestamos.ShowDialog();
        }

        private void listadoDePréstamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Crear_F_GrillaPrestamos = new F_GrillaPrestamos { Owner = this };
            Crear_F_GrillaPrestamos.ShowDialog();
        }

        private void registroDePagosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var Crear_F_RegistrosPagos = new F_RegistrosPagos() { Owner = this };
            Crear_F_RegistrosPagos.ShowDialog();
        }

        //SUCURSALES

        private void AltasSucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Crear_F_AltasLugares = new F_AltasSucursales(new Sucursal()) { Owner = this };
            Crear_F_AltasLugares.ShowDialog();
        }

        private void GrillaSucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Crear_F_GrillaSucursales = new F_GrillaSucursales { Owner = this };
            Crear_F_GrillaSucursales.ShowDialog();
        }

        //COMERCIOS

        private void AltaComercioStripMenu_Click(object sender, EventArgs e) //ALTA COMERCIOS
        {
            var Crear_F_AltasComercios = new F_AltasComercios(new Comercio()) { Owner = this };
            Crear_F_AltasComercios.ShowDialog();
        }

        private void GrillaComerciosStripMenu_Click(object sender, EventArgs e) //GRILLA COMERCIOS
        {
            var Crear_F_GrillaComercios = new F_GrillaComercios { Owner = this };
            Crear_F_GrillaComercios.ShowDialog();
        }

        //LUGAR DE PAGO

        private void AltaLugarDePagoStripMenu_Click(object sender, EventArgs e) //ALTA LUGARES DE PAGO
        {
            var Crear_F_AltasLugares = new F_AltasLugares(new LugarDePago()) { Owner = this };
            Crear_F_AltasLugares.ShowDialog();
        }

        private void GrillaLugaresDePagoStripMenu_Click(object sender, EventArgs e) //GRILLA LUGARES DE PAGO
        {
            F_GrillaLugares form = new F_GrillaLugares();
            form.Owner = this;
            form.ShowDialog();
        }


        /// <summary>
        /// CLIENTES
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>

        public ResultadoOp AltaClientes(Cliente cliente)
        {
            return FlatMinor.AltaClientes(cliente);
        }

        public ResultadoOp ModificacionCliente(Cliente cliente, bool eliminar)
        {
            return FlatMinor.ModificacionCliente(cliente, eliminar);
        }

        public List<Cliente> ObtenerClientes()
        {
            return FlatMinor.ObtenerClientes();
        }

        /// <summary>
        /// COMERCIOS
        /// </summary>
        /// <param name="comercio"></param>
        /// <returns></returns>

        public ResultadoOp AltaComercios(Comercio comercio)
        {
            return FlatMinor.AltaComercios(comercio);
        }

        public ResultadoOp ModificacionComercio(Comercio comercio, bool eliminar)
        {
            return FlatMinor.ModificacionComercio(comercio, eliminar);
        }

        public List<Comercio> ObtenerComercios()
        {
            return FlatMinor.ObtenerComercios();
        }

        /// <summary>
        /// LUGARES DE PAGO
        /// </summary>
        /// <param name="lugar"></param>
        /// <returns></returns>

        public ResultadoOp AltaLugares(LugarDePago lugar)
        {
            return FlatMinor.AltaLugaresDePago(lugar);
        }

        public ResultadoOp ModificacionLugar(LugarDePago lugar, bool eliminar)
        {
            return FlatMinor.ModificacionLugaresDePago(lugar, eliminar);
        }

        public List<LugarDePago> ObtenerLugares()
        {
            return FlatMinor.ObtenerLugares();
        }

        /// <summary>
        /// SUCURSALES
        /// </summary>
        /// <param name="sucursal"></param>
        /// <returns></returns>

        public ResultadoOp AltaSucursales(Sucursal sucursal)
        {
            return FlatMinor.AltaSucursal(sucursal);
        }

        public ResultadoOp ModificacionSucursal(Sucursal sucursal, bool eliminar)
        {
           return FlatMinor.ModificacionSucursal(sucursal, eliminar);
        }

        public List<Sucursal> ObtenerSucursales()
        {
            return FlatMinor.ObtenerSucursales();
        }

        //SALIR

        private void LabelSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// PRESTAMOS
        /// </summary>
        /// <param name="prestamo"></param>
        /// <returns></returns>

        public ResultadoOp AltaPrestamos(Prestamo prestamo)
        {
            return FlatMinor.AltaPrestamos(prestamo);
        }

        public ResultadoOp ModificacionPrestamos(Prestamo Prestamo, bool eliminar)
        {
            throw new NotImplementedException();
        }

        public List<Prestamo> ObtenerPrestamos()
        {
            return FlatMinor.ObtenerPrestamos();
        }

        public List<Prestamo> ObtenerRegistrosPagos()
        {
            return FlatMinor.ObtenerRegistrosPagos();
        }
    }
}
