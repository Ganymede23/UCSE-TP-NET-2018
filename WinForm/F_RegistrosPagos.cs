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
    public partial class F_RegistrosPagos : Form, I_RegistrosPagos
    {
        public F_RegistrosPagos()
        {
            InitializeComponent();            
        }

        public ResultadoOp CrearArchivos()
        {
            throw new NotImplementedException();
        }

        public ResultadoOp RegistroPagos(Prestamo prestamo, LugarDePago lugar)
        {
            var resultadoalta = new ResultadoOp();
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
            {
                resultadoalta = F_MenuPrincipal.RegistroPagos(prestamo, lugar);
            }
            return resultadoalta;
        }

        public void ActualizarGrillaPagos()
        {
            ResultadoOp resultado = new ResultadoOp();
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            this.GrillaRegistrosPagos.DataSource = null;

            if (F_MenuPrincipal != null)
            {
                this.GrillaRegistrosPagos.DataSource = F_MenuPrincipal.ObtenerRegistrosPagos();
            }
        }

        public List<LugarDePago> ObtenerLugares()
        {
            List<LugarDePago> ListaLugaresDePago = new List<LugarDePago>();
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
            {
                ListaLugaresDePago = F_MenuPrincipal.ObtenerLugares();
            }
            return ListaLugaresDePago;
        }

        private void F_RegistrosPagos_Load(object sender, EventArgs e)
        {
            this.GrillaRegistrosPagos.AutoGenerateColumns = false;
            this.GrillaRegistrosPagos.ColumnCount = 6;

            this.GrillaRegistrosPagos.Columns[0].HeaderText = "ID";
            this.GrillaRegistrosPagos.Columns[0].DataPropertyName = "ID";
            this.GrillaRegistrosPagos.Columns[0].Width = 30;
            this.GrillaRegistrosPagos.Columns[1].HeaderText = "Nombre";
            this.GrillaRegistrosPagos.Columns[1].DataPropertyName = "Cliente";
            this.GrillaRegistrosPagos.Columns[1].Width = 150;
            this.GrillaRegistrosPagos.Columns[2].HeaderText = "Fecha";
            this.GrillaRegistrosPagos.Columns[2].DataPropertyName = "FCredito";
            this.GrillaRegistrosPagos.Columns[2].Width = 80;
            this.GrillaRegistrosPagos.Columns[3].HeaderText = "Monto del crédito ($)";
            this.GrillaRegistrosPagos.Columns[3].DataPropertyName = "MontoCredito";
            this.GrillaRegistrosPagos.Columns[3].Width = 137;
            this.GrillaRegistrosPagos.Columns[4].HeaderText = "Cuotas Pagas";
            this.GrillaRegistrosPagos.Columns[4].DataPropertyName = "CuotasPagadas";
            this.GrillaRegistrosPagos.Columns[4].Width = 100;
            this.GrillaRegistrosPagos.Columns[5].HeaderText = "Cuotas Faltantes";
            this.GrillaRegistrosPagos.Columns[5].DataPropertyName = "CuotasFaltantes";
            this.GrillaRegistrosPagos.Columns[5].Width = 100;

            I_MenuPrincipal owner = this.Owner as I_MenuPrincipal;
            if (owner != null)
            {
                GrillaRegistrosPagos.DataSource = owner.ObtenerRegistrosPagos();
            }

            DataGridViewLinkColumn EfectuarPago = new DataGridViewLinkColumn();
            EfectuarPago.HeaderText = "Efecutar Pago";
            EfectuarPago.Text = "Pagar";
            EfectuarPago.Width = 70;
            EfectuarPago.UseColumnTextForLinkValue = true;
            GrillaRegistrosPagos.Columns.Add(EfectuarPago);
        }

        private void GrillaRegistrosPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = this.GrillaRegistrosPagos.Columns[e.ColumnIndex];
            var row = this.GrillaRegistrosPagos.Rows[e.RowIndex];

            if (column.HeaderText == "Efecutar Pago")
            {
                Prestamo prestamo = row.DataBoundItem as Prestamo;
                var Crear_F_EfectuarPago = new F_EfectuarPago(prestamo) { Owner = this };
                Crear_F_EfectuarPago.ShowDialog();
            }
        }
    }
}
