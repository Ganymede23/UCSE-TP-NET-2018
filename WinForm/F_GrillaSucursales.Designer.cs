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
            this.BT_NuevaSucursal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaSucursales
            // 
            this.GrillaSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaSucursales.Location = new System.Drawing.Point(12, 51);
            this.GrillaSucursales.Name = "GrillaSucursales";
            this.GrillaSucursales.Size = new System.Drawing.Size(710, 298);
            this.GrillaSucursales.TabIndex = 0;
            // 
            // BT_NuevaSucursal
            // 
            this.BT_NuevaSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_NuevaSucursal.Location = new System.Drawing.Point(532, 9);
            this.BT_NuevaSucursal.Name = "BT_NuevaSucursal";
            this.BT_NuevaSucursal.Size = new System.Drawing.Size(190, 36);
            this.BT_NuevaSucursal.TabIndex = 2;
            this.BT_NuevaSucursal.Text = "Nueva Sucursal";
            this.BT_NuevaSucursal.UseVisualStyleBackColor = true;
            this.BT_NuevaSucursal.Click += new System.EventHandler(this.BT_NuevaSucursal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Listado de Sucursales";
            // 
            // F_GrillaSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_NuevaSucursal);
            this.Controls.Add(this.GrillaSucursales);
            this.Name = "F_GrillaSucursales";
            this.Text = "Listado de Sucursales";
            this.Load += new System.EventHandler(this.F_GrillaSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaSucursales;
        private System.Windows.Forms.Button BT_NuevaSucursal;
        private System.Windows.Forms.Label label1;
    }
}