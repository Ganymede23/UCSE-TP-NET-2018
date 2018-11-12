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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_GuardarCliente = new System.Windows.Forms.Button();
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
            this.TB_cp = new System.Windows.Forms.MaskedTextBox();
            this.TB_MontoMax = new System.Windows.Forms.MaskedTextBox();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_Domicilio = new System.Windows.Forms.TextBox();
            this.TB_Localidad = new System.Windows.Forms.TextBox();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.LBL_ID_Titulo = new System.Windows.Forms.Label();
            this.LBL_ID = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CB_TipoCliente
            // 
            this.CB_TipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_TipoCliente.FormattingEnabled = true;
            this.CB_TipoCliente.Items.AddRange(new object[] {
            "Regular",
            "VIP"});
            this.CB_TipoCliente.Location = new System.Drawing.Point(484, 180);
            this.CB_TipoCliente.Name = "CB_TipoCliente";
            this.CB_TipoCliente.Size = new System.Drawing.Size(148, 24);
            this.CB_TipoCliente.TabIndex = 40;
            // 
            // CB_TipoDoc
            // 
            this.CB_TipoDoc.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.CB_TipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_TipoDoc.FormattingEnabled = true;
            this.CB_TipoDoc.Items.AddRange(new object[] {
            "LE",
            "LC",
            "DNI"});
            this.CB_TipoDoc.Location = new System.Drawing.Point(189, 76);
            this.CB_TipoDoc.Name = "CB_TipoDoc";
            this.CB_TipoDoc.Size = new System.Drawing.Size(148, 24);
            this.CB_TipoDoc.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(53, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 16);
            this.label13.TabIndex = 51;
            this.label13.Text = "Nombre y Apellido";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(353, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "Monto Maximo ($)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(367, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "Tipo de Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(410, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Localidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(385, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Codigo Postal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(414, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Domicilio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(439, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Numero de Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tipo de Documento";
            // 
            // BT_GuardarCliente
            // 
            this.BT_GuardarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_GuardarCliente.Location = new System.Drawing.Point(484, 236);
            this.BT_GuardarCliente.Name = "BT_GuardarCliente";
            this.BT_GuardarCliente.Size = new System.Drawing.Size(148, 41);
            this.BT_GuardarCliente.TabIndex = 28;
            this.BT_GuardarCliente.Text = "Guardar";
            this.BT_GuardarCliente.UseVisualStyleBackColor = true;
            this.BT_GuardarCliente.Click += new System.EventHandler(this.BT_GuardarCliente_Click);
            // 
            // CB_Sexo
            // 
            this.CB_Sexo.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.CB_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Sexo.FormattingEnabled = true;
            this.CB_Sexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.CB_Sexo.Location = new System.Drawing.Point(484, 76);
            this.CB_Sexo.Name = "CB_Sexo";
            this.CB_Sexo.Size = new System.Drawing.Size(148, 24);
            this.CB_Sexo.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(172, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 16);
            this.label14.TabIndex = 52;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(172, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 16);
            this.label15.TabIndex = 53;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(172, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 16);
            this.label16.TabIndex = 54;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(172, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 16);
            this.label17.TabIndex = 55;
            this.label17.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(465, 183);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 16);
            this.label18.TabIndex = 56;
            this.label18.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(465, 211);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 16);
            this.label19.TabIndex = 57;
            this.label19.Text = "*";
            // 
            // TB_NroDocumento
            // 
            this.TB_NroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NroDocumento.Location = new System.Drawing.Point(189, 103);
            this.TB_NroDocumento.Mask = "00000000";
            this.TB_NroDocumento.Name = "TB_NroDocumento";
            this.TB_NroDocumento.Size = new System.Drawing.Size(148, 22);
            this.TB_NroDocumento.TabIndex = 31;
            // 
            // TB_Email
            // 
            this.TB_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Email.Location = new System.Drawing.Point(189, 156);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(148, 22);
            this.TB_Email.TabIndex = 33;
            this.TB_Email.Leave += new System.EventHandler(this.TB_Email_Leave);
            // 
            // TB_Celular
            // 
            this.TB_Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Celular.Location = new System.Drawing.Point(189, 182);
            this.TB_Celular.Mask = "+54 \\9 0000000000";
            this.TB_Celular.Name = "TB_Celular";
            this.TB_Celular.Size = new System.Drawing.Size(148, 22);
            this.TB_Celular.TabIndex = 34;
            // 
            // TB_cp
            // 
            this.TB_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_cp.Location = new System.Drawing.Point(484, 128);
            this.TB_cp.Mask = "0000";
            this.TB_cp.Name = "TB_cp";
            this.TB_cp.Size = new System.Drawing.Size(148, 22);
            this.TB_cp.TabIndex = 38;
            this.TB_cp.ValidatingType = typeof(int);
            // 
            // TB_MontoMax
            // 
            this.TB_MontoMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_MontoMax.Location = new System.Drawing.Point(484, 208);
            this.TB_MontoMax.Mask = "099999999";
            this.TB_MontoMax.Name = "TB_MontoMax";
            this.TB_MontoMax.Size = new System.Drawing.Size(148, 22);
            this.TB_MontoMax.TabIndex = 41;
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nombre.Location = new System.Drawing.Point(189, 130);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(148, 22);
            this.TB_Nombre.TabIndex = 32;
            // 
            // TB_Domicilio
            // 
            this.TB_Domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Domicilio.Location = new System.Drawing.Point(484, 103);
            this.TB_Domicilio.Name = "TB_Domicilio";
            this.TB_Domicilio.Size = new System.Drawing.Size(148, 22);
            this.TB_Domicilio.TabIndex = 37;
            // 
            // TB_Localidad
            // 
            this.TB_Localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Localidad.Location = new System.Drawing.Point(484, 154);
            this.TB_Localidad.Name = "TB_Localidad";
            this.TB_Localidad.Size = new System.Drawing.Size(148, 22);
            this.TB_Localidad.TabIndex = 39;
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.Location = new System.Drawing.Point(12, 9);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(220, 31);
            this.LBL_Titulo.TabIndex = 58;
            this.LBL_Titulo.Text = "Alta de Clientes";
            // 
            // LBL_ID_Titulo
            // 
            this.LBL_ID_Titulo.AutoSize = true;
            this.LBL_ID_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ID_Titulo.Location = new System.Drawing.Point(165, 53);
            this.LBL_ID_Titulo.Name = "LBL_ID_Titulo";
            this.LBL_ID_Titulo.Size = new System.Drawing.Size(21, 16);
            this.LBL_ID_Titulo.TabIndex = 59;
            this.LBL_ID_Titulo.Text = "ID";
            // 
            // LBL_ID
            // 
            this.LBL_ID.AutoSize = true;
            this.LBL_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ID.Location = new System.Drawing.Point(189, 53);
            this.LBL_ID.Name = "LBL_ID";
            this.LBL_ID.Size = new System.Drawing.Size(60, 16);
            this.LBL_ID.TabIndex = 60;
            this.LBL_ID.Text = "IDcliente";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 208);
            this.dateTimePicker1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 22);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // F_AltasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 288);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LBL_ID);
            this.Controls.Add(this.LBL_ID_Titulo);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.TB_Localidad);
            this.Controls.Add(this.TB_Domicilio);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.TB_MontoMax);
            this.Controls.Add(this.TB_cp);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_GuardarCliente);
            this.Name = "F_AltasClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Clientes";
            this.Load += new System.EventHandler(this.F_AltasClientes_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_GuardarCliente;
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
        private System.Windows.Forms.MaskedTextBox TB_cp;
        private System.Windows.Forms.MaskedTextBox TB_MontoMax;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_Domicilio;
        private System.Windows.Forms.TextBox TB_Localidad;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.Label LBL_ID_Titulo;
        private System.Windows.Forms.Label LBL_ID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}