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
    public partial class F_GrillaComercios : Form, I_GrillaComercios
    {
        public F_GrillaComercios()
        {
            InitializeComponent();
        }

        private void ActualizarGrillaComercios()
        {
            I_MenuPrincipal formComercio = this.Owner as I_MenuPrincipal;
            this.GrillaComercios.DataSource = null;

            if (formComercio != null)
            {
                this.GrillaComercios.DataSource = formComercio.ObtenerComercios();
            }
        }

        public ResultadoOp AltaComercios(Comercio comercio)
        {
            ResultadoOp resultadoOp = new ResultadoOp(false, "Error interno en el servidor");
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
            {
                resultadoOp = F_MenuPrincipal.AltaComercios(comercio);

                if (resultadoOp.Resultado)
                {
                    ActualizarGrillaComercios();
                }
            }
            return resultadoOp;
        }

        public ResultadoOp CrearArchivos()
        {
            throw new NotImplementedException();
        }

        private void BT_NuevoComercio_Click(object sender, EventArgs e)
        {
            var Crear_F_AltasComercios = new F_AltasComercios(new Comercio()) { Owner = this };
            Crear_F_AltasComercios.ShowDialog();
        }

        private void F_GrillaComercios_Load(object sender, EventArgs e)
        {
            this.GrillaComercios.AutoGenerateColumns = false;
            this.GrillaComercios.ColumnCount = 5;

            this.GrillaComercios.Columns[0].HeaderText = "ID";
            this.GrillaComercios.Columns[0].DataPropertyName = "ID";
            this.GrillaComercios.Columns[0].Width = 30;
            this.GrillaComercios.Columns[1].HeaderText = "Ciudad";
            this.GrillaComercios.Columns[1].DataPropertyName = "Ciudad";
            this.GrillaComercios.Columns[1].Width = 100;
            this.GrillaComercios.Columns[2].HeaderText = "Dirección";
            this.GrillaComercios.Columns[2].DataPropertyName = "Direccion";
            this.GrillaComercios.Columns[2].Width = 237;
            this.GrillaComercios.Columns[3].HeaderText = "Código Postal";
            this.GrillaComercios.Columns[3].DataPropertyName = "CP";
            this.GrillaComercios.Columns[3].Width = 50;
            this.GrillaComercios.Columns[4].HeaderText = "Razón Social";
            this.GrillaComercios.Columns[4].DataPropertyName = "RazonSocial";
            this.GrillaComercios.Columns[4].Width = 150;

            I_MenuPrincipal owner = this.Owner as I_MenuPrincipal;
            //this.GrillaComercios_1.AutoGenerateColumns = true;
            if (owner != null)
            {
                GrillaComercios.DataSource = owner.ObtenerComercios();
            }

            DataGridViewLinkColumn editar = new DataGridViewLinkColumn();
            editar.HeaderText = "Edicion";
            editar.Text = "Editar";
            editar.Width = 50;
            editar.UseColumnTextForLinkValue = true;
            GrillaComercios.Columns.Add(editar);

            DataGridViewLinkColumn eliminar = new DataGridViewLinkColumn();
            eliminar.HeaderText = "Eliminar";
            eliminar.Text = "Eliminar";
            eliminar.Width = 50;
            eliminar.UseColumnTextForLinkValue = true;
            GrillaComercios.Columns.Add(eliminar);
        }

        public ResultadoOp ModificacionComercio(Comercio comercio, bool Eliminar)
        {
            ResultadoOp resultadoOperacion = new ResultadoOp(false, "Error interno en el servidor");
            I_MenuPrincipal formPrincipal = this.Owner as I_MenuPrincipal;
            if (formPrincipal != null)
            {
                resultadoOperacion = formPrincipal.ModificacionComercio(comercio, Eliminar);

                if (resultadoOperacion.Resultado)
                {
                    ActualizarGrillaComercios();
                }
            }
            return resultadoOperacion;
        }

        private void GrillaComercios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = this.GrillaComercios.Columns[e.ColumnIndex];
            var row = this.GrillaComercios.Rows[e.RowIndex];

            if (column.HeaderText == "Eliminar")
            {
                var mensaje = MessageBox.Show("¿Está seguro que desea Eliminar el comercio?", "Eliminar comercio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje == DialogResult.OK)
                {
                    Comercio comercio = row.DataBoundItem as Comercio;
                    I_MenuPrincipal formPrincipal = this.Owner as I_MenuPrincipal;

                    if (formPrincipal != null)
                    {
                        comercio.Activo = false;
                        formPrincipal.ModificacionComercio(comercio, true);
                        ActualizarGrillaComercios();
                    }
                }
            }
            else
            {
                if (column.HeaderText == "Edicion")
                {
                    Comercio comercio = row.DataBoundItem as Comercio;
                    var Crear_F_AltasComercios = new F_AltasComercios(comercio) { Owner = this };
                    Crear_F_AltasComercios.ShowDialog();
                }
            }
        }
    }
}
