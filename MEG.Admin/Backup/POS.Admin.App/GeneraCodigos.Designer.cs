namespace POS.Admin.Appl
{
    partial class GeneraCodigos
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
            this.barcodeNETWindows1 = new BarcodeNETWorkShop.BarcodeNETWindows();
            this.groupBusqueda = new System.Windows.Forms.GroupBox();
            this.radioDescripcion = new System.Windows.Forms.RadioButton();
            this.radioEan = new System.Windows.Forms.RadioButton();
            this.gridBusqueda = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTGenera = new System.Windows.Forms.Button();
            this.BTImprime = new System.Windows.Forms.Button();
            this.gridListado = new System.Windows.Forms.DataGridView();
            this.eanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulosCodigoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTMover = new System.Windows.Forms.Button();
            this.groupBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBusqueda)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosCodigoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barcodeNETWindows1
            // 
            this.barcodeNETWindows1.AntiAlias = false;
            this.barcodeNETWindows1.BarcodeColor = System.Drawing.Color.Black;
            this.barcodeNETWindows1.BarcodeGap = new BarcodeNETWorkShop.Core.TextGap(1, 1, 1, 1);
            this.barcodeNETWindows1.BarcodeMargins = new BarcodeNETWorkShop.Core.MarginBound(10, 10, 10, 10);
            this.barcodeNETWindows1.BarcodeText = "BarcodeNET";
            this.barcodeNETWindows1.BarcodeType = BarcodeNETWorkShop.Core.BARCODE_TYPE.CODE128B;
            this.barcodeNETWindows1.BarHeight = 60;
            this.barcodeNETWindows1.BarWidth = 1;
            this.barcodeNETWindows1.BgColor = System.Drawing.Color.White;
            this.barcodeNETWindows1.CustomText = "";
            this.barcodeNETWindows1.ExceptionType = BarcodeNETWorkShop.Core.EXCEPTION_TYPE.DEFAULT_MSG;
            this.barcodeNETWindows1.FileFormat = BarcodeNETWorkShop.Core.FILE_FORMAT.PNG;
            this.barcodeNETWindows1.IncludeChecksumDigit = true;
            this.barcodeNETWindows1.IsRounded = false;
            this.barcodeNETWindows1.Location = new System.Drawing.Point(165, 18);
            this.barcodeNETWindows1.Name = "barcodeNETWindows1";
            this.barcodeNETWindows1.RotateAngle = BarcodeNETWorkShop.Core.ROTATE_ANGLE.R0;
            this.barcodeNETWindows1.ShowBarcodeText = true;
            this.barcodeNETWindows1.ShowBorder = false;
            this.barcodeNETWindows1.SilentMode = false;
            this.barcodeNETWindows1.Size = new System.Drawing.Size(167, 108);
            this.barcodeNETWindows1.SupplementalText = "";
            this.barcodeNETWindows1.SupplementalTextStyle = BarcodeNETWorkShop.Core.SUPPLEMENTAL_TEXT_STYLE.TOP;
            this.barcodeNETWindows1.TabIndex = 0;
            this.barcodeNETWindows1.TextColor = System.Drawing.Color.Black;
            this.barcodeNETWindows1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.barcodeNETWindows1.TopText = "";
            // 
            // groupBusqueda
            // 
            this.groupBusqueda.Controls.Add(this.radioDescripcion);
            this.groupBusqueda.Controls.Add(this.radioEan);
            this.groupBusqueda.Controls.Add(this.gridBusqueda);
            this.groupBusqueda.Controls.Add(this.label4);
            this.groupBusqueda.Controls.Add(this.txtBuscar);
            this.groupBusqueda.Location = new System.Drawing.Point(12, 12);
            this.groupBusqueda.Name = "groupBusqueda";
            this.groupBusqueda.Size = new System.Drawing.Size(437, 471);
            this.groupBusqueda.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTGenera);
            this.groupBox1.Controls.Add(this.BTImprime);
            this.groupBox1.Controls.Add(this.gridListado);
            this.groupBox1.Controls.Add(this.barcodeNETWindows1);
            this.groupBox1.Location = new System.Drawing.Point(492, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 471);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Artículos";
            // 
            // BTGenera
            // 
            this.BTGenera.Location = new System.Drawing.Point(17, 51);
            this.BTGenera.Name = "BTGenera";
            this.BTGenera.Size = new System.Drawing.Size(99, 22);
            this.BTGenera.TabIndex = 6;
            this.BTGenera.Text = "Generar Códigos";
            this.BTGenera.UseVisualStyleBackColor = true;
            this.BTGenera.Click += new System.EventHandler(this.BTGenera_Click);
            // 
            // BTImprime
            // 
            this.BTImprime.Location = new System.Drawing.Point(17, 23);
            this.BTImprime.Name = "BTImprime";
            this.BTImprime.Size = new System.Drawing.Size(99, 22);
            this.BTImprime.TabIndex = 5;
            this.BTImprime.Text = "Imprimir Códigos";
            this.BTImprime.UseVisualStyleBackColor = true;
            this.BTImprime.Click += new System.EventHandler(this.BTImprime_Click);
            // 
            // gridListado
            // 
            this.gridListado.AllowUserToOrderColumns = true;
            this.gridListado.AutoGenerateColumns = false;
            this.gridListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eanDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.gridListado.DataSource = this.articulosCodigoBindingSource;
            this.gridListado.Location = new System.Drawing.Point(17, 133);
            this.gridListado.Name = "gridListado";
            this.gridListado.ReadOnly = true;
            this.gridListado.Size = new System.Drawing.Size(364, 319);
            this.gridListado.TabIndex = 4;
            this.gridListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListado_CellClick);
            // 
            // eanDataGridViewTextBoxColumn
            // 
            this.eanDataGridViewTextBoxColumn.DataPropertyName = "ean";
            this.eanDataGridViewTextBoxColumn.HeaderText = "Código EAN";
            this.eanDataGridViewTextBoxColumn.Name = "eanDataGridViewTextBoxColumn";
            this.eanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articulosCodigoBindingSource
            // 
            this.articulosCodigoBindingSource.DataSource = typeof(POS.Admin.Identities.ArticulosCodigo);
            // 
            // BTMover
            // 
            this.BTMover.Location = new System.Drawing.Point(455, 218);
            this.BTMover.Name = "BTMover";
            this.BTMover.Size = new System.Drawing.Size(31, 35);
            this.BTMover.TabIndex = 7;
            this.BTMover.Text = ">>";
            this.BTMover.UseVisualStyleBackColor = true;
            this.BTMover.Click += new System.EventHandler(this.BTMover_Click);
            // 
            // GeneraCodigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 497);
            this.Controls.Add(this.BTMover);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBusqueda);
            this.MaximizeBox = false;
            this.Name = "GeneraCodigos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generador de Códigos";
            this.groupBusqueda.ResumeLayout(false);
            this.groupBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBusqueda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosCodigoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BarcodeNETWorkShop.BarcodeNETWindows barcodeNETWindows1;
        private System.Windows.Forms.GroupBox groupBusqueda;
        private System.Windows.Forms.RadioButton radioDescripcion;
        private System.Windows.Forms.RadioButton radioEan;
        private System.Windows.Forms.DataGridView gridBusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTGenera;
        private System.Windows.Forms.Button BTImprime;
        private System.Windows.Forms.DataGridView gridListado;
        private System.Windows.Forms.Button BTMover;
        private System.Windows.Forms.DataGridViewTextBoxColumn eanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource articulosCodigoBindingSource;
    }
}