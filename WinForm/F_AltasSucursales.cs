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
    public partial class F_AltasSucursales : Form
    {
        public F_AltasSucursales()
        {
            InitializeComponent();
        }

        public F_AltasSucursales(Sucursal sucursal)
        {
            InitializeComponent();
            if (sucursal.ID != 0)
            {
                this.Text = "Modificación de Sucursales";
                LBL_Titulo.Text = "Editar Sucursal";
                LBL_ID_Titulo.Visible = true;
                LBL_ID.Visible = true;
                CompletarDatosSucursal(sucursal);
            }
            else
            {
                LBL_Titulo.Text = "Nueva Sucursal";
                LBL_ID.Text = "";
                LBL_ID.Visible = false;
                LBL_ID_Titulo.Visible = false;
            }

           
        }

        private void CompletarDatosSucursal(Sucursal sucursal)
        {
            this.LBL_ID.Text = Convert.ToString(sucursal.ID);
            this.TB_Ciudad.Text = sucursal.Ciudad;
            this.TB_Direccion.Text = sucursal.Direccion;
            this.TB_Cp.Text = Convert.ToString(sucursal.CP);
            this.TB_TasaInteres.Text = Convert.ToString(sucursal.TasaInteres);
        }

        private void BT_GuardarSucursal_Click(object sender, EventArgs e)
        {
            var resultadoalta = new ResultadoOp();
            var sucursal = new Sucursal();

            sucursal.Direccion = this.TB_Direccion.Text;
            if (this.TB_Cp.Text == "")
                sucursal.CP = 0;
            else
                sucursal.CP = Convert.ToInt32(this.TB_Cp.Text);
            sucursal.Ciudad = this.TB_Ciudad.Text;
            if (this.TB_TasaInteres.Text=="")
                sucursal.TasaInteres = 0.0M;
            else
                sucursal.TasaInteres=Convert.ToDecimal(this.TB_TasaInteres.Text);

            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;

            if (F_MenuPrincipal != null)
            {
                resultadoalta = F_MenuPrincipal.AltaSucursales(sucursal);
            }
            else
            {
                I_GrillaSucursales F_GrillaSucursales = this.Owner as I_GrillaSucursales;
                if (F_GrillaSucursales != null)
                {
                    if (LBL_ID.Text != "")
                    {
                        sucursal.ID = Convert.ToInt32(LBL_ID.Text);
                        resultadoalta = F_GrillaSucursales.ModificacionSucursal(sucursal, false);
                    }
                    else
                    {
                        resultadoalta = F_GrillaSucursales.AltaSucursales(sucursal);
                    }
                }
            }
            if (resultadoalta.Resultado == true)
            {
                MessageBox.Show("La operación se realizó con éxito", "Operación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show(resultadoalta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void F_AltasSucursales_Load(object sender, EventArgs e)
        {

        }
    }
}
