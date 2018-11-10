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
    public partial class F_GrillaPrestamos : Form, I_GrillaPrestamos
    {
        public F_GrillaPrestamos()
        {
            InitializeComponent();
        }

        private void ActualizarGrillaPrestamos()
        {
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            this.GrillaPrestamos.DataSource = null;

            if (F_MenuPrincipal != null)
            {
                this.GrillaPrestamos.DataSource = F_MenuPrincipal.ObtenerPrestamos();
            }
        }

        public ResultadoOp AltaPrestamos(Prestamo prestamo)
        {
            ResultadoOp resultadoOp = new ResultadoOp(false, "Error interno en el servidor");
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
            {
                resultadoOp = F_MenuPrincipal.AltaPrestamos(prestamo);

                if (resultadoOp.Resultado)
                {
                    ActualizarGrillaPrestamos();
                }
            }
            return resultadoOp;
        }

        public ResultadoOp CrearArchivos()
        {
            throw new NotImplementedException();
        }

        private void BT_NuevoPrestamo_Click(object sender, EventArgs e)
        {
            var Crear_F_AltasPrestamos = new F_AltasPrestamos(new Prestamo()) { Owner = this };
            Crear_F_AltasPrestamos.ShowDialog();
        }

        private void F_GrillaPrestamos_Load(object sender, EventArgs e)
        {
            this.GrillaPrestamos.AutoGenerateColumns = false;
            this.GrillaPrestamos.ColumnCount = 4;

            this.GrillaPrestamos.Columns[0].HeaderText = "ID";
            this.GrillaPrestamos.Columns[0].DataPropertyName = "ID";
            this.GrillaPrestamos.Columns[1].HeaderText = "Monto del crédito($)";
            this.GrillaPrestamos.Columns[1].DataPropertyName = "MontoCredito";
            this.GrillaPrestamos.Columns[2].HeaderText = "Tasa (%)";
            this.GrillaPrestamos.Columns[2].DataPropertyName = "Tasa";
            this.GrillaPrestamos.Columns[3].HeaderText = "Monto cuotas ($)";
            this.GrillaPrestamos.Columns[3].DataPropertyName = "MontoCuota";

            I_MenuPrincipal owner = this.Owner as I_MenuPrincipal;
            //this.GrillaPrestamos_1.AutoGenerateColumns = true;
            if (owner != null)
            {
                GrillaPrestamos.DataSource = owner.ObtenerPrestamos();
            }

            //DataGridViewLinkColumn editar = new DataGridViewLinkColumn();
            //editar.HeaderText = "Edicion";
            //editar.Text = "Editar";
            //editar.UseColumnTextForLinkValue = true;
            //GrillaPrestamos.Columns.Add(editar);
        }

        private void GrillaPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = this.GrillaPrestamos.Columns[e.ColumnIndex];
            var row = this.GrillaPrestamos.Rows[e.RowIndex];

            if (column.HeaderText == "Eliminar")
            {
                var mensaje = MessageBox.Show("¿Está seguro que desea Eliminar el cliente?", "Eliminar cliente", MessageBoxButtons.OKCancel);

                if (mensaje == DialogResult.OK)
                {
                    Cliente cliente = row.DataBoundItem as Cliente;
                    I_MenuPrincipal formPrincipal = this.Owner as I_MenuPrincipal;

                    if (formPrincipal != null)
                    {
                        cliente.Activo = false;
                        formPrincipal.ModificacionCliente(cliente, true);
                        ActualizarGrillaPrestamos();
                    }
                }
            }
            //else if (column.HeaderText == "Edicion")
            //{
            //    Prestamo prestamo = row.DataBoundItem as Prestamo;
            //    var Crear_F_AltasPrestamos = new F_AltasPrestamos(prestamo) { Owner = this };
            //    Crear_F_AltasPrestamos.ShowDialog();
            //}
        }
    }
}
