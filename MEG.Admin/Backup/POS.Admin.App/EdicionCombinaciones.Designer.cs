namespace POS.Admin.Appl
{
    partial class EdicionCombinaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionCombinaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.GBCaptura = new System.Windows.Forms.GroupBox();
            this.dtFin = new System.Windows.Forms.MaskedTextBox();
            this.dtInicio = new System.Windows.Forms.MaskedTextBox();
            this.CBCategorias = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CBEstatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.GridGrupos = new System.Windows.Forms.DataGridView();
            this.chEan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chFechaMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTxtUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.CBGrupo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.GBCaptura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrupos)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(729, 25);
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
            this.GBCaptura.Controls.Add(this.label11);
            this.GBCaptura.Controls.Add(this.dtFin);
            this.GBCaptura.Controls.Add(this.txtConsumo);
            this.GBCaptura.Controls.Add(this.dtInicio);
            this.GBCaptura.Controls.Add(this.CBCategorias);
            this.GBCaptura.Controls.Add(this.label10);
            this.GBCaptura.Controls.Add(this.label6);
            this.GBCaptura.Controls.Add(this.label9);
            this.GBCaptura.Controls.Add(this.CBEstatus);
            this.GBCaptura.Controls.Add(this.label3);
            this.GBCaptura.Controls.Add(this.label2);
            this.GBCaptura.Controls.Add(this.txtPrecioVenta);
            this.GBCaptura.Controls.Add(this.label1);
            this.GBCaptura.Controls.Add(this.txtDescripcion);
            this.GBCaptura.Location = new System.Drawing.Point(7, 36);
            this.GBCaptura.Name = "GBCaptura";
            this.GBCaptura.Size = new System.Drawing.Size(367, 186);
            this.GBCaptura.TabIndex = 6;
            this.GBCaptura.TabStop = false;
            this.GBCaptura.Text = "Campos Combinacion";
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(227, 155);
            this.dtFin.Mask = "00:00";
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(55, 20);
            this.dtFin.TabIndex = 22;
            this.dtFin.ValidatingType = typeof(System.DateTime);
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(102, 155);
            this.dtInicio.Mask = "00:00";
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(56, 20);
            this.dtInicio.TabIndex = 21;
            this.dtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // CBCategorias
            // 
            this.CBCategorias.FormattingEnabled = true;
            this.CBCategorias.Location = new System.Drawing.Point(102, 105);
            this.CBCategorias.Name = "CBCategorias";
            this.CBCategorias.Size = new System.Drawing.Size(180, 21);
            this.CBCategorias.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(174, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Hora Fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Hora Inicio";
            // 
            // CBEstatus
            // 
            this.CBEstatus.FormattingEnabled = true;
            this.CBEstatus.Location = new System.Drawing.Point(102, 78);
            this.CBEstatus.Name = "CBEstatus";
            this.CBEstatus.Size = new System.Drawing.Size(180, 21);
            this.CBEstatus.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(102, 52);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(102, 26);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(257, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // GridGrupos
            // 
            this.GridGrupos.AllowUserToAddRows = false;
            this.GridGrupos.AllowUserToOrderColumns = true;
            this.GridGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chEan,
            this.chGrupo,
            this.chFechaMod,
            this.cTxtUnidad});
            this.GridGrupos.Location = new System.Drawing.Point(8, 281);
            this.GridGrupos.Name = "GridGrupos";
            this.GridGrupos.Size = new System.Drawing.Size(438, 211);
            this.GridGrupos.TabIndex = 8;
            this.GridGrupos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridGrupos_CellEndEdit);
            // 
            // chEan
            // 
            this.chEan.FillWeight = 90.85089F;
            this.chEan.HeaderText = "ID";
            this.chEan.Name = "chEan";
            // 
            // chGrupo
            // 
            this.chGrupo.FillWeight = 149.1178F;
            this.chGrupo.HeaderText = "Grupo";
            this.chGrupo.Name = "chGrupo";
            // 
            // chFechaMod
            // 
            this.chFechaMod.HeaderText = "Fecha";
            this.chFechaMod.Name = "chFechaMod";
            this.chFechaMod.Visible = false;
            // 
            // cTxtUnidad
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "1";
            this.cTxtUnidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.cTxtUnidad.FillWeight = 105.0958F;
            this.cTxtUnidad.HeaderText = "Cantidad (UM)";
            this.cTxtUnidad.Name = "cTxtUnidad";
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
            this.gridSubCategorias.Location = new System.Drawing.Point(453, 281);
            this.gridSubCategorias.Name = "gridSubCategorias";
            this.gridSubCategorias.Size = new System.Drawing.Size(265, 211);
            this.gridSubCategorias.TabIndex = 9;
            this.gridSubCategorias.DoubleClick += new System.EventHandler(this.gridSubCategorias_DoubleClick);
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
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "1";
            this.txtcCantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.txtcCantidad.HeaderText = "Cantidad";
            this.txtcCantidad.Name = "txtcCantidad";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAgregaSubCat,
            this.toolStripSeparator2});
            this.toolStrip2.Location = new System.Drawing.Point(677, 262);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(39, 25);
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
            this.toolStrip3.Location = new System.Drawing.Point(404, 250);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip3.Size = new System.Drawing.Size(39, 25);
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
            this.CBSubCategoria.Location = new System.Drawing.Point(453, 254);
            this.CBSubCategoria.Name = "CBSubCategoria";
            this.CBSubCategoria.Size = new System.Drawing.Size(222, 21);
            this.CBSubCategoria.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(453, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "SubCategoria";
            // 
            // CBCategoriaArt
            // 
            this.CBCategoriaArt.FormattingEnabled = true;
            this.CBCategoriaArt.Location = new System.Drawing.Point(8, 254);
            this.CBCategoriaArt.Name = "CBCategoriaArt";
            this.CBCategoriaArt.Size = new System.Drawing.Size(206, 21);
            this.CBCategoriaArt.TabIndex = 15;
            this.CBCategoriaArt.SelectedIndexChanged += new System.EventHandler(this.CBCategoriaArt_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "SubCategoria";
            // 
            // CBGrupo
            // 
            this.CBGrupo.FormattingEnabled = true;
            this.CBGrupo.Location = new System.Drawing.Point(220, 254);
            this.CBGrupo.Name = "CBGrupo";
            this.CBGrupo.Size = new System.Drawing.Size(181, 21);
            this.CBGrupo.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(217, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Grupo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Consumo Minimo";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(102, 132);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(56, 20);
            this.txtConsumo.TabIndex = 21;
            this.txtConsumo.Text = "0";
            // 
            // EdicionCombinaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 508);
            this.ControlBox = false;
            this.Controls.Add(this.CBGrupo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBCategoriaArt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBSubCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.GridGrupos);
            this.Controls.Add(this.gridSubCategorias);
            this.Controls.Add(this.GBCaptura);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EdicionCombinaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edicion Combinaciones";
            this.Load += new System.EventHandler(this.EdicionCombinaciones_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GBCaptura.ResumeLayout(false);
            this.GBCaptura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrupos)).EndInit();
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
        private System.Windows.Forms.DataGridView GridGrupos;
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
        private System.Windows.Forms.ComboBox CBGrupo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBCategorias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn chEan;
        private System.Windows.Forms.DataGridViewTextBoxColumn chGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn chFechaMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTxtUnidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox dtFin;
        private System.Windows.Forms.MaskedTextBox dtInicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtConsumo;
    }
}