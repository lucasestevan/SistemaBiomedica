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
    public partial class frm_ImpressaoHematologia : Form
    {
        public frm_ImpressaoHematologia()
        {
            InitializeComponent();
        }

        private void Frm_ImpressaoHematologia_Load(object sender, EventArgs e)
        {
            //CRIAR PARAMETROS E PEGAR OQUE ESTA NO ESTATICO PARA JOGAR NA TELA DE IMPRESSAO
            ReportParameterCollection report = new ReportParameterCollection();
            report.Add(new ReportParameter("Nome", Modelo.Estaticos.nomeHema));
            report.Add(new ReportParameter("dataCole", Modelo.Estaticos.datacolHema));
            report.Add(new ReportParameter("Colaborador", Modelo.Estaticos.colaboradorHema));
            report.Add(new ReportParameter("Eritocitos", Modelo.Estaticos.Eritocitos));
            report.Add(new ReportParameter("Hemoglobina", Modelo.Estaticos.Hemoglobina));
            report.Add(new ReportParameter("Hematocrito", Modelo.Estaticos.Hematocrito));
            report.Add(new ReportParameter("VCM", Modelo.Estaticos.VCM));
            report.Add(new ReportParameter("HCM", Modelo.Estaticos.HCM));
            report.Add(new ReportParameter("CHCM", Modelo.Estaticos.CHCM));
            report.Add(new ReportParameter("Plaquetas", Modelo.Estaticos.Plaquetas));
            report.Add(new ReportParameter("Reticulocitos", Modelo.Estaticos.Reticulocitos));
            report.Add(new ReportParameter("Leucocitos", Modelo.Estaticos.Leucocitos));
            report.Add(new ReportParameter("Mielocitos", Modelo.Estaticos.Mielocitos));
            report.Add(new ReportParameter("Metamielocitos", Modelo.Estaticos.Metamielocitos));
            report.Add(new ReportParameter("Bastonetes", Modelo.Estaticos.Bastonetes));
            report.Add(new ReportParameter("Segmentados", Modelo.Estaticos.Segmentados));
            report.Add(new ReportParameter("Eosinofilos", Modelo.Estaticos.Eosinofilos));
            report.Add(new ReportParameter("Basofilos", Modelo.Estaticos.Basofilos));
            report.Add(new ReportParameter("Linfoticos_Tipicos", Modelo.Estaticos.Linfoticos_Tipicos));
            report.Add(new ReportParameter("Linfoticos_Atipicos", Modelo.Estaticos.Linfoticos_Atipicos));
            report.Add(new ReportParameter("Monocitos", Modelo.Estaticos.Monocitos));
            report.Add(new ReportParameter("Outras", Modelo.Estaticos.Outras));
            report.Add(new ReportParameter("Observacao", Modelo.Estaticos.Observacao));
            report.Add(new ReportParameter("ABO", Modelo.Estaticos.ABO));
            report.Add(new ReportParameter("RH", Modelo.Estaticos.RH));
            report.Add(new ReportParameter("VHS", Modelo.Estaticos.VHS));
            report.Add(new ReportParameter("Falci", Modelo.Estaticos.Falci));
            this.rvImpressaoHema.LocalReport.SetParameters(report);
            this.rvImpressaoHema.RefreshReport();
        }
    }
    
}
