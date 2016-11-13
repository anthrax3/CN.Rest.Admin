namespace POS.Admin.Appl
{
    partial class EdicionUnidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionUnidades));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.GBCaptura = new System.Windows.Forms.GroupBox();
            this.listUnidades = new System.Windows.Forms.ListView();
            this.chID = new System.Windows.Forms.ColumnHeader();
            this.chDescripcion = new System.Windows.Forms.ColumnHeader();
            this.chAbreviatura = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.GBCaptura.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSalir,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(365, 25);
            this.toolStrip1.TabIndex = 0;
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
            // GBCaptura
            // 
            this.GBCaptura.Controls.Add(this.listUnidades);
            this.GBCaptura.Location = new System.Drawing.Point(12, 39);
            this.GBCaptura.Name = "GBCaptura";
            this.GBCaptura.Size = new System.Drawing.Size(341, 170);
            this.GBCaptura.TabIndex = 1;
            this.GBCaptura.TabStop = false;
            this.GBCaptura.Text = "Catalogo Unidades";
            // 
            // listUnidades
            // 
            this.listUnidades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chDescripcion,
            this.chAbreviatura});
            this.listUnidades.FullRowSelect = true;
            this.listUnidades.GridLines = true;
            this.listUnidades.Location = new System.Drawing.Point(6, 28);
            this.listUnidades.Name = "listUnidades";
            this.listUnidades.Size = new System.Drawing.Size(327, 136);
            this.listUnidades.TabIndex = 0;
            this.listUnidades.UseCompatibleStateImageBehavior = false;
            this.listUnidades.View = System.Windows.Forms.View.Details;
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
            // chAbreviatura
            // 
            this.chAbreviatura.Text = "Abreviatura";
            this.chAbreviatura.Width = 100;
            // 
            // EdicionUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 221);
            this.ControlBox = false;
            this.Controls.Add(this.GBCaptura);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EdicionUnidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unidades";
            this.Load += new System.EventHandler(this.EdicionUnidades_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GBCaptura.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox GBCaptura;
        private System.Windows.Forms.ListView listUnidades;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chDescripcion;
        private System.Windows.Forms.ColumnHeader chAbreviatura;
    }
}