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
    public partial class F_AltasLugares : Form
    {
        public F_AltasLugares(LugarDePago lugar)
        {
            InitializeComponent();
            if (lugar.ID != 0)
            {
                this.Text = "Modificación de lugar de pago";
                LBL_Titulo.Text = "Editar lugar de pago";
                LBL_ID_Titulo.Visible = true;
                LBL_ID.Visible = true;
                CompletarDatosLugar(lugar);
            }
            else
            {
                LBL_Titulo.Text = "Nuevo lugar de pago";
                LBL_ID.Text = "";
                LBL_ID.Visible = false;
                LBL_ID_Titulo.Visible = false;
            }
        }

        private void CompletarDatosLugar(LugarDePago lugar)
        {
            this.LBL_ID.Text = Convert.ToString(lugar.ID);
            this.TB_RazonSocial.Text = lugar.RazonSocial;
            this.TB_Direccion.Text = lugar.Direccion;
            this.TB_cp.Text = Convert.ToString(lugar.CP);
            this.TB_Ciudad.Text = Convert.ToString(lugar.Ciudad);
            if (lugar.EsSucursal==true)
            {
                this.checkedListBox1.SetItemChecked(0, true);
                this.checkedListBox1.SetItemChecked(1, false);
            }
            else
            {
                this.checkedListBox1.SetItemChecked(0, false);
                this.checkedListBox1.SetItemChecked(1, true);
            }
        }
        
        private void Bt_GuardarLugar_Click(object sender, EventArgs e)
        {
            var resultadoalta = new ResultadoOp();
            var lugar = new LugarDePago();

            lugar.RazonSocial = this.TB_RazonSocial.Text;
            lugar.Direccion = this.TB_Direccion.Text;
            if (this.TB_cp.Text == "")
                lugar.CP = 0;
            else
                lugar.CP = Convert.ToInt32(this.TB_cp.Text);
            lugar.Ciudad = this.TB_Ciudad.Text;
            if (this.checkedListBox1.GetItemChecked(0)==true)
            {
                lugar.EsSucursal = true;
            }
            else
            {
                lugar.EsSucursal = false;
            }
            

            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;

            if (F_MenuPrincipal != null)
            {
                resultadoalta = F_MenuPrincipal.AltaLugares(lugar);
            }
            else
            {
                I_GrillaLugares F_GrillaLugares = this.Owner as I_GrillaLugares; //En caso de que se edite el Cliente (desde grilla)
                if (F_GrillaLugares != null)
                {
                    if (LBL_ID.Text != "")
                    {
                        lugar.ID = Convert.ToInt32(LBL_ID.Text);
                        resultadoalta = F_GrillaLugares.ModificacionLugar(lugar, false);
                    }
                    else
                    {
                        resultadoalta = F_GrillaLugares.AltaLugares(lugar);
                    }
                }
            }
            if (resultadoalta.Resultado == true)
                MessageBox.Show("La operación se realizó con éxito", "Operación compeltada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(resultadoalta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void F_AltasLugares_Load(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e) //Evita que puedan seleccionarse dos items al mismo tiempo
        {
            for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox1.SetItemChecked(ix, false);
        }
    }
}
