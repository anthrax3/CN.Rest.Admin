namespace POS.Admin.Appl
{
    partial class EdicionPedidoProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionPedidoProveedor));
            this.GBCaptura = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBEstatus = new System.Windows.Forms.ComboBox();
            this.CBProveedor = new System.Windows.Forms.ComboBox();
            this.CBSucural = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.GridDetalleOrden = new System.Windows.Forms.DataGridView();
            this.btGuardar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.btReportear = new System.Windows.Forms.Button();
            this.btExporta = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GBCaptura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalleOrden)).BeginInit();
            this.gbBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCaptura
            // 
            this.GBCaptura.Controls.Add(this.lblTotal);
            this.GBCaptura.Controls.Add(this.lblIva);
            this.GBCaptura.Controls.Add(this.lblSubtotal);
            this.GBCaptura.Controls.Add(this.label7);
            this.GBCaptura.Controls.Add(this.label4);
            this.GBCaptura.Controls.Add(this.label3);
            this.GBCaptura.Controls.Add(this.CBEstatus);
            this.GBCaptura.Controls.Add(this.CBProveedor);
            this.GBCaptura.Controls.Add(this.CBSucural);
            this.GBCaptura.Controls.Add(this.label2);
            this.GBCaptura.Controls.Add(this.label1);
            this.GBCaptura.Controls.Add(this.label5);
            this.GBCaptura.Controls.Add(this.label6);
            this.GBCaptura.Controls.Add(this.txtFactura);
            this.GBCaptura.Location = new System.Drawing.Point(12, 65);
            this.GBCaptura.Name = "GBCaptura";
            this.GBCaptura.Size = new System.Drawing.Size(462, 166);
            this.GBCaptura.TabIndex = 1;
            this.GBCaptura.TabStop = false;
            this.GBCaptura.Text = "Campos Orden";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(315, 132);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(133, 20);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIva
            // 
            this.lblIva.BackColor = System.Drawing.Color.White;
            this.lblIva.Location = new System.Drawing.Point(315, 105);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(133, 20);
            this.lblIva.TabIndex = 13;
            this.lblIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(315, 78);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(133, 20);
            this.lblSubtotal.TabIndex = 11;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "I.V.A.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Subtotal";
            // 
            // CBEstatus
            // 
            this.CBEstatus.FormattingEnabled = true;
            this.CBEstatus.Location = new System.Drawing.Point(81, 105);
            this.CBEstatus.Name = "CBEstatus";
            this.CBEstatus.Size = new System.Drawing.Size(154, 21);
            this.CBEstatus.TabIndex = 9;
            // 
            // CBProveedor
            // 
            this.CBProveedor.FormattingEnabled = true;
            this.CBProveedor.Location = new System.Drawing.Point(81, 48);
            this.CBProveedor.Name = "CBProveedor";
            this.CBProveedor.Size = new System.Drawing.Size(367, 21);
            this.CBProveedor.TabIndex = 3;
            // 
            // CBSucural
            // 
            this.CBSucural.FormattingEnabled = true;
            this.CBSucural.Location = new System.Drawing.Point(81, 19);
            this.CBSucural.Name = "CBSucural";
            this.CBSucural.Size = new System.Drawing.Size(367, 21);
            this.CBSucural.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estatus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Referencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sucursal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Proveedor";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(81, 78);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(133, 20);
            this.txtFactura.TabIndex = 7;
            // 
            // GridDetalleOrden
            // 
            this.GridDetalleOrden.AllowUserToDeleteRows = false;
            this.GridDetalleOrden.AllowUserToOrderColumns = true;
            this.GridDetalleOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridDetalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDetalleOrden.Location = new System.Drawing.Point(12, 242);
            this.GridDetalleOrden.Name = "GridDetalleOrden";
            this.GridDetalleOrden.ReadOnly = true;
            this.GridDetalleOrden.Size = new System.Drawing.Size(631, 282);
            this.GridDetalleOrden.TabIndex = 2;
            this.GridDetalleOrden.DoubleClick += new System.EventHandler(this.GridDetalleOrden_DoubleClick);
            this.GridDetalleOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridDetalleOrden_KeyPress);
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
            // gbBotones
            // 
            this.gbBotones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbBotones.Controls.Add(this.btSalir);
            this.gbBotones.Controls.Add(this.btReportear);
            this.gbBotones.Controls.Add(this.btExporta);
            this.gbBotones.Controls.Add(this.btEliminar);
            this.gbBotones.Controls.Add(this.btNuevo);
            this.gbBotones.Controls.Add(this.btGuardar);
            this.gbBotones.Location = new System.Drawing.Point(161, -5);
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
            this.btExporta.Click += new System.EventHandler(this.btExporta_Click);
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
            // EdicionPedidoProveedor
            // 
            this.AcceptButton = this.btGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btSalir;
            this.ClientSize = new System.Drawing.Size(655, 536);
            this.ControlBox = false;
            this.Controls.Add(this.gbBotones);
            this.Controls.Add(this.GridDetalleOrden);
            this.Controls.Add(this.GBCaptura);
            this.Name = "EdicionPedidoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edición Pedido";
            this.Load += new System.EventHandler(this.EdicionOrden_Load);
            this.GBCaptura.ResumeLayout(false);
            this.GBCaptura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalleOrden)).EndInit();
            this.gbBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCaptura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.DataGridView GridDetalleOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBEstatus;
        private System.Windows.Forms.ComboBox CBProveedor;
        private System.Windows.Forms.ComboBox CBSucural;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.GroupBox gbBotones;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btReportear;
        private System.Windows.Forms.Button btExporta;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}