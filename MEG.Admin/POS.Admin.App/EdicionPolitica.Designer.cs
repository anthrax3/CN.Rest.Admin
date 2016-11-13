namespace POS.Admin.Appl
{
    partial class EdicionPolitica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionPolitica));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.GBCaptura = new System.Windows.Forms.GroupBox();
            this.CHBVisualizar = new System.Windows.Forms.CheckBox();
            this.CHBEliminar = new System.Windows.Forms.CheckBox();
            this.CHBModificar = new System.Windows.Forms.CheckBox();
            this.CHBAgregar = new System.Windows.Forms.CheckBox();
            this.lblModulo = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.GBCaptura.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(343, 25);
            this.toolStrip1.TabIndex = 3;
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
            this.GBCaptura.Controls.Add(this.CHBVisualizar);
            this.GBCaptura.Controls.Add(this.CHBEliminar);
            this.GBCaptura.Controls.Add(this.CHBModificar);
            this.GBCaptura.Controls.Add(this.CHBAgregar);
            this.GBCaptura.Controls.Add(this.lblModulo);
            this.GBCaptura.Controls.Add(this.lblRol);
            this.GBCaptura.Controls.Add(this.label1);
            this.GBCaptura.Controls.Add(this.label6);
            this.GBCaptura.Location = new System.Drawing.Point(12, 38);
            this.GBCaptura.Name = "GBCaptura";
            this.GBCaptura.Size = new System.Drawing.Size(318, 192);
            this.GBCaptura.TabIndex = 4;
            this.GBCaptura.TabStop = false;
            this.GBCaptura.Text = "Campos Política";
            // 
            // CHBVisualizar
            // 
            this.CHBVisualizar.AutoSize = true;
            this.CHBVisualizar.Location = new System.Drawing.Point(64, 162);
            this.CHBVisualizar.Name = "CHBVisualizar";
            this.CHBVisualizar.Size = new System.Drawing.Size(70, 17);
            this.CHBVisualizar.TabIndex = 10;
            this.CHBVisualizar.Text = "Visualizar";
            this.CHBVisualizar.UseVisualStyleBackColor = true;
            // 
            // CHBEliminar
            // 
            this.CHBEliminar.AutoSize = true;
            this.CHBEliminar.Location = new System.Drawing.Point(64, 139);
            this.CHBEliminar.Name = "CHBEliminar";
            this.CHBEliminar.Size = new System.Drawing.Size(62, 17);
            this.CHBEliminar.TabIndex = 9;
            this.CHBEliminar.Text = "Eliminar";
            this.CHBEliminar.UseVisualStyleBackColor = true;
            // 
            // CHBModificar
            // 
            this.CHBModificar.AutoSize = true;
            this.CHBModificar.Location = new System.Drawing.Point(64, 116);
            this.CHBModificar.Name = "CHBModificar";
            this.CHBModificar.Size = new System.Drawing.Size(69, 17);
            this.CHBModificar.TabIndex = 8;
            this.CHBModificar.Text = "Modificar";
            this.CHBModificar.UseVisualStyleBackColor = true;
            // 
            // CHBAgregar
            // 
            this.CHBAgregar.AutoSize = true;
            this.CHBAgregar.Location = new System.Drawing.Point(64, 93);
            this.CHBAgregar.Name = "CHBAgregar";
            this.CHBAgregar.Size = new System.Drawing.Size(63, 17);
            this.CHBAgregar.TabIndex = 7;
            this.CHBAgregar.Text = "Agregar";
            this.CHBAgregar.UseVisualStyleBackColor = true;
            // 
            // lblModulo
            // 
            this.lblModulo.BackColor = System.Drawing.Color.White;
            this.lblModulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblModulo.Location = new System.Drawing.Point(64, 57);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(237, 21);
            this.lblModulo.TabIndex = 5;
            // 
            // lblRol
            // 
            this.lblRol.BackColor = System.Drawing.Color.White;
            this.lblRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRol.Location = new System.Drawing.Point(64, 31);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(237, 21);
            this.lblRol.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Módulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Rol";
            // 
            // EdicionPolitica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 246);
            this.ControlBox = false;
            this.Controls.Add(this.GBCaptura);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EdicionPolitica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición Política";
            this.Load += new System.EventHandler(this.EdicionPolitica_Load);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox GBCaptura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CHBVisualizar;
        private System.Windows.Forms.CheckBox CHBEliminar;
        private System.Windows.Forms.CheckBox CHBModificar;
        private System.Windows.Forms.CheckBox CHBAgregar;
    }
}