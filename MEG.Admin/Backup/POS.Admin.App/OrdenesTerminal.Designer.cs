namespace POS.Admin.Appl
{
    partial class OrdenesTerminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenesTerminal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTRefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.GBOrdenes = new System.Windows.Forms.GroupBox();
            this.listOrdenes = new System.Windows.Forms.ListView();
            this.CHArchivo = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.GBOrdenes.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGuardar,
            this.toolStripSeparator1,
            this.BTRefrescar,
            this.toolStripSeparator3,
            this.toolStripSalir,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(419, 25);
            this.toolStrip1.TabIndex = 1;
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
            // BTRefrescar
            // 
            this.BTRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("BTRefrescar.Image")));
            this.BTRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTRefrescar.Name = "BTRefrescar";
            this.BTRefrescar.Size = new System.Drawing.Size(23, 22);
            this.BTRefrescar.Text = "Refrescar";
            this.BTRefrescar.ToolTipText = "Refrescar Listado de Ordenes";
            this.BTRefrescar.Click += new System.EventHandler(this.BTRefrescar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // GBOrdenes
            // 
            this.GBOrdenes.Controls.Add(this.listOrdenes);
            this.GBOrdenes.Location = new System.Drawing.Point(26, 41);
            this.GBOrdenes.Name = "GBOrdenes";
            this.GBOrdenes.Size = new System.Drawing.Size(365, 300);
            this.GBOrdenes.TabIndex = 2;
            this.GBOrdenes.TabStop = false;
            this.GBOrdenes.Text = "Listado Ordenes Dispositivo Móvil";
            // 
            // listOrdenes
            // 
            this.listOrdenes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHArchivo});
            this.listOrdenes.GridLines = true;
            this.listOrdenes.Location = new System.Drawing.Point(22, 33);
            this.listOrdenes.MultiSelect = false;
            this.listOrdenes.Name = "listOrdenes";
            this.listOrdenes.Size = new System.Drawing.Size(323, 247);
            this.listOrdenes.TabIndex = 0;
            this.listOrdenes.UseCompatibleStateImageBehavior = false;
            this.listOrdenes.View = System.Windows.Forms.View.Details;
            // 
            // CHArchivo
            // 
            this.CHArchivo.Text = "Archivo";
            this.CHArchivo.Width = 300;
            // 
            // OrdenesTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 365);
            this.ControlBox = false;
            this.Controls.Add(this.GBOrdenes);
            this.Controls.Add(this.toolStrip1);
            this.Name = "OrdenesTerminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ordenes Terminal";
            this.Load += new System.EventHandler(this.OrdenesTerminal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GBOrdenes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox GBOrdenes;
        private System.Windows.Forms.ListView listOrdenes;
        private System.Windows.Forms.ColumnHeader CHArchivo;
        private System.Windows.Forms.ToolStripButton BTRefrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}