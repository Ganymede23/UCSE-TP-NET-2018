namespace WinForm
{
    partial class F_RegistrosPagos
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
            this.GrillaRegistrosPagos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaRegistrosPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaRegistrosPagos
            // 
            this.GrillaRegistrosPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaRegistrosPagos.Location = new System.Drawing.Point(12, 51);
            this.GrillaRegistrosPagos.Name = "GrillaRegistrosPagos";
            this.GrillaRegistrosPagos.Size = new System.Drawing.Size(710, 298);
            this.GrillaRegistrosPagos.TabIndex = 0;
            this.GrillaRegistrosPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaRegistrosPagos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registro de Pagos";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "ATENCION\r\nAquí solo se visualizan préstamos con cuotas pendientes de ser pagadas." +
    "";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_RegistrosPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrillaRegistrosPagos);
            this.Name = "F_RegistrosPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Pagos";
            this.Load += new System.EventHandler(this.F_RegistrosPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaRegistrosPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaRegistrosPagos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}