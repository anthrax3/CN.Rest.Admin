namespace POS.Admin.Appl
{
    partial class EdicionPaquetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionPaquetes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.GBCaptura = new System.Windows.Forms.GroupBox();
            this.dtFin = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNoArticulos = new System.Windows.Forms.TextBox();
            this.CBCategorias = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBEstatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.GridArticulos = new System.Windows.Forms.DataGridView();
            this.chEan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chDesArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridSubCategorias = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btAgregaSubCat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btAgregaArticulo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.CBSubCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBCategoriaArt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBArticulo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.GBCaptura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubCategorias)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGuardar,
            this.toolStripSeparator1,
            this.toolStripSalir,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(727, 25);
            this.toolStrip1.TabIndex = 5;
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // GBCaptura
            // 
            this.GBCaptura.Controls.Add(this.dtFin);
            this.GBCaptura.Controls.Add(this.label11);
            this.GBCaptura.Controls.Add(this.dtInicio);
            this.GBCaptura.Controls.Add(this.txtConsumo);
            this.GBCaptura.Controls.Add(this.label10);
            this.GBCaptura.Controls.Add(this.label9);
            this.GBCaptura.Controls.Add(this.label8);
            this.GBCaptura.Controls.Add(this.txtNoArticulos);
            this.GBCaptura.Controls.Add(this.CBCategorias);
            this.GBCaptura.Controls.Add(this.label6);
            this.GBCaptura.Controls.Add(this.CBEstatus);
            this.GBCaptura.Controls.Add(this.label3);
            this.GBCaptura.Controls.Add(this.label2);
            this.GBCaptura.Controls.Add(this.txtPrecioVenta);
            this.GBCaptura.Controls.Add(this.label1);
            this.GBCaptura.Controls.Add(this.txtDescripcion);
            this.GBCaptura.Location = new System.Drawing.Point(7, 36);
            this.GBCaptura.Name = "GBCaptura";
            this.GBCaptura.Size = new System.Drawing.Size(378, 217);
            this.GBCaptura.TabIndex = 6;
            this.GBCaptura.TabStop = false;
            this.GBCaptura.Text = "Campos Paquete";
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(225, 184);
            this.dtFin.Mask = "00:00";
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(55, 20);
            this.dtFin.TabIndex = 19;
            this.dtFin.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Consumo Minimo";
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(100, 184);
            this.dtInicio.Mask = "00:00";
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(56, 20);
            this.dtInicio.TabIndex = 18;
            this.dtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(100, 158);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(56, 20);
            this.txtConsumo.TabIndex = 19;
            this.txtConsumo.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Hora Fin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Hora Inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "No. Articulos";
            // 
            // txtNoArticulos
            // 
            this.txtNoArticulos.Location = new System.Drawing.Point(100, 132);
            this.txtNoArticulos.Name = "txtNoArticulos";
            this.txtNoArticulos.Size = new System.Drawing.Size(100, 20);
            this.txtNoArticulos.TabIndex = 13;
            // 
            // CBCategorias
            // 
            this.CBCategorias.FormattingEnabled = true;
            this.CBCategorias.Location = new System.Drawing.Point(100, 105);
            this.CBCategorias.Name = "CBCategorias";
            this.CBCategorias.Size = new System.Drawing.Size(180, 21);
            this.CBCategorias.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Categoria";
            // 
            // CBEstatus
            // 
            this.CBEstatus.FormattingEnabled = true;
            this.CBEstatus.Location = new System.Drawing.Point(100, 78);
            this.CBEstatus.Name = "CBEstatus";
            this.CBEstatus.Size = new System.Drawing.Size(180, 21);
            this.CBEstatus.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(100, 52);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 7;
            this.txtPrecioVenta.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(100, 26);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(269, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // GridArticulos
            // 
            this.GridArticulos.AllowUserToAddRows = false;
            this.GridArticulos.AllowUserToOrderColumns = true;
            this.GridArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chEan,
            this.chDesArt});
            this.GridArticulos.Location = new System.Drawing.Point(7, 307);
            this.GridArticulos.Name = "GridArticulos";
            this.GridArticulos.ReadOnly = true;
            this.GridArticulos.Size = new System.Drawing.Size(438, 195);
            this.GridArticulos.TabIndex = 8;
            // 
            // chEan
            // 
            this.chEan.FillWeight = 92.78012F;
            this.chEan.HeaderText = "Codigo";
            this.chEan.Name = "chEan";
            this.chEan.ReadOnly = true;
            // 
            // chDesArt
            // 
            this.chDesArt.FillWeight = 152.2843F;
            this.chDesArt.HeaderText = "Articulo";
            this.chDesArt.Name = "chDesArt";
            this.chDesArt.ReadOnly = true;
            // 
            // gridSubCategorias
            // 
            this.gridSubCategorias.AllowUserToAddRows = false;
            this.gridSubCategorias.AllowUserToOrderColumns = true;
            this.gridSubCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSubCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSubCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SubCategoria,
            this.txtcCantidad});
            this.gridSubCategorias.Location = new System.Drawing.Point(452, 307);
            this.gridSubCategorias.Name = "gridSubCategorias";
            this.gridSubCategorias.Size = new System.Drawing.Size(265, 195);
            this.gridSubCategorias.TabIndex = 9;
            this.gridSubCategorias.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSubCategorias_CellEndEdit);
            // 
            // ID
            // 
            this.ID.FillWeight = 60.9137F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // SubCategoria
            // 
            this.SubCategoria.FillWeight = 139.0863F;
            this.SubCategoria.HeaderText = "SubCategoria";
            this.SubCategoria.Name = "SubCategoria";
            // 
            // txtcCantidad
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "1";
            this.txtcCantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtcCantidad.HeaderText = "Cantidad";
            this.txtcCantidad.MaxInputLength = 10;
            this.txtcCantidad.Name = "txtcCantidad";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAgregaSubCat,
            this.toolStripSeparator2});
            this.toolStrip2.Location = new System.Drawing.Point(677, 279);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(41, 25);
            this.toolStrip2.TabIndex = 10;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btAgregaSubCat
            // 
            this.btAgregaSubCat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAgregaSubCat.Image = global::POS.Admin.Appl.Properties.Resources.plus_blue;
            this.btAgregaSubCat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAgregaSubCat.Name = "btAgregaSubCat";
            this.btAgregaSubCat.Size = new System.Drawing.Size(23, 22);
            this.btAgregaSubCat.Text = "toolStripButton1";
            this.btAgregaSubCat.Click += new System.EventHandler(this.btAgregaSubCat_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAgregaArticulo,
            this.toolStripSeparator5});
            this.toolStrip3.Location = new System.Drawing.Point(403, 279);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip3.Size = new System.Drawing.Size(41, 25);
            this.toolStrip3.TabIndex = 11;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btAgregaArticulo
            // 
            this.btAgregaArticulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAgregaArticulo.Image = global::POS.Admin.Appl.Properties.Resources.plus_blue;
            this.btAgregaArticulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAgregaArticulo.Name = "btAgregaArticulo";
            this.btAgregaArticulo.Size = new System.Drawing.Size(23, 22);
            this.btAgregaArticulo.Text = "toolStripButton1";
            this.btAgregaArticulo.Click += new System.EventHandler(this.btAgregaArticulo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // CBSubCategoria
            // 
            this.CBSubCategoria.FormattingEnabled = true;
            this.CBSubCategoria.Location = new System.Drawing.Point(452, 283);
            this.CBSubCategoria.Name = "CBSubCategoria";
            this.CBSubCategoria.Size = new System.Drawing.Size(198, 21);
            this.CBSubCategoria.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(452, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "SubCategoria";
            // 
            // CBCategoriaArt
            // 
            this.CBCategoriaArt.FormattingEnabled = true;
            this.CBCategoriaArt.Location = new System.Drawing.Point(7, 283);
            this.CBCategoriaArt.Name = "CBCategoriaArt";
            this.CBCategoriaArt.Size = new System.Drawing.Size(156, 21);
            this.CBCategoriaArt.TabIndex = 15;
            this.CBCategoriaArt.SelectedIndexChanged += new System.EventHandler(this.CBCategoriaArt_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "SubCategoria";
            // 
            // CBArticulo
            // 
            this.CBArticulo.FormattingEnabled = true;
            this.CBArticulo.Location = new System.Drawing.Point(169, 283);
            this.CBArticulo.Name = "CBArticulo";
            this.CBArticulo.Size = new System.Drawing.Size(231, 21);
            this.CBArticulo.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(166, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Articulo";
            // 
            // EdicionPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 514);
            this.ControlBox = false;
            this.Controls.Add(this.CBArticulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBCategoriaArt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBSubCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.GridArticulos);
            this.Controls.Add(this.gridSubCategorias);
            this.Controls.Add(this.GBCaptura);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EdicionPaquetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edicion Paquetes";
            this.Load += new System.EventHandler(this.EdicionPaquetes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GBCaptura.ResumeLayout(false);
            this.GBCaptura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubCategorias)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox GBCaptura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox CBEstatus;
        private System.Windows.Forms.DataGridView GridArticulos;
        private System.Windows.Forms.DataGridView gridSubCategorias;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btAgregaSubCat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btAgregaArticulo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ComboBox CBSubCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBCategoriaArt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBArticulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoArticulos;
        private System.Windows.Forms.ComboBox CBCategorias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn chEan;
        private System.Windows.Forms.DataGridViewTextBoxColumn chDesArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.MaskedTextBox dtInicio;
        private System.Windows.Forms.MaskedTextBox dtFin;
    }
}