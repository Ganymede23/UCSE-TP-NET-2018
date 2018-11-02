using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class F_MenuPrincipal : Form, I_MenuPrincipal
    {
        public F_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void F_MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Crear_F_AltasClientes = new F_AltasClientes() { Owner = this };
            Crear_F_AltasClientes.ShowDialog();
        }
    }
}
