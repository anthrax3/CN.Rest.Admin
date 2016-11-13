namespace POS.Admin.Appl
{
    partial class Reportes
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
            this.webBrowserReport = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserReport
            // 
            this.webBrowserReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserReport.Location = new System.Drawing.Point(0, 0);
            this.webBrowserReport.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserReport.Name = "webBrowserReport";
            this.webBrowserReport.Size = new System.Drawing.Size(838, 581);
            this.webBrowserReport.TabIndex = 0;
            this.webBrowserReport.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 581);
            this.Controls.Add(this.webBrowserReport);
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserReport;
    }
}