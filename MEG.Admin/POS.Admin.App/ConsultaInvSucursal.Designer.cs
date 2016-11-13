namespace POS.Admin.Appl
{
    partial class ConsultaInvSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaInvSucursal));
            this.GBCaptura = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listTipo = new System.Windows.Forms.ListBox();
            this.dtpA = new System.Windows.Forms.DateTimePicker();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.GBCaptura.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCaptura
            // 
            this.GBCaptura.Controls.Add(this.label2);
            this.GBCaptura.Controls.Add(this.listTipo);
            this.GBCaptura.Controls.Add(this.dtpA);
            this.GBCaptura.Controls.Add(this.dtpDe);
            this.GBCaptura.Controls.Add(this.label1);
            this.GBCaptura.Controls.Add(this.label5);
            this.GBCaptura.Location = new System.Drawing.Point(8, 12);
            this.GBCaptura.Name = "GBCaptura";
            this.GBCaptura.Size = new System.Drawing.Size(160, 135);
            this.GBCaptura.TabIndex = 2;
            this.GBCaptura.TabStop = false;
            this.GBCaptura.Text = "Agregar parametros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo:";
            // 
            // listTipo
            // 
            this.listTipo.FormattingEnabled = true;
            this.listTipo.Items.AddRange(new object[] {
            "CATALOGO",
            "TRANSACCION"});
            this.listTipo.Location = new System.Drawing.Point(43, 104);
            this.listTipo.Name = "listTipo";
            this.listTipo.Size = new System.Drawing.Size(103, 17);
            this.listTipo.TabIndex = 5;
            // 
            // dtpA
            // 
            this.dtpA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpA.Location = new System.Drawing.Point(43, 66);
            this.dtpA.Name = "dtpA";
            this.dtpA.Size = new System.Drawing.Size(103, 20);
            this.dtpA.TabIndex = 4;
            // 
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(43, 28);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(103, 20);
            this.dtpDe.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "De:";
            // 
            // btAceptar
            // 
            this.btAceptar.ImageIndex = 0;
            this.btAceptar.ImageList = this.imageList1;
            this.btAceptar.Location = new System.Drawing.Point(134, 153);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(34, 37);
            this.btAceptar.TabIndex = 3;
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "download.gif");
            // 
            // ConsultaInvSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 201);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.GBCaptura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaInvSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros Consulta";
            this.Load += new System.EventHandler(this.ConsultaInvSucursal_Load);
            this.GBCaptura.ResumeLayout(false);
            this.GBCaptura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCaptura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DateTimePicker dtpA;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listTipo;
    }
}