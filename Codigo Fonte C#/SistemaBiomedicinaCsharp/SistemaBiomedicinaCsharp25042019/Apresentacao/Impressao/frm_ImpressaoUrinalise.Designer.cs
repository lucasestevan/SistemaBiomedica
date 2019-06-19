namespace SistemaBiomedicinaCsharp25042019.Apresentacao.Impressao
{
    partial class frm_ImpressaoUrinalise
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
            this.rvImpressaoUri = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvImpressaoUri
            // 
            this.rvImpressaoUri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvImpressaoUri.LocalReport.ReportEmbeddedResource = "SistemaBiomedicinaCsharp25042019.Apresentacao.ImpressaoUri .rdlc";
            this.rvImpressaoUri.Location = new System.Drawing.Point(0, 0);
            this.rvImpressaoUri.Name = "rvImpressaoUri";
            this.rvImpressaoUri.ServerReport.BearerToken = null;
            this.rvImpressaoUri.Size = new System.Drawing.Size(656, 640);
            this.rvImpressaoUri.TabIndex = 3;
            // 
            // frm_ImpressaoUrinalise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 640);
            this.Controls.Add(this.rvImpressaoUri);
            this.MinimizeBox = false;
            this.Name = "frm_ImpressaoUrinalise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão Urinalise";
            this.Load += new System.EventHandler(this.Frm_ImpressaoUrinalise_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvImpressaoUri;
    }
}