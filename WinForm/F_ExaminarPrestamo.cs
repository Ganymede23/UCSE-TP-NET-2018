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
    public partial class F_ExaminarPrestamo : Form, I_ExaminarPrestamo
    {
        public F_ExaminarPrestamo(Prestamo prestamo)
        {
            InitializeComponent();
            prop_prestamo = prestamo;
        }

        private Prestamo prop_prestamo { get; set; }

        public void ActualizarGrillaPagos(Prestamo prestamo)
        {
            ResultadoOp resultado = new ResultadoOp();
            I_GrillaPrestamos F_GrillaPrestamos = this.Owner as I_GrillaPrestamos;
            this.GrillaCuotas.DataSource = null;

            if (F_GrillaPrestamos != null)
            {
                this.GrillaCuotas.DataSource = F_GrillaPrestamos.ObtenerRegistrosPagos(prop_prestamo);
            }
        }

        private void F_ExaminarPrestamo_Load(object sender, EventArgs e)
        {
            //ActualizarGrillaPagos();

            //PRESTAMO
            LBL_PrestamoID.Text = Convert.ToString(prop_prestamo.ID);
            LBL_PrestamoFecha.Text = Convert.ToString(prop_prestamo.FCredito.ToString("dd/MM/yyyy"));
            LBL_PrestamoMonto.Text = "$ " + Convert.ToString(prop_prestamo.MontoCredito);
            LBL_PrestamoMontoTotal.Text = "$ " + Convert.ToString(prop_prestamo.MontoTotal);
            LBL_PrestamoMontoCuota.Text = "$ " + Convert.ToString(prop_prestamo.MontoCuota);
            LBL_PrestamoCantCuotas.Text = Convert.ToString(prop_prestamo.CantidadCuotas);
            LBL_PrestamoCuotasPagas.Text = Convert.ToString(prop_prestamo.CuotasPagadas);
            LBL_PrestamoCuotasImpagas.Text = Convert.ToString(prop_prestamo.CuotasFaltantes);

            //CLIENTE
            LBL_ClienteID.Text = Convert.ToString(prop_prestamo.Cliente.ID);
            LBL_ClienteDoc.Text = "- " + Convert.ToString(prop_prestamo.Cliente.TipoDocumento) + " " + Convert.ToString(prop_prestamo.Cliente.NroDocumento);
            LBL_ClienteNombre.Text = Convert.ToString(prop_prestamo.Cliente.Nombre);
            LBL_ClienteEmail.Text = Convert.ToString(prop_prestamo.Cliente.Correo);
            LBL_ClienteTipo.Text = Convert.ToString(prop_prestamo.Cliente.TipoCliente);

            //SUCURSAL
            LBL_SucursalID.Text = Convert.ToString(prop_prestamo.Sucursal.ID);
            LBL_SucursalCiudad.Text = Convert.ToString(prop_prestamo.Sucursal.Ciudad);
            LBL_SucursalDireccion.Text = Convert.ToString(prop_prestamo.Sucursal.Direccion);
            LBL_SucursalCP.Text = Convert.ToString(prop_prestamo.Sucursal.CP);
            LBL_SucursalTasa.Text = Convert.ToString(prop_prestamo.Tasa) + " %";

            //COMERCIO
            LBL_ComercioID.Text = Convert.ToString(prop_prestamo.ComercioAdherido.ID);
            LBL_ComercioCiudad.Text = Convert.ToString(prop_prestamo.ComercioAdherido.Ciudad);
            LBL_ComercioDireccion.Text = Convert.ToString(prop_prestamo.ComercioAdherido.Direccion);
            LBL_ComercioCP.Text = Convert.ToString(prop_prestamo.ComercioAdherido.CP);
            LBL_ComercioRazonSoc.Text = Convert.ToString(prop_prestamo.ComercioAdherido.RazonSocial);

            this.GrillaCuotas.AutoGenerateColumns = false;
            this.GrillaCuotas.ColumnCount = 5;

            this.GrillaCuotas.Columns[0].HeaderText = "Nro.";
            this.GrillaCuotas.Columns[0].DataPropertyName = "NumeroCuota";
            this.GrillaCuotas.Columns[0].Width = 30;
            this.GrillaCuotas.Columns[1].HeaderText = "Monto Cuota ($)";
            this.GrillaCuotas.Columns[1].DataPropertyName = "MontoCuota";
            this.GrillaCuotas.Columns[1].Width = 105;
            this.GrillaCuotas.Columns[2].HeaderText = "Monto Pago ($)";
            this.GrillaCuotas.Columns[2].DataPropertyName = "MontoPago";
            this.GrillaCuotas.Columns[2].Width = 105;
            this.GrillaCuotas.Columns[3].HeaderText = "Fecha de Pago";
            this.GrillaCuotas.Columns[3].DataPropertyName = "FechaPago";
            this.GrillaCuotas.Columns[3].Width = 100;
            this.GrillaCuotas.Columns[4].HeaderText = "Lugar de Pago";
            this.GrillaCuotas.Columns[4].DataPropertyName = "LugarPago";
            this.GrillaCuotas.Columns[4].Width = 160;

            GrillaCuotas.DataSource = prop_prestamo.ListaPagos;

            DataGridViewLinkColumn EfectuarPago = new DataGridViewLinkColumn();
            EfectuarPago.HeaderText = "Efecutar Pago";
            EfectuarPago.Text = "Pagar";
            EfectuarPago.Width = 70;
            EfectuarPago.UseColumnTextForLinkValue = true;
            GrillaCuotas.Columns.Add(EfectuarPago);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void GrillaCuotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = this.GrillaCuotas.Columns[e.ColumnIndex];
            var row = this.GrillaCuotas.Rows[e.RowIndex];

            if (column.HeaderText == "Efecutar Pago")
            {
                Pago pago = row.DataBoundItem as Pago;
                if (pago.MontoPago != 0)
                {
                    MessageBox.Show("La cuota seleccionada ya está paga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var Crear_F_EfectuarPago = new F_EfectuarPago(prop_prestamo, pago) { Owner = this };
                    Crear_F_EfectuarPago.ShowDialog();
                }
            }
            ActualizarGrillaPagos(prop_prestamo);
        }

        public ResultadoOp RegistroPagos(Prestamo prestamo, LugarDePago lugar)
        {
            var resultadoalta = new ResultadoOp();
            I_GrillaPrestamos F_GrillaPrestamos = this.Owner as I_GrillaPrestamos;
            if (F_GrillaPrestamos != null)
            {
                resultadoalta = F_GrillaPrestamos.RegistroPagos(prestamo, lugar);
            }
            return resultadoalta;
        }
        public List<LugarDePago> ObtenerLugares()
        {
            List<LugarDePago> ListaLugaresDePago = new List<LugarDePago>();
            I_GrillaPrestamos F_GrillaPrestamos = this.Owner as I_GrillaPrestamos;
            if (F_GrillaPrestamos != null)
            {
                ListaLugaresDePago = F_GrillaPrestamos.ObtenerLugares();
            }
            return ListaLugaresDePago;
        }
    }
}
