namespace SistemaBiomedicinaCsharp25042019.Apresentacao
{
    partial class frm_ImpressaoBioquimica
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
            this.rvImpressaoBio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvImpressaoBio
            // 
            this.rvImpressaoBio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvImpressaoBio.LocalReport.ReportEmbeddedResource = "SistemaBiomedicinaCsharp25042019.Apresentacao.ImpressaoBio.rdlc";
            this.rvImpressaoBio.Location = new System.Drawing.Point(0, 0);
            this.rvImpressaoBio.Name = "rvImpressaoBio";
            this.rvImpressaoBio.ServerReport.BearerToken = null;
            this.rvImpressaoBio.Size = new System.Drawing.Size(668, 675);
            this.rvImpressaoBio.TabIndex = 0;
            // 
            // frm_ImpressaoBioquimica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 675);
            this.Controls.Add(this.rvImpressaoBio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "frm_ImpressaoBioquimica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão Bioquimica";
            this.Load += new System.EventHandler(this.Frm_telaImpressao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvImpressaoBio;
    }
}