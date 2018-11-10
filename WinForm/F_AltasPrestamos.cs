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
            //CompletarDatosCliente(cliente);
            //ActualizarComboBoxComercios();
            this.LBL_Fecha.Text = Convert.ToString(DateTime.Today);
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

        private ResultadoOp VerificarCliente()
        {
            List<Cliente> ListaClientes = new List<Cliente>();

            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            if (F_MenuPrincipal != null)
            {
                ListaClientes = F_MenuPrincipal.ObtenerClientes();
            }
            var resultadoverificacion = new ResultadoOp(false, "Cliente no encontrado. Verifique ID.");
            foreach (var item in ListaClientes)
            {
                if (Convert.ToInt32(TB_IDcliente.Text) == item.ID)
                {
                    resultadoverificacion.Mensaje = "";
                    resultadoverificacion.Resultado = true;
                    break;
                }
            }
            return resultadoverificacion;
        }

        private void VerificarCliente(Prestamo prestamo)
        {
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            List<Cliente> ListaClientes = new List<Cliente>();
            int IDcliente = 0;
            if (this.TB_IDcomercio.Text == "")
            {
                IDcliente = 0;
            }
            else
            {
                IDcliente = Convert.ToInt32(this.TB_IDcliente.Text);
            }
            if (F_MenuPrincipal != null)
            {
                ListaClientes = F_MenuPrincipal.ObtenerClientes();
            }
            bool cliente_encontrado = false;
            foreach (var item in ListaClientes)
            {
                if (IDcliente == item.ID)
                {
                    cliente_encontrado = true;
                    prestamo.Cliente = item;
                    CompletarDatosCliente(item);
                    break;
                }
            }
            if (!cliente_encontrado)
            {
                MessageBox.Show("Cliente no encontrado. Verifique el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void VerificarSucursal(Prestamo prestamo)
        {
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
            List<Sucursal> ListaSucursales = new List<Sucursal>();
            int IDsucursal = 0;
            if (this.TB_IDcomercio.Text == "")
            {
                IDsucursal = 0;
            }
            else
            {
                IDsucursal = Convert.ToInt32(this.TB_IDsucursal.Text);
            }
            if (F_MenuPrincipal != null)
            {
                ListaSucursales = F_MenuPrincipal.ObtenerSucursales();
            }
            bool sucursal_encontrada = false;
            foreach (var item in ListaSucursales)
            {
                if (IDsucursal == item.ID)
                {
                    sucursal_encontrada = true;
                    prestamo.Sucursal = item;
                    LBL_Tasa.Text = Convert.ToString(prestamo.Sucursal.TasaInteres);
                    break;
                }
            }
            if (!sucursal_encontrada)
            {
                MessageBox.Show("Sucursal no encontrada. Verifique el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void VerificarComercio(Prestamo prestamo)
        {
            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;
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
            if (F_MenuPrincipal != null)
            {
                ListaComercios = F_MenuPrincipal.ObtenerComercios();
            }
            bool comercio_encontrado = false;
            foreach (var item in ListaComercios)
            {
                if (IDcomercio == item.ID)
                {
                    comercio_encontrado = true;
                    prestamo.ComercioAdherido = item;
                    break;
                }
            }
            if (!comercio_encontrado)
            {
                MessageBox.Show("Comercio no encontrado. Verifique el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void BT_GuardarPrestamo_Click(object sender, EventArgs e)
        {
            var resultadoalta = new ResultadoOp();
            var prestamo = new Prestamo();

            VerificarCliente(prestamo);     ///VERIFICACION DE EXISTENCIA DEL CLIENTE///
            VerificarSucursal(prestamo);    ///VERIFICACION DE EXISTENCIA DE LA SUCURSAL///
            VerificarComercio(prestamo);    ///VERIFICACION DE EXISTENCIA DEL COMERCIO///

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
                I_GrillaClientes F_GrillaClientes = this.Owner as I_GrillaClientes; //En caso de que se edite el Cliente (desde grilla)
                if (F_GrillaClientes != null)
                {
                    resultadoalta = F_MenuPrincipal.AltaPrestamos(prestamo);
                }
            }
            MessageBox.Show(resultadoalta.Resultado == true ? "La operación se realizó con exito" : resultadoalta.Mensaje);
            this.Close();
        }

        private void F_AltasPrestamos_Load(object sender, EventArgs e)
        {
            
        }

        //private void ActualizarComboBoxSucursales()
        //{
        //    I_MenuPrincipal formPrestamos = this.Owner as I_MenuPrincipal;

        //    if (formCliente != null)
        //    {
        //        this.GrillaClientes.DataSource = formPrestamos.ObtenerSucursales();
        //    }
        //}

        //private void ActualizarComboBoxComercios()
        //{
        //    I_GrillaClientes F_GrillaClientes = this.Owner as I_GrillaClientes;
        //    if (F_GrillaClientes != null)
        //    {
        //        List<Comercio> ListaComercios = F_GrillaClientes.ObtenerComercios();
        //        foreach (var item in ListaComercios)
        //        {
        //            this.CB_Comercio.Items.Add(Convert.ToString(item.RazonSocial));
        //        }
        //    }
        //}

        private void BT_Calcular_Click(object sender, EventArgs e)
        {
            //int monto_credito = Convert.ToInt32(TB_MontoCredito.Text);
            //double tasa = Convert.ToDouble(LBL_Tasa.Text);
            //LBL_MontoTotal.Text = Convert.ToString(monto_credito + (tasa * monto_credito / 100));

            //int monto_total = Convert.ToInt32(LBL_MontoTotal.Text);
            //int cantidad_cuotas = Convert.ToInt32(TB_CantidadCuotas.Text);
            //LBL_MontoCuota.Text = Convert.ToString(monto_total / cantidad_cuotas);
        }
    }
}
