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
    public partial class F_GrillaClientes : Form, I_GrillaClientes
    {
        public F_GrillaClientes()
        {
            InitializeComponent();
        }

        private void ActualizarGrillaClientes()
        {
            I_MenuPrincipal formCliente = this.Owner as I_MenuPrincipal;
            this.GrillaClientes_1.DataSource = null;

            if (formCliente != null)
            {
                this.GrillaClientes_1.DataSource = formCliente.ObtenerClientes(null);
            }
        }

        public ResultadoOp AltaClientes(Cliente cliente)
        {
            ResultadoOp resultadoOp = new ResultadoOp(false, "Error interno en el servidor");
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
            {
                resultadoOp = F_MenuPrincipal.AltaClientes(cliente);

                if (resultadoOp.Resultado)
                {
                    ActualizarGrillaClientes();
                }
            }

            return resultadoOp;
        }

        public ResultadoOp CrearArchivos()
        {
            throw new NotImplementedException();
        }

        private void BT_NuevoCliente_Click(object sender, EventArgs e)
        {
            var Crear_F_AltasClientes = new F_AltasClientes(new Cliente()) { Owner = this };
            Crear_F_AltasClientes.ShowDialog();
        }

        private void F_GrillaClientes_Load(object sender, EventArgs e)
        {
            this.GrillaClientes_1.AutoGenerateColumns = false;
            this.GrillaClientes_1.ColumnCount = 6;

            this.GrillaClientes_1.Columns[0].HeaderText = "Tipo Doc.";
            this.GrillaClientes_1.Columns[0].DataPropertyName = "TipoDocumento";
            this.GrillaClientes_1.Columns[1].HeaderText = "Numero de Documento";
            this.GrillaClientes_1.Columns[1].DataPropertyName = "NroDocumento";
            this.GrillaClientes_1.Columns[2].HeaderText = "Nombre y Apellido";
            this.GrillaClientes_1.Columns[2].DataPropertyName = "Nombre";
            this.GrillaClientes_1.Columns[3].HeaderText = "Correo";
            this.GrillaClientes_1.Columns[3].DataPropertyName = "Correo";
            this.GrillaClientes_1.Columns[4].HeaderText = "Tipo de Cliente";
            this.GrillaClientes_1.Columns[4].DataPropertyName = "TipoCliente";
            this.GrillaClientes_1.Columns[5].HeaderText = "Monto Maximo";
            this.GrillaClientes_1.Columns[5].DataPropertyName = "MontoMaximo";

            I_MenuPrincipal owner = this.Owner as I_MenuPrincipal;
            //this.GrillaClientes_1.AutoGenerateColumns = true;
            if (owner != null)
            {
                GrillaClientes_1.DataSource = owner.ObtenerClientes(null);
            }

            DataGridViewLinkColumn editar = new DataGridViewLinkColumn();
            editar.HeaderText = "Edicion";
            editar.Text = "Editar";
            editar.UseColumnTextForLinkValue = true;
            GrillaClientes_1.Columns.Add(editar);

            DataGridViewLinkColumn eliminar = new DataGridViewLinkColumn();
            eliminar.HeaderText = "Eliminar";
            eliminar.Text = "Eliminar";
            eliminar.UseColumnTextForLinkValue = true;
            GrillaClientes_1.Columns.Add(eliminar);
        }

        public ResultadoOp ModificacionCliente(Cliente cliente, bool Eliminar)
        {
            ResultadoOp resultadoOperacion = new ResultadoOp(false, "Error interno en el servidor");
            I_MenuPrincipal formPrincipal = this.Owner as I_MenuPrincipal;
            if (formPrincipal != null)
            {
                resultadoOperacion = formPrincipal.ModificacionCliente(cliente, Eliminar);

                if (resultadoOperacion.Resultado)
                {
                    ActualizarGrillaClientes();
                }
            }

            return resultadoOperacion;
        }

        private void GrillaClientes_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = this.GrillaClientes_1.Columns[e.ColumnIndex];
            var row = this.GrillaClientes_1.Rows[e.RowIndex];

            if (column.HeaderText == "Eliminar")
            {
                var mensaje = MessageBox.Show("¿Está seguro que desea Eliminar el cliente?", "Eliminar cliente", MessageBoxButtons.OKCancel);

                if (mensaje == DialogResult.OK)
                {
                    Cliente cliente = row.DataBoundItem as Cliente;
                    I_MenuPrincipal formPrincipal = this.Owner as I_MenuPrincipal;

                    //if (formPrincipal != null)
                    //{
                    //    formPrincipal.ModificacionPaciente(cliente, true);
                    //    ActualizarGrillaClientes();
                    //}
                }
            }
            else
            {
                if (column.HeaderText == "Edicion")
                {
                    Cliente cliente = row.DataBoundItem as Cliente;
                    var Crear_F_AltasClientes = new F_AltasClientes(new Cliente()) { Owner = this };
                    Crear_F_AltasClientes.ShowDialog();
                }
            }
        }
    }
}
