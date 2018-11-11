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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_LugarPago = new System.Windows.Forms.MaskedTextBox();
            this.LBL_Entrega = new System.Windows.Forms.Label();
            this.LBL_Fecha = new System.Windows.Forms.Label();
            this.LBL_NroCuota = new System.Windows.Forms.Label();
            this.LBL_Monto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_RealizarPago
            // 
            this.BT_RealizarPago.Location = new System.Drawing.Point(162, 237);
            this.BT_RealizarPago.Name = "BT_RealizarPago";
            this.BT_RealizarPago.Size = new System.Drawing.Size(213, 52);
            this.BT_RealizarPago.TabIndex = 0;
            this.BT_RealizarPago.Text = "Realizar Pago";
            this.BT_RealizarPago.UseVisualStyleBackColor = true;
            this.BT_RealizarPago.Click += new System.EventHandler(this.BT_RealizarPago_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(181, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lugar de Pago";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(170, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detalles";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(181, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NroCuota";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(162, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 172);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(181, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Monto ";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(181, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Entrega";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(181, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha";
            // 
            // TB_LugarPago
            // 
            this.TB_LugarPago.Location = new System.Drawing.Point(264, 185);
            this.TB_LugarPago.Name = "TB_LugarPago";
            this.TB_LugarPago.Size = new System.Drawing.Size(87, 20);
            this.TB_LugarPago.TabIndex = 8;
            // 
            // LBL_Entrega
            // 
            this.LBL_Entrega.Location = new System.Drawing.Point(261, 134);
            this.LBL_Entrega.Name = "LBL_Entrega";
            this.LBL_Entrega.Size = new System.Drawing.Size(57, 13);
            this.LBL_Entrega.TabIndex = 11;
            this.LBL_Entrega.Text = "label10";
            // 
            // LBL_Fecha
            // 
            this.LBL_Fecha.Location = new System.Drawing.Point(261, 160);
            this.LBL_Fecha.Name = "LBL_Fecha";
            this.LBL_Fecha.Size = new System.Drawing.Size(41, 13);
            this.LBL_Fecha.TabIndex = 12;
            this.LBL_Fecha.Text = "label11";
            // 
            // LBL_NroCuota
            // 
            this.LBL_NroCuota.Location = new System.Drawing.Point(261, 84);
            this.LBL_NroCuota.Name = "LBL_NroCuota";
            this.LBL_NroCuota.Size = new System.Drawing.Size(57, 13);
            this.LBL_NroCuota.TabIndex = 13;
            this.LBL_NroCuota.Text = "label8";
            // 
            // LBL_Monto
            // 
            this.LBL_Monto.Location = new System.Drawing.Point(261, 108);
            this.LBL_Monto.Name = "LBL_Monto";
            this.LBL_Monto.Size = new System.Drawing.Size(57, 13);
            this.LBL_Monto.TabIndex = 14;
            this.LBL_Monto.Text = "label9";
            // 
            // F_EfectuarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 323);
            this.Controls.Add(this.LBL_Monto);
            this.Controls.Add(this.LBL_NroCuota);
            this.Controls.Add(this.LBL_Fecha);
            this.Controls.Add(this.LBL_Entrega);
            this.Controls.Add(this.TB_LugarPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_RealizarPago);
            this.Controls.Add(this.label4);
            this.Name = "F_EfectuarPago";
            this.Text = "F_DetallesDelPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_RealizarPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TB_LugarPago;
        private System.Windows.Forms.Label LBL_Entrega;
        private System.Windows.Forms.Label LBL_Fecha;
        private System.Windows.Forms.Label LBL_NroCuota;
        private System.Windows.Forms.Label LBL_Monto;
    }
}