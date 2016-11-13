namespace POS.Admin.Appl
{
    partial class EdicionEntrada
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionEntrada));
            this.GBCaptura = new System.Windows.Forms.GroupBox();
            this.CBProvFactura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblImporteQuince = new System.Windows.Forms.Label();
            this.lblImporteCero = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBEstatus = new System.Windows.Forms.ComboBox();
            this.CBProveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.GridDetalleEntrada = new System.Windows.Forms.DataGridView();
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btReportear = new System.Windows.Forms.Button();
            this.btExporta = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GBCaptura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalleEntrada)).BeginInit();
            this.gbBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCaptura
            // 
            this.GBCaptura.Controls.Add(this.CBProvFactura);
            this.GBCaptura.Controls.Add(this.label3);
            this.GBCaptura.Controls.Add(this.lblImporteQuince);
            this.GBCaptura.Controls.Add(this.lblImporteCero);
            this.GBCaptura.Controls.Add(this.label7);
            this.GBCaptura.Controls.Add(this.label4);
            this.GBCaptura.Controls.Add(this.CBEstatus);
            this.GBCaptura.Controls.Add(this.CBProveedor);
            this.GBCaptura.Controls.Add(this.label2);
            this.GBCaptura.Controls.Add(this.label1);
            this.GBCaptura.Controls.Add(this.txtFolio);
            this.GBCaptura.Controls.Add(this.label6);
            this.GBCaptura.Controls.Add(this.label8);
            this.GBCaptura.Controls.Add(this.txtFactura);
            this.GBCaptura.Location = new System.Drawing.Point(12, 66);
            this.GBCaptura.Name = "GBCaptura";
            this.GBCaptura.Size = new System.Drawing.Size(630, 143);
            this.GBCaptura.TabIndex = 1;
            this.GBCaptura.TabStop = false;
            this.GBCaptura.Text = "Campos Orden";
            // 
            // CBProvFactura
            // 
            this.CBProvFactura.FormattingEnabled = true;
            this.CBProvFactura.Location = new System.Drawing.Point(75, 51);
            this.CBProvFactura.Name = "CBProvFactura";
            this.CBProvFactura.Size = new System.Drawing.Size(391, 21);
            this.CBProvFactura.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Proveedor";
            // 
            // lblImporteQuince
            // 
            this.lblImporteQuince.BackColor = System.Drawing.Color.White;
            this.lblImporteQuince.Location = new System.Drawing.Point(484, 110);
            this.lblImporteQuince.Name = "lblImporteQuince";
            this.lblImporteQuince.Size = new System.Drawing.Size(133, 20);
            this.lblImporteQuince.TabIndex = 11;
            this.lblImporteQuince.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblImporteCero
            // 
            this.lblImporteCero.BackColor = System.Drawing.Color.White;
            this.lblImporteCero.Location = new System.Drawing.Point(484, 82);
            this.lblImporteCero.Name = "lblImporteCero";
            this.lblImporteCero.Size = new System.Drawing.Size(133, 20);
            this.lblImporteCero.TabIndex = 9;
            this.lblImporteCero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Importe 15%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Importe 0%";
            // 
            // CBEstatus
            // 
            this.CBEstatus.FormattingEnabled = true;
            this.CBEstatus.Location = new System.Drawing.Point(237, 109);
            this.CBEstatus.Name = "CBEstatus";
            this.CBEstatus.Size = new System.Drawing.Size(160, 21);
            this.CBEstatus.TabIndex = 7;
            // 
            // CBProveedor
            // 
            this.CBProveedor.FormattingEnabled = true;
            this.CBProveedor.Location = new System.Drawing.Point(75, 19);
            this.CBProveedor.Name = "CBProveedor";
            this.CBProveedor.Size = new System.Drawing.Size(391, 21);
            this.CBProveedor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estatus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Factura";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(75, 81);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(139, 20);
            this.txtFolio.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Almacén";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Folio";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(75, 110);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(139, 20);
            this.txtFactura.TabIndex = 3;
            // 
            // GridDetalleEntrada
            // 
            this.GridDetalleEntrada.AllowUserToDeleteRows = false;
            this.GridDetalleEntrada.AllowUserToOrderColumns = true;
            this.GridDetalleEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridDetalleEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDetalleEntrada.Location = new System.Drawing.Point(12, 220);
            this.GridDetalleEntrada.Name = "GridDetalleEntrada";
            this.GridDetalleEntrada.ReadOnly = true;
            this.GridDetalleEntrada.Size = new System.Drawing.Size(843, 390);
            this.GridDetalleEntrada.TabIndex = 2;
            this.GridDetalleEntrada.DoubleClick += new System.EventHandler(this.GridDetalleEntrada_DoubleClick);
            this.GridDetalleEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridDetalleEntrada_KeyPress);
            // 
            // gbBotones
            // 
            this.gbBotones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbBotones.Controls.Add(this.btSalir);
            this.gbBotones.Controls.Add(this.btReportear);
            this.gbBotones.Controls.Add(this.btExporta);
            this.gbBotones.Controls.Add(this.btEliminar);
            this.gbBotones.Controls.Add(this.btNuevo);
            this.gbBotones.Controls.Add(this.btGuardar);
            this.gbBotones.Location = new System.Drawing.Point(267, -5);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(332, 65);
            this.gbBotones.TabIndex = 0;
            this.gbBotones.TabStop = false;
            // 
            // btSalir
            // 
            this.btSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSalir.ImageIndex = 5;
            this.btSalir.ImageList = this.imageList1;
            this.btSalir.Location = new System.Drawing.Point(276, 17);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(48, 39);
            this.btSalir.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btSalir, "Regresar a Inicio");
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "79.ICO");
            this.imageList1.Images.SetKeyName(1, "135.ICO");
            this.imageList1.Images.SetKeyName(2, "132.ICO");
            this.imageList1.Images.SetKeyName(3, "127.ICO");
            this.imageList1.Images.SetKeyName(4, "WinXPSetV4 Icon 52.ico");
            this.imageList1.Images.SetKeyName(5, "151.ICO");
            // 
            // btReportear
            // 
            this.btReportear.ImageIndex = 4;
            this.btReportear.ImageList = this.imageList1;
            this.btReportear.Location = new System.Drawing.Point(222, 17);
            this.btReportear.Name = "btReportear";
            this.btReportear.Size = new System.Drawing.Size(48, 39);
            this.btReportear.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btReportear, "Generar Reporte");
            this.btReportear.UseVisualStyleBackColor = true;
            this.btReportear.Click += new System.EventHandler(this.btReportear_Click);
            // 
            // btExporta
            // 
            this.btExporta.ImageIndex = 3;
            this.btExporta.ImageList = this.imageList1;
            this.btExporta.Location = new System.Drawing.Point(168, 17);
            this.btExporta.Name = "btExporta";
            this.btExporta.Size = new System.Drawing.Size(48, 39);
            this.btExporta.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btExporta, "Exportar Documento");
            this.btExporta.UseVisualStyleBackColor = true;
            // 
            // btEliminar
            // 
            this.btEliminar.ImageIndex = 2;
            this.btEliminar.ImageList = this.imageList1;
            this.btEliminar.Location = new System.Drawing.Point(114, 17);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(48, 39);
            this.btEliminar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btEliminar, "Eliminar Item");
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.ImageIndex = 1;
            this.btNuevo.ImageList = this.imageList1;
            this.btNuevo.Location = new System.Drawing.Point(60, 17);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(48, 39);
            this.btNuevo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btNuevo, "Insertar Nuevo Item");
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.ImageIndex = 0;
            this.btGuardar.ImageList = this.imageList1;
            this.btGuardar.Location = new System.Drawing.Point(6, 17);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(48, 39);
            this.btGuardar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btGuardar, "Guardar Cambios");
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // EdicionEntrada
            // 
            this.AcceptButton = this.btGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btSalir;
            this.ClientSize = new System.Drawing.Size(867, 622);
            this.ControlBox = false;
            this.Controls.Add(this.gbBotones);
            this.Controls.Add(this.GridDetalleEntrada);
            this.Controls.Add(this.GBCaptura);
            this.Name = "EdicionEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición Entrada";
            this.Load += new System.EventHandler(this.EdicionEntrada_Load);
            this.GBCaptura.ResumeLayout(false);
            this.GBCaptura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalleEntrada)).EndInit();
            this.gbBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCaptura;
        private System.Windows.Forms.Label lblImporteQuince;
        private System.Windows.Forms.Label lblImporteCero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBEstatus;
        private System.Windows.Forms.ComboBox CBProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.DataGridView GridDetalleEntrada;
        private System.Windows.Forms.GroupBox gbBotones;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btReportear;
        private System.Windows.Forms.Button btExporta;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.ComboBox CBProvFactura;
        private System.Windows.Forms.Label label3;
    }
}