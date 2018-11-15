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
    public partial class F_EfectuarPago : Form
    {
        public F_EfectuarPago(Prestamo prestamo)
        {
            InitializeComponent();
            this.BT_RealizarPago.Enabled = false;

            foreach (Pago item in prestamo.ListaPagos)
            {
                if (item.LugarPago==null)
                {
                    this.LBL_NroCuota.Text = Convert.ToString(item.NumeroCuota);
                    this.LBL_Monto.Text = Convert.ToString(Math.Round(item.MontoCuota,2));
                    this.LBL_Entrega.Text = Convert.ToString(Math.Round(item.MontoPago,2));
                    this.LBL_Fecha.Text = Convert.ToString(item.FechaPago.ToString("dd/MM/yyyy"));
                    prop_prestamo = prestamo;
                    break;
                }
            }
        }

        LugarDePago lugar = new LugarDePago();
        Prestamo prop_prestamo = new Prestamo();

        private void BT_RealizarPago_Click(object sender, EventArgs e)
        {
            var resultadoalta = new ResultadoOp();
            var update_grilla = new ResultadoOp();
            var pago = new Pago();

            if (pago.LugarPago != null)
            {
                I_RegistrosPagos F_RegistrosPagos = this.Owner as I_RegistrosPagos;
                if (F_RegistrosPagos != null)
                {
                    resultadoalta = F_RegistrosPagos.RegistroPagos(prop_prestamo, lugar);
                    F_RegistrosPagos.ActualizarGrillaPagos();
                }
                if (resultadoalta.Resultado == true)
                {
                    MessageBox.Show("La operación se realizó con éxito", "Operación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
                MessageBox.Show("Seleccione un lugar de pago válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void F_EfectuarPago_Load(object sender, EventArgs e)
        {
            I_RegistrosPagos F_RegistrosPagos = this.Owner as I_RegistrosPagos;
            if (F_RegistrosPagos != null)
            {
                List<LugarDePago> ListaLugaresDePago = F_RegistrosPagos.ObtenerLugares();
                foreach (var item in ListaLugaresDePago)
                {
                    this.CB_Lugar.Items.Add(Convert.ToString(item.RazonSocial));
                }
            }
        }

        private void CB_Lugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
            {
                List<LugarDePago> ListaLugaresDePago = F_MenuPrincipal.ObtenerLugares();
                lugar = ListaLugaresDePago[CB_Lugar.SelectedIndex];
                BT_RealizarPago.Enabled = true;
            }
        }
    }
}
