namespace POS.Admin.Appl
{
    partial class EdicionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionUsuario));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.GBCaptura = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.CBRoles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaterno = new System.Windows.Forms.TextBox();
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
            this.toolStrip1.Size = new System.Drawing.Size(366, 25);
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
            this.GBCaptura.Controls.Add(this.label5);
            this.GBCaptura.Controls.Add(this.txtMaterno);
            this.GBCaptura.Controls.Add(this.label4);
            this.GBCaptura.Controls.Add(this.txtPaterno);
            this.GBCaptura.Controls.Add(this.label3);
            this.GBCaptura.Controls.Add(this.txtNombre);
            this.GBCaptura.Controls.Add(this.label);
            this.GBCaptura.Controls.Add(this.CBRoles);
            this.GBCaptura.Controls.Add(this.label2);
            this.GBCaptura.Controls.Add(this.txtConfirmar);
            this.GBCaptura.Controls.Add(this.label1);
            this.GBCaptura.Controls.Add(this.txtPassword);
            this.GBCaptura.Controls.Add(this.label6);
            this.GBCaptura.Controls.Add(this.txtUsuario);
            this.GBCaptura.Location = new System.Drawing.Point(12, 38);
            this.GBCaptura.Name = "GBCaptura";
            this.GBCaptura.Size = new System.Drawing.Size(338, 210);
            this.GBCaptura.TabIndex = 4;
            this.GBCaptura.TabStop = false;
            this.GBCaptura.Text = "Campos Usuario";
            this.GBCaptura.Enter += new System.EventHandler(this.GBCaptura_Enter);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(54, 181);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(23, 13);
            this.label.TabIndex = 9;
            this.label.Text = "Rol";
            // 
            // CBRoles
            // 
            this.CBRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRoles.FormattingEnabled = true;
            this.CBRoles.Location = new System.Drawing.Point(83, 178);
            this.CBRoles.Name = "CBRoles";
            this.CBRoles.Size = new System.Drawing.Size(237, 21);
            this.CBRoles.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirmar";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(83, 152);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(150, 20);
            this.txtConfirmar.TabIndex = 7;
            this.txtConfirmar.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(83, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(83, 97);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(180, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "A. Paterno";
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(83, 45);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(180, 20);
            this.txtPaterno.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "A. Materno";
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(83, 71);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(180, 20);
            this.txtMaterno.TabIndex = 15;
            // 
            // EdicionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 257);
            this.ControlBox = false;
            this.Controls.Add(this.GBCaptura);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EdicionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición Usuario";
            this.Load += new System.EventHandler(this.EdicionUsuario_Load);
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
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox CBRoles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
    }
}