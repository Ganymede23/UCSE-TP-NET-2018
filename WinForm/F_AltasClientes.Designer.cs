namespace WinForm
{
    partial class F_AltasClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CB_TipoCliente = new System.Windows.Forms.ComboBox();
            this.CB_TipoDoc = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_GuardarCliente = new System.Windows.Forms.Button();
            this.CB_Sexo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TB_NroDocumento = new System.Windows.Forms.MaskedTextBox();
            this.TB_Email = new System.Windows.Forms.MaskedTextBox();
            this.TB_Celular = new System.Windows.Forms.MaskedTextBox();
            this.TB_FechaNac = new System.Windows.Forms.MaskedTextBox();
            this.TB_cp = new System.Windows.Forms.MaskedTextBox();
            this.TB_MontoMax = new System.Windows.Forms.MaskedTextBox();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_Domicilio = new System.Windows.Forms.TextBox();
            this.TB_Localidad = new System.Windows.Forms.TextBox();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.LBL_ID_Titulo = new System.Windows.Forms.Label();
            this.LBL_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_TipoCliente
            // 
            this.CB_TipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TipoCliente.FormattingEnabled = true;
            this.CB_TipoCliente.Items.AddRange(new object[] {
            "Regular",
            "VIP"});
            this.CB_TipoCliente.Location = new System.Drawing.Point(483, 187);
            this.CB_TipoCliente.Name = "CB_TipoCliente";
            this.CB_TipoCliente.Size = new System.Drawing.Size(148, 21);
            this.CB_TipoCliente.TabIndex = 40;
            // 
            // CB_TipoDoc
            // 
            this.CB_TipoDoc.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.CB_TipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TipoDoc.FormattingEnabled = true;
            this.CB_TipoDoc.Items.AddRange(new object[] {
            "LE",
            "LC",
            "DNI"});
            this.CB_TipoDoc.Location = new System.Drawing.Point(167, 83);
            this.CB_TipoDoc.Name = "CB_TipoDoc";
            this.CB_TipoDoc.Size = new System.Drawing.Size(148, 21);
            this.CB_TipoDoc.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Nombre y Apellido";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(376, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Monto Maximo ($)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(392, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Tipo de Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Localidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Codigo Postal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Domicilio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Numero de Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tipo de Documento";
            // 
            // Bt_GuardarCliente
            // 
            this.Bt_GuardarCliente.Location = new System.Drawing.Point(167, 350);
            this.Bt_GuardarCliente.Name = "Bt_GuardarCliente";
            this.Bt_GuardarCliente.Size = new System.Drawing.Size(148, 41);
            this.Bt_GuardarCliente.TabIndex = 28;
            this.Bt_GuardarCliente.Text = "Guardar";
            this.Bt_GuardarCliente.UseVisualStyleBackColor = true;
            this.Bt_GuardarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // CB_Sexo
            // 
            this.CB_Sexo.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.CB_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Sexo.FormattingEnabled = true;
            this.CB_Sexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.CB_Sexo.Location = new System.Drawing.Point(483, 83);
            this.CB_Sexo.Name = "CB_Sexo";
            this.CB_Sexo.Size = new System.Drawing.Size(148, 21);
            this.CB_Sexo.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(150, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(150, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(150, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(150, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(466, 190);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 13);
            this.label18.TabIndex = 56;
            this.label18.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(466, 218);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(11, 13);
            this.label19.TabIndex = 57;
            this.label19.Text = "*";
            // 
            // TB_NroDocumento
            // 
            this.TB_NroDocumento.Location = new System.Drawing.Point(167, 110);
            this.TB_NroDocumento.Mask = "00000000";
            this.TB_NroDocumento.Name = "TB_NroDocumento";
            this.TB_NroDocumento.Size = new System.Drawing.Size(148, 20);
            this.TB_NroDocumento.TabIndex = 31;
            this.TB_NroDocumento.ValidatingType = typeof(int);
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(167, 163);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(148, 20);
            this.TB_Email.TabIndex = 33;
            // 
            // TB_Celular
            // 
            this.TB_Celular.Location = new System.Drawing.Point(167, 189);
            this.TB_Celular.Mask = "+54 \\9 0000000000";
            this.TB_Celular.Name = "TB_Celular";
            this.TB_Celular.Size = new System.Drawing.Size(148, 20);
            this.TB_Celular.TabIndex = 34;
            // 
            // TB_FechaNac
            // 
            this.TB_FechaNac.Location = new System.Drawing.Point(167, 215);
            this.TB_FechaNac.Mask = "00\\/00\\/0000";
            this.TB_FechaNac.Name = "TB_FechaNac";
            this.TB_FechaNac.Size = new System.Drawing.Size(148, 20);
            this.TB_FechaNac.TabIndex = 35;
            this.TB_FechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // TB_cp
            // 
            this.TB_cp.Location = new System.Drawing.Point(483, 135);
            this.TB_cp.Mask = "0000";
            this.TB_cp.Name = "TB_cp";
            this.TB_cp.Size = new System.Drawing.Size(148, 20);
            this.TB_cp.TabIndex = 38;
            this.TB_cp.ValidatingType = typeof(int);
            // 
            // TB_MontoMax
            // 
            this.TB_MontoMax.Location = new System.Drawing.Point(483, 215);
            this.TB_MontoMax.Mask = "099999999";
            this.TB_MontoMax.Name = "TB_MontoMax";
            this.TB_MontoMax.Size = new System.Drawing.Size(148, 20);
            this.TB_MontoMax.TabIndex = 41;
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(167, 137);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(148, 20);
            this.TB_Nombre.TabIndex = 32;
            // 
            // TB_Domicilio
            // 
            this.TB_Domicilio.Location = new System.Drawing.Point(483, 110);
            this.TB_Domicilio.Name = "TB_Domicilio";
            this.TB_Domicilio.Size = new System.Drawing.Size(148, 20);
            this.TB_Domicilio.TabIndex = 37;
            // 
            // TB_Localidad
            // 
            this.TB_Localidad.Location = new System.Drawing.Point(483, 161);
            this.TB_Localidad.Name = "TB_Localidad";
            this.TB_Localidad.Size = new System.Drawing.Size(148, 20);
            this.TB_Localidad.TabIndex = 39;
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.Location = new System.Drawing.Point(12, 9);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(219, 33);
            this.LBL_Titulo.TabIndex = 58;
            this.LBL_Titulo.Text = "Alta de Clientes";
            // 
            // LBL_ID_Titulo
            // 
            this.LBL_ID_Titulo.AutoSize = true;
            this.LBL_ID_Titulo.Location = new System.Drawing.Point(143, 60);
            this.LBL_ID_Titulo.Name = "LBL_ID_Titulo";
            this.LBL_ID_Titulo.Size = new System.Drawing.Size(18, 13);
            this.LBL_ID_Titulo.TabIndex = 59;
            this.LBL_ID_Titulo.Text = "ID";
            // 
            // LBL_ID
            // 
            this.LBL_ID.AutoSize = true;
            this.LBL_ID.Location = new System.Drawing.Point(167, 60);
            this.LBL_ID.Name = "LBL_ID";
            this.LBL_ID.Size = new System.Drawing.Size(49, 13);
            this.LBL_ID.TabIndex = 60;
            this.LBL_ID.Text = "IDcliente";
            // 
            // F_AltasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 413);
            this.Controls.Add(this.LBL_ID);
            this.Controls.Add(this.LBL_ID_Titulo);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.TB_Localidad);
            this.Controls.Add(this.TB_Domicilio);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.TB_MontoMax);
            this.Controls.Add(this.TB_cp);
            this.Controls.Add(this.TB_FechaNac);
            this.Controls.Add(this.TB_Celular);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.TB_NroDocumento);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CB_Sexo);
            this.Controls.Add(this.CB_TipoCliente);
            this.Controls.Add(this.CB_TipoDoc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_GuardarCliente);
            this.Name = "F_AltasClientes";
            this.Text = "Alta de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_TipoCliente;
        private System.Windows.Forms.ComboBox CB_TipoDoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_GuardarCliente;
        private System.Windows.Forms.ComboBox CB_Sexo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox TB_NroDocumento;
        private System.Windows.Forms.MaskedTextBox TB_Email;
        private System.Windows.Forms.MaskedTextBox TB_Celular;
        private System.Windows.Forms.MaskedTextBox TB_FechaNac;
        private System.Windows.Forms.MaskedTextBox TB_cp;
        private System.Windows.Forms.MaskedTextBox TB_MontoMax;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_Domicilio;
        private System.Windows.Forms.TextBox TB_Localidad;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.Label LBL_ID_Titulo;
        private System.Windows.Forms.Label LBL_ID;
    }
}