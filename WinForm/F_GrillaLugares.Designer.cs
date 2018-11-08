namespace WinForm
{
    partial class F_GrillaLugares
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
            this.BT_NuevoLugar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GrillaLugares = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLugares)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_NuevoLugar
            // 
            this.BT_NuevoLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_NuevoLugar.Location = new System.Drawing.Point(532, 9);
            this.BT_NuevoLugar.Name = "BT_NuevoLugar";
            this.BT_NuevoLugar.Size = new System.Drawing.Size(190, 36);
            this.BT_NuevoLugar.TabIndex = 5;
            this.BT_NuevoLugar.Text = "Nuevo Lugar de Pago";
            this.BT_NuevoLugar.UseVisualStyleBackColor = true;
            this.BT_NuevoLugar.Click += new System.EventHandler(this.BT_NuevoLugar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listado de Lugares de Pago";
            // 
            // GrillaLugares
            // 
            this.GrillaLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaLugares.Location = new System.Drawing.Point(15, 52);
            this.GrillaLugares.Name = "GrillaLugares";
            this.GrillaLugares.Size = new System.Drawing.Size(707, 297);
            this.GrillaLugares.TabIndex = 3;
            this.GrillaLugares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaLugares_CellContentClick);
            // 
            // F_GrillaLugares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.BT_NuevoLugar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrillaLugares);
            this.Name = "F_GrillaLugares";
            this.Text = "Listado de Lugares de Pago";
            this.Load += new System.EventHandler(this.F_GrillaLugares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLugares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_NuevoLugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrillaLugares;
    }
}