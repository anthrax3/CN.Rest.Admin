namespace POS.Admin.Appl
{
    partial class EdicionImpuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionImpuestos));
            this.GBCaptura = new System.Windows.Forms.GroupBox();
            this.listImpuestos = new System.Windows.Forms.ListView();
            this.chID = new System.Windows.Forms.ColumnHeader();
            this.chDescripcion = new System.Windows.Forms.ColumnHeader();
            this.chPorcentaje = new System.Windows.Forms.ColumnHeader();
            this.chTipo = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.GBCaptura.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCaptura
            // 
            this.GBCaptura.Controls.Add(this.listImpuestos);
            this.GBCaptura.Location = new System.Drawing.Point(12, 38);
            this.GBCaptura.Name = "GBCaptura";
            this.GBCaptura.Size = new System.Drawing.Size(442, 170);
            this.GBCaptura.TabIndex = 3;
            this.GBCaptura.TabStop = false;
            this.GBCaptura.Text = "Catalogo Unidades";
            // 
            // listImpuestos
            // 
            this.listImpuestos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chDescripcion,
            this.chPorcentaje,
            this.chTipo});
            this.listImpuestos.FullRowSelect = true;
            this.listImpuestos.GridLines = true;
            this.listImpuestos.Location = new System.Drawing.Point(6, 28);
            this.listImpuestos.Name = "listImpuestos";
            this.listImpuestos.Size = new System.Drawing.Size(431, 136);
            this.listImpuestos.TabIndex = 0;
            this.listImpuestos.UseCompatibleStateImageBehavior = false;
            this.listImpuestos.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chDescripcion
            // 
            this.chDescripcion.Text = "Descripcion";
            this.chDescripcion.Width = 150;
            // 
            // chPorcentaje
            // 
            this.chPorcentaje.Text = "Porcentaje";
            this.chPorcentaje.Width = 100;
            // 
            // chTipo
            // 
            this.chTipo.Text = "Tipo";
            this.chTipo.Width = 100;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSalir,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(468, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // EdicionImpuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 221);
            this.Controls.Add(this.GBCaptura);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EdicionImpuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edicion Impuestos";
            this.Load += new System.EventHandler(this.EdicionImpuestos_Load);
            this.GBCaptura.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCaptura;
        private System.Windows.Forms.ListView listImpuestos;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chDescripcion;
        private System.Windows.Forms.ColumnHeader chPorcentaje;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ColumnHeader chTipo;
    }
}