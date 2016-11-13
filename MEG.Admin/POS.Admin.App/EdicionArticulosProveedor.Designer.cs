namespace POS.Admin.Appl
{
    partial class EdicionArticulosProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionArticulosProveedor));
            this.GBCaptura = new System.Windows.Forms.GroupBox();
            this.BTBorrar = new System.Windows.Forms.Button();
            this.BTBuscar = new System.Windows.Forms.Button();
            this.gridArticulosProv = new System.Windows.Forms.DataGridView();
            this.CBProveedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTMover = new System.Windows.Forms.Button();
            this.groupBusqueda = new System.Windows.Forms.GroupBox();
            this.radioDescripcion = new System.Windows.Forms.RadioButton();
            this.radioEan = new System.Windows.Forms.RadioButton();
            this.gridBusqueda = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.GBCaptura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulosProv)).BeginInit();
            this.groupBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // GBCaptura
            // 
            this.GBCaptura.Controls.Add(this.BTBorrar);
            this.GBCaptura.Controls.Add(this.BTBuscar);
            this.GBCaptura.Controls.Add(this.gridArticulosProv);
            this.GBCaptura.Controls.Add(this.CBProveedor);
            this.GBCaptura.Controls.Add(this.label6);
            this.GBCaptura.Location = new System.Drawing.Point(12, 31);
            this.GBCaptura.Name = "GBCaptura";
            this.GBCaptura.Size = new System.Drawing.Size(418, 484);
            this.GBCaptura.TabIndex = 2;
            this.GBCaptura.TabStop = false;
            this.GBCaptura.Text = "Campos Orden";
            // 
            // BTBorrar
            // 
            this.BTBorrar.Image = ((System.Drawing.Image)(resources.GetObject("BTBorrar.Image")));
            this.BTBorrar.Location = new System.Drawing.Point(379, 36);
            this.BTBorrar.Name = "BTBorrar";
            this.BTBorrar.Size = new System.Drawing.Size(23, 21);
            this.BTBorrar.TabIndex = 23;
            this.BTBorrar.UseVisualStyleBackColor = true;
            this.BTBorrar.Click += new System.EventHandler(this.BTBorrar_Click);
            // 
            // BTBuscar
            // 
            this.BTBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BTBuscar.Image")));
            this.BTBuscar.Location = new System.Drawing.Point(350, 36);
            this.BTBuscar.Name = "BTBuscar";
            this.BTBuscar.Size = new System.Drawing.Size(23, 21);
            this.BTBuscar.TabIndex = 22;
            this.BTBuscar.UseVisualStyleBackColor = true;
            this.BTBuscar.Click += new System.EventHandler(this.BTBuscar_Click);
            // 
            // gridArticulosProv
            // 
            this.gridArticulosProv.AllowUserToDeleteRows = false;
            this.gridArticulosProv.AllowUserToOrderColumns = true;
            this.gridArticulosProv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridArticulosProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArticulosProv.Location = new System.Drawing.Point(19, 64);
            this.gridArticulosProv.Name = "gridArticulosProv";
            this.gridArticulosProv.ReadOnly = true;
            this.gridArticulosProv.Size = new System.Drawing.Size(383, 407);
            this.gridArticulosProv.TabIndex = 5;
            // 
            // CBProveedor
            // 
            this.CBProveedor.FormattingEnabled = true;
            this.CBProveedor.Location = new System.Drawing.Point(19, 37);
            this.CBProveedor.Name = "CBProveedor";
            this.CBProveedor.Size = new System.Drawing.Size(329, 21);
            this.CBProveedor.TabIndex = 3;
            this.CBProveedor.TextChanged += new System.EventHandler(this.CBProveedor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Proveedor";
            // 
            // BTMover
            // 
            this.BTMover.Location = new System.Drawing.Point(436, 267);
            this.BTMover.Name = "BTMover";
            this.BTMover.Size = new System.Drawing.Size(31, 35);
            this.BTMover.TabIndex = 19;
            this.BTMover.Text = "<<";
            this.BTMover.UseVisualStyleBackColor = true;
            this.BTMover.Click += new System.EventHandler(this.BTMover_Click);
            // 
            // groupBusqueda
            // 
            this.groupBusqueda.Controls.Add(this.radioDescripcion);
            this.groupBusqueda.Controls.Add(this.radioEan);
            this.groupBusqueda.Controls.Add(this.gridBusqueda);
            this.groupBusqueda.Controls.Add(this.label4);
            this.groupBusqueda.Controls.Add(this.txtBuscar);
            this.groupBusqueda.Location = new System.Drawing.Point(473, 31);
            this.groupBusqueda.Name = "groupBusqueda";
            this.groupBusqueda.Size = new System.Drawing.Size(437, 484);
            this.groupBusqueda.TabIndex = 21;
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
            this.gridBusqueda.Size = new System.Drawing.Size(403, 407);
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
            // EdicionArticulosProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 528);
            this.Controls.Add(this.groupBusqueda);
            this.Controls.Add(this.BTMover);
            this.Controls.Add(this.GBCaptura);
            this.Name = "EdicionArticulosProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Artículos por Proveedor";
            this.Load += new System.EventHandler(this.EdicionArticulosProveedor_Load);
            this.GBCaptura.ResumeLayout(false);
            this.GBCaptura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulosProv)).EndInit();
            this.groupBusqueda.ResumeLayout(false);
            this.groupBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCaptura;
        private System.Windows.Forms.ComboBox CBProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTMover;
        private System.Windows.Forms.GroupBox groupBusqueda;
        private System.Windows.Forms.RadioButton radioDescripcion;
        private System.Windows.Forms.RadioButton radioEan;
        private System.Windows.Forms.DataGridView gridBusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView gridArticulosProv;
        private System.Windows.Forms.Button BTBuscar;
        private System.Windows.Forms.Button BTBorrar;
    }
}