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

        public ResultadoOp CrearArchivos()
        {
            throw new NotImplementedException();
        }

        private void BT_NuevoSucursal_Click(object sender, EventArgs e)
        {
            var Crear_F_AltasSucursals = new F_AltasSucursales(new Sucursal()) { Owner = this };
            Crear_F_AltasSucursals.ShowDialog();
        }

        private void F_GrillaSucursaless_Load(object sender, EventArgs e)
        {
            this.GrillaSucursales.AutoGenerateColumns = false;
            this.GrillaSucursales.ColumnCount = 5;

            this.GrillaSucursales.Columns[0].HeaderText = "ID";
            this.GrillaSucursales.Columns[0].DataPropertyName = "ID";
            this.GrillaSucursales.Columns[1].HeaderText = "Ciudad";
            this.GrillaSucursales.Columns[1].DataPropertyName = "Ciudad";
            this.GrillaSucursales.Columns[2].HeaderText = "Dirección";
            this.GrillaSucursales.Columns[2].DataPropertyName = "Direccion";
            this.GrillaSucursales.Columns[3].HeaderText = "Código Postal";
            this.GrillaSucursales.Columns[3].DataPropertyName = "CP";
            this.GrillaSucursales.Columns[4].HeaderText = "Tasa Interes";
            this.GrillaSucursales.Columns[4].DataPropertyName = "Tasa interes";

            I_MenuPrincipal owner = this.Owner as I_MenuPrincipal;
            //this.GrillaSucursaless_1.AutoGenerateColumns = true;
            if (owner != null)
            {
                GrillaSucursales.DataSource = owner.ObtenerSucursales();
            }

            DataGridViewLinkColumn editar = new DataGridViewLinkColumn();
            editar.HeaderText = "Edicion";
            editar.Text = "Editar";
            editar.UseColumnTextForLinkValue = true;
            GrillaSucursales.Columns.Add(editar);

            DataGridViewLinkColumn eliminar = new DataGridViewLinkColumn();
            eliminar.HeaderText = "Eliminar";
            eliminar.Text = "Eliminar";
            eliminar.UseColumnTextForLinkValue = true;
            GrillaSucursales.Columns.Add(eliminar);
        }

        public ResultadoOp ModificacionSucursal(Sucursal Sucursal, bool Eliminar)
        {
            ResultadoOp resultadoOperacion = new ResultadoOp(false, "Error interno en el servidor");
            I_MenuPrincipal formPrincipal = this.Owner as I_MenuPrincipal;
            if (formPrincipal != null)
            {
                resultadoOperacion = formPrincipal.ModificacionSucursal(Sucursal, Eliminar);

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
                var mensaje = MessageBox.Show("¿Está seguro que desea Eliminar el Sucursal?", "Eliminar Sucursal", MessageBoxButtons.OKCancel);

                if (mensaje == DialogResult.OK)
                {
                    Sucursal Sucursal = row.DataBoundItem as Sucursal;
                    I_MenuPrincipal formPrincipal = this.Owner as I_MenuPrincipal;

                    if (formPrincipal != null)
                    {
                        Sucursal.Activo = false;
                        formPrincipal.ModificacionSucursal(Sucursal, true);
                        ActualizarGrillaSucursales();
                    }
                }
            }
            else
            {
                if (column.HeaderText == "Edicion")
                {
                    Sucursal Sucursal = row.DataBoundItem as Sucursal;
                    var Crear_F_AltasSucursals = new F_AltasSucursales(Sucursal) { Owner = this };
                    Crear_F_AltasSucursals.ShowDialog();
                }
            }
        }
    }
}
