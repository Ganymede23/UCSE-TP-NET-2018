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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.CB_TipoCliente = new System.Windows.Forms.ComboBox();
            this.TB_Busqueda = new System.Windows.Forms.TextBox();
            this.CHKB_FechaDesde = new System.Windows.Forms.CheckBox();
            this.CHKB_FechaHasta = new System.Windows.Forms.CheckBox();
            this.CHKB_TipoCliente = new System.Windows.Forms.CheckBox();
            this.CHKB_Busqueda = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_NuevoPrestamo
            // 
            this.BT_NuevoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_NuevoPrestamo.Location = new System.Drawing.Point(456, 12);
            this.BT_NuevoPrestamo.Name = "BT_NuevoPrestamo";
            this.BT_NuevoPrestamo.Size = new System.Drawing.Size(190, 36);
            this.BT_NuevoPrestamo.TabIndex = 5;
            this.BT_NuevoPrestamo.Text = "Nuevo Préstamo";
            this.BT_NuevoPrestamo.UseVisualStyleBackColor = true;
            this.BT_NuevoPrestamo.Click += new System.EventHandler(this.BT_NuevoPrestamo_Click);
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
            this.GrillaPrestamos.Size = new System.Drawing.Size(633, 298);
            this.GrillaPrestamos.TabIndex = 3;
            this.GrillaPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaPrestamos_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filtrar:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(131, 105);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(101, 22);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.Visible = false;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // CB_TipoCliente
            // 
            this.CB_TipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_TipoCliente.FormattingEnabled = true;
            this.CB_TipoCliente.Items.AddRange(new object[] {
            "Regular",
            "VIP"});
            this.CB_TipoCliente.Location = new System.Drawing.Point(238, 104);
            this.CB_TipoCliente.Name = "CB_TipoCliente";
            this.CB_TipoCliente.Size = new System.Drawing.Size(116, 24);
            this.CB_TipoCliente.TabIndex = 10;
            this.CB_TipoCliente.Visible = false;
            this.CB_TipoCliente.SelectedIndexChanged += new System.EventHandler(this.CB_TipoCliente_SelectedIndexChanged);
            // 
            // TB_Busqueda
            // 
            this.TB_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Busqueda.Location = new System.Drawing.Point(360, 105);
            this.TB_Busqueda.Name = "TB_Busqueda";
            this.TB_Busqueda.Size = new System.Drawing.Size(285, 22);
            this.TB_Busqueda.TabIndex = 11;
            this.TB_Busqueda.Visible = false;
            this.TB_Busqueda.TextChanged += new System.EventHandler(this.TB_Busqueda_TextChanged);
            // 
            // CHKB_FechaDesde
            // 
            this.CHKB_FechaDesde.AutoSize = true;
            this.CHKB_FechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKB_FechaDesde.Location = new System.Drawing.Point(18, 79);
            this.CHKB_FechaDesde.Name = "CHKB_FechaDesde";
            this.CHKB_FechaDesde.Size = new System.Drawing.Size(107, 20);
            this.CHKB_FechaDesde.TabIndex = 12;
            this.CHKB_FechaDesde.Text = "Fecha desde";
            this.CHKB_FechaDesde.UseVisualStyleBackColor = true;
            this.CHKB_FechaDesde.CheckedChanged += new System.EventHandler(this.CHKB_FechaDesde_CheckedChanged);
            // 
            // CHKB_FechaHasta
            // 
            this.CHKB_FechaHasta.AutoSize = true;
            this.CHKB_FechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKB_FechaHasta.Location = new System.Drawing.Point(131, 79);
            this.CHKB_FechaHasta.Name = "CHKB_FechaHasta";
            this.CHKB_FechaHasta.Size = new System.Drawing.Size(101, 20);
            this.CHKB_FechaHasta.TabIndex = 13;
            this.CHKB_FechaHasta.Text = "Fecha hasta";
            this.CHKB_FechaHasta.UseVisualStyleBackColor = true;
            this.CHKB_FechaHasta.CheckedChanged += new System.EventHandler(this.CHKB_FechaHasta_CheckedChanged);
            // 
            // CHKB_TipoCliente
            // 
            this.CHKB_TipoCliente.AutoSize = true;
            this.CHKB_TipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKB_TipoCliente.Location = new System.Drawing.Point(238, 79);
            this.CHKB_TipoCliente.Name = "CHKB_TipoCliente";
            this.CHKB_TipoCliente.Size = new System.Drawing.Size(116, 20);
            this.CHKB_TipoCliente.TabIndex = 14;
            this.CHKB_TipoCliente.Text = "Tipo de cliente";
            this.CHKB_TipoCliente.UseVisualStyleBackColor = true;
            this.CHKB_TipoCliente.CheckedChanged += new System.EventHandler(this.CHKB_TipoCliente_CheckedChanged);
            // 
            // CHKB_Busqueda
            // 
            this.CHKB_Busqueda.AutoSize = true;
            this.CHKB_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKB_Busqueda.Location = new System.Drawing.Point(360, 79);
            this.CHKB_Busqueda.Name = "CHKB_Busqueda";
            this.CHKB_Busqueda.Size = new System.Drawing.Size(141, 20);
            this.CHKB_Busqueda.TabIndex = 15;
            this.CHKB_Busqueda.Text = "Buscar por nombre";
            this.CHKB_Busqueda.UseVisualStyleBackColor = true;
            this.CHKB_Busqueda.CheckedChanged += new System.EventHandler(this.CHKB_Busqueda_CheckedChanged);
            // 
            // F_GrillaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.CHKB_Busqueda);
            this.Controls.Add(this.CHKB_TipoCliente);
            this.Controls.Add(this.CHKB_FechaHasta);
            this.Controls.Add(this.CHKB_FechaDesde);
            this.Controls.Add(this.TB_Busqueda);
            this.Controls.Add(this.CB_TipoCliente);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_NuevoPrestamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrillaPrestamos);
            this.Name = "F_GrillaPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox CB_TipoCliente;
        private System.Windows.Forms.TextBox TB_Busqueda;
        private System.Windows.Forms.CheckBox CHKB_FechaDesde;
        private System.Windows.Forms.CheckBox CHKB_FechaHasta;
        private System.Windows.Forms.CheckBox CHKB_TipoCliente;
        private System.Windows.Forms.CheckBox CHKB_Busqueda;
    }
}