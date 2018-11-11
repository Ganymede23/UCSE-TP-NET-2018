namespace WinForm
{
    partial class F_GrillaComercios
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
            this.BT_NuevoComercio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GrillaComercios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaComercios)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_NuevoComercio
            // 
            this.BT_NuevoComercio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_NuevoComercio.Location = new System.Drawing.Point(532, 9);
            this.BT_NuevoComercio.Name = "BT_NuevoComercio";
            this.BT_NuevoComercio.Size = new System.Drawing.Size(190, 36);
            this.BT_NuevoComercio.TabIndex = 5;
            this.BT_NuevoComercio.Text = "Nuevo Comercio";
            this.BT_NuevoComercio.UseVisualStyleBackColor = true;
            this.BT_NuevoComercio.Click += new System.EventHandler(this.BT_NuevoComercio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listado de Comercios";
            // 
            // GrillaComercios
            // 
            this.GrillaComercios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaComercios.Location = new System.Drawing.Point(12, 51);
            this.GrillaComercios.Name = "GrillaComercios";
            this.GrillaComercios.Size = new System.Drawing.Size(710, 298);
            this.GrillaComercios.TabIndex = 3;
            this.GrillaComercios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaComercios_CellContentClick);
            // 
            // F_GrillaComercios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.BT_NuevoComercio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrillaComercios);
            this.Name = "F_GrillaComercios";
            this.Text = "Listado de Comercios";
            this.Load += new System.EventHandler(this.F_GrillaComercios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaComercios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_NuevoComercio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrillaComercios;
    }
}