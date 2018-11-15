namespace WinForm
{
    partial class F_AltasPrestamos
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
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_GuardarPrestamo = new System.Windows.Forms.Button();
            this.borde1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.LB_Cliente_Nombre = new System.Windows.Forms.Label();
            this.LB_Cliente_Doc = new System.Windows.Forms.Label();
            this.LB_Cliente_Email = new System.Windows.Forms.Label();
            this.LB_Cliente_MontoMax = new System.Windows.Forms.Label();
            this.LB_Cliente_Tipo = new System.Windows.Forms.Label();
            this.LB_Cliente_ID = new System.Windows.Forms.Label();
            this.LBL_Fecha = new System.Windows.Forms.Label();
            this.TB_MontoCredito = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_CantidadCuotas = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_MontoTotal = new System.Windows.Forms.Label();
            this.LBL_MontoCuota = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.LBL_Tasa = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_Comercio = new System.Windows.Forms.ComboBox();
            this.CB_Cliente = new System.Windows.Forms.ComboBox();
            this.CB_Sucursal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.Location = new System.Drawing.Point(12, 9);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(252, 31);
            this.LBL_Titulo.TabIndex = 93;
            this.LBL_Titulo.Text = "Alta de Préstamos";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(172, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 16);
            this.label16.TabIndex = 89;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(172, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 16);
            this.label15.TabIndex = 88;
            this.label15.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(97, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 86;
            this.label13.Text = "ID Sucursal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "ID Comercio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Fecha";
            // 
            // BT_GuardarPrestamo
            // 
            this.BT_GuardarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_GuardarPrestamo.Location = new System.Drawing.Point(356, 278);
            this.BT_GuardarPrestamo.Name = "BT_GuardarPrestamo";
            this.BT_GuardarPrestamo.Size = new System.Drawing.Size(257, 36);
            this.BT_GuardarPrestamo.TabIndex = 120;
            this.BT_GuardarPrestamo.Text = "Guardar Préstamo";
            this.BT_GuardarPrestamo.UseVisualStyleBackColor = true;
            this.BT_GuardarPrestamo.Click += new System.EventHandler(this.BT_GuardarPrestamo_Click);
            // 
            // borde1
            // 
            this.borde1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.borde1.Location = new System.Drawing.Point(356, 53);
            this.borde1.Name = "borde1";
            this.borde1.Size = new System.Drawing.Size(257, 211);
            this.borde1.TabIndex = 96;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(364, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(131, 20);
            this.label20.TabIndex = 97;
            this.label20.Text = "Datos del cliente:";
            // 
            // LB_Cliente_Nombre
            // 
            this.LB_Cliente_Nombre.AutoSize = true;
            this.LB_Cliente_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Cliente_Nombre.Location = new System.Drawing.Point(365, 160);
            this.LB_Cliente_Nombre.Name = "LB_Cliente_Nombre";
            this.LB_Cliente_Nombre.Size = new System.Drawing.Size(54, 16);
            this.LB_Cliente_Nombre.TabIndex = 99;
            this.LB_Cliente_Nombre.Text = "nombre";
            // 
            // LB_Cliente_Doc
            // 
            this.LB_Cliente_Doc.AutoSize = true;
            this.LB_Cliente_Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Cliente_Doc.Location = new System.Drawing.Point(365, 133);
            this.LB_Cliente_Doc.Name = "LB_Cliente_Doc";
            this.LB_Cliente_Doc.Size = new System.Drawing.Size(75, 16);
            this.LB_Cliente_Doc.TabIndex = 100;
            this.LB_Cliente_Doc.Text = "documento";
            // 
            // LB_Cliente_Email
            // 
            this.LB_Cliente_Email.AutoSize = true;
            this.LB_Cliente_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Cliente_Email.Location = new System.Drawing.Point(365, 186);
            this.LB_Cliente_Email.Name = "LB_Cliente_Email";
            this.LB_Cliente_Email.Size = new System.Drawing.Size(41, 16);
            this.LB_Cliente_Email.TabIndex = 101;
            this.LB_Cliente_Email.Text = "email";
            // 
            // LB_Cliente_MontoMax
            // 
            this.LB_Cliente_MontoMax.AutoSize = true;
            this.LB_Cliente_MontoMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Cliente_MontoMax.Location = new System.Drawing.Point(365, 238);
            this.LB_Cliente_MontoMax.Name = "LB_Cliente_MontoMax";
            this.LB_Cliente_MontoMax.Size = new System.Drawing.Size(70, 16);
            this.LB_Cliente_MontoMax.TabIndex = 103;
            this.LB_Cliente_MontoMax.Text = "montomax";
            // 
            // LB_Cliente_Tipo
            // 
            this.LB_Cliente_Tipo.AutoSize = true;
            this.LB_Cliente_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Cliente_Tipo.Location = new System.Drawing.Point(365, 212);
            this.LB_Cliente_Tipo.Name = "LB_Cliente_Tipo";
            this.LB_Cliente_Tipo.Size = new System.Drawing.Size(30, 16);
            this.LB_Cliente_Tipo.TabIndex = 102;
            this.LB_Cliente_Tipo.Text = "tipo";
            // 
            // LB_Cliente_ID
            // 
            this.LB_Cliente_ID.AutoSize = true;
            this.LB_Cliente_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Cliente_ID.Location = new System.Drawing.Point(365, 106);
            this.LB_Cliente_ID.Name = "LB_Cliente_ID";
            this.LB_Cliente_ID.Size = new System.Drawing.Size(19, 16);
            this.LB_Cliente_ID.TabIndex = 104;
            this.LB_Cliente_ID.Text = "id";
            // 
            // LBL_Fecha
            // 
            this.LBL_Fecha.AutoSize = true;
            this.LBL_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Fecha.Location = new System.Drawing.Point(189, 56);
            this.LBL_Fecha.Name = "LBL_Fecha";
            this.LBL_Fecha.Size = new System.Drawing.Size(80, 16);
            this.LBL_Fecha.TabIndex = 106;
            this.LBL_Fecha.Text = "fecha actual";
            // 
            // TB_MontoCredito
            // 
            this.TB_MontoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_MontoCredito.Location = new System.Drawing.Point(189, 161);
            this.TB_MontoCredito.Mask = "099999999";
            this.TB_MontoCredito.Name = "TB_MontoCredito";
            this.TB_MontoCredito.Size = new System.Drawing.Size(148, 22);
            this.TB_MontoCredito.TabIndex = 107;
            this.TB_MontoCredito.TextChanged += new System.EventHandler(this.TB_MontoCredito_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(170, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 16);
            this.label6.TabIndex = 109;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 108;
            this.label7.Text = "Monto del Crédito ($)";
            // 
            // TB_CantidadCuotas
            // 
            this.TB_CantidadCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CantidadCuotas.Location = new System.Drawing.Point(189, 189);
            this.TB_CantidadCuotas.Mask = "099999999";
            this.TB_CantidadCuotas.Name = "TB_CantidadCuotas";
            this.TB_CantidadCuotas.Size = new System.Drawing.Size(148, 22);
            this.TB_CantidadCuotas.TabIndex = 118;
            this.TB_CantidadCuotas.TextChanged += new System.EventHandler(this.TB_CantidadCuotas_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(170, 192);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 16);
            this.label22.TabIndex = 120;
            this.label22.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(47, 192);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(124, 16);
            this.label23.TabIndex = 119;
            this.label23.Text = "Cantidad de cuotas";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(43, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 95);
            this.label4.TabIndex = 125;
            // 
            // LBL_MontoTotal
            // 
            this.LBL_MontoTotal.AutoSize = true;
            this.LBL_MontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MontoTotal.Location = new System.Drawing.Point(189, 257);
            this.LBL_MontoTotal.Name = "LBL_MontoTotal";
            this.LBL_MontoTotal.Size = new System.Drawing.Size(73, 16);
            this.LBL_MontoTotal.TabIndex = 131;
            this.LBL_MontoTotal.Text = "monto total";
            // 
            // LBL_MontoCuota
            // 
            this.LBL_MontoCuota.AutoSize = true;
            this.LBL_MontoCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MontoCuota.Location = new System.Drawing.Point(189, 283);
            this.LBL_MontoCuota.Name = "LBL_MontoCuota";
            this.LBL_MontoCuota.Size = new System.Drawing.Size(81, 16);
            this.LBL_MontoCuota.TabIndex = 130;
            this.LBL_MontoCuota.Text = "monto cuota";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(65, 283);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(118, 16);
            this.label21.TabIndex = 129;
            this.label21.Text = "Monto de cuota ($)";
            // 
            // LBL_Tasa
            // 
            this.LBL_Tasa.AutoSize = true;
            this.LBL_Tasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Tasa.Location = new System.Drawing.Point(189, 231);
            this.LBL_Tasa.Name = "LBL_Tasa";
            this.LBL_Tasa.Size = new System.Drawing.Size(34, 16);
            this.LBL_Tasa.TabIndex = 128;
            this.LBL_Tasa.Text = "tasa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 16);
            this.label9.TabIndex = 127;
            this.label9.Text = "Tasa de Interés (%)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(86, 257);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 16);
            this.label14.TabIndex = 126;
            this.label14.Text = "Monto Total ($)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(172, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 135;
            this.label5.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(108, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 134;
            this.label8.Text = "ID Cliente";
            // 
            // CB_Comercio
            // 
            this.CB_Comercio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Comercio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Comercio.FormattingEnabled = true;
            this.CB_Comercio.Location = new System.Drawing.Point(189, 106);
            this.CB_Comercio.Name = "CB_Comercio";
            this.CB_Comercio.Size = new System.Drawing.Size(148, 24);
            this.CB_Comercio.TabIndex = 105;
            this.CB_Comercio.SelectedIndexChanged += new System.EventHandler(this.CB_Comercio_SelectedIndexChanged);
            // 
            // CB_Cliente
            // 
            this.CB_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Cliente.FormattingEnabled = true;
            this.CB_Cliente.Location = new System.Drawing.Point(189, 78);
            this.CB_Cliente.Name = "CB_Cliente";
            this.CB_Cliente.Size = new System.Drawing.Size(148, 24);
            this.CB_Cliente.TabIndex = 104;
            this.CB_Cliente.SelectedIndexChanged += new System.EventHandler(this.CB_Cliente_SelectedIndexChanged);
            // 
            // CB_Sucursal
            // 
            this.CB_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Sucursal.FormattingEnabled = true;
            this.CB_Sucursal.Location = new System.Drawing.Point(189, 133);
            this.CB_Sucursal.Name = "CB_Sucursal";
            this.CB_Sucursal.Size = new System.Drawing.Size(148, 24);
            this.CB_Sucursal.TabIndex = 106;
            this.CB_Sucursal.SelectedIndexChanged += new System.EventHandler(this.CB_Sucursal_SelectedIndexChanged);
            // 
            // F_AltasPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 328);
            this.Controls.Add(this.CB_Sucursal);
            this.Controls.Add(this.CB_Cliente);
            this.Controls.Add(this.CB_Comercio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LBL_MontoTotal);
            this.Controls.Add(this.LBL_MontoCuota);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.LBL_Tasa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_CantidadCuotas);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.TB_MontoCredito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LBL_Fecha);
            this.Controls.Add(this.LB_Cliente_ID);
            this.Controls.Add(this.LB_Cliente_MontoMax);
            this.Controls.Add(this.LB_Cliente_Tipo);
            this.Controls.Add(this.LB_Cliente_Email);
            this.Controls.Add(this.LB_Cliente_Doc);
            this.Controls.Add(this.LB_Cliente_Nombre);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.borde1);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_GuardarPrestamo);
            this.Name = "F_AltasPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Préstamos";
            this.Load += new System.EventHandler(this.F_AltasPrestamos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_GuardarPrestamo;
        private System.Windows.Forms.Label borde1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label LB_Cliente_Nombre;
        private System.Windows.Forms.Label LB_Cliente_Doc;
        private System.Windows.Forms.Label LB_Cliente_Email;
        private System.Windows.Forms.Label LB_Cliente_MontoMax;
        private System.Windows.Forms.Label LB_Cliente_Tipo;
        private System.Windows.Forms.Label LB_Cliente_ID;
        private System.Windows.Forms.Label LBL_Fecha;
        private System.Windows.Forms.MaskedTextBox TB_MontoCredito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TB_CantidadCuotas;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_MontoTotal;
        private System.Windows.Forms.Label LBL_MontoCuota;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label LBL_Tasa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_Comercio;
        private System.Windows.Forms.ComboBox CB_Cliente;
        private System.Windows.Forms.ComboBox CB_Sucursal;
    }
}