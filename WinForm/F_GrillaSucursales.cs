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
    public partial class F_GrillaSucursales : Form, I_GrillaSucursales
    {
        public F_GrillaSucursales()
        {
            InitializeComponent();
        }

        private void ActualizarGrillaSucursales()
        {
            I_MenuPrincipal formSucursal = this.Owner as I_MenuPrincipal;
            this.GrillaSucursales.DataSource = null;

            if (formSucursal != null)
            {
                this.GrillaSucursales.DataSource = formSucursal.ObtenerSucursales();
            }
        }

        public ResultadoOp AltaSucursales(Sucursal sucursal)
        {
            ResultadoOp resultadoOp = new ResultadoOp(false, "Error interno en el servidor");
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
            {
                resultadoOp = F_MenuPrincipal.AltaSucursales(sucursal);

                if (resultadoOp.Resultado)
                {
                    ActualizarGrillaSucursales();
                }
            }
            return resultadoOp;
        }

        public void CrearArchivos()
        {
            throw new NotImplementedException();
        }

        private void BT_NuevaSucursal_Click(object sender, EventArgs e)
        {
            var Crear_F_AltasSucursals = new F_AltasSucursales(new Sucursal()) { Owner = this };
            Crear_F_AltasSucursals.ShowDialog();
        }

        private void F_GrillaSucursales_Load(object sender, EventArgs e)
        {
            this.GrillaSucursales.AutoGenerateColumns = false;
            this.GrillaSucursales.ColumnCount = 5;

            this.GrillaSucursales.Columns[0].HeaderText = "ID";
            this.GrillaSucursales.Columns[0].DataPropertyName = "ID";
            this.GrillaSucursales.Columns[0].Width = 30;
            this.GrillaSucursales.Columns[1].HeaderText = "Ciudad";
            this.GrillaSucursales.Columns[1].DataPropertyName = "Ciudad";
            this.GrillaSucursales.Columns[1].Width = 100;
            this.GrillaSucursales.Columns[2].HeaderText = "Dirección";
            this.GrillaSucursales.Columns[2].DataPropertyName = "Direccion";
            this.GrillaSucursales.Columns[2].Width = 247;
            this.GrillaSucursales.Columns[3].HeaderText = "Código Postal";
            this.GrillaSucursales.Columns[3].DataPropertyName = "CP";
            this.GrillaSucursales.Columns[3].Width = 50;
            this.GrillaSucursales.Columns[4].HeaderText = "Tasa de Interes (%)";
            this.GrillaSucursales.Columns[4].DataPropertyName = "TasaInteres";
            this.GrillaSucursales.Columns[4].Width = 140;

            I_MenuPrincipal owner = this.Owner as I_MenuPrincipal;

            if (owner != null)
            {
                GrillaSucursales.DataSource = owner.ObtenerSucursales();
            }

            DataGridViewLinkColumn editar = new DataGridViewLinkColumn();
            editar.HeaderText = "Edicion";
            editar.Text = "Editar";
            editar.Width = 50;
            editar.UseColumnTextForLinkValue = true;
            GrillaSucursales.Columns.Add(editar);

            DataGridViewLinkColumn eliminar = new DataGridViewLinkColumn();
            eliminar.HeaderText = "Eliminar";
            eliminar.Text = "Eliminar";
            eliminar.Width = 50;
            eliminar.UseColumnTextForLinkValue = true;
            GrillaSucursales.Columns.Add(eliminar);
        }

        public ResultadoOp ModificacionSucursal(Sucursal sucursal, bool Eliminar)
        {
            ResultadoOp resultadoOperacion = new ResultadoOp(false, "Error interno en el servidor");
            I_MenuPrincipal formPrincipal = this.Owner as I_MenuPrincipal;
            if (formPrincipal != null)
            {
                resultadoOperacion = formPrincipal.ModificacionSucursal(sucursal, Eliminar);

                if (resultadoOperacion.Resultado)
                {
                    ActualizarGrillaSucursales();
                }
            }
            return resultadoOperacion;
        }

        private void GrillaSucursales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = this.GrillaSucursales.Columns[e.ColumnIndex];
            var row = this.GrillaSucursales.Rows[e.RowIndex];

            if (column.HeaderText == "Eliminar")
            {
                var mensaje = MessageBox.Show("¿Está seguro que desea Eliminar el Sucursal?", "Eliminar Sucursal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje == DialogResult.Yes)
                {
                    Sucursal sucursal = row.DataBoundItem as Sucursal;
                    I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;

                    if (F_MenuPrincipal != null)
                    {
                        sucursal.Activo = false;
                        F_MenuPrincipal.ModificacionSucursal(sucursal, true);
                        ActualizarGrillaSucursales();
                    }
                }
            }
            else
            {
                if (column.HeaderText == "Edicion")
                {
                    Sucursal sucursal = row.DataBoundItem as Sucursal;
                    var Crear_F_AltasSucursales = new F_AltasSucursales(sucursal) { Owner = this };
                    Crear_F_AltasSucursales.ShowDialog();
                }
            }
        }
    }
}
