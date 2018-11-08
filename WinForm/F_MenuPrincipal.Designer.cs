namespace WinForm
{
    partial class F_MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeCreditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarSucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comerciosAhderidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarComercioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lugaresDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarLugarDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelSalir = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLienteToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.sucursalesToolStripMenuItem,
            this.comerciosAhderidosToolStripMenuItem,
            this.lugaresDePagoToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // cLienteToolStripMenuItem
            // 
            this.cLienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeClientesToolStripMenuItem,
            this.agregarClienteToolStripMenuItem});
            this.cLienteToolStripMenuItem.Name = "cLienteToolStripMenuItem";
            resources.ApplyResources(this.cLienteToolStripMenuItem, "cLienteToolStripMenuItem");
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            resources.ApplyResources(this.listadoDeClientesToolStripMenuItem, "listadoDeClientesToolStripMenuItem");
            this.listadoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.GrillaClientesStripMenu_Click);
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            resources.ApplyResources(this.agregarClienteToolStripMenuItem, "agregarClienteToolStripMenuItem");
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.AltaClienteStripMenu_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPrestamoToolStripMenuItem,
            this.reportesDeCreditosToolStripMenuItem});
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            resources.ApplyResources(this.prestamosToolStripMenuItem, "prestamosToolStripMenuItem");
            // 
            // agregarPrestamoToolStripMenuItem
            // 
            this.agregarPrestamoToolStripMenuItem.Name = "agregarPrestamoToolStripMenuItem";
            resources.ApplyResources(this.agregarPrestamoToolStripMenuItem, "agregarPrestamoToolStripMenuItem");
            // 
            // reportesDeCreditosToolStripMenuItem
            // 
            this.reportesDeCreditosToolStripMenuItem.Name = "reportesDeCreditosToolStripMenuItem";
            resources.ApplyResources(this.reportesDeCreditosToolStripMenuItem, "reportesDeCreditosToolStripMenuItem");
            // 
            // sucursalesToolStripMenuItem
            // 
            this.sucursalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarSucursalesToolStripMenuItem,
            this.modificacionToolStripMenuItem});
            this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            resources.ApplyResources(this.sucursalesToolStripMenuItem, "sucursalesToolStripMenuItem");
            // 
            // agregarSucursalesToolStripMenuItem
            // 
            this.agregarSucursalesToolStripMenuItem.Name = "agregarSucursalesToolStripMenuItem";
            resources.ApplyResources(this.agregarSucursalesToolStripMenuItem, "agregarSucursalesToolStripMenuItem");
            // 
            // modificacionToolStripMenuItem
            // 
            this.modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            resources.ApplyResources(this.modificacionToolStripMenuItem, "modificacionToolStripMenuItem");
            // 
            // comerciosAhderidosToolStripMenuItem
            // 
            this.comerciosAhderidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificacionToolStripMenuItem1,
            this.agregarComercioToolStripMenuItem});
            this.comerciosAhderidosToolStripMenuItem.Name = "comerciosAhderidosToolStripMenuItem";
            resources.ApplyResources(this.comerciosAhderidosToolStripMenuItem, "comerciosAhderidosToolStripMenuItem");
            // 
            // modificacionToolStripMenuItem1
            // 
            this.modificacionToolStripMenuItem1.Name = "modificacionToolStripMenuItem1";
            resources.ApplyResources(this.modificacionToolStripMenuItem1, "modificacionToolStripMenuItem1");
            this.modificacionToolStripMenuItem1.Click += new System.EventHandler(this.GrillaComerciosStripMenu_Click);
            // 
            // agregarComercioToolStripMenuItem
            // 
            this.agregarComercioToolStripMenuItem.Name = "agregarComercioToolStripMenuItem";
            resources.ApplyResources(this.agregarComercioToolStripMenuItem, "agregarComercioToolStripMenuItem");
            this.agregarComercioToolStripMenuItem.Click += new System.EventHandler(this.AltaComercioStripMenu_Click);
            // 
            // lugaresDePagoToolStripMenuItem
            // 
            this.lugaresDePagoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificacionToolStripMenuItem2,
            this.agregarLugarDePagoToolStripMenuItem});
            resources.ApplyResources(this.lugaresDePagoToolStripMenuItem, "lugaresDePagoToolStripMenuItem");
            this.lugaresDePagoToolStripMenuItem.Name = "lugaresDePagoToolStripMenuItem";
            // 
            // modificacionToolStripMenuItem2
            // 
            this.modificacionToolStripMenuItem2.Name = "modificacionToolStripMenuItem2";
            resources.ApplyResources(this.modificacionToolStripMenuItem2, "modificacionToolStripMenuItem2");
            this.modificacionToolStripMenuItem2.Click += new System.EventHandler(this.GrillaLugaresDePagoStripMenu_Click);
            // 
            // agregarLugarDePagoToolStripMenuItem
            // 
            this.agregarLugarDePagoToolStripMenuItem.Name = "agregarLugarDePagoToolStripMenuItem";
            resources.ApplyResources(this.agregarLugarDePagoToolStripMenuItem, "agregarLugarDePagoToolStripMenuItem");
            this.agregarLugarDePagoToolStripMenuItem.Click += new System.EventHandler(this.AltaLugarDePagoStripMenu_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // LabelSalir
            // 
            resources.ApplyResources(this.LabelSalir, "LabelSalir");
            this.LabelSalir.Name = "LabelSalir";
            this.LabelSalir.TabStop = true;
            this.LabelSalir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelSalir_LinkClicked);
            // 
            // F_MenuPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LabelSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "F_MenuPrincipal";
            this.Load += new System.EventHandler(this.F_MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeCreditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarSucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comerciosAhderidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarComercioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lugaresDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarLugarDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel LabelSalir;
    }
}

