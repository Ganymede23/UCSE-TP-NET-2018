namespace WinForm
{
    partial class F_EfectuarPago
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
            this.BT_RealizarPago = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LBL_Fecha = new System.Windows.Forms.Label();
            this.LBL_Entrega = new System.Windows.Forms.Label();
            this.LBL_Monto = new System.Windows.Forms.Label();
            this.LBL_NroCuota = new System.Windows.Forms.Label();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CB_Lugar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BT_RealizarPago
            // 
            this.BT_RealizarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_RealizarPago.Location = new System.Drawing.Point(18, 206);
            this.BT_RealizarPago.Name = "BT_RealizarPago";
            this.BT_RealizarPago.Size = new System.Drawing.Size(233, 37);
            this.BT_RealizarPago.TabIndex = 0;
            this.BT_RealizarPago.Text = "Realizar Pago";
            this.BT_RealizarPago.UseVisualStyleBackColor = true;
            this.BT_RealizarPago.Click += new System.EventHandler(this.BT_RealizarPago_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(52, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 56;
            this.label13.Text = "Entrega ($)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "Monto ($)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 52;
            this.label11.Text = "Cuota Nro.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 57;
            this.label9.Text = "Lugar de pago";
            // 
            // LBL_Fecha
            // 
            this.LBL_Fecha.AutoSize = true;
            this.LBL_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Fecha.Location = new System.Drawing.Point(131, 140);
            this.LBL_Fecha.Name = "LBL_Fecha";
            this.LBL_Fecha.Size = new System.Drawing.Size(41, 16);
            this.LBL_Fecha.TabIndex = 58;
            this.LBL_Fecha.Text = "fecha";
            // 
            // LBL_Entrega
            // 
            this.LBL_Entrega.AutoSize = true;
            this.LBL_Entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Entrega.Location = new System.Drawing.Point(131, 113);
            this.LBL_Entrega.Name = "LBL_Entrega";
            this.LBL_Entrega.Size = new System.Drawing.Size(22, 16);
            this.LBL_Entrega.TabIndex = 59;
            this.LBL_Entrega.Text = "$$";
            // 
            // LBL_Monto
            // 
            this.LBL_Monto.AutoSize = true;
            this.LBL_Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Monto.Location = new System.Drawing.Point(131, 86);
            this.LBL_Monto.Name = "LBL_Monto";
            this.LBL_Monto.Size = new System.Drawing.Size(22, 16);
            this.LBL_Monto.TabIndex = 60;
            this.LBL_Monto.Text = "$$";
            // 
            // LBL_NroCuota
            // 
            this.LBL_NroCuota.AutoSize = true;
            this.LBL_NroCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NroCuota.Location = new System.Drawing.Point(131, 59);
            this.LBL_NroCuota.Name = "LBL_NroCuota";
            this.LBL_NroCuota.Size = new System.Drawing.Size(27, 16);
            this.LBL_NroCuota.TabIndex = 61;
            this.LBL_NroCuota.Text = "nro";
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.Location = new System.Drawing.Point(12, 9);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(240, 31);
            this.LBL_Titulo.TabIndex = 64;
            this.LBL_Titulo.Text = "Detalles del pago";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(114, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 16);
            this.label15.TabIndex = 65;
            this.label15.Text = "*";
            // 
            // CB_Lugar
            // 
            this.CB_Lugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Lugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Lugar.FormattingEnabled = true;
            this.CB_Lugar.Location = new System.Drawing.Point(129, 163);
            this.CB_Lugar.Name = "CB_Lugar";
            this.CB_Lugar.Size = new System.Drawing.Size(121, 24);
            this.CB_Lugar.TabIndex = 66;
            this.CB_Lugar.SelectedIndexChanged += new System.EventHandler(this.CB_Lugar_SelectedIndexChanged);
            // 
            // F_EfectuarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 257);
            this.Controls.Add(this.CB_Lugar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.LBL_NroCuota);
            this.Controls.Add(this.LBL_Monto);
            this.Controls.Add(this.LBL_Entrega);
            this.Controls.Add(this.LBL_Fecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BT_RealizarPago);
            this.Name = "F_EfectuarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del pago";
            this.Load += new System.EventHandler(this.F_EfectuarPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_RealizarPago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBL_Fecha;
        private System.Windows.Forms.Label LBL_Entrega;
        private System.Windows.Forms.Label LBL_Monto;
        private System.Windows.Forms.Label LBL_NroCuota;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CB_Lugar;
    }
}