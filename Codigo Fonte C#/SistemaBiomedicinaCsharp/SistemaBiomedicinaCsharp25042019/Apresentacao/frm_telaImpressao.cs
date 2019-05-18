using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiomedicinaCsharp25042019.Apresentacao
{
    public partial class frm_telaImpressao : Form
    {
        public frm_telaImpressao(string nome)//, string sexo, string dataCole, string dataNasc)
        {
            InitializeComponent();
            rvImpressao.LocalReport.DataSources.Clear();
            rvImpressao.LocalReport.ReportEmbeddedResource = "SistemaBiomedicinaCsharp25042019.Apresentacao.Impressao.rdlc";

            //FALAR QUANTOS PARAMBETRO VOU PASSAR
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[1];

            //SETAR OS PARAMETROS
            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("Nome", nome);
           // p[1] = new Microsoft.Reporting.WinForms.ReportParameter("Sexo", sexo);
           // p[2] = new Microsoft.Reporting.WinForms.ReportParameter("dataColeta", dataCole);
           // p[3] = new Microsoft.Reporting.WinForms.ReportParameter("dataNasc", dataNasc);


            rvImpressao.LocalReport.SetParameters(p);
           rvImpressao.LocalReport.Refresh();
            rvImpressao.RefreshReport();
        }

        private void Frm_telaImpressao_Load(object sender, EventArgs e)
        {

            this.rvImpressao.RefreshReport();
        }
    }
}
