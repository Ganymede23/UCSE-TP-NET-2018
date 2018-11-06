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
    public partial class F_AltasClientes : Form
    {
        public F_AltasClientes(Cliente cliente)
        {
            InitializeComponent();
        }

        //private void CompletarDatosPaciente(Cliente paciente)
        //{
        //    this.LblId.Text = Convert.ToString(paciente.Id);
        //    this.TxtDni.Text = Convert.ToString(paciente.Dni);
        //    this.TxtNombre.Text = paciente.Nombre;
        //    this.TxtApellido.Text = paciente.Apellido;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            var resultadoalta = new ResultadoAlta();
            var cliente = new Cliente();

            switch (this.CB_TipoDoc.SelectedText)
            {
                case "LE":
                    cliente.TipoDocumento = TipoDocumento.LE;
                    break;
                case "LC":
                    cliente.TipoDocumento = TipoDocumento.LC;
                    break;
                case "DNI":
                    cliente.TipoDocumento = TipoDocumento.DNI;
                    break;
            }
            cliente.NroDocumento = int.Parse(this.TB_NroDocumento.Text);
            cliente.Nombre = this.TB_Nombre.Text;
            cliente.Correo = this.TB_email.Text;
            cliente.Celular = int.Parse(this.TB_celular.Text);
            cliente.FNac = DateTime.Parse(this.TB_FechaNac.Text);

            switch (this.CB_Sexo.SelectedText)
            {
                case "Hombre":
                    cliente.Sexo = Sexo.Hombre;
                    break;
                case "Mujer":
                    cliente.Sexo = Sexo.Mujer;
                    break;
            }
            cliente.Domicilio = this.TB_domicilio.Text;
            cliente.CP = int.Parse(this.TB_cp.Text);
            switch (this.CB_TipoCliente.SelectedText)
            {
                case "Regular":
                    cliente.TipoCliente = TipoCliente.Regular;
                    break;
                case "VIP":
                    cliente.TipoCliente = TipoCliente.VIP;
                    break;
            }
            cliente.MontoMaximo = int.Parse(this.TB_MontoMax.Text);

            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;

            resultadoalta = F_MenuPrincipal.AltaClientes(cliente);

            //if (F_MenuPrincipal != null)
            //{
            //    resultadoalta = F_MenuPrincipal.AgregarCliente(cliente);
            //}
            //else
            //{
            //    IFormGrilla formGrilla = this.Owner as IFormGrilla;
            //    if (formGrilla != null)
            //    {
            //        if (LblId.Text != "")
            //        {
            //            paciente.Id = Convert.ToInt32(LblId.Text);
            //            resultadoOperacion = formGrilla.ModificacionPaciente(paciente, false);
            //        }
            //        else
            //        {
            //            resultadoOperacion = formGrilla.NuevoPaciente(paciente);
            //        }
            //    }
            }
        }
}
