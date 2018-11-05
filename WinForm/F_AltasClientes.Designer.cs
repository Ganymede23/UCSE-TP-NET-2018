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
            this.TB_MontoMax = new System.Windows.Forms.TextBox();
            this.TB_localidad = new System.Windows.Forms.TextBox();
            this.TB_cp = new System.Windows.Forms.TextBox();
            this.TB_domicilio = new System.Windows.Forms.TextBox();
            this.TB_FechaNac = new System.Windows.Forms.TextBox();
            this.TB_celular = new System.Windows.Forms.TextBox();
            this.TB_email = new System.Windows.Forms.TextBox();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_NroDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_GuardarCliente = new System.Windows.Forms.Button();
            this.CB_Sexo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CB_TipoCliente
            // 
            this.CB_TipoCliente.FormattingEnabled = true;
            this.CB_TipoCliente.Items.AddRange(new object[] {
            "Regular",
            "VIP"});
            this.CB_TipoCliente.Location = new System.Drawing.Point(182, 306);
            this.CB_TipoCliente.Name = "CB_TipoCliente";
            this.CB_TipoCliente.Size = new System.Drawing.Size(148, 21);
            this.CB_TipoCliente.TabIndex = 53;
            // 
            // CB_TipoDoc
            // 
            this.CB_TipoDoc.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.CB_TipoDoc.FormattingEnabled = true;
            this.CB_TipoDoc.Items.AddRange(new object[] {
            "LE",
            "LC",
            "DNI"});
            this.CB_TipoDoc.Location = new System.Drawing.Point(182, 41);
            this.CB_TipoDoc.Name = "CB_TipoDoc";
            this.CB_TipoDoc.Size = new System.Drawing.Size(148, 21);
            this.CB_TipoDoc.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "*Nombre y Apellido";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "*Monto Maximo ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "*Tipo de Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Localidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Codigo Postal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Domicilio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "*Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 41;
            // 
            // TB_MontoMax
            // 
            this.TB_MontoMax.Location = new System.Drawing.Point(182, 333);
            this.TB_MontoMax.Name = "TB_MontoMax";
            this.TB_MontoMax.Size = new System.Drawing.Size(148, 20);
            this.TB_MontoMax.TabIndex = 40;
            // 
            // TB_localidad
            // 
            this.TB_localidad.Location = new System.Drawing.Point(182, 280);
            this.TB_localidad.Name = "TB_localidad";
            this.TB_localidad.Size = new System.Drawing.Size(148, 20);
            this.TB_localidad.TabIndex = 39;
            // 
            // TB_cp
            // 
            this.TB_cp.Location = new System.Drawing.Point(182, 254);
            this.TB_cp.Name = "TB_cp";
            this.TB_cp.Size = new System.Drawing.Size(148, 20);
            this.TB_cp.TabIndex = 38;
            // 
            // TB_domicilio
            // 
            this.TB_domicilio.Location = new System.Drawing.Point(182, 228);
            this.TB_domicilio.Name = "TB_domicilio";
            this.TB_domicilio.Size = new System.Drawing.Size(148, 20);
            this.TB_domicilio.TabIndex = 37;
            // 
            // TB_FechaNac
            // 
            this.TB_FechaNac.Location = new System.Drawing.Point(182, 176);
            this.TB_FechaNac.Name = "TB_FechaNac";
            this.TB_FechaNac.Size = new System.Drawing.Size(148, 20);
            this.TB_FechaNac.TabIndex = 35;
            // 
            // TB_celular
            // 
            this.TB_celular.Location = new System.Drawing.Point(182, 150);
            this.TB_celular.Name = "TB_celular";
            this.TB_celular.Size = new System.Drawing.Size(148, 20);
            this.TB_celular.TabIndex = 34;
            // 
            // TB_email
            // 
            this.TB_email.Location = new System.Drawing.Point(182, 124);
            this.TB_email.Name = "TB_email";
            this.TB_email.Size = new System.Drawing.Size(148, 20);
            this.TB_email.TabIndex = 33;
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(182, 98);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(148, 20);
            this.TB_Nombre.TabIndex = 32;
            // 
            // TB_NroDocumento
            // 
            this.TB_NroDocumento.Location = new System.Drawing.Point(182, 72);
            this.TB_NroDocumento.Name = "TB_NroDocumento";
            this.TB_NroDocumento.Size = new System.Drawing.Size(148, 20);
            this.TB_NroDocumento.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "*Numero de Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "*Tipo de Documento";
            // 
            // Bt_GuardarCliente
            // 
            this.Bt_GuardarCliente.Location = new System.Drawing.Point(40, 374);
            this.Bt_GuardarCliente.Name = "Bt_GuardarCliente";
            this.Bt_GuardarCliente.Size = new System.Drawing.Size(108, 41);
            this.Bt_GuardarCliente.TabIndex = 28;
            this.Bt_GuardarCliente.Text = "Guardar";
            this.Bt_GuardarCliente.UseVisualStyleBackColor = true;
            this.Bt_GuardarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // CB_Sexo
            // 
            this.CB_Sexo.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.CB_Sexo.FormattingEnabled = true;
            this.CB_Sexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.CB_Sexo.Location = new System.Drawing.Point(182, 202);
            this.CB_Sexo.Name = "CB_Sexo";
            this.CB_Sexo.Size = new System.Drawing.Size(148, 21);
            this.CB_Sexo.TabIndex = 54;
            // 
            // F_AltasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 456);
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
            this.Controls.Add(this.TB_MontoMax);
            this.Controls.Add(this.TB_localidad);
            this.Controls.Add(this.TB_cp);
            this.Controls.Add(this.TB_domicilio);
            this.Controls.Add(this.TB_FechaNac);
            this.Controls.Add(this.TB_celular);
            this.Controls.Add(this.TB_email);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.TB_NroDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_GuardarCliente);
            this.Name = "F_AltasClientes";
            this.Text = "F_AltasClientes";
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
        private System.Windows.Forms.TextBox TB_MontoMax;
        private System.Windows.Forms.TextBox TB_localidad;
        private System.Windows.Forms.TextBox TB_cp;
        private System.Windows.Forms.TextBox TB_domicilio;
        private System.Windows.Forms.TextBox TB_FechaNac;
        private System.Windows.Forms.TextBox TB_celular;
        private System.Windows.Forms.TextBox TB_email;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_NroDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_GuardarCliente;
        private System.Windows.Forms.ComboBox CB_Sexo;
    }
}