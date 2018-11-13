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
    public partial class F_AltasPrestamos : Form
    {
        public F_AltasPrestamos(Prestamo prestamo)
        {
            InitializeComponent();
            this.LBL_Fecha.Text = Convert.ToString(DateTime.Today.ToString("dd/MM/yyyy"));
            LimpiarDatosAdicionalesPrestamo();
            LimpiarDatosCliente(null);
        }

        private void CompletarDatosCliente(Cliente cliente)
        {
            this.LB_Cliente_ID.Text = "ID: " + Convert.ToString(cliente.ID);
            this.LB_Cliente_Doc.Text = Convert.ToString(cliente.TipoDocumento) + " " + Convert.ToString(cliente.NroDocumento);
            this.LB_Cliente_Nombre.Text = cliente.Nombre;
            this.LB_Cliente_Email.Text = cliente.Correo;
            this.LB_Cliente_Tipo.Text = "Cliente " + Convert.ToString(cliente.TipoCliente);
            this.LB_Cliente_MontoMax.Text = "Monto máximo: $" + Convert.ToString(cliente.MontoMaximo);
        }
        private void LimpiarDatosCliente(Cliente cliente)
        {
            this.LB_Cliente_ID.Text = "";
            this.LB_Cliente_Doc.Text = "";
            this.LB_Cliente_Nombre.Text = "";
            this.LB_Cliente_Email.Text = "";
            this.LB_Cliente_Tipo.Text = "";
            this.LB_Cliente_MontoMax.Text = "";
        }
        private void LimpiarDatosAdicionalesPrestamo()
        {
            this.LBL_Tasa.Text = "";
            this.LBL_MontoCuota.Text = "";
            this.LBL_MontoTotal.Text = "";
        }

        private void VerificarCliente(Prestamo prestamo, bool uso)
        {
            List<Cliente> ListaClientes = new List<Cliente>();
            int IDcliente = 0;
            if (this.TB_IDcliente.Text == "")
            {
                IDcliente = 0;
            }
            else
            {
                IDcliente = Convert.ToInt32(this.TB_IDcliente.Text);
            }

            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
            {
                ListaClientes = F_MenuPrincipal.ObtenerClientes();
            }
            else
            {
                I_GrillaPrestamos F_GrillaPrestamos = this.Owner as I_GrillaPrestamos;
                if (F_GrillaPrestamos != null)
                {
                    ListaClientes = F_GrillaPrestamos.ObtenerClientes();
                }
            }


            bool cliente_encontrado = false;
            foreach (var item in ListaClientes)
            {
                if (IDcliente == item.ID && item.Activo != false)
                {
                    cliente_encontrado = true;
                    if (uso)
                    {
                        prestamo.Cliente = item;
                    }
                    else
                        CompletarDatosCliente(item);
                    BT_GuardarPrestamo.Enabled = true;
                    break;
                }
            }
            if (!cliente_encontrado)
            {
                MessageBox.Show("Cliente no encontrado. Verifique el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (uso)
                    this.Close();
                else
                    BT_GuardarPrestamo.Enabled = false;
            }
        }

        Sucursal sucursal = new Sucursal();

        private void VerificarSucursal(Prestamo prestamo, bool uso)
        {
            List<Sucursal> ListaSucursales = new List<Sucursal>();
            int IDsucursal = 0;
            if (this.TB_IDsucursal.Text == "")
            {
                IDsucursal = 0;
            }
            else
            {
                IDsucursal = Convert.ToInt32(this.TB_IDsucursal.Text);
            }
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
            {
                ListaSucursales = F_MenuPrincipal.ObtenerSucursales();
            }
            else
            {
                I_GrillaPrestamos F_GrillaPrestamos = this.Owner as I_GrillaPrestamos;
                if (F_GrillaPrestamos != null)
                {
                    ListaSucursales = F_GrillaPrestamos.ObtenerSucursales();
                }
            }

            bool sucursal_encontrada = false;

            foreach (var item in ListaSucursales)
            {
                if (IDsucursal == item.ID && item.Activo == true)
                {
                    sucursal_encontrada = true;
                    if (uso)
                        prestamo.Sucursal = item;
                    else
                        sucursal = item;
                    BT_GuardarPrestamo.Enabled = true;
                    break;
                }
            }
            if (!sucursal_encontrada)
            {
                MessageBox.Show("Sucursal no encontrada. Verifique el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (uso)
                    this.Close();
                else
                    BT_GuardarPrestamo.Enabled = false;
            }
        }

        private void VerificarComercio(Prestamo prestamo, bool uso)
        {
            List<Comercio> ListaComercios = new List<Comercio>();
            int IDcomercio = 0;
            if (this.TB_IDcomercio.Text == "")
            {
                IDcomercio = 0;
            }
            else
            {
                IDcomercio = Convert.ToInt32(this.TB_IDcomercio.Text);
            }
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
            {
                ListaComercios = F_MenuPrincipal.ObtenerComercios();
            }
            else
            {
                I_GrillaPrestamos F_GrillaPrestamos = this.Owner as I_GrillaPrestamos;
                if (F_GrillaPrestamos != null)
                {
                    ListaComercios = F_GrillaPrestamos.ObtenerComercios();
                }
            }
            bool comercio_encontrado = false;
            foreach (var item in ListaComercios)
            {
                if (IDcomercio == item.ID && item.Activo != false)
                {
                    comercio_encontrado = true;
                    if (uso)
                        prestamo.ComercioAdherido = item;
                    break;
                }
            }
            if (!comercio_encontrado)
            {
                MessageBox.Show("Comercio no encontrado. Verifique el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (uso)
                    this.Close();
                else
                    BT_GuardarPrestamo.Enabled = false; 
            }
        }
        
        private void BT_GuardarPrestamo_Click(object sender, EventArgs e)
        {
            var resultadoalta = new ResultadoOp();
            var prestamo = new Prestamo();

            VerificarCliente(prestamo,true);     ///VERIFICACION DE EXISTENCIA DEL CLIENTE///
            VerificarSucursal(prestamo,true);    ///VERIFICACION DE EXISTENCIA DE LA SUCURSAL///
            VerificarComercio(prestamo,true);    ///VERIFICACION DE EXISTENCIA DEL COMERCIO///

            if (this.TB_MontoCredito.Text == "")
                prestamo.MontoCredito = 0;
            else
                prestamo.MontoCredito = Convert.ToInt32(this.TB_MontoCredito.Text);

            if (this.TB_CantidadCuotas.Text == "")
                prestamo.CantidadCuotas = 0;
            else
                prestamo.CantidadCuotas = Convert.ToInt32(this.TB_CantidadCuotas.Text);

            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
            {
                resultadoalta = F_MenuPrincipal.AltaPrestamos(prestamo);
            }
            else
            {
                I_GrillaPrestamos F_GrillaPrestamos = this.Owner as I_GrillaPrestamos; //En caso de que se edite el Cliente (desde grilla)
                if (F_GrillaPrestamos != null)
                {
                    resultadoalta = F_GrillaPrestamos.AltaPrestamos(prestamo);
                }
            }
            if (resultadoalta.Resultado==true)
                MessageBox.Show("La operación se realizó con éxito", "Operación compeltada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(resultadoalta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void F_AltasPrestamos_Load(object sender, EventArgs e)
        {
            
        }

        private void TB_IDcliente_TextChanged(object sender, EventArgs e)
        {
            if (TB_IDcliente.Text != "")
                VerificarCliente(null, false);
            else
                LimpiarDatosCliente(null);
        }
        private void TB_IDsucursal_TextChanged(object sender, EventArgs e)
        {
            if (TB_IDsucursal.Text != "")
            {
                VerificarSucursal(null, false);
                LBL_Tasa.Text = Convert.ToString(sucursal.TasaInteres);
            }
            else
                LimpiarDatosAdicionalesPrestamo();
        }
        private void TB_IDcomercio_TextChanged(object sender, EventArgs e)
        {
            if (TB_IDcomercio.Text != "")
            {
                VerificarComercio(null, false);
            }
        }

        private void TB_MontoCredito_TextChanged(object sender, EventArgs e)
        {
            if (TB_MontoCredito.Text != "" && LBL_Tasa.Text != "")
            {
                int monto_credito = Convert.ToInt32(TB_MontoCredito.Text);
                decimal tasa = Convert.ToDecimal(LBL_Tasa.Text);
                LBL_MontoTotal.Text = Convert.ToString(Math.Round(monto_credito + (tasa * monto_credito / 100)));
            }
        }

        private void TB_CantidadCuotas_TextChanged(object sender, EventArgs e)
        {
            if (TB_CantidadCuotas.Text != "" && LBL_MontoTotal.Text != "")
            {
                this.LBL_MontoCuota.Text = Convert.ToString(Math.Round(Convert.ToDecimal(LBL_MontoTotal.Text) / Convert.ToInt32(TB_CantidadCuotas.Text),2));
            }
        }
    }
}
