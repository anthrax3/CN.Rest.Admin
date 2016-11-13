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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionArticulo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripModificaCodigo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.GBCaptura = new System.Windows.Forms.GroupBox();
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
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.GBCaptura.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(463, 25);
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
            this.GBCaptura.Size = new System.Drawing.Size(437, 277);
            this.GBCaptura.TabIndex = 0;
            this.GBCaptura.TabStop = false;
            this.GBCaptura.Text = "Campos Artículo";
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
            this.CBUnidad.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Unidad";
            // 
            // CBImpuesto
            // 
            this.CBImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBImpuesto.FormattingEnabled = true;
            this.CBImpuesto.Location = new System.Drawing.Point(84, 114);
            this.CBImpuesto.Name = "CBImpuesto";
            this.CBImpuesto.Size = new System.Drawing.Size(131, 21);
            this.CBImpuesto.TabIndex = 7;
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
            this.label10.TabIndex = 6;
            this.label10.Text = "I.V.A.";
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(258, 84);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(84, 20);
            this.txtVenta.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Precio Venta";
            // 
            // EdicionArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 327);
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
    }
}