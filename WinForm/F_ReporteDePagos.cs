using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class F_ReporteDePagos : Form
    {
        public F_ReporteDePagos()
        {
            InitializeComponent();
        }

        private void F_ReporteDePagos_Load(object sender, EventArgs e)
        {
            List<Prestamo> ListaPrestamos = new List<Prestamo>();
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
            {
                ListaPrestamos = F_MenuPrincipal.ObtenerPrestamos(null,null,null,null);
            }

            if (ListaPrestamos.Count!=0)
            {
                double monto_prestado = ListaPrestamos.Sum(x => x.MontoCredito);
                double cuotas_pagadas = ListaPrestamos.Sum(x => x.CuotasPagadas * x.MontoCuota);

                LBL_MontoPrestado.Text = "$ " + Convert.ToString(Math.Round(monto_prestado,2));
                LBL_CuotasPagadas.Text = "$ " + Convert.ToString(Math.Round(cuotas_pagadas,2));
                LBL_TasaInteres.Text = Convert.ToString(Math.Round(ListaPrestamos.Average(x => x.Tasa),2)) + " %";

                double resultado = cuotas_pagadas - monto_prestado;
                LBL_Resultado.Text = "$ " + Convert.ToString(resultado);
                if (resultado > 0)
                    LBL_Resultado.ForeColor = Color.Green;
                else if (resultado < 0)
                    LBL_Resultado.ForeColor = Color.Red;
                else
                    LBL_Resultado.ForeColor = Color.Black;
            }
            else
            {
                LBL_MontoPrestado.Text = "$ 0";
                LBL_CuotasPagadas.Text = "$ 0";
                LBL_TasaInteres.Text = " - %";
                LBL_Resultado.Text = "$ 0";
            }
        }
    }
}
