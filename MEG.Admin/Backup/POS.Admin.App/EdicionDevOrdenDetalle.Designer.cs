namespace POS.Admin.Appl
{
    partial class EdicionDevOrdenDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionDevOrdenDetalle));
            this.groupBusqueda = new System.Windows.Forms.GroupBox();
            this.radioDescripcion = new System.Windows.Forms.RadioButton();
            this.radioEan = new System.Windows.Forms.RadioButton();
            this.gridBusqueda = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.GBCaptura = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btGuardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblMensaje = new System.Windows.Forms.Label();
            this.groupBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBusqueda)).BeginInit();
            this.GBCaptura.SuspendLayout();
            this.gbBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBusqueda
            // 
            this.groupBusqueda.Controls.Add(this.radioDescripcion);
            this.groupBusqueda.Controls.Add(this.radioEan);
            this.groupBusqueda.Controls.Add(this.gridBusqueda);
            this.groupBusqueda.Controls.Add(this.label4);
            this.groupBusqueda.Controls.Add(this.txtBuscar);
            this.groupBusqueda.Location = new System.Drawing.Point(442, 64);
            this.groupBusqueda.Name = "groupBusqueda";
            this.groupBusqueda.Size = new System.Drawing.Size(437, 471);
            this.groupBusqueda.TabIndex = 1;
            this.groupBusqueda.TabStop = false;
            this.groupBusqueda.Text = "Búsqueda de Artículos";
            // 
            // radioDescripcion
            // 
            this.radioDescripcion.AutoSize = true;
            this.radioDescripcion.Location = new System.Drawing.Point(233, 41);
            this.radioDescripcion.Name = "radioDescripcion";
            this.radioDescripcion.Size = new System.Drawing.Size(81, 17);
            this.radioDescripcion.TabIndex = 1;
            this.radioDescripcion.TabStop = true;
            this.radioDescripcion.Text = "Descripción";
            this.radioDescripcion.UseVisualStyleBackColor = true;
            // 
            // radioEan
            // 
            this.radioEan.AutoSize = true;
            this.radioEan.Location = new System.Drawing.Point(233, 18);
            this.radioEan.Name = "radioEan";
            this.radioEan.Size = new System.Drawing.Size(83, 17);
            this.radioEan.TabIndex = 0;
            this.radioEan.TabStop = true;
            this.radioEan.Text = "Código EAN";
            this.radioEan.UseVisualStyleBackColor = true;
            // 
            // gridBusqueda
            // 
            this.gridBusqueda.AllowUserToDeleteRows = false;
            this.gridBusqueda.AllowUserToOrderColumns = true;
            this.gridBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBusqueda.Location = new System.Drawing.Point(16, 64);
            this.gridBusqueda.Name = "gridBusqueda";
            this.gridBusqueda.ReadOnly = true;
            this.gridBusqueda.Size = new System.Drawing.Size(403, 388);
            this.gridBusqueda.TabIndex = 4;
            this.gridBusqueda.DoubleClick += new System.EventHandler(this.gridBusqueda_DoubleClick);
            this.gridBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridBusqueda_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(59, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(168, 20);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // GBCaptura
            // 
            this.GBCaptura.Controls.Add(this.label3);
            this.GBCaptura.Controls.Add(this.txtCantidad);
            this.GBCaptura.Controls.Add(this.label2);
            this.GBCaptura.Controls.Add(this.label1);
            this.GBCaptura.Controls.Add(this.txtTotal);
            this.GBCaptura.Controls.Add(this.txtSubtotal);
            this.GBCaptura.Controls.Add(this.txtIva);
            this.GBCaptura.Controls.Add(this.txtCosto);
            this.GBCaptura.Controls.Add(this.label5);
            this.GBCaptura.Controls.Add(this.txtVenta);
            this.GBCaptura.Controls.Add(this.label6);
            this.GBCaptura.Controls.Add(this.txtDescripcion);
            this.GBCaptura.Controls.Add(this.label8);
            this.GBCaptura.Controls.Add(this.txtEan);
            this.GBCaptura.Controls.Add(this.label9);
            this.GBCaptura.Controls.Add(this.label10);
            this.GBCaptura.Location = new System.Drawing.Point(12, 64);
            this.GBCaptura.Name = "GBCaptura";
            this.GBCaptura.Size = new System.Drawing.Size(424, 246);
            this.GBCaptura.TabIndex = 0;
            this.GBCaptura.TabStop = false;
            this.GBCaptura.Text = "Campos Artículo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(79, 81);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(84, 20);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "I.V.A.";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(79, 212);
            this.txtTotal.MaxLength = 6;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(84, 20);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(79, 160);
            this.txtSubtotal.MaxLength = 6;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(84, 20);
            this.txtSubtotal.TabIndex = 11;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(79, 186);
            this.txtIva.MaxLength = 6;
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(84, 20);
            this.txtIva.TabIndex = 13;
            this.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(79, 108);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(84, 20);
            this.txtCosto.TabIndex = 7;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCosto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCosto_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo EAN";
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(79, 134);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(84, 20);
            this.txtVenta.TabIndex = 9;
            this.txtVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(79, 55);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(338, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Precio Venta";
            // 
            // txtEan
            // 
            this.txtEan.Location = new System.Drawing.Point(79, 29);
            this.txtEan.Name = "txtEan";
            this.txtEan.Size = new System.Drawing.Size(168, 20);
            this.txtEan.TabIndex = 1;
            this.txtEan.Leave += new System.EventHandler(this.txtEan_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Precio Costo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Subtotal";
            // 
            // gbBotones
            // 
            this.gbBotones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbBotones.Controls.Add(this.btSalir);
            this.gbBotones.Controls.Add(this.btGuardar);
            this.gbBotones.Location = new System.Drawing.Point(387, -5);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(116, 65);
            this.gbBotones.TabIndex = 2;
            this.gbBotones.TabStop = false;
            // 
            // btSalir
            // 
            this.btSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSalir.ImageIndex = 5;
            this.btSalir.ImageList = this.imageList1;
            this.btSalir.Location = new System.Drawing.Point(60, 17);
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
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(9, 38);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(321, 23);
            this.lblMensaje.TabIndex = 5;
            // 
            // EdicionDevOrdenDetalle
            // 
            this.AcceptButton = this.btGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btSalir;
            this.ClientSize = new System.Drawing.Size(891, 546);
            this.ControlBox = false;
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.gbBotones);
            this.Controls.Add(this.groupBusqueda);
            this.Controls.Add(this.GBCaptura);
            this.Name = "EdicionDevOrdenDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edición Devolución Orden Detalle";
            this.Load += new System.EventHandler(this.EdicionDevOrdenDetalle_Load);
            this.groupBusqueda.ResumeLayout(false);
            this.groupBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBusqueda)).EndInit();
            this.GBCaptura.ResumeLayout(false);
            this.GBCaptura.PerformLayout();
            this.gbBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBusqueda;
        private System.Windows.Forms.RadioButton radioDescripcion;
        private System.Windows.Forms.RadioButton radioEan;
        private System.Windows.Forms.DataGridView gridBusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox GBCaptura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbBotones;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label lblMensaje;
    }
}