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
    public partial class F_GrillaLugares : Form, I_GrillaLugares
    {
        public F_GrillaLugares()
        {
            InitializeComponent();
        }

        private void ActualizarGrillaLugares()
        {
            I_MenuPrincipal formCliente = this.Owner as I_MenuPrincipal;
            this.GrillaLugares.DataSource = null;

            if (formCliente != null)
            {
                this.GrillaLugares.DataSource = formCliente.ObtenerLugares();
            }
        }

        public ResultadoOp AltaLugares(LugarDePago lugar)
        {
            ResultadoOp resultadoOp = new ResultadoOp(false, "Error interno en el servidor");
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
            {
                resultadoOp = F_MenuPrincipal.AltaLugares(lugar);

                if (resultadoOp.Resultado)
                {
                    ActualizarGrillaLugares();
                }
            }
            return resultadoOp;
        }

        public void CrearArchivos()
        {
            throw new NotImplementedException();
        }

        private void BT_NuevoLugar_Click(object sender, EventArgs e)
        {
            var Crear_F_AltasLugares = new F_AltasLugares(new LugarDePago()) { Owner = this };
            Crear_F_AltasLugares.ShowDialog();
        }

        private void F_GrillaLugares_Load(object sender, EventArgs e)
        {
            this.GrillaLugares.AutoGenerateColumns = false;
            this.GrillaLugares.ColumnCount = 6;

            this.GrillaLugares.Columns[0].HeaderText = "ID";
            this.GrillaLugares.Columns[0].DataPropertyName = "ID";
            this.GrillaLugares.Columns[0].Width = 30;
            this.GrillaLugares.Columns[1].HeaderText = "Ciudad";
            this.GrillaLugares.Columns[1].DataPropertyName = "Ciudad";
            this.GrillaLugares.Columns[1].Width = 100;
            this.GrillaLugares.Columns[2].HeaderText = "Dirección";
            this.GrillaLugares.Columns[2].DataPropertyName = "Direccion";
            this.GrillaLugares.Columns[2].Width = 227;
            this.GrillaLugares.Columns[3].HeaderText = "Código Postal";
            this.GrillaLugares.Columns[3].DataPropertyName = "CP";
            this.GrillaLugares.Columns[3].Width = 50;
            this.GrillaLugares.Columns[4].HeaderText = "Razón Social";
            this.GrillaLugares.Columns[4].DataPropertyName = "RazonSocial";
            this.GrillaLugares.Columns[4].Width = 100;
            this.GrillaLugares.Columns[5].HeaderText = "Sucursal";
            this.GrillaLugares.Columns[5].DataPropertyName = "EsSucursal";
            this.GrillaLugares.Columns[5].Width = 60;

            I_MenuPrincipal owner = this.Owner as I_MenuPrincipal;
            //this.GrillaLugares_1.AutoGenerateColumns = true;
            if (owner != null)
            {
                GrillaLugares.DataSource = owner.ObtenerLugares();
            }

            DataGridViewLinkColumn editar = new DataGridViewLinkColumn();
            editar.Width = 50;
            editar.HeaderText = "Edicion";
            editar.Text = "Editar";
            editar.UseColumnTextForLinkValue = true;
            GrillaLugares.Columns.Add(editar);

            DataGridViewLinkColumn eliminar = new DataGridViewLinkColumn();
            eliminar.Width = 50;
            eliminar.HeaderText = "Eliminar";
            eliminar.Text = "Eliminar";
            eliminar.UseColumnTextForLinkValue = true;
            GrillaLugares.Columns.Add(eliminar);
        }

        public ResultadoOp ModificacionLugar(LugarDePago lugar, bool eliminar)
        {
            ResultadoOp resultadoOperacion = new ResultadoOp(false, "Error interno en el servidor");
            I_MenuPrincipal formPrincipal = this.Owner as I_MenuPrincipal;
            if (formPrincipal != null)
            {
                resultadoOperacion = formPrincipal.ModificacionLugar(lugar, eliminar);

                if (resultadoOperacion.Resultado)
                {
                    ActualizarGrillaLugares();
                }
            }
            return resultadoOperacion;
        }

        private void GrillaLugares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = this.GrillaLugares.Columns[e.ColumnIndex];
            var row = this.GrillaLugares.Rows[e.RowIndex];

            if (column.HeaderText == "Eliminar")
            {
                var mensaje = MessageBox.Show("¿Está seguro que desea Eliminar el lugar de pago?", "Eliminar lugar de pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje == DialogResult.Yes)
                {
                    LugarDePago lugar = row.DataBoundItem as LugarDePago;
                    I_MenuPrincipal formPrincipal = this.Owner as I_MenuPrincipal;

                    if (formPrincipal != null)
                    {
                        lugar.Activo = false;
                        formPrincipal.ModificacionLugar(lugar, true);
                        ActualizarGrillaLugares();
                    }
                }
            }
            else
            {
                if (column.HeaderText == "Edicion")
                {
                    LugarDePago lugar = row.DataBoundItem as LugarDePago;
                    var Crear_F_AltasLugares = new F_AltasLugares(lugar) { Owner = this };
                    Crear_F_AltasLugares.ShowDialog();
                }
            }
        }
    }
}
