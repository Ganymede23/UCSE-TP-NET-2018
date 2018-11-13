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

        private void VerificarLugarDePago(Pago pago, bool uso)
        {
            List<LugarDePago> ListaLugaresDePago = new List<LugarDePago>();
            int IDlugar;
            if (this.TB_LugarPago.Text == "")
            {
                IDlugar = 0;
            }
            else
            {
                IDlugar = Convert.ToInt32(this.TB_LugarPago.Text);
            }
            I_RegistrosPagos F_RegistrosPagos = this.Owner as I_RegistrosPagos;
            if (F_RegistrosPagos != null)
            {
                ListaLugaresDePago = F_RegistrosPagos.ObtenerLugares();
            }

            bool lugar_encontrado = false;

            foreach (var item in ListaLugaresDePago)
            {
                if (IDlugar == item.ID && item.Activo == true)
                {
                    lugar_encontrado = true;
                    if (uso)
                        lugar = item;
                    BT_RealizarPago.Enabled = true;
                    break;
                }
            }
            if (!lugar_encontrado)
            {
                MessageBox.Show("Lugar de pago no encontrado. Verifique el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (uso)
                    this.Close();
                else
                    BT_RealizarPago.Enabled = false;
            }
        }

        private void BT_RealizarPago_Click(object sender, EventArgs e)
        {
            var resultadoalta = new ResultadoOp();
            var update_grilla = new ResultadoOp();
            var pago = new Pago();

            VerificarLugarDePago(pago, true);

            I_RegistrosPagos F_RegistrosPagos = this.Owner as I_RegistrosPagos;
            if (F_RegistrosPagos != null)
            {
                resultadoalta = F_RegistrosPagos.RegistroPagos(prop_prestamo, lugar);
                F_RegistrosPagos.ActualizarGrillaPagos();
            }
            if (resultadoalta.Resultado == true)
                MessageBox.Show("La operación se realizó con éxito", "Operación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(resultadoalta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void F_EfectuarPago_Load(object sender, EventArgs e)
        {

        }

        private void TB_LugarPago_TextChanged(object sender, EventArgs e)
        {
            if (TB_LugarPago.Text != "")
            {
                VerificarLugarDePago(null, false);
            }
        }
    }
}
