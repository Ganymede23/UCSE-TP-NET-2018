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

        Sucursal sucursal = new Sucursal();
        Cliente cliente = new Cliente();
        Comercio comercio = new Comercio();
        
        private void BT_GuardarPrestamo_Click(object sender, EventArgs e)
        {
            var resultadoalta = new ResultadoOp();
            var prestamo = new Prestamo();

            prestamo.Sucursal = sucursal;
            prestamo.Cliente = cliente;
            prestamo.ComercioAdherido = comercio;

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
            {
                MessageBox.Show("La operación se realizó con éxito", "Operación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show(resultadoalta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void F_AltasPrestamos_Load(object sender, EventArgs e)
        {
            List<Comercio> ListaComercios = new List<Comercio>();
            List<Cliente> ListaClientes = new List<Cliente>();
            List<Sucursal> ListaSucursales = new List<Sucursal>();

            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
            {
                ListaComercios = F_MenuPrincipal.ObtenerComercios();
                ListaClientes = F_MenuPrincipal.ObtenerClientes();
                ListaSucursales = F_MenuPrincipal.ObtenerSucursales();
            }
            else
            {
                I_GrillaPrestamos F_GrillaPrestamos = this.Owner as I_GrillaPrestamos;
                if (F_GrillaPrestamos != null)
                {
                    ListaComercios = F_GrillaPrestamos.ObtenerComercios();
                    ListaClientes = F_GrillaPrestamos.ObtenerClientes();
                    ListaSucursales = F_GrillaPrestamos.ObtenerSucursales();
                }
            }
            foreach (var item in ListaComercios)
            {
                this.CB_Comercio.Items.Add(Convert.ToString(item.RazonSocial));
            }
            foreach (var item in ListaClientes)
            {
                this.CB_Cliente.Items.Add(Convert.ToString(item.Nombre));
            }
            foreach (var item in ListaSucursales)
            {
                this.CB_Sucursal.Items.Add(Convert.ToString(item.ID + " - " + item.Direccion));
            }
        }

        private void CB_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Cliente> ListaClientes = new List<Cliente>();

            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
                ListaClientes = F_MenuPrincipal.ObtenerClientes();
            else
            {
                I_GrillaPrestamos F_GrillaPrestamos = this.Owner as I_GrillaPrestamos;
                if (F_GrillaPrestamos != null)
                    ListaClientes = F_GrillaPrestamos.ObtenerClientes();
            }

            this.LB_Cliente_ID.Text = "ID: " + Convert.ToString(ListaClientes[CB_Cliente.SelectedIndex].ID);
            this.LB_Cliente_Doc.Text = Convert.ToString(ListaClientes[CB_Cliente.SelectedIndex].TipoDocumento) + " " + Convert.ToString(ListaClientes[CB_Cliente.SelectedIndex].NroDocumento);
            this.LB_Cliente_Nombre.Text = ListaClientes[CB_Cliente.SelectedIndex].Nombre;
            this.LB_Cliente_Email.Text = ListaClientes[CB_Cliente.SelectedIndex].Correo;
            this.LB_Cliente_Tipo.Text = "Cliente " + Convert.ToString(ListaClientes[CB_Cliente.SelectedIndex].TipoCliente);
            this.LB_Cliente_MontoMax.Text = "Monto máximo: $" + Convert.ToString(ListaClientes[CB_Cliente.SelectedIndex].MontoMaximo);

            cliente = ListaClientes[CB_Cliente.SelectedIndex];
        }
        private void CB_Comercio_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Comercio> ListaComercios = new List<Comercio>();

            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
                ListaComercios = F_MenuPrincipal.ObtenerComercios();
            else
            {
                I_GrillaPrestamos F_GrillaPrestamos = this.Owner as I_GrillaPrestamos;
                if (F_GrillaPrestamos != null)
                    ListaComercios = F_GrillaPrestamos.ObtenerComercios();
            }

            comercio = ListaComercios[CB_Comercio.SelectedIndex];
        }
        private void CB_Sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Sucursal> ListaSucursales = new List<Sucursal>();

            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
                ListaSucursales = F_MenuPrincipal.ObtenerSucursales();
            else
            {
                I_GrillaPrestamos F_GrillaPrestamos = this.Owner as I_GrillaPrestamos;
                if (F_GrillaPrestamos != null)
                    ListaSucursales = F_GrillaPrestamos.ObtenerSucursales();
            }

            LBL_Tasa.Text = Convert.ToString(ListaSucursales[CB_Sucursal.SelectedIndex].TasaInteres);

            sucursal = ListaSucursales[CB_Sucursal.SelectedIndex];
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
                this.LBL_MontoCuota.Text = Convert.ToString(Math.Round(Convert.ToDecimal(LBL_MontoTotal.Text) / Convert.ToInt32(TB_CantidadCuotas.Text), 2));
            }
        }
    }
}
