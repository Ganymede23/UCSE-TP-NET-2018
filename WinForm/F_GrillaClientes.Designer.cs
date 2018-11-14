namespace WinForm
{
    partial class F_GrillaClientes
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
            this.GrillaClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_NuevoCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaClientes
            // 
            this.GrillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaClientes.Location = new System.Drawing.Point(12, 51);
            this.GrillaClientes.Name = "GrillaClientes";
            this.GrillaClientes.ReadOnly = true;
            this.GrillaClientes.Size = new System.Drawing.Size(710, 298);
            this.GrillaClientes.TabIndex = 0;
            this.GrillaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaClientes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Clientes";
            // 
            // BT_NuevoCliente
            // 
            this.BT_NuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_NuevoCliente.Location = new System.Drawing.Point(532, 9);
            this.BT_NuevoCliente.Name = "BT_NuevoCliente";
            this.BT_NuevoCliente.Size = new System.Drawing.Size(190, 36);
            this.BT_NuevoCliente.TabIndex = 2;
            this.BT_NuevoCliente.Text = "Nuevo Cliente";
            this.BT_NuevoCliente.UseVisualStyleBackColor = true;
            this.BT_NuevoCliente.Click += new System.EventHandler(this.BT_NuevoCliente_Click);
            // 
            // F_GrillaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.BT_NuevoCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrillaClientes);
            this.Name = "F_GrillaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.F_GrillaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_NuevoCliente;
    }
}