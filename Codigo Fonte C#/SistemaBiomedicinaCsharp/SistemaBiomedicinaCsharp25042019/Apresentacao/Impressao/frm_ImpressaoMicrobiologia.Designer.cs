namespace SistemaBiomedicinaCsharp25042019.Apresentacao.Impressao
{
    partial class frm_ImpressaoMicrobiologia
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
            this.rvImpressaoMicro = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvImpressaoMicro
            // 
            this.rvImpressaoMicro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvImpressaoMicro.LocalReport.ReportEmbeddedResource = "SistemaBiomedicinaCsharp25042019.Apresentacao.ImpressaoMicro.rdlc";
            this.rvImpressaoMicro.Location = new System.Drawing.Point(0, 0);
            this.rvImpressaoMicro.Name = "rvImpressaoMicro";
            this.rvImpressaoMicro.ServerReport.BearerToken = null;
            this.rvImpressaoMicro.Size = new System.Drawing.Size(672, 679);
            this.rvImpressaoMicro.TabIndex = 2;
            // 
            // frm_ImpressaoMicrobiologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 679);
            this.Controls.Add(this.rvImpressaoMicro);
            this.MaximizeBox = false;
            this.Name = "frm_ImpressaoMicrobiologia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão Microbiologia";
            this.Load += new System.EventHandler(this.Frm_ImpressaoMicrobiologia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvImpressaoMicro;
    }
}