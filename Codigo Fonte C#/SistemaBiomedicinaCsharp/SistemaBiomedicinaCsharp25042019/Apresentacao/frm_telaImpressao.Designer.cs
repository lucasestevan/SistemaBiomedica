namespace SistemaBiomedicinaCsharp25042019.Apresentacao
{
    partial class frm_telaImpressao
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
            this.rvImpressao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvImpressao
            // 
            this.rvImpressao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvImpressao.LocalReport.ReportEmbeddedResource = "SistemaBiomedicinaCsharp25042019.Apresentacao.Impressao.rdlc";
            this.rvImpressao.Location = new System.Drawing.Point(0, 0);
            this.rvImpressao.Name = "rvImpressao";
            this.rvImpressao.ServerReport.BearerToken = null;
            this.rvImpressao.Size = new System.Drawing.Size(668, 571);
            this.rvImpressao.TabIndex = 0;
            // 
            // frm_telaImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 571);
            this.Controls.Add(this.rvImpressao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_telaImpressao";
            this.Text = "Impressão Bioquimica";
            this.Load += new System.EventHandler(this.Frm_telaImpressao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvImpressao;
    }
}