namespace POS.Admin.Appl
{
    partial class UCSeguridad
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSeguridad));
            this.BTCargaRol = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageListSeguridad = new System.Windows.Forms.ImageList(this.components);
            this.TabCatalogs = new System.Windows.Forms.TabControl();
            this.tabSeguridad = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridPoliticas = new System.Windows.Forms.DataGridView();
            this.gridModulos = new System.Windows.Forms.DataGridView();
            this.gridRoles = new System.Windows.Forms.DataGridView();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.BTCargarPolitica = new System.Windows.Forms.Button();
            this.BTEliminaUsuario = new System.Windows.Forms.Button();
            this.BTCargaUsuario = new System.Windows.Forms.Button();
            this.BTNuevoUsuario = new System.Windows.Forms.Button();
            this.BTAsignaPolitica = new System.Windows.Forms.Button();
            this.BTEliminaPolitica = new System.Windows.Forms.Button();
            this.BTCargaModulo = new System.Windows.Forms.Button();
            this.BTEliminaRol = new System.Windows.Forms.Button();
            this.BTNuevoRol = new System.Windows.Forms.Button();
            this.tabRespaldos = new System.Windows.Forms.TabPage();
            this.gridRespaldos = new System.Windows.Forms.DataGridView();
            this.TSRespaldos = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel17 = new System.Windows.Forms.ToolStripLabel();
            this.cbRespaldos = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator35 = new System.Windows.Forms.ToolStripSeparator();
            this.cbBuscaRespaldo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator37 = new System.Windows.Forms.ToolStripSeparator();
            this.TabCatalogs.SuspendLayout();
            this.tabSeguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPoliticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.tabRespaldos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRespaldos)).BeginInit();
            this.TSRespaldos.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTCargaRol
            // 
            this.BTCargaRol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTCargaRol.ImageIndex = 2;
            this.BTCargaRol.ImageList = this.imageList1;
            this.BTCargaRol.Location = new System.Drawing.Point(6, 17);
            this.BTCargaRol.Name = "BTCargaRol";
            this.BTCargaRol.Size = new System.Drawing.Size(48, 39);
            this.BTCargaRol.TabIndex = 27;
            this.BTCargaRol.UseVisualStyleBackColor = true;
            this.BTCargaRol.Click += new System.EventHandler(this.BTCargaRol_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "135.ICO");
            this.imageList1.Images.SetKeyName(1, "132.ICO");
            this.imageList1.Images.SetKeyName(2, "136.ICO");
            this.imageList1.Images.SetKeyName(3, "177.ICO");
            // 
            // imageListSeguridad
            // 
            this.imageListSeguridad.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSeguridad.ImageStream")));
            this.imageListSeguridad.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSeguridad.Images.SetKeyName(0, "135.ICO");
            this.imageListSeguridad.Images.SetKeyName(1, "132.ICO");
            this.imageListSeguridad.Images.SetKeyName(2, "136.ICO");
            this.imageListSeguridad.Images.SetKeyName(3, "177.ICO");
            // 
            // TabCatalogs
            // 
            this.TabCatalogs.Controls.Add(this.tabSeguridad);
            this.TabCatalogs.Controls.Add(this.tabRespaldos);
            this.TabCatalogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCatalogs.Location = new System.Drawing.Point(0, 0);
            this.TabCatalogs.Name = "TabCatalogs";
            this.TabCatalogs.SelectedIndex = 0;
            this.TabCatalogs.Size = new System.Drawing.Size(906, 580);
            this.TabCatalogs.TabIndex = 16;
            // 
            // tabSeguridad
            // 
            this.tabSeguridad.Controls.Add(this.label7);
            this.tabSeguridad.Controls.Add(this.label6);
            this.tabSeguridad.Controls.Add(this.label4);
            this.tabSeguridad.Controls.Add(this.label3);
            this.tabSeguridad.Controls.Add(this.gridPoliticas);
            this.tabSeguridad.Controls.Add(this.gridModulos);
            this.tabSeguridad.Controls.Add(this.gridRoles);
            this.tabSeguridad.Controls.Add(this.gridUsuarios);
            this.tabSeguridad.Controls.Add(this.BTCargarPolitica);
            this.tabSeguridad.Controls.Add(this.BTEliminaUsuario);
            this.tabSeguridad.Controls.Add(this.BTCargaUsuario);
            this.tabSeguridad.Controls.Add(this.BTNuevoUsuario);
            this.tabSeguridad.Controls.Add(this.BTAsignaPolitica);
            this.tabSeguridad.Controls.Add(this.BTEliminaPolitica);
            this.tabSeguridad.Controls.Add(this.BTCargaModulo);
            this.tabSeguridad.Controls.Add(this.BTEliminaRol);
            this.tabSeguridad.Controls.Add(this.BTCargaRol);
            this.tabSeguridad.Controls.Add(this.BTNuevoRol);
            this.tabSeguridad.Location = new System.Drawing.Point(4, 22);
            this.tabSeguridad.Name = "tabSeguridad";
            this.tabSeguridad.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeguridad.Size = new System.Drawing.Size(898, 554);
            this.tabSeguridad.TabIndex = 9;
            this.tabSeguridad.Text = "Seguridad";
            this.tabSeguridad.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(793, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 23);
            this.label7.TabIndex = 48;
            this.label7.Text = "MÓDULOS";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(788, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "POLÍTICAS";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "USUARIOS";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "ROLES";
            // 
            // gridPoliticas
            // 
            this.gridPoliticas.AllowUserToAddRows = false;
            this.gridPoliticas.AllowUserToDeleteRows = false;
            this.gridPoliticas.AllowUserToOrderColumns = true;
            this.gridPoliticas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridPoliticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPoliticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPoliticas.Location = new System.Drawing.Point(456, 317);
            this.gridPoliticas.MultiSelect = false;
            this.gridPoliticas.Name = "gridPoliticas";
            this.gridPoliticas.Size = new System.Drawing.Size(438, 217);
            this.gridPoliticas.TabIndex = 25;
            // 
            // gridModulos
            // 
            this.gridModulos.AllowUserToAddRows = false;
            this.gridModulos.AllowUserToDeleteRows = false;
            this.gridModulos.AllowUserToOrderColumns = true;
            this.gridModulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridModulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridModulos.Location = new System.Drawing.Point(456, 62);
            this.gridModulos.MultiSelect = false;
            this.gridModulos.Name = "gridModulos";
            this.gridModulos.ReadOnly = true;
            this.gridModulos.Size = new System.Drawing.Size(436, 204);
            this.gridModulos.TabIndex = 24;
            // 
            // gridRoles
            // 
            this.gridRoles.AllowUserToAddRows = false;
            this.gridRoles.AllowUserToDeleteRows = false;
            this.gridRoles.AllowUserToOrderColumns = true;
            this.gridRoles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRoles.Location = new System.Drawing.Point(4, 62);
            this.gridRoles.MultiSelect = false;
            this.gridRoles.Name = "gridRoles";
            this.gridRoles.ReadOnly = true;
            this.gridRoles.Size = new System.Drawing.Size(436, 204);
            this.gridRoles.TabIndex = 23;
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.AllowUserToAddRows = false;
            this.gridUsuarios.AllowUserToDeleteRows = false;
            this.gridUsuarios.AllowUserToOrderColumns = true;
            this.gridUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Location = new System.Drawing.Point(6, 317);
            this.gridUsuarios.MultiSelect = false;
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.ReadOnly = true;
            this.gridUsuarios.Size = new System.Drawing.Size(436, 217);
            this.gridUsuarios.TabIndex = 22;
            // 
            // BTCargarPolitica
            // 
            this.BTCargarPolitica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTCargarPolitica.ImageIndex = 2;
            this.BTCargarPolitica.ImageList = this.imageList1;
            this.BTCargarPolitica.Location = new System.Drawing.Point(456, 272);
            this.BTCargarPolitica.Name = "BTCargarPolitica";
            this.BTCargarPolitica.Size = new System.Drawing.Size(48, 39);
            this.BTCargarPolitica.TabIndex = 44;
            this.BTCargarPolitica.UseVisualStyleBackColor = true;
            this.BTCargarPolitica.Click += new System.EventHandler(this.BTCargarPolitica_Click);
            // 
            // BTEliminaUsuario
            // 
            this.BTEliminaUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTEliminaUsuario.ImageIndex = 1;
            this.BTEliminaUsuario.ImageList = this.imageList1;
            this.BTEliminaUsuario.Location = new System.Drawing.Point(114, 272);
            this.BTEliminaUsuario.Name = "BTEliminaUsuario";
            this.BTEliminaUsuario.Size = new System.Drawing.Size(48, 39);
            this.BTEliminaUsuario.TabIndex = 43;
            this.BTEliminaUsuario.UseVisualStyleBackColor = true;
            this.BTEliminaUsuario.Click += new System.EventHandler(this.BTEliminaUsuario_Click);
            // 
            // BTCargaUsuario
            // 
            this.BTCargaUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTCargaUsuario.ImageIndex = 2;
            this.BTCargaUsuario.ImageList = this.imageList1;
            this.BTCargaUsuario.Location = new System.Drawing.Point(6, 272);
            this.BTCargaUsuario.Name = "BTCargaUsuario";
            this.BTCargaUsuario.Size = new System.Drawing.Size(48, 39);
            this.BTCargaUsuario.TabIndex = 42;
            this.BTCargaUsuario.UseVisualStyleBackColor = true;
            this.BTCargaUsuario.Click += new System.EventHandler(this.BTCargaUsuario_Click);
            // 
            // BTNuevoUsuario
            // 
            this.BTNuevoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTNuevoUsuario.ImageIndex = 0;
            this.BTNuevoUsuario.ImageList = this.imageList1;
            this.BTNuevoUsuario.Location = new System.Drawing.Point(60, 272);
            this.BTNuevoUsuario.Name = "BTNuevoUsuario";
            this.BTNuevoUsuario.Size = new System.Drawing.Size(48, 39);
            this.BTNuevoUsuario.TabIndex = 41;
            this.BTNuevoUsuario.UseVisualStyleBackColor = true;
            this.BTNuevoUsuario.Click += new System.EventHandler(this.BTNuevoUsuario_Click);
            // 
            // BTAsignaPolitica
            // 
            this.BTAsignaPolitica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTAsignaPolitica.ImageIndex = 0;
            this.BTAsignaPolitica.ImageList = this.imageList1;
            this.BTAsignaPolitica.Location = new System.Drawing.Point(510, 272);
            this.BTAsignaPolitica.Name = "BTAsignaPolitica";
            this.BTAsignaPolitica.Size = new System.Drawing.Size(48, 39);
            this.BTAsignaPolitica.TabIndex = 39;
            this.BTAsignaPolitica.UseVisualStyleBackColor = true;
            this.BTAsignaPolitica.Click += new System.EventHandler(this.BTAsignaPolitica_Click);
            // 
            // BTEliminaPolitica
            // 
            this.BTEliminaPolitica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTEliminaPolitica.ImageIndex = 1;
            this.BTEliminaPolitica.ImageList = this.imageList1;
            this.BTEliminaPolitica.Location = new System.Drawing.Point(564, 272);
            this.BTEliminaPolitica.Name = "BTEliminaPolitica";
            this.BTEliminaPolitica.Size = new System.Drawing.Size(48, 39);
            this.BTEliminaPolitica.TabIndex = 38;
            this.BTEliminaPolitica.UseVisualStyleBackColor = true;
            this.BTEliminaPolitica.Click += new System.EventHandler(this.BTEliminaPolitica_Click);
            // 
            // BTCargaModulo
            // 
            this.BTCargaModulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTCargaModulo.ImageIndex = 2;
            this.BTCargaModulo.ImageList = this.imageList1;
            this.BTCargaModulo.Location = new System.Drawing.Point(456, 17);
            this.BTCargaModulo.Name = "BTCargaModulo";
            this.BTCargaModulo.Size = new System.Drawing.Size(48, 39);
            this.BTCargaModulo.TabIndex = 36;
            this.BTCargaModulo.UseVisualStyleBackColor = true;
            this.BTCargaModulo.Click += new System.EventHandler(this.BTCargaModulo_Click);
            // 
            // BTEliminaRol
            // 
            this.BTEliminaRol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTEliminaRol.ImageIndex = 1;
            this.BTEliminaRol.ImageList = this.imageList1;
            this.BTEliminaRol.Location = new System.Drawing.Point(114, 17);
            this.BTEliminaRol.Name = "BTEliminaRol";
            this.BTEliminaRol.Size = new System.Drawing.Size(48, 39);
            this.BTEliminaRol.TabIndex = 34;
            this.BTEliminaRol.UseVisualStyleBackColor = true;
            this.BTEliminaRol.Click += new System.EventHandler(this.BTEliminaRol_Click);
            // 
            // BTNuevoRol
            // 
            this.BTNuevoRol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTNuevoRol.ImageIndex = 0;
            this.BTNuevoRol.ImageList = this.imageList1;
            this.BTNuevoRol.Location = new System.Drawing.Point(60, 17);
            this.BTNuevoRol.Name = "BTNuevoRol";
            this.BTNuevoRol.Size = new System.Drawing.Size(48, 39);
            this.BTNuevoRol.TabIndex = 26;
            this.BTNuevoRol.UseVisualStyleBackColor = true;
            this.BTNuevoRol.Click += new System.EventHandler(this.BTNuevoRol_Click);
            // 
            // tabRespaldos
            // 
            this.tabRespaldos.Controls.Add(this.gridRespaldos);
            this.tabRespaldos.Controls.Add(this.TSRespaldos);
            this.tabRespaldos.Location = new System.Drawing.Point(4, 22);
            this.tabRespaldos.Name = "tabRespaldos";
            this.tabRespaldos.Padding = new System.Windows.Forms.Padding(3);
            this.tabRespaldos.Size = new System.Drawing.Size(898, 554);
            this.tabRespaldos.TabIndex = 11;
            this.tabRespaldos.Text = "Respaldos";
            this.tabRespaldos.UseVisualStyleBackColor = true;
            // 
            // gridRespaldos
            // 
            this.gridRespaldos.AllowUserToAddRows = false;
            this.gridRespaldos.AllowUserToDeleteRows = false;
            this.gridRespaldos.AllowUserToOrderColumns = true;
            this.gridRespaldos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRespaldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRespaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRespaldos.Location = new System.Drawing.Point(0, 29);
            this.gridRespaldos.MultiSelect = false;
            this.gridRespaldos.Name = "gridRespaldos";
            this.gridRespaldos.ReadOnly = true;
            this.gridRespaldos.Size = new System.Drawing.Size(898, 523);
            this.gridRespaldos.TabIndex = 26;
            // 
            // TSRespaldos
            // 
            this.TSRespaldos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TSRespaldos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel17,
            this.cbRespaldos,
            this.toolStripSeparator35,
            this.cbBuscaRespaldo,
            this.toolStripSeparator37});
            this.TSRespaldos.Location = new System.Drawing.Point(3, 3);
            this.TSRespaldos.Name = "TSRespaldos";
            this.TSRespaldos.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TSRespaldos.Size = new System.Drawing.Size(892, 25);
            this.TSRespaldos.TabIndex = 25;
            this.TSRespaldos.Text = "Connection";
            // 
            // toolStripLabel17
            // 
            this.toolStripLabel17.Name = "toolStripLabel17";
            this.toolStripLabel17.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel17.Text = "Sucursal";
            // 
            // cbRespaldos
            // 
            this.cbRespaldos.Name = "cbRespaldos";
            this.cbRespaldos.Size = new System.Drawing.Size(300, 25);
            // 
            // toolStripSeparator35
            // 
            this.toolStripSeparator35.Name = "toolStripSeparator35";
            this.toolStripSeparator35.Size = new System.Drawing.Size(6, 25);
            // 
            // cbBuscaRespaldo
            // 
            this.cbBuscaRespaldo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cbBuscaRespaldo.Image = ((System.Drawing.Image)(resources.GetObject("cbBuscaRespaldo.Image")));
            this.cbBuscaRespaldo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cbBuscaRespaldo.Name = "cbBuscaRespaldo";
            this.cbBuscaRespaldo.Size = new System.Drawing.Size(23, 22);
            this.cbBuscaRespaldo.ToolTipText = "Buscar Entradas de Almacén";
            // 
            // toolStripSeparator37
            // 
            this.toolStripSeparator37.Name = "toolStripSeparator37";
            this.toolStripSeparator37.Size = new System.Drawing.Size(6, 25);
            // 
            // UCSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabCatalogs);
            this.Name = "UCSeguridad";
            this.Size = new System.Drawing.Size(906, 580);
            this.Load += new System.EventHandler(this.UCSeguridad_Load);
            this.TabCatalogs.ResumeLayout(false);
            this.tabSeguridad.ResumeLayout(false);
            this.tabSeguridad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPoliticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.tabRespaldos.ResumeLayout(false);
            this.tabRespaldos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRespaldos)).EndInit();
            this.TSRespaldos.ResumeLayout(false);
            this.TSRespaldos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListSeguridad;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridPoliticas;
        private System.Windows.Forms.DataGridView gridModulos;
        private System.Windows.Forms.DataGridView gridRoles;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.DataGridView gridRespaldos;
        private System.Windows.Forms.ToolStripLabel toolStripLabel17;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator35;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator37;
        public System.Windows.Forms.TabControl TabCatalogs;
        public System.Windows.Forms.TabPage tabSeguridad;
        public System.Windows.Forms.TabPage tabRespaldos;
        public System.Windows.Forms.ToolStrip TSRespaldos;
        public System.Windows.Forms.ToolStripComboBox cbRespaldos;
        public System.Windows.Forms.ToolStripButton cbBuscaRespaldo;
        public System.Windows.Forms.Button BTCargarPolitica;
        public System.Windows.Forms.Button BTEliminaUsuario;
        public System.Windows.Forms.Button BTCargaUsuario;
        public System.Windows.Forms.Button BTNuevoUsuario;
        public System.Windows.Forms.Button BTAsignaPolitica;
        public System.Windows.Forms.Button BTEliminaPolitica;
        public System.Windows.Forms.Button BTCargaModulo;
        public System.Windows.Forms.Button BTEliminaRol;
        public System.Windows.Forms.Button BTNuevoRol;
        private System.Windows.Forms.Button BTCargaRol;
    }
}
