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
        public FlatMinor FlatMinor { get; set; }

        public F_MenuPrincipal()
        {
            var flatminor = new FlatMinor();

            InitializeComponent(); 
        }

        public ResultadoAlta AltaClientes(Cliente cliente)
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
    }
}
