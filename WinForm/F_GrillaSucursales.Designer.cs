namespace WinForm
{
    partial class F_GrillaSucursales
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
            this.GrillaSucursales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_NuevaSucursal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaSucursales
            // 
            this.GrillaSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaSucursales.Location = new System.Drawing.Point(12, 68);
            this.GrillaSucursales.Name = "GrillaSucursales";
            this.GrillaSucursales.Size = new System.Drawing.Size(571, 261);
            this.GrillaSucursales.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado De Sucursales";
            // 
            // BT_NuevaSucursal
            // 
            this.BT_NuevaSucursal.Location = new System.Drawing.Point(431, 21);
            this.BT_NuevaSucursal.Name = "BT_NuevaSucursal";
            this.BT_NuevaSucursal.Size = new System.Drawing.Size(151, 31);
            this.BT_NuevaSucursal.TabIndex = 2;
            this.BT_NuevaSucursal.Text = "Nueva Sucursal";
            this.BT_NuevaSucursal.UseVisualStyleBackColor = true;
            // 
            // F_GrillaSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 373);
            this.Controls.Add(this.BT_NuevaSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrillaSucursales);
            this.Name = "F_GrillaSucursales";
            this.Text = "F_GrillaSucursales";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaSucursales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_NuevaSucursal;
    }
}