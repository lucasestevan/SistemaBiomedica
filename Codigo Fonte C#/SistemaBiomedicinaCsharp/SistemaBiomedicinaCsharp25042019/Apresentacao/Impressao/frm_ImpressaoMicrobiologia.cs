using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiomedicinaCsharp25042019.Apresentacao.Impressao
{
    public partial class frm_ImpressaoMicrobiologia : Form
    {
        public frm_ImpressaoMicrobiologia()
        {
            InitializeComponent();
        }

        private void Frm_ImpressaoMicrobiologia_Load(object sender, EventArgs e)
        {
            //CRIAR PARAMETROS E PEGAR OQUE ESTA NO ESTATICO PARA JOGAR NA TELA DE IMPRESSAO
            ReportParameterCollection report = new ReportParameterCollection();
            report.Add(new ReportParameter("Nome", Modelo.Estaticos.nomeMicro));
            report.Add(new ReportParameter("dataCole", Modelo.Estaticos.datacolMicro));
            report.Add(new ReportParameter("Colaborador", Modelo.Estaticos.colaboradorMicro));
            report.Add(new ReportParameter("Material_utilizado", Modelo.Estaticos.Material_utilizado));
            report.Add(new ReportParameter("Gram", Modelo.Estaticos.Gram));
            report.Add(new ReportParameter("Micro1", Modelo.Estaticos.Micro1));
            report.Add(new ReportParameter("C_Col", Modelo.Estaticos.C_Col));
            report.Add(new ReportParameter("Micro2", Modelo.Estaticos.Micro2));
            report.Add(new ReportParameter("C_Col2", Modelo.Estaticos.C_Col2));
            report.Add(new ReportParameter("Baar", Modelo.Estaticos.Baar));
            report.Add(new ReportParameter("Gram_2", Modelo.Estaticos.Gram_2));
            this.rvImpressaoMicro.LocalReport.SetParameters(report);
            this.rvImpressaoMicro.RefreshReport();
        }
    }
}
