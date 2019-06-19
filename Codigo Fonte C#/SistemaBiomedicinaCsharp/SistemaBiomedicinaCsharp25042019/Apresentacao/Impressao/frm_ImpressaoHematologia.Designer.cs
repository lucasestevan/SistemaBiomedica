namespace SistemaBiomedicinaCsharp25042019.Apresentacao.Impressao
{
    partial class frm_ImpressaoHematologia
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
            this.rvImpressaoHema = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvImpressaoHema
            // 
            this.rvImpressaoHema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvImpressaoHema.LocalReport.ReportEmbeddedResource = "SistemaBiomedicinaCsharp25042019.Apresentacao.ImpressaoHema.rdlc";
            this.rvImpressaoHema.Location = new System.Drawing.Point(0, 0);
            this.rvImpressaoHema.Name = "rvImpressaoHema";
            this.rvImpressaoHema.ServerReport.BearerToken = null;
            this.rvImpressaoHema.Size = new System.Drawing.Size(668, 675);
            this.rvImpressaoHema.TabIndex = 1;
            // 
            // frm_ImpressaoHematologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 675);
            this.Controls.Add(this.rvImpressaoHema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_ImpressaoHematologia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão Hematologia";
            this.Load += new System.EventHandler(this.Frm_ImpressaoHematologia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvImpressaoHema;
    }
}