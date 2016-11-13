namespace POS.Admin.Appl
{
    partial class EdicionProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionProveedor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.GBCaptura = new System.Windows.Forms.GroupBox();
            this.chbAlmacen = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.GBCaptura.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGuardar,
            this.toolStripSeparator1,
            this.toolStripSalir,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(461, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripGuardar
            // 
            this.toolStripGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGuardar.Image")));
            this.toolStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGuardar.Name = "toolStripGuardar";
            this.toolStripGuardar.Size = new System.Drawing.Size(23, 22);
            this.toolStripGuardar.Text = "Guardar";
            this.toolStripGuardar.Click += new System.EventHandler(this.toolStripGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSalir
            // 
            this.toolStripSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSalir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSalir.Image")));
            this.toolStripSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSalir.Name = "toolStripSalir";
            this.toolStripSalir.Size = new System.Drawing.Size(23, 22);
            this.toolStripSalir.Text = "Regresar";
            this.toolStripSalir.Click += new System.EventHandler(this.toolStripSalir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // GBCaptura
            // 
            this.GBCaptura.Controls.Add(this.label2);
            this.GBCaptura.Controls.Add(this.txtAlias);
            this.GBCaptura.Controls.Add(this.chbAlmacen);
            this.GBCaptura.Controls.Add(this.label1);
            this.GBCaptura.Controls.Add(this.label5);
            this.GBCaptura.Controls.Add(this.txtDireccion);
            this.GBCaptura.Controls.Add(this.label6);
            this.GBCaptura.Controls.Add(this.txtRazon);
            this.GBCaptura.Controls.Add(this.label8);
            this.GBCaptura.Controls.Add(this.txtRfc);
            this.GBCaptura.Location = new System.Drawing.Point(12, 38);
            this.GBCaptura.Name = "GBCaptura";
            this.GBCaptura.Size = new System.Drawing.Size(437, 228);
            this.GBCaptura.TabIndex = 1;
            this.GBCaptura.TabStop = false;
            this.GBCaptura.Text = "Campos Proveedor";
            // 
            // chbAlmacen
            // 
            this.chbAlmacen.AutoSize = true;
            this.chbAlmacen.Location = new System.Drawing.Point(84, 199);
            this.chbAlmacen.Name = "chbAlmacen";
            this.chbAlmacen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbAlmacen.Size = new System.Drawing.Size(15, 14);
            this.chbAlmacen.TabIndex = 7;
            this.chbAlmacen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Almacén";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "RFC";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(84, 111);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(338, 81);
            this.txtDireccion.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Razón Social";
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(84, 58);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(338, 20);
            this.txtRazon.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Dirección";
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(84, 29);
            this.txtRfc.MaxLength = 13;
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(168, 20);
            this.txtRfc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alias";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(84, 85);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(245, 20);
            this.txtAlias.TabIndex = 9;
            // 
            // EdicionProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 280);
            this.ControlBox = false;
            this.Controls.Add(this.GBCaptura);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EdicionProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edición Proveedor";
            this.Load += new System.EventHandler(this.EdicionProveedor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GBCaptura.ResumeLayout(false);
            this.GBCaptura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox GBCaptura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.CheckBox chbAlmacen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlias;
    }
}