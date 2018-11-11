namespace WinForm
{
    partial class F_AltasComercios
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
            this.LBL_ID = new System.Windows.Forms.Label();
            this.LBL_ID_Titulo = new System.Windows.Forms.Label();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.TB_Ciudad = new System.Windows.Forms.TextBox();
            this.TB_Direccion = new System.Windows.Forms.TextBox();
            this.TB_RazonSocial = new System.Windows.Forms.TextBox();
            this.TB_cp = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Bt_GuardarComercio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_ID
            // 
            this.LBL_ID.AutoSize = true;
            this.LBL_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ID.Location = new System.Drawing.Point(112, 51);
            this.LBL_ID.Name = "LBL_ID";
            this.LBL_ID.Size = new System.Drawing.Size(77, 16);
            this.LBL_ID.TabIndex = 95;
            this.LBL_ID.Text = "IDcomercio";
            // 
            // LBL_ID_Titulo
            // 
            this.LBL_ID_Titulo.AutoSize = true;
            this.LBL_ID_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ID_Titulo.Location = new System.Drawing.Point(91, 51);
            this.LBL_ID_Titulo.Name = "LBL_ID_Titulo";
            this.LBL_ID_Titulo.Size = new System.Drawing.Size(21, 16);
            this.LBL_ID_Titulo.TabIndex = 94;
            this.LBL_ID_Titulo.Text = "ID";
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.Location = new System.Drawing.Point(12, 9);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(391, 31);
            this.LBL_Titulo.TabIndex = 93;
            this.LBL_Titulo.Text = "Alta de Comercios Adheridos";
            // 
            // TB_Ciudad
            // 
            this.TB_Ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Ciudad.Location = new System.Drawing.Point(394, 72);
            this.TB_Ciudad.Name = "TB_Ciudad";
            this.TB_Ciudad.Size = new System.Drawing.Size(148, 22);
            this.TB_Ciudad.TabIndex = 32;
            // 
            // TB_Direccion
            // 
            this.TB_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Direccion.Location = new System.Drawing.Point(115, 99);
            this.TB_Direccion.Name = "TB_Direccion";
            this.TB_Direccion.Size = new System.Drawing.Size(148, 22);
            this.TB_Direccion.TabIndex = 31;
            // 
            // TB_RazonSocial
            // 
            this.TB_RazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_RazonSocial.Location = new System.Drawing.Point(115, 72);
            this.TB_RazonSocial.Name = "TB_RazonSocial";
            this.TB_RazonSocial.Size = new System.Drawing.Size(148, 22);
            this.TB_RazonSocial.TabIndex = 30;
            // 
            // TB_cp
            // 
            this.TB_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_cp.Location = new System.Drawing.Point(394, 98);
            this.TB_cp.Mask = "0000";
            this.TB_cp.Name = "TB_cp";
            this.TB_cp.Size = new System.Drawing.Size(148, 22);
            this.TB_cp.TabIndex = 33;
            this.TB_cp.ValidatingType = typeof(int);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(99, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 16);
            this.label16.TabIndex = 89;
            this.label16.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 86;
            this.label13.Text = "Razon Social";
            // 
            // Bt_GuardarComercio
            // 
            this.Bt_GuardarComercio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_GuardarComercio.Location = new System.Drawing.Point(394, 133);
            this.Bt_GuardarComercio.Name = "Bt_GuardarComercio";
            this.Bt_GuardarComercio.Size = new System.Drawing.Size(148, 41);
            this.Bt_GuardarComercio.TabIndex = 34;
            this.Bt_GuardarComercio.Text = "Guardar";
            this.Bt_GuardarComercio.UseVisualStyleBackColor = true;
            this.Bt_GuardarComercio.Click += new System.EventHandler(this.Bt_GuardarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(375, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 99;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(375, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 98;
            this.label2.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 97;
            this.label5.Text = "Ciudad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(286, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 96;
            this.label9.Text = "Codigo Postal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(99, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 101;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 100;
            this.label4.Text = "Dirección";
            // 
            // F_AltasComercios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 192);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LBL_ID);
            this.Controls.Add(this.LBL_ID_Titulo);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.TB_Ciudad);
            this.Controls.Add(this.TB_Direccion);
            this.Controls.Add(this.TB_RazonSocial);
            this.Controls.Add(this.TB_cp);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Bt_GuardarComercio);
            this.Name = "F_AltasComercios";
            this.Text = "Alta de Comercios Adheridos";
            this.Load += new System.EventHandler(this.F_AltasComercios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_ID;
        private System.Windows.Forms.Label LBL_ID_Titulo;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.TextBox TB_Ciudad;
        private System.Windows.Forms.TextBox TB_Direccion;
        private System.Windows.Forms.TextBox TB_RazonSocial;
        private System.Windows.Forms.MaskedTextBox TB_cp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Bt_GuardarComercio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}