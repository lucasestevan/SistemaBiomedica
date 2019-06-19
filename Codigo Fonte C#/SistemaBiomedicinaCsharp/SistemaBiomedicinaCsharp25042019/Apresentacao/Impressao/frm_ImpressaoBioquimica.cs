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

namespace SistemaBiomedicinaCsharp25042019.Apresentacao
{
    public partial class frm_ImpressaoBioquimica : Form
    {
        public frm_ImpressaoBioquimica()
        {
            InitializeComponent();
        }
        

        private void Frm_telaImpressao_Load(object sender, EventArgs e)
        {
            //CRIAR PARAMETROS E PEGAR OQUE ESTA NO ESTATICO PARA JOGAR NA TELA DE IMPRESSAO
            ReportParameterCollection reportBio = new ReportParameterCollection();
            reportBio.Add(new ReportParameter("Nome", Modelo.Estaticos.nome));
            reportBio.Add(new ReportParameter("dataCole", Modelo.Estaticos.datacol));
            reportBio.Add(new ReportParameter("Colaborador", Modelo.Estaticos.colaborador));
            reportBio.Add(new ReportParameter("COLESTEROL", Modelo.Estaticos.COLESTEROL));
            reportBio.Add(new ReportParameter("TRI", Modelo.Estaticos.TRI));
            reportBio.Add(new ReportParameter("HDL", Modelo.Estaticos.HDL));
            reportBio.Add(new ReportParameter("LDL", Modelo.Estaticos.LDL));
            reportBio.Add(new ReportParameter("VI_DL", Modelo.Estaticos.VI_DL));
            reportBio.Add(new ReportParameter("DHE", Modelo.Estaticos.DHE));
            reportBio.Add(new ReportParameter("CREATINA", Modelo.Estaticos.CREATINA));
            reportBio.Add(new ReportParameter("TGO", Modelo.Estaticos.TGO));
            reportBio.Add(new ReportParameter("TGP", Modelo.Estaticos.TGP));
            reportBio.Add(new ReportParameter("BIL_D", Modelo.Estaticos.BIL_D));
            reportBio.Add(new ReportParameter("FERRO", Modelo.Estaticos.FERRO));
            reportBio.Add(new ReportParameter("PROTEINA", Modelo.Estaticos.PROTEINA));
            reportBio.Add(new ReportParameter("CLOR", Modelo.Estaticos.CLOR));
            reportBio.Add(new ReportParameter("FAL", Modelo.Estaticos.FAL));
            reportBio.Add(new ReportParameter("CALCIO", Modelo.Estaticos.CALCIO));
            reportBio.Add(new ReportParameter("ALBUMINA", Modelo.Estaticos.ALBUMINA));
            reportBio.Add(new ReportParameter("CPK", Modelo.Estaticos.CPK));
            reportBio.Add(new ReportParameter("ACIDO_URICO", Modelo.Estaticos.ACIDO_URICO));
            reportBio.Add(new ReportParameter("DHL", Modelo.Estaticos.DHL));
            reportBio.Add(new ReportParameter("BHCQ", Modelo.Estaticos.BHCQ));
            reportBio.Add(new ReportParameter("PHOS", Modelo.Estaticos.PHOS));
            this.rvImpressaoBio.LocalReport.SetParameters(reportBio);
            this.rvImpressaoBio.RefreshReport();
        }
    }
}
