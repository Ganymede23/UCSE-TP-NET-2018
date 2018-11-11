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
    public partial class F_RegistrosPagos : Form, I_RegistroPagos
    {
        public Prestamo prestamo { get; set; }

        public F_RegistrosPagos()
        {
            InitializeComponent();            
        }

        public ResultadoOp CrearArchivos()
        {
            throw new NotImplementedException();
        }

        public ResultadoOp RegistroPagos()
        {
            return prestamo.RegistroPagos();
        }

        private void F_RegistrosPagos_Load(object sender, EventArgs e)
        {
            this.GrillaRegistrosPagos.AutoGenerateColumns = false;
            this.GrillaRegistrosPagos.ColumnCount = 4;

            this.GrillaRegistrosPagos.Columns[0].HeaderText = "ID";
            this.GrillaRegistrosPagos.Columns[0].DataPropertyName = "ID";
            this.GrillaRegistrosPagos.Columns[1].HeaderText = "Fecha del Credito";
            this.GrillaRegistrosPagos.Columns[1].DataPropertyName = "FCredito";
            this.GrillaRegistrosPagos.Columns[2].HeaderText = "Cuotas Pagas";
            this.GrillaRegistrosPagos.Columns[2].DataPropertyName = "CuotasPagadas";
            this.GrillaRegistrosPagos.Columns[3].HeaderText = "Cuotas Faltantes";
            this.GrillaRegistrosPagos.Columns[3].DataPropertyName = "CuotasFaltantes";

            I_MenuPrincipal owner = this.Owner as I_MenuPrincipal;
            //this.GrillaRegistrosPagos_1.AutoGenerateColumns = true;
            if (owner != null)
            {
                GrillaRegistrosPagos.DataSource = owner.ObtenerRegistrosPagos();

            }

            DataGridViewLinkColumn EfectuarPago = new DataGridViewLinkColumn();
            EfectuarPago.HeaderText = "Efecutar Pago";
            EfectuarPago.Text = "Pagar";
            EfectuarPago.UseColumnTextForLinkValue = true;
            GrillaRegistrosPagos.Columns.Add(EfectuarPago);
        }

        private void GrillaRegistrosPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = this.GrillaRegistrosPagos.Columns[e.ColumnIndex];
            var row = this.GrillaRegistrosPagos.Rows[e.RowIndex];

            if (column.HeaderText == "Efectuar Pago")
            {
                Prestamo prestamo = row.DataBoundItem as Prestamo;
                var Crear_F_EfectuarPago = new F_EfectuarPago(prestamo) { Owner = this };
                Crear_F_EfectuarPago.ShowDialog();
            }
        }
    }


}
