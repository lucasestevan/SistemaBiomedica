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
    public partial class frm_ImpressaoUrinalise : Form
    {
        public frm_ImpressaoUrinalise()
        {
            InitializeComponent();
        }

        private void Frm_ImpressaoUrinalise_Load(object sender, EventArgs e)
        {
            //CRIAR PARAMETROS E PEGAR OQUE ESTA NO ESTATICO PARA JOGAR NA TELA DE IMPRESSAO
            ReportParameterCollection report = new ReportParameterCollection();
            report.Add(new ReportParameter("Nome", Modelo.Estaticos.nomeUri));
            report.Add(new ReportParameter("dataCole", Modelo.Estaticos.datacolUri));
            report.Add(new ReportParameter("Colaborador", Modelo.Estaticos.colaboradorUri));
            report.Add(new ReportParameter("Cor", Modelo.Estaticos.Cor));
            report.Add(new ReportParameter("Aspecto", Modelo.Estaticos.Aspecto));
            report.Add(new ReportParameter("Densidade", Modelo.Estaticos.Densidade));
            report.Add(new ReportParameter("Reacao_pH", Modelo.Estaticos.Reacao_pH));
            report.Add(new ReportParameter("Proteinas", Modelo.Estaticos.Proteinas));
            report.Add(new ReportParameter("Glicose", Modelo.Estaticos.Glicose));
            report.Add(new ReportParameter("Urobiolinogenio", Modelo.Estaticos.Urobiolinogenio));
            report.Add(new ReportParameter("Bilirrubinas", Modelo.Estaticos.Bilirrubinas));
            report.Add(new ReportParameter("Corpos_Cetonicos", Modelo.Estaticos.Corpos_Cetonicos));
            report.Add(new ReportParameter("HemoglobinaBio", Modelo.Estaticos.HemoglobinaBio));
            report.Add(new ReportParameter("Nitrito", Modelo.Estaticos.Nitrito));
            report.Add(new ReportParameter("Celulas_Epiteliais", Modelo.Estaticos.Celulas_Epiteliais));
            report.Add(new ReportParameter("LeucocitosBio", Modelo.Estaticos.LeucocitosBio));
            report.Add(new ReportParameter("Hemacias", Modelo.Estaticos.Hemacias));
            report.Add(new ReportParameter("Bacterias", Modelo.Estaticos.Bacterias));
            report.Add(new ReportParameter("Cilindros", Modelo.Estaticos.Cilindros));
            report.Add(new ReportParameter("Cristais", Modelo.Estaticos.Cristais));
            report.Add(new ReportParameter("Filamentos_de_muco", Modelo.Estaticos.Filamentos_de_muco));
            report.Add(new ReportParameter("Trinch", Modelo.Estaticos.Trinch));
            report.Add(new ReportParameter("Outros_Elementos1", Modelo.Estaticos.Outros_Elementos1));
            report.Add(new ReportParameter("Outros_Elementos2", Modelo.Estaticos.Outros_Elementos2));
            this.rvImpressaoUri.LocalReport.SetParameters(report);
            this.rvImpressaoUri.RefreshReport();
        }
    }
}
