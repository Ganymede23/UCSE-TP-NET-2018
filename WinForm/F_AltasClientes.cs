﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using System.Net.Mail;
//using System.Text.RegularExpressions;

namespace WinForm
{
    public partial class F_AltasClientes : Form
    {
        public F_AltasClientes(Cliente cliente)
        {
            InitializeComponent();
            if (cliente.ID != 0)
            {
                this.Text = "Modificación de Clientes";
                LBL_Titulo.Text = "Editar Cliente";
                LBL_ID_Titulo.Visible = true;
                LBL_ID.Visible = true;
                CompletarDatosCliente(cliente);
            }
            else
            {
                LBL_Titulo.Text = "Nuevo Cliente";
                LBL_ID.Text = "";
                LBL_ID.Visible = false;
                LBL_ID_Titulo.Visible = false;
            }
        }

        private void CompletarDatosCliente(Cliente cliente)
        {
            this.LBL_ID.Text = Convert.ToString(cliente.ID);
            this.CB_TipoDoc.Text = Convert.ToString(cliente.TipoDocumento);
            this.TB_NroDocumento.Text = Convert.ToString(cliente.NroDocumento);
            this.TB_Nombre.Text = cliente.Nombre;
            this.TB_Email.Text = cliente.Correo;
            this.TB_Celular.Text = cliente.Celular;
            this.dateTimePicker1.Text = Convert.ToString(cliente.FNac);
            this.CB_Sexo.Text = Convert.ToString(cliente.Sexo);
            this.TB_Domicilio.Text = cliente.Domicilio;
            this.TB_cp.Text = Convert.ToString(cliente.CP);
            this.TB_Localidad.Text = cliente.Localidad;
            this.CB_TipoCliente.Text = Convert.ToString(cliente.TipoCliente);
            this.TB_MontoMax.Text = Convert.ToString(cliente.MontoMaximo);
        }

        private void BT_GuardarCliente_Click(object sender, EventArgs e)
        {
            var resultadoalta = new ResultadoOp();
            var cliente = new Cliente();
            switch (this.CB_TipoDoc.Text)
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
            if (this.TB_NroDocumento.Text=="")
                cliente.NroDocumento = 0;
            else
                cliente.NroDocumento = Convert.ToInt32(this.TB_NroDocumento.Text);
            cliente.Nombre = this.TB_Nombre.Text;
            cliente.Correo = this.TB_Email.Text;
            cliente.Celular = this.TB_Celular.Text;
            cliente.FNac = DateTime.Parse(this.dateTimePicker1.Text);
            switch (this.CB_Sexo.Text)
            {
                case "Hombre":
                    cliente.Sexo = Sexo.Hombre;
                    break;
                case "Mujer":
                    cliente.Sexo = Sexo.Mujer;
                    break;
            }
            cliente.Domicilio = this.TB_Domicilio.Text;
            if (this.TB_cp.Text == "")
                cliente.CP = 0;
            else
                cliente.CP = Convert.ToInt32(this.TB_NroDocumento.Text);
            cliente.Localidad = this.TB_Localidad.Text;
            switch (this.CB_TipoCliente.Text)
            {
                case "Regular":
                    cliente.TipoCliente = TipoCliente.Regular;
                    break;
                case "VIP":
                    cliente.TipoCliente = TipoCliente.VIP;
                    break;
            }
            if (this.TB_MontoMax.Text == "")
                cliente.MontoMaximo = 0;
            else
                cliente.MontoMaximo = Convert.ToInt32(this.TB_MontoMax.Text);

            I_MenuPrincipal F_MenuPrincipal = this.Owner as I_MenuPrincipal;

            if (F_MenuPrincipal != null)
            {
                resultadoalta = F_MenuPrincipal.AltaClientes(cliente);
            }
            else
            {
                I_GrillaClientes F_GrillaClientes = this.Owner as I_GrillaClientes; //En caso de que se edite el Cliente (desde grilla)
                if (F_GrillaClientes != null)
                {
                    if (LBL_ID.Text != "")
                    {
                        cliente.ID = Convert.ToInt32(LBL_ID.Text);
                        resultadoalta = F_GrillaClientes.ModificacionCliente(cliente, false);
                    }
                    else
                    {
                        resultadoalta = F_GrillaClientes.AltaClientes(cliente);
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

        private void F_AltasClientes_Load(object sender, EventArgs e)
        {

        }

        void ValidarEmail()
        {
            if (TB_Email.Text != "")
            {
                try
                {
                    var correo = new MailAddress(TB_Email.Text);
                    BT_GuardarCliente.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("El correo electrónico ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BT_GuardarCliente.Enabled = false;
                }
            }
        }

        private void TB_Email_Leave(object sender, EventArgs e)
        {
            ValidarEmail();
        }
    }
}
