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
                DateTime? fechaDesde = null;
                if (CHKB_FechaDesde.Checked)
                {
                    fechaDesde = Convert.ToDateTime(dateTimePicker1.Text);
                }

                DateTime? fechaHasta = null;
                if (CHKB_FechaHasta.Checked)
                {
                    fechaHasta = Convert.ToDateTime(dateTimePicker2.Text);
                }

                TipoCliente? tipoCliente;
                switch (this.CB_TipoCliente.Text)
                {
                    case "Regular":
                        tipoCliente = TipoCliente.Regular;
                        break;
                    case "VIP":
                        tipoCliente = TipoCliente.VIP;
                        break;
                    default:
                        tipoCliente = null;
                        break;
                }

                string nombre = null;
                if (CHKB_Busqueda.Checked)
                {
                    nombre = TB_Busqueda.Text;
                }

                this.GrillaPrestamos.DataSource = F_MenuPrincipal.ObtenerPrestamos(fechaDesde, fechaHasta, tipoCliente, nombre);
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
            this.GrillaPrestamos.ColumnCount = 7;

            this.GrillaPrestamos.Columns[0].HeaderText = "ID";
            this.GrillaPrestamos.Columns[0].DataPropertyName = "ID";
            this.GrillaPrestamos.Columns[0].Width = 30;
            this.GrillaPrestamos.Columns[1].HeaderText = "Nombre";
            this.GrillaPrestamos.Columns[1].DataPropertyName = "Cliente";
            this.GrillaPrestamos.Columns[1].Width = 100;
            this.GrillaPrestamos.Columns[2].HeaderText = "Fecha";
            this.GrillaPrestamos.Columns[2].DataPropertyName = "FCredito";
            this.GrillaPrestamos.Columns[2].Width = 75;
            this.GrillaPrestamos.Columns[3].HeaderText = "Monto del crédito ($)";
            this.GrillaPrestamos.Columns[3].DataPropertyName = "MontoCredito";
            this.GrillaPrestamos.Columns[3].Width = 100;
            this.GrillaPrestamos.Columns[4].HeaderText = "Tasa (%)";
            this.GrillaPrestamos.Columns[4].DataPropertyName = "Tasa";
            this.GrillaPrestamos.Columns[4].Width = 75;
            this.GrillaPrestamos.Columns[5].HeaderText = "Nro. de cuotas";
            this.GrillaPrestamos.Columns[5].DataPropertyName = "CantidadCuotas";
            this.GrillaPrestamos.Columns[5].Width = 75;
            this.GrillaPrestamos.Columns[6].HeaderText = "Monto cuotas ($)";
            this.GrillaPrestamos.Columns[6].DataPropertyName = "MontoCuota";
            this.GrillaPrestamos.Columns[6].Width = 75;

            ActualizarGrillaPrestamos();

            DataGridViewLinkColumn examinar = new DataGridViewLinkColumn();
            examinar.HeaderText = "Examinar";
            examinar.Text = "Examinar";
            examinar.Width = 60;
            examinar.UseColumnTextForLinkValue = true;
            GrillaPrestamos.Columns.Add(examinar);
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
            else if (column.HeaderText == "Examinar")
            {
                Prestamo prestamo = row.DataBoundItem as Prestamo;
                var Crear_F_ExaminarPrestamo = new F_ExaminarPrestamo(prestamo) { Owner = this };
                Crear_F_ExaminarPrestamo.ShowDialog();
            }
        }

        private void CHKB_FechaDesde_CheckedChanged(object sender, EventArgs e)
        {
            if (!dateTimePicker1.Visible)
                dateTimePicker1.Visible = true;
            else
            {
                dateTimePicker1.Visible = false;
                dateTimePicker1.Text = null;
            }
            ActualizarGrillaPrestamos();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ActualizarGrillaPrestamos();
        }

        private void CHKB_FechaHasta_CheckedChanged(object sender, EventArgs e)
        {
            if (!dateTimePicker2.Visible)
                dateTimePicker2.Visible = true;
            else
            {
                dateTimePicker2.Visible = false;
                dateTimePicker2.Text = null;
            }

            ActualizarGrillaPrestamos();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ActualizarGrillaPrestamos();
        }

        private void CHKB_TipoCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (!CB_TipoCliente.Visible)
                CB_TipoCliente.Visible = true;
            else
            {
                CB_TipoCliente.Visible = false;
                CB_TipoCliente.Text = null;
            }
        }
        private void CB_TipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrillaPrestamos();
        }

        private void CHKB_Busqueda_CheckedChanged(object sender, EventArgs e)
        {
            if (!TB_Busqueda.Visible)
                TB_Busqueda.Visible = true;
            else
            {
                TB_Busqueda.Visible = false;
                TB_Busqueda.Text = null;
            }
        }

        private void TB_Busqueda_TextChanged(object sender, EventArgs e)
        {
            ActualizarGrillaPrestamos();
        }

        public List<Sucursal> ObtenerSucursales()
        {
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            return F_MenuPrincipal.ObtenerSucursales();
        }
        public List<Cliente> ObtenerClientes()
        {
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            return F_MenuPrincipal.ObtenerClientes();
        }
        public List<Comercio> ObtenerComercios()
        {
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            return F_MenuPrincipal.ObtenerComercios();
        }
        //public List<Pago> ObtenerRegistrosPagos()
        //{
        //    I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
        //    return F_MenuPrincipal.ObtenerRegistrosPagos();
        //}
    }
}
