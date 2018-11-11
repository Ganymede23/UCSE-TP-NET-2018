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
    public partial class F_AltasComercios : Form
    {
        public F_AltasComercios(Comercio comercio)
        {
            InitializeComponent();
            if (comercio.ID != 0)
            {
                this.Text = "Modificación de Comercios";
                LBL_Titulo.Text = "Editar Comercio";
                LBL_ID_Titulo.Visible = true;
                LBL_ID.Visible = true;
                CompletarDatosComercio(comercio);
            }
            else
            {
                LBL_Titulo.Text = "Nuevo Comercio";
                LBL_ID.Text = "";
                LBL_ID.Visible = false;
                LBL_ID_Titulo.Visible = false;
            }
        }

        private void CompletarDatosComercio(Comercio comercio)
        {
            this.LBL_ID.Text = Convert.ToString(comercio.ID);
            this.TB_RazonSocial.Text = comercio.RazonSocial;
            this.TB_Direccion.Text = comercio.Direccion;
            this.TB_cp.Text = Convert.ToString(comercio.CP);
            this.TB_Ciudad.Text = Convert.ToString(comercio.Ciudad);
        }

        private void Bt_GuardarCliente_Click(object sender, EventArgs e)
        {
            var resultadoalta = new ResultadoOp();
            var comercio = new Comercio();

            comercio.RazonSocial = this.TB_RazonSocial.Text;
            comercio.Direccion = this.TB_Direccion.Text;
            if (this.TB_cp.Text == "")
                comercio.CP = 0;
            else
                comercio.CP = Convert.ToInt32(this.TB_cp.Text);
            comercio.Ciudad = this.TB_Ciudad.Text;

            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;

            if (F_MenuPrincipal != null)
            {
                resultadoalta = F_MenuPrincipal.AltaComercios(comercio);
            }
            else
            {
                I_GrillaComercios F_GrillaComercios = this.Owner as I_GrillaComercios; //En caso de que se edite el Cliente (desde grilla)
                if (F_GrillaComercios != null)
                {
                    if (LBL_ID.Text != "")
                    {
                        comercio.ID = Convert.ToInt32(LBL_ID.Text);
                        resultadoalta = F_GrillaComercios.ModificacionComercio(comercio, false);
                    }
                    else
                    {
                        resultadoalta = F_GrillaComercios.AltaComercios(comercio);
                    }
                }
            }
            MessageBox.Show(resultadoalta.Resultado == true ? "La operación se realizó con exito" : resultadoalta.Mensaje);
            this.Close();
        }

        private void F_AltasComercios_Load(object sender, EventArgs e)
        {

        }
    }
}
