namespace WinForm
{
    partial class F_GrillaPrestamos
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
            this.BT_NuevoPrestamo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GrillaPrestamos = new System.Windows.Forms.DataGridView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.CB_TipoCliente = new System.Windows.Forms.ComboBox();
            this.TB_Busqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_NuevoPrestamo
            // 
            this.BT_NuevoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_NuevoPrestamo.Location = new System.Drawing.Point(532, 9);
            this.BT_NuevoPrestamo.Name = "BT_NuevoPrestamo";
            this.BT_NuevoPrestamo.Size = new System.Drawing.Size(190, 36);
            this.BT_NuevoPrestamo.TabIndex = 5;
            this.BT_NuevoPrestamo.Text = "Nuevo Préstamo";
            this.BT_NuevoPrestamo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listado de Préstamos";
            // 
            // GrillaPrestamos
            // 
            this.GrillaPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaPrestamos.Location = new System.Drawing.Point(12, 140);
            this.GrillaPrestamos.Name = "GrillaPrestamos";
            this.GrillaPrestamos.Size = new System.Drawing.Size(710, 298);
            this.GrillaPrestamos.TabIndex = 3;
            this.GrillaPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaPrestamos_CellContentClick);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Tipo de cliente",
            "Entre dos fechas",
            "Buscar por nombre"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 75);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(141, 55);
            this.checkedListBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filtrar";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(159, 98);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // CB_TipoCliente
            // 
            this.CB_TipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_TipoCliente.FormattingEnabled = true;
            this.CB_TipoCliente.Items.AddRange(new object[] {
            "Regular",
            "VIP"});
            this.CB_TipoCliente.Location = new System.Drawing.Point(159, 75);
            this.CB_TipoCliente.Name = "CB_TipoCliente";
            this.CB_TipoCliente.Size = new System.Drawing.Size(121, 24);
            this.CB_TipoCliente.TabIndex = 10;
            // 
            // TB_Busqueda
            // 
            this.TB_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Busqueda.Location = new System.Drawing.Point(159, 75);
            this.TB_Busqueda.Name = "TB_Busqueda";
            this.TB_Busqueda.Size = new System.Drawing.Size(100, 22);
            this.TB_Busqueda.TabIndex = 11;
            // 
            // F_GrillaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_Busqueda);
            this.Controls.Add(this.CB_TipoCliente);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.BT_NuevoPrestamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrillaPrestamos);
            this.Name = "F_GrillaPrestamos";
            this.Text = "Reporte de créditos y registro de pagos";
            this.Load += new System.EventHandler(this.F_GrillaPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_NuevoPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrillaPrestamos;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox CB_TipoCliente;
        private System.Windows.Forms.TextBox TB_Busqueda;
    }
}