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

            var pago = new Pago();

            var ListaPago = prestamo.ListaPagos;
            foreach (var item in ListaPago)
            {
                if (item.LugarPago == null)
                {
                    pago = item;
                }
            }
            pago.LugarPago.ID = Convert.ToInt32(this.TB_LugarPago.Text);
            CompletarDatosPago(pago);
            VerificarLugarDePago(pago);
        }


        private void CompletarDatosPago(Pago pago)
        {
            this.LBL_NroCuota.Text = Convert.ToString(pago.NumeroCuota);
            this.LBL_Monto.Text = Convert.ToString(pago.MontoCuota);
            this.LBL_Entrega.Text = Convert.ToString(pago.MontoPago);
        }

        private void VerificarLugarDePago(Pago pago)
        {
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            List<LugarDePago> ListaLugaresDePago = new List<LugarDePago>();
            int IDlugar = 0;
            if (this.TB_LugarPago.Text == "")
            {
                IDlugar = 0;
            }
            else
            {
                IDlugar = Convert.ToInt32(this.TB_LugarPago.Text);
            }
            if (F_MenuPrincipal != null)
            {
                ListaLugaresDePago = F_MenuPrincipal.ObtenerLugares();
            }
            bool lugar_encontrado = false;
            foreach (var item in ListaLugaresDePago)
            {
                if (IDlugar == item.ID && item.Activo != false)
                {
                    lugar_encontrado = true;
                    pago.LugarPago = item;
                    break;
                }
            }
            if (!lugar_encontrado)
            {
                MessageBox.Show("Lugar de pago no encontrado. Verifique el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }



        private void BT_RealizarPago_Click(object sender, EventArgs e)
        {
            var resultadoalta = new ResultadoOp();

            I_RegistroPagos F_RegistrosPagos = this.Owner as I_RegistroPagos;
            if (F_RegistrosPagos != null)
            {
                resultadoalta = F_RegistrosPagos.RegistroPagos();
            }

        }
    }
}
