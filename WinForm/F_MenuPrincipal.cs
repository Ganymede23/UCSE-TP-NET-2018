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

        public ResultadoOp AltaClientes(Cliente cliente)
        {
            return FlatMinor.AltaClientes(cliente);
        }

        private void agregarClienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var Crear_F_AltasClientes = new F_AltasClientes(new Cliente()) { Owner = this };
            Crear_F_AltasClientes.ShowDialog();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Crear_F_AltasClientes = new F_AltasClientes(new Cliente()) { Owner = this };
            Crear_F_AltasClientes.ShowDialog();
        }

        private void F_MenuPrincipal_Load(object sender, EventArgs e)
        {
            FlatMinor.CrearArchivos();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GrillaClientes form = new F_GrillaClientes();
            form.Owner = this;
            form.ShowDialog();
        }

        public List<Cliente> ObtenerClientes(int? documento)
        {
            return FlatMinor.ObtenerClientes(documento);
        }

        public ResultadoOp ModificacionCliente(Cliente cliente, bool eliminar)
        {
            return FlatMinor.ModificacionCliente(cliente, eliminar);
        }
    }
}
