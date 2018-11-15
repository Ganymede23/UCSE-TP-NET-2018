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
        public F_EfectuarPago(Prestamo prestamo, Pago pago)
        {
            InitializeComponent();
            this.BT_RealizarPago.Enabled = false;

            this.LBL_NroCuota.Text = Convert.ToString(pago.NumeroCuota);
            this.LBL_Monto.Text = Convert.ToString(Math.Round(pago.MontoCuota,2));
            this.LBL_Entrega.Text = Convert.ToString(Math.Round(pago.MontoCuota,2));
            this.LBL_Fecha.Text = Convert.ToString(pago.FechaPago.ToString("dd/MM/yyyy"));
            prop_prestamo = prestamo;
        }

        LugarDePago lugar = new LugarDePago();
        Prestamo prop_prestamo = new Prestamo();

        private void BT_RealizarPago_Click(object sender, EventArgs e)
        {
            var resultadoalta = new ResultadoOp();
            var update_grilla = new ResultadoOp();
            var pago = new Pago();
            pago.LugarPago = lugar;

            if (pago.LugarPago != null)
            {
                I_ExaminarPrestamo F_ExaminarPrestamo = this.Owner as I_ExaminarPrestamo;
                if (F_ExaminarPrestamo != null)
                {
                    resultadoalta = F_ExaminarPrestamo.RegistroPagos(prop_prestamo, lugar);
                    F_ExaminarPrestamo.ActualizarGrillaPagos(prop_prestamo);
                }
                if (resultadoalta.Resultado == true)
                {
                    MessageBox.Show("La operación se realizó con éxito", "Operación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    F_ExaminarPrestamo.ActualizarGrillaPagos(prop_prestamo);
                }
            }
            else
                MessageBox.Show("Seleccione un lugar de pago válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void F_EfectuarPago_Load(object sender, EventArgs e)
        {
            I_ExaminarPrestamo F_ExaminarPrestamo = this.Owner as I_ExaminarPrestamo;
            if (F_ExaminarPrestamo != null)
            {
                List<LugarDePago> ListaLugaresDePago = F_ExaminarPrestamo.ObtenerLugares();
                foreach (var item in ListaLugaresDePago)
                {
                    this.CB_Lugar.Items.Add(Convert.ToString(item.RazonSocial));
                }
            }
        }

        private void CB_Lugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            I_ExaminarPrestamo F_ExaminarPrestamo = this.Owner as I_ExaminarPrestamo;
            if (F_ExaminarPrestamo != null)
            {
                List<LugarDePago> ListaLugaresDePago = F_ExaminarPrestamo.ObtenerLugares();
                lugar = ListaLugaresDePago[CB_Lugar.SelectedIndex];
                BT_RealizarPago.Enabled = true;
            }
        }
    }
}
