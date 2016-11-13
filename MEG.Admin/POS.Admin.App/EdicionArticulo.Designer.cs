namespace POS.Admin.Appl
{
    partial class EdicionArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionArticulo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripModificaCodigo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.GBCaptura = new System.Windows.Forms.GroupBox();
            this.chbPrincipal = new System.Windows.Forms.CheckBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.dgvImagenes = new System.Windows.Forms.DataGridView();
            this.lblNombreImagen = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btAltaImg = new System.Windows.Forms.Button();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBSubCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBUnidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBImpuesto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CBEstatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ofImagen = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtPDistrib = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chbArtPrincipal = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.GBCaptura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGuardar,
            this.toolStripSeparator1,
            this.toolStripModificaCodigo,
            this.toolStripSeparator2,
            this.toolStripSalir,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(631, 25);
            this.toolStrip1.TabIndex = 0;
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
            // toolStripModificaCodigo
            // 
            this.toolStripModificaCodigo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripModificaCodigo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripModificaCodigo.Image")));
            this.toolStripModificaCodigo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripModificaCodigo.Name = "toolStripModificaCodigo";
            this.toolStripModificaCodigo.Size = new System.Drawing.Size(23, 22);
            this.toolStripModificaCodigo.Text = "Modificar Código EAN";
            this.toolStripModificaCodigo.Click += new System.EventHandler(this.toolStripModificaCodigo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.GBCaptura.Controls.Add(this.chbArtPrincipal);
            this.GBCaptura.Controls.Add(this.txtPDistrib);
            this.GBCaptura.Controls.Add(this.label11);
            this.GBCaptura.Controls.Add(this.chbPrincipal);
            this.GBCaptura.Controls.Add(this.btEliminar);
            this.GBCaptura.Controls.Add(this.dgvImagenes);
            this.GBCaptura.Controls.Add(this.lblNombreImagen);
            this.GBCaptura.Controls.Add(this.btSave);
            this.GBCaptura.Controls.Add(this.pbImagen);
            this.GBCaptura.Controls.Add(this.btAltaImg);
            this.GBCaptura.Controls.Add(this.txtVenta);
            this.GBCaptura.Controls.Add(this.label7);
            this.GBCaptura.Controls.Add(this.cbGrupo);
            this.GBCaptura.Controls.Add(this.label3);
            this.GBCaptura.Controls.Add(this.CBSubCategoria);
            this.GBCaptura.Controls.Add(this.label2);
            this.GBCaptura.Controls.Add(this.CBUnidad);
            this.GBCaptura.Controls.Add(this.label1);
            this.GBCaptura.Controls.Add(this.CBImpuesto);
            this.GBCaptura.Controls.Add(this.label4);
            this.GBCaptura.Controls.Add(this.txtCosto);
            this.GBCaptura.Controls.Add(this.label5);
            this.GBCaptura.Controls.Add(this.txtMedida);
            this.GBCaptura.Controls.Add(this.label6);
            this.GBCaptura.Controls.Add(this.txtDescripcion);
            this.GBCaptura.Controls.Add(this.label8);
            this.GBCaptura.Controls.Add(this.txtEan);
            this.GBCaptura.Controls.Add(this.label9);
            this.GBCaptura.Controls.Add(this.CBEstatus);
            this.GBCaptura.Controls.Add(this.label10);
            this.GBCaptura.Location = new System.Drawing.Point(12, 38);
            this.GBCaptura.Name = "GBCaptura";
            this.GBCaptura.Size = new System.Drawing.Size(607, 487);
            this.GBCaptura.TabIndex = 1;
            this.GBCaptura.TabStop = false;
            this.GBCaptura.Text = "Campos Artículo";
            // 
            // chbPrincipal
            // 
            this.chbPrincipal.AutoSize = true;
            this.chbPrincipal.Location = new System.Drawing.Point(488, 284);
            this.chbPrincipal.Name = "chbPrincipal";
            this.chbPrincipal.Size = new System.Drawing.Size(104, 17);
            this.chbPrincipal.TabIndex = 25;
            this.chbPrincipal.Text = "Imagen Principal";
            this.chbPrincipal.UseVisualStyleBackColor = true;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(373, 369);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(53, 23);
            this.btEliminar.TabIndex = 21;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // dgvImagenes
            // 
            this.dgvImagenes.AllowUserToAddRows = false;
            this.dgvImagenes.AllowUserToOrderColumns = true;
            this.dgvImagenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImagenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImagenes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImagenes.Location = new System.Drawing.Point(16, 311);
            this.dgvImagenes.MultiSelect = false;
            this.dgvImagenes.Name = "dgvImagenes";
            this.dgvImagenes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImagenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvImagenes.Size = new System.Drawing.Size(337, 160);
            this.dgvImagenes.TabIndex = 18;
            this.dgvImagenes.DoubleClick += new System.EventHandler(this.dgvImagenes_DoubleClick);
            // 
            // lblNombreImagen
            // 
            this.lblNombreImagen.Location = new System.Drawing.Point(281, 255);
            this.lblNombreImagen.Name = "lblNombreImagen";
            this.lblNombreImagen.Size = new System.Drawing.Size(311, 26);
            this.lblNombreImagen.TabIndex = 24;
            this.lblNombreImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(373, 340);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(53, 23);
            this.btSave.TabIndex = 20;
            this.btSave.Text = "Agregar";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(432, 311);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(160, 160);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 22;
            this.pbImagen.TabStop = false;
            // 
            // btAltaImg
            // 
            this.btAltaImg.Location = new System.Drawing.Point(373, 311);
            this.btAltaImg.Name = "btAltaImg";
            this.btAltaImg.Size = new System.Drawing.Size(53, 23);
            this.btAltaImg.TabIndex = 19;
            this.btAltaImg.Text = "Buscar";
            this.btAltaImg.UseVisualStyleBackColor = true;
            this.btAltaImg.Click += new System.EventHandler(this.btAltaImg_Click);
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(258, 84);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(84, 20);
            this.txtVenta.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio Venta";
            // 
            // cbGrupo
            // 
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(84, 206);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(131, 21);
            this.cbGrupo.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Grupo";
            // 
            // CBSubCategoria
            // 
            this.CBSubCategoria.FormattingEnabled = true;
            this.CBSubCategoria.Location = new System.Drawing.Point(84, 175);
            this.CBSubCategoria.Name = "CBSubCategoria";
            this.CBSubCategoria.Size = new System.Drawing.Size(131, 21);
            this.CBSubCategoria.TabIndex = 13;
            this.CBSubCategoria.SelectedIndexChanged += new System.EventHandler(this.CBSubCategoria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "SubCategoria";
            // 
            // CBUnidad
            // 
            this.CBUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBUnidad.FormattingEnabled = true;
            this.CBUnidad.Location = new System.Drawing.Point(84, 144);
            this.CBUnidad.Name = "CBUnidad";
            this.CBUnidad.Size = new System.Drawing.Size(131, 21);
            this.CBUnidad.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Unidad";
            // 
            // CBImpuesto
            // 
            this.CBImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBImpuesto.FormattingEnabled = true;
            this.CBImpuesto.Location = new System.Drawing.Point(84, 114);
            this.CBImpuesto.Name = "CBImpuesto";
            this.CBImpuesto.Size = new System.Drawing.Size(131, 21);
            this.CBImpuesto.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Estatus";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(84, 84);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(84, 20);
            this.txtCosto.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo EAN";
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(281, 144);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(84, 20);
            this.txtMedida.TabIndex = 11;
            this.txtMedida.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(84, 58);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(338, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Medida";
            // 
            // txtEan
            // 
            this.txtEan.Location = new System.Drawing.Point(84, 29);
            this.txtEan.Name = "txtEan";
            this.txtEan.Size = new System.Drawing.Size(168, 20);
            this.txtEan.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Precio Costo";
            // 
            // CBEstatus
            // 
            this.CBEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstatus.FormattingEnabled = true;
            this.CBEstatus.Location = new System.Drawing.Point(84, 237);
            this.CBEstatus.Name = "CBEstatus";
            this.CBEstatus.Size = new System.Drawing.Size(131, 21);
            this.CBEstatus.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "I.V.A.";
            // 
            // ofImagen
            // 
            this.ofImagen.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtPDistrib
            // 
            this.txtPDistrib.Location = new System.Drawing.Point(457, 84);
            this.txtPDistrib.Name = "txtPDistrib";
            this.txtPDistrib.Size = new System.Drawing.Size(84, 20);
            this.txtPDistrib.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(357, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Precio Distribuidor";
            // 
            // chbArtPrincipal
            // 
            this.chbArtPrincipal.AutoSize = true;
            this.chbArtPrincipal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbArtPrincipal.Location = new System.Drawing.Point(49, 267);
            this.chbArtPrincipal.Name = "chbArtPrincipal";
            this.chbArtPrincipal.Size = new System.Drawing.Size(49, 17);
            this.chbArtPrincipal.TabIndex = 28;
            this.chbArtPrincipal.Text = "Main";
            this.chbArtPrincipal.UseVisualStyleBackColor = true;
            // 
            // EdicionArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 539);
            this.ControlBox = false;
            this.Controls.Add(this.GBCaptura);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EdicionArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edición Artículo";
            this.Load += new System.EventHandler(this.EdicionArticulo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GBCaptura.ResumeLayout(false);
            this.GBCaptura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox GBCaptura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBEstatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripButton toolStripModificaCodigo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ComboBox CBImpuesto;
        private System.Windows.Forms.ComboBox CBSubCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBUnidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog ofImagen;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btAltaImg;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lblNombreImagen;
        private System.Windows.Forms.DataGridView dgvImagenes;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.CheckBox chbPrincipal;
        private System.Windows.Forms.TextBox txtPDistrib;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chbArtPrincipal;
    }
}