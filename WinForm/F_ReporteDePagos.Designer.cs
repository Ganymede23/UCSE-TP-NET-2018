namespace WinForm
{
    partial class F_ReporteDePagos
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
            this.label13 = new System.Windows.Forms.Label();
            this.LBL_MontoPrestado = new System.Windows.Forms.Label();
            this.LBL_TasaInteres = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_CuotasPagadas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBL_Resultado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.Location = new System.Drawing.Point(12, 9);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(248, 31);
            this.LBL_Titulo.TabIndex = 115;
            this.LBL_Titulo.Text = "Reporte de Pagos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(58, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 16);
            this.label13.TabIndex = 113;
            this.label13.Text = "Monto total prestado";
            // 
            // LBL_MontoPrestado
            // 
            this.LBL_MontoPrestado.AutoSize = true;
            this.LBL_MontoPrestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MontoPrestado.ForeColor = System.Drawing.Color.Red;
            this.LBL_MontoPrestado.Location = new System.Drawing.Point(194, 59);
            this.LBL_MontoPrestado.Name = "LBL_MontoPrestado";
            this.LBL_MontoPrestado.Size = new System.Drawing.Size(84, 16);
            this.LBL_MontoPrestado.TabIndex = 118;
            this.LBL_MontoPrestado.Text = "monto total";
            // 
            // LBL_TasaInteres
            // 
            this.LBL_TasaInteres.AutoSize = true;
            this.LBL_TasaInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TasaInteres.Location = new System.Drawing.Point(194, 87);
            this.LBL_TasaInteres.Name = "LBL_TasaInteres";
            this.LBL_TasaInteres.Size = new System.Drawing.Size(108, 16);
            this.LBL_TasaInteres.TabIndex = 120;
            this.LBL_TasaInteres.Text = "tasa promedio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 119;
            this.label3.Text = "Tasa de interés promedio";
            // 
            // LBL_CuotasPagadas
            // 
            this.LBL_CuotasPagadas.AutoSize = true;
            this.LBL_CuotasPagadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CuotasPagadas.ForeColor = System.Drawing.Color.Green;
            this.LBL_CuotasPagadas.Location = new System.Drawing.Point(194, 116);
            this.LBL_CuotasPagadas.Name = "LBL_CuotasPagadas";
            this.LBL_CuotasPagadas.Size = new System.Drawing.Size(54, 16);
            this.LBL_CuotasPagadas.TabIndex = 122;
            this.LBL_CuotasPagadas.Text = "cuotas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 121;
            this.label5.Text = "Total de cuotas cobradas";
            // 
            // LBL_Resultado
            // 
            this.LBL_Resultado.AutoSize = true;
            this.LBL_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Resultado.Location = new System.Drawing.Point(194, 158);
            this.LBL_Resultado.Name = "LBL_Resultado";
            this.LBL_Resultado.Size = new System.Drawing.Size(73, 16);
            this.LBL_Resultado.TabIndex = 124;
            this.LBL_Resultado.Text = "resultado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 123;
            this.label7.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(18, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 1);
            this.label1.TabIndex = 125;
            // 
            // F_ReporteDePagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_Resultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LBL_CuotasPagadas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBL_TasaInteres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBL_MontoPrestado);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.label13);
            this.Name = "F_ReporteDePagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Pagos";
            this.Load += new System.EventHandler(this.F_ReporteDePagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LBL_MontoPrestado;
        private System.Windows.Forms.Label LBL_TasaInteres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_CuotasPagadas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBL_Resultado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}