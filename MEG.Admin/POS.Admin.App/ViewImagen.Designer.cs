namespace POS.Admin.Appl
{
    partial class ViewImagen
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
            this.wbImg = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbImg
            // 
            this.wbImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbImg.Location = new System.Drawing.Point(0, 0);
            this.wbImg.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbImg.Name = "wbImg";
            this.wbImg.Size = new System.Drawing.Size(427, 389);
            this.wbImg.TabIndex = 0;
            // 
            // ViewImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 389);
            this.Controls.Add(this.wbImg);
            this.Name = "ViewImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewImagen";
            this.Load += new System.EventHandler(this.ViewImagen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbImg;
    }
}