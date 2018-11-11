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
            ((System.ComponentModel.ISupportInitialize)(this.GrillaRegistrosPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaRegistrosPagos
            // 
            this.GrillaRegistrosPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaRegistrosPagos.Location = new System.Drawing.Point(29, 86);
            this.GrillaRegistrosPagos.Name = "GrillaRegistrosPagos";
            this.GrillaRegistrosPagos.Size = new System.Drawing.Size(703, 230);
            this.GrillaRegistrosPagos.TabIndex = 0;
            this.GrillaRegistrosPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaRegistrosPagos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registros de Pagos";
            // 
            // F_RegistrosPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrillaRegistrosPagos);
            this.Name = "F_RegistrosPagos";
            this.Text = "F_RegistrosPagos";
            this.Load += new System.EventHandler(this.F_RegistrosPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaRegistrosPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaRegistrosPagos;
        private System.Windows.Forms.Label label1;
    }
}