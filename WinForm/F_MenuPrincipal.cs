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

        private void LabelSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
