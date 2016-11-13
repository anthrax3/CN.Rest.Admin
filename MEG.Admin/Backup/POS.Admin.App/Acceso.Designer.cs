namespace POS.Admin.Appl
{
    partial class Acceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceso));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btCancelar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btAceptar);
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // btAceptar
            // 
            this.btAceptar.ImageKey = "113.ICO";
            this.btAceptar.ImageList = this.imageList1;
            this.btAceptar.Location = new System.Drawing.Point(183, 94);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(41, 38);
            this.btAceptar.TabIndex = 4;
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "113.ICO");
            this.imageList1.Images.SetKeyName(1, "216.ICO");
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.ImageKey = "216.ICO";
            this.btCancelar.ImageList = this.imageList1;
            this.btCancelar.Location = new System.Drawing.Point(243, 94);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(41, 38);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(87, 59);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(197, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(87, 24);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(197, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // Acceso
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(325, 167);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Acceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.Acceso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ImageList imageList1;
    }
}