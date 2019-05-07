using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiomedicinaCsharp25042019.Apresentacao
{
    public partial class frm_ConsultaExame : Form
    {
        public frm_ConsultaExame()
        {
            InitializeComponent();
        }

        public void frm_ConsultaExame_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        //METODO DESABILITAR CAMPOS
        public void DesabilitarCampos()
        {
            btnExcluirMicro.Enabled = false;
            btnAlterarMicro.Enabled = false;
            btnLocalizarMicro.Enabled = false;
            btnAlterarBio.Enabled = false;
            btnExcluirBio.Enabled = false;
            btnLocalizarBio.Enabled = false;
            btnExcluirUri.Enabled = false;
            btnAlterarUri.Enabled = false;
            btnLocalizarUri.Enabled = false;
            btnExcluirHema.Enabled = false;
            btnAlterarHema.Enabled = false;
            btnLocalizarHema.Enabled = false;
        }

        // FORMATAR DG BIOQUIMICA
        public void FormatarDgConsultarExameBio()
        {
            dgConsultarExame.Columns[0].HeaderText = "Número do Exame";
            dgConsultarExame.Columns[1].HeaderText = "Paciente"; //Nome paciente tabela paciente
            dgConsultarExame.Columns[2].HeaderText = "Colaborador";
            dgConsultarExame.Columns[3].HeaderText = "Número do dia";
            dgConsultarExame.Columns[4].HeaderText = "COL";
            dgConsultarExame.Columns[5].HeaderText = "TRI";
            dgConsultarExame.Columns[6].HeaderText = "HDL";
            dgConsultarExame.Columns[7].HeaderText = "LDL";
            dgConsultarExame.Columns[8].HeaderText = "VI DL";
            dgConsultarExame.Columns[9].HeaderText = "DHE";
            dgConsultarExame.Columns[10].HeaderText = "CREA";
            dgConsultarExame.Columns[11].HeaderText = "TGO";
            dgConsultarExame.Columns[12].HeaderText = "TGP";
            dgConsultarExame.Columns[13].HeaderText = "BIL D";
            dgConsultarExame.Columns[14].HeaderText = "FERRO";
            dgConsultarExame.Columns[15].HeaderText = "PROT";
            dgConsultarExame.Columns[16].HeaderText = "CLOR";
            dgConsultarExame.Columns[17].HeaderText = "FAL";
            dgConsultarExame.Columns[18].HeaderText = "CALCIO";
            dgConsultarExame.Columns[19].HeaderText = "ALB";
            dgConsultarExame.Columns[20].HeaderText = "CPK";
            dgConsultarExame.Columns[22].HeaderText = "AC UR";
            dgConsultarExame.Columns[23].HeaderText = "DHL";
            dgConsultarExame.Columns[23].HeaderText = "BHCQ";
            dgConsultarExame.Columns[24].HeaderText = "PHOS";
            dgConsultarExame.Columns[25].HeaderText = "DATA CADASTRO";
            dgConsultarExame.Columns[26].Visible = false; //mensagem
            dgConsultarExame.Columns[27].Visible = false; //id_paciente
            dgConsultarExame.Columns[28].Visible = false; //id_colaborador
        }

        //FORMATAR DG EXAME HEMATOLOGIA
        public void FormatarDgConsultarExameHema()
        {
            dgConsultarExame.Columns[0].HeaderText = "Número do Exame";
            dgConsultarExame.Columns[1].HeaderText = "Paciente"; //Nome paciente tabela paciente
            dgConsultarExame.Columns[2].HeaderText = "Colaborador";
            dgConsultarExame.Columns[3].HeaderText = "Número do dia";
            dgConsultarExame.Columns[4].HeaderText = "ERIT";
            dgConsultarExame.Columns[5].HeaderText = "HB";
            dgConsultarExame.Columns[6].HeaderText = "HT";
            dgConsultarExame.Columns[7].HeaderText = "VMC";
            dgConsultarExame.Columns[8].HeaderText = "HCM";
            dgConsultarExame.Columns[9].HeaderText = "CHCM";
            dgConsultarExame.Columns[10].HeaderText = "PLAQ";
            dgConsultarExame.Columns[11].HeaderText = "RET";
            dgConsultarExame.Columns[12].HeaderText = "LEUC";
            dgConsultarExame.Columns[13].HeaderText = "MIE";
            dgConsultarExame.Columns[14].HeaderText = "MET";
            dgConsultarExame.Columns[15].HeaderText = "BAS";
            dgConsultarExame.Columns[16].HeaderText = "SEG";
            dgConsultarExame.Columns[17].HeaderText = "EOS";
            dgConsultarExame.Columns[18].HeaderText = "BAF";
            dgConsultarExame.Columns[19].HeaderText = "LIN TIP";
            dgConsultarExame.Columns[20].HeaderText = "LINT AT";
            dgConsultarExame.Columns[21].HeaderText = "MONO";
            dgConsultarExame.Columns[22].HeaderText = "OUTRAS";
            dgConsultarExame.Columns[23].HeaderText = "OBS";
            dgConsultarExame.Columns[24].HeaderText = "ABO";
            dgConsultarExame.Columns[25].HeaderText = "RH";
            dgConsultarExame.Columns[26].HeaderText = "VHS";
            dgConsultarExame.Columns[27].HeaderText = "FALCI";
            dgConsultarExame.Columns[28].HeaderText = "DATA CADASTRO";
            dgConsultarExame.Columns[29].Visible = false; //mensagem
            dgConsultarExame.Columns[30].Visible = false; //id_paciente
            dgConsultarExame.Columns[31].Visible = false; //id_colaborador
        }

        //METODO FORMATAR DG EXAME MICROBIOLOGIA
        private void FormatarDgConsultarExameMicro()
        {
            dgConsultarExame.Columns[0].HeaderText = "Número do Exame";
            dgConsultarExame.Columns[1].HeaderText = "Paciente"; //Nome paciente tabela paciente
            dgConsultarExame.Columns[2].HeaderText = "Colaborador";
            dgConsultarExame.Columns[3].HeaderText = "Número do dia";
            dgConsultarExame.Columns[4].HeaderText = "MAT";
            dgConsultarExame.Columns[5].HeaderText = "GRAM";
            dgConsultarExame.Columns[6].HeaderText = "MICR 1";
            dgConsultarExame.Columns[7].HeaderText = "C.COL";
            dgConsultarExame.Columns[8].HeaderText = "MICRO 2";
            dgConsultarExame.Columns[9].HeaderText = "C.COL 2";
            dgConsultarExame.Columns[10].HeaderText = "BAAR";
            dgConsultarExame.Columns[11].HeaderText = "GRAM 2";
            dgConsultarExame.Columns[12].HeaderText = "DATA CADASTRO";
            dgConsultarExame.Columns[13].Visible = false; //MENSAGEM
            dgConsultarExame.Columns[14].Visible = false; //id_paciente
            dgConsultarExame.Columns[15].Visible = false; //id_colaborador
        }

        //METODO FORMATAR DG EXAME URINALISE
        public void FormatarDgConsultarExameUri()
        {
            dgConsultarExame.Columns[0].HeaderText = "Número do Exame";
            dgConsultarExame.Columns[1].HeaderText = "Paciente"; //Nome paciente tabela paciente
            dgConsultarExame.Columns[2].HeaderText = "Colaborador";
            dgConsultarExame.Columns[3].HeaderText = "Número do dia";
            dgConsultarExame.Columns[4].HeaderText = "COR";
            dgConsultarExame.Columns[5].HeaderText = "ASPC";
            dgConsultarExame.Columns[6].HeaderText = "DENS";
            dgConsultarExame.Columns[7].HeaderText = "PH";
            dgConsultarExame.Columns[8].HeaderText = "PT";
            dgConsultarExame.Columns[9].HeaderText = "GLI";
            dgConsultarExame.Columns[10].HeaderText = "URO";
            dgConsultarExame.Columns[11].HeaderText = "BIL";
            dgConsultarExame.Columns[12].HeaderText = "CET";
            dgConsultarExame.Columns[13].HeaderText = "HB";
            dgConsultarExame.Columns[14].HeaderText = "NIT";
            dgConsultarExame.Columns[15].HeaderText = "CELS";
            dgConsultarExame.Columns[16].HeaderText = "LEUC";
            dgConsultarExame.Columns[17].HeaderText = "HEM";
            dgConsultarExame.Columns[18].HeaderText = "BAC";
            dgConsultarExame.Columns[19].HeaderText = "CIL";
            dgConsultarExame.Columns[20].HeaderText = "CRIST";
            dgConsultarExame.Columns[21].HeaderText = "F. MUCO";
            dgConsultarExame.Columns[22].HeaderText = "TRINCH";
            dgConsultarExame.Columns[23].HeaderText = "OUTROS 1";
            dgConsultarExame.Columns[24].HeaderText = "OUTROS 2";
            dgConsultarExame.Columns[25].HeaderText = "DATA CADASTRO";
            dgConsultarExame.Columns[26].Visible = false; //MENSAGEM
            dgConsultarExame.Columns[27].Visible = false; //id_paciente
            dgConsultarExame.Columns[28].Visible = false; //id_colaborador
        }

        //METODO CONTAR LINHAS
        public void ContarLinhas()
        {
            int total = dgConsultarExame.Rows.Count;
            lblTotal.Text = System.Convert.ToString(total);
        }

        //RADIO BUTON CHECADO HABILITAR BOTOES DE BIOQUIMICA
        public void rbBio_CheckedChanged(object sender, EventArgs e)
        {
            btnAlterarBio.Enabled = true;
            btnLocalizarBio.Enabled = true;
            btnExcluirBio.Enabled = true;
            btnAlterarBio.Visible = true;
            btnLocalizarBio.Visible = true;
            btnExcluirBio.Visible = true;
            btnExcluirMicro.Visible = false;
            btnAlterarMicro.Visible = false;
            btnLocalizarMicro.Visible = false;
            btnExcluirUri.Visible = false;
            btnAlterarUri.Visible = false;
            btnLocalizarUri.Visible = false;
            btnExcluirHema.Visible = false;
            btnAlterarHema.Visible = false;
            btnLocalizarHema.Visible = false;
        }

        //RADIO BUTON CHECADO HABILITAR BOTOES DE HEMATOLOGIA
        public void rbHematologia_CheckedChanged(object sender, EventArgs e)
        {
            btnAlterarHema.Enabled = true;
            btnLocalizarHema.Enabled = true;
            btnExcluirHema.Enabled = true;
            btnAlterarHema.Visible = true;
            btnLocalizarHema.Visible = true;
            btnExcluirHema.Visible = true;
            btnExcluirMicro.Visible = false;
            btnAlterarMicro.Visible = false;
            btnLocalizarMicro.Visible = false;
            btnAlterarBio.Visible = false;
            btnExcluirBio.Visible = false;
            btnLocalizarBio.Visible = false;
            btnExcluirUri.Visible = false;
            btnAlterarUri.Visible = false;
            btnLocalizarUri.Visible = false;
        }

        //RADIO BUTON CHECADO HABILITAR BOTOES DE MICROBIOLOGIA
        public void rbMicrobiologia_CheckedChanged(object sender, EventArgs e)
        {
            btnAlterarMicro.Enabled = true;
            btnLocalizarMicro.Enabled = true;
            btnExcluirMicro.Enabled = true;
            btnAlterarMicro.Visible = true;
            btnLocalizarMicro.Visible = true;
            btnExcluirMicro.Visible = true;
            btnAlterarBio.Visible = false;
            btnExcluirBio.Visible = false;
            btnLocalizarBio.Visible = false;
            btnExcluirUri.Visible = false;
            btnAlterarUri.Visible = false;
            btnLocalizarUri.Visible = false;
            btnExcluirHema.Visible = false;
            btnAlterarHema.Visible = false;
            btnLocalizarHema.Visible = false;
        }

        //RADIO BUTON CHECADO HABILITAR BOTOES DE URINALISE
        public void rbUrinalise_CheckedChanged(object sender, EventArgs e)
        {
            btnAlterarUri.Enabled = true;
            btnLocalizarUri.Enabled = true;
            btnExcluirUri.Enabled = true;
            btnAlterarUri.Visible = true;
            btnLocalizarUri.Visible = true;
            btnExcluirUri.Visible = true;
            btnExcluirMicro.Visible = false;
            btnAlterarMicro.Visible = false;
            btnLocalizarMicro.Visible = false;
            btnAlterarBio.Visible = false;
            btnExcluirBio.Visible = false;
            btnLocalizarBio.Visible = false;
            btnExcluirHema.Visible = false;
            btnAlterarHema.Visible = false;
            btnLocalizarHema.Visible = false;
        }

        //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
        public void dgConsultarExame_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[0].Value);
        }

        //BOTAO FAZER BUSCA EXAME BIOQUIMICA
        public void btnLocalizarBio_Click(object sender, EventArgs e)
        {
            //FAZER A BUSCA PELO NOME
            dgConsultarExame.ClearSelection();
            //SE O CAMPO TXT NOME ESTIVER VAZIO FACA
            if (txtNomePaci.Text == "")
            {
                ListarBio();
            }
            //SE NÃO ESTIVER VAZIO FACA
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = default(SqlDataAdapter);
                try
                {
                    Conexao.Conexao.abrir();
                    da = new SqlDataAdapter("sp_BuscarExameBioNomePaci", Conexao.Conexao.con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@nomePaci", txtNomePaci.Text);
                    da.Fill(dt);
                    dgConsultarExame.DataSource = dt;

                    //metodo contar linhas
                    ContarLinhas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no metodo listar" + ex.Message, "Erro" , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    Conexao.Conexao.fechar();
                }
            }
            FormatarDgConsultarExameBio();
        }

        // METODO LISTAR EXAME BIOQUIMICA
        public void ListarBio()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            try
            {
                Conexao.Conexao.abrir();
                //FAZER UM INNER JOIN PARA MESCLAR MAIS DE UMA TABELA (SIGLA exaB. = tabela de exame) ( SIGLA pac. = tabela de paciente) (SIGLA col. = tabela de colaborador)
                da = new SqlDataAdapter(@"SELECT exaB.id_exameBio, pac.nome, col.nome, exaB.numeroDia, exaB.col, exaB.tri, exaB.hdl, exaB.ldl, exaB.vi_dl, exaB.dhe,
                exaB.crea, exaB.tgo, exaB.tgp, exaB.bil_d, exaB.ferro, exaB.prot, exaB.clor, exaB.fal, exaB.calcio, exaB.alb, exaB.cpk, exaB.ac_ur, exaB.dhl, exaB.bhcg, exaB.phos,
                exaB.data_cadastro, exaB.mensagem, exaB.id_paciente,
                exaB.id_colaborador FROM examesBioquimica as exaB INNER JOIN pacientes as pac on exaB.id_paciente = pac.id_paciente
                INNER JOIN colaboradores as col on exaB.id_colaborador = col.id_colaborador", Conexao.Conexao.con);
                //PREENCHER A TABELA
                da.Fill(dt);
                dgConsultarExame.DataSource = dt;

                ContarLinhas();
                FormatarDgConsultarExameBio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no metodo listar" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                Conexao.Conexao.fechar();
            }
        }

        //BOTAO PESQUISAR EXAME HEMATOLOGIA
        public void btnLocalizarHema_Click(object sender, EventArgs e)
        {
            dgConsultarExame.ClearSelection();
            //SE TXT NOME ESTIVER VAZIO FACA 
            if (txtNomePaci.Text == "")
            {
                ListarHema();
            }
            //SE NAO ESTIVER VAZIO FACA
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = default(SqlDataAdapter);
                try
                {
                    Conexao.Conexao.abrir();
                    da = new SqlDataAdapter("sp_BuscarExameHemaNomePaci", Conexao.Conexao.con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@nomePaci", txtNomePaci.Text);
                    da.Fill(dt);
                    dgConsultarExame.DataSource = dt;

                    ContarLinhas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no metodo listar" + ex.Message, "Erro" , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    Conexao.Conexao.fechar();
                }
            }
            FormatarDgConsultarExameHema();
        }

        //METODO LISTAR EXAME HEMATOLOGIA
        public void ListarHema()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            try
            {
                Conexao.Conexao.abrir();
                //FAZER UM INNER JOIN PARA MESCLAR MAIS DE UMA TABELA (SIGLA exaH. = tabela de exame) ( SIGLA pac. = tabela de paciente) (SIGLA col. = tabela de colaborador)
                da = new SqlDataAdapter(@"SELECT exaH.id_exameHema, pac.nome, col.nome, exaH.numeroDia, exaH.erit, exaH.hb, exaH.ht, exaH.vmc, exaH.hcm, exaH.chcm,
                exaH.plaq, exaH.ret, exaH.leuc, exaH.mie, exaH.met, exaH.bas, exaH.seg, exaH.eos, exaH.baf, exaH.lin_tip, exaH.lint_at, exaH.mono, exaH.outras, exaH.obs, exaH.abo, exaH.rh, exaH.vhs, exaH.falci,
                exaH.data_cadastro, exaH.mensagem, exaH.id_paciente,
                exaH.id_colaborador FROM examesHematologia as exaH INNER JOIN pacientes as pac on exaH.id_paciente = pac.id_paciente
                INNER JOIN colaboradores as col on exaH.id_colaborador = col.id_colaborador", Conexao.Conexao.con);
                //PREENCHER A TABELA
                da.Fill(dt);
                dgConsultarExame.DataSource = dt;

                ContarLinhas();
                FormatarDgConsultarExameHema();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no metodo listar" + ex.Message, "Erro" , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                Conexao.Conexao.fechar();
            }
        }

        //BOTAOLOCALIZAR EXAME MICROBIOLOGIA
        public void btnLocalizarMicro_Click(object sender, EventArgs e)
        {
            dgConsultarExame.ClearSelection();

            //SE O TXT NOME ESTIVER VAZIO FACA
            if (txtNomePaci.Text == "")
            {
                ListarMicro();
            }
            // SE NAO ESTIVER VAZIO FACA
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = default(SqlDataAdapter);
                try
                {
                    Conexao.Conexao.abrir();
                    da = new SqlDataAdapter("sp_BuscarExameMicroNomePaci", Conexao.Conexao.con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@nomePaci", txtNomePaci.Text);
                    da.Fill(dt);
                    dgConsultarExame.DataSource = dt;

                    ContarLinhas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no metodo listar" + ex.Message, "Erro" , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    Conexao.Conexao.fechar();
                }
            }
            FormatarDgConsultarExameMicro();
        }

        //METODO LISTAR EXAME MICRO
        public void ListarMicro()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            try
            {
                Conexao.Conexao.abrir();
                //FAZER UM INNER JOIN PARA MESCLAR MAIS DE UMA TABELA (SIGLA exaM. = tabela de exame) ( SIGLA pac. = tabela de paciente) (SIGLA col. = tabela de colaborador)
                da = new SqlDataAdapter(@"SELECT exaM.id_exameMicro, pac.nome, col.nome, exaM.numeroDia, exaM.mat, exaM.gram, exaM.micr_1, exaM.c_col, exaM.micro_2, exaM.c_col_2,
                exaM.baar, exaM.bil_d, exaM.data_cadastro, exaM.mensagem, exaM.id_paciente,
                exaM.id_colaborador FROM examesMicrobiologia as exaM INNER JOIN pacientes as pac on exaM.id_paciente = pac.id_paciente
                INNER JOIN colaboradores as col on exaM.id_colaborador = col.id_colaborador", Conexao.Conexao.con);
                //PREENCHER A TABELA
                da.Fill(dt);
                dgConsultarExame.DataSource = dt;

                ContarLinhas();
                FormatarDgConsultarExameMicro();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no metodo listar", "Erro" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                Conexao.Conexao.fechar();
            }
        }

        //BOTAO LOCALIZAR EXAME URINALISE
        public void btnLocalizarUri_Click(object sender, EventArgs e)
        {
            dgConsultarExame.ClearSelection();

            //SE O TXT NOME ESTIVER VAZIO FACA
            if (txtNomePaci.Text == "")
            {
                ListarUri();
            }
            // SE NAO ESTIVER VAZIO FACA
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = default(SqlDataAdapter);
                try
                {
                    Conexao.Conexao.abrir();
                    da = new SqlDataAdapter("sp_BuscarExameUriNomePaci", Conexao.Conexao.con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@nomePaci", txtNomePaci.Text);
                    da.Fill(dt);
                    dgConsultarExame.DataSource = dt;

                    ContarLinhas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no metodo listar" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    Conexao.Conexao.fechar();
                }
            }
            FormatarDgConsultarExameMicro();
        }

        //METODO LISTAR EXAME URINALISE
        public void ListarUri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            try
            {
                //FAZER UM INNER JOIN PARA MESCLAR MAIS DE UMA TABELA (SIGLA exaU. = tabela de exame) ( SIGLA pac. = tabela de paciente) (SIGLA col. = tabela de colaborador)
                da = new SqlDataAdapter(@"SELECT exaU.id_exameUri, pac.nome, col.nome, exaU.numeroDia, exaU.cor, exaU.aspc, exaU.dens, exaU.ph, exaU.pt, exaU.gli,
                exaU.uro, exaU.bil, exaU.cet, exaU.hb, exaU.nit, exaU.cels, exaU.leuc, exaU.hem, exaU.bac, exaU.cil, exaU.crist, exaU.f_muco, exaU.trinch, exaU.outros1, exaU.outros2,
                exaU.data_cadastro, exaU.mensagem, exaU.id_paciente,
                exaU.id_colaborador FROM examesUrinalise as exaU INNER JOIN pacientes as pac on exaU.id_paciente = pac.id_paciente
                INNER JOIN colaboradores as col on exaU.id_colaborador = col.id_colaborador", Conexao.Conexao.con);
                //PREENCHER A TABELA
                da.Fill(dt);
                dgConsultarExame.DataSource = dt;

                ContarLinhas();
                FormatarDgConsultarExameUri();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no metodo listar" + ex.Message, "Erro" , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                Conexao.Conexao.fechar();
            }
        }

        //BOTAO ALTERAR EXAME BIOQUIMICA
        public void btnAlterarBio_Click(object sender, EventArgs e)
        {
            frm_Bioquimica frm_Bioquimica = new frm_Bioquimica();
            //ABRIR O FORM DE CAD BIOQUIMICA
             
            //HABILITAR OS CAMPOS PARA PODER ALTERAR
            habilitarCamposParaeditarBio();
            frm_Bioquimica.Show();
            frm_Bioquimica.txtId.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[0].Value);
            frm_Bioquimica.txtNome.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[1].Value);
            frm_Bioquimica.txtCola.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[2].Value);
            frm_Bioquimica.txtNdia.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[3].Value);
            frm_Bioquimica.txtCol.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[4].Value);
            frm_Bioquimica.txtTri.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[5].Value);
            frm_Bioquimica.txtHdl.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[6].Value);
            frm_Bioquimica.txtLdl.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[7].Value);
            frm_Bioquimica.txtVidl.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[8].Value);
            frm_Bioquimica.txtdhe.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[9].Value);
            frm_Bioquimica.txtCrea.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[10].Value);
            frm_Bioquimica.txtTgo.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[11].Value);
            frm_Bioquimica.txtTgp.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[12].Value);
            frm_Bioquimica.txtBild.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[13].Value);
            frm_Bioquimica.txtFerro.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[14].Value);
            frm_Bioquimica.txtProt.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[15].Value);
            frm_Bioquimica.txtClor.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[16].Value);
            frm_Bioquimica.txtFal.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[17].Value);
            frm_Bioquimica.txtCalcio.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[18].Value);
            frm_Bioquimica.txtAlb.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[19].Value);
            frm_Bioquimica.txtCpk.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[20].Value);
            frm_Bioquimica.txtAcur.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[21].Value);
            frm_Bioquimica.txtDhl.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[22].Value);
            frm_Bioquimica.txtBhcg.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[23].Value);
            frm_Bioquimica.txtPhos.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[24].Value);
            frm_Bioquimica.mskData.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[25].Value);
            frm_Bioquimica.txtIdPac.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[27].Value);//id_paciente
            frm_Bioquimica.txtIdcola.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[28].Value);//id_colaborador
        }

        //METODO PARA HABILITAR CAMPOS NO FORM BIOQUIMICA PARA PODER ALTERAR
        public void habilitarCamposParaeditarBio()
        {
            frm_Bioquimica frm_Bioquimica = new frm_Bioquimica();
            frm_Bioquimica.txtId.Enabled = true;
            frm_Bioquimica.txtNome.Enabled = true;
            frm_Bioquimica.txtNdia.Enabled = true;
            frm_Bioquimica.txtCol.Enabled = true;
            frm_Bioquimica.txtTri.Enabled = true;
            frm_Bioquimica.txtHdl.Enabled = true;
            frm_Bioquimica.txtLdl.Enabled = true;
            frm_Bioquimica.txtVidl.Enabled = true;
            frm_Bioquimica.txtdhe.Enabled = true;
            frm_Bioquimica.txtCrea.Enabled = true;
            frm_Bioquimica.txtBild.Enabled = true;
            frm_Bioquimica.txtTgo.Enabled = true;
            frm_Bioquimica.txtTgp.Enabled = true;
            frm_Bioquimica.txtFerro.Enabled = true;
            frm_Bioquimica.txtProt.Enabled = true;
            frm_Bioquimica.txtClor.Enabled = true;
            frm_Bioquimica.txtFal.Enabled = true;
            frm_Bioquimica.txtCalcio.Enabled = true;
            frm_Bioquimica.txtAlb.Enabled = true;
            frm_Bioquimica.txtCpk.Enabled = true;
            frm_Bioquimica.txtAcur.Enabled = true;
            frm_Bioquimica.txtDhl.Enabled = true;
            frm_Bioquimica.txtBhcg.Enabled = true;
            frm_Bioquimica.txtPhos.Enabled = true;
            frm_Bioquimica.btnNovo.Enabled = false;
            frm_Bioquimica.mskData.Enabled = true;
            frm_Bioquimica.btnAlterarBio.Enabled = true;
            frm_Bioquimica.btnSelecionarPac.Enabled = true;
        }

        //BOTAO ALTERAR EXAME HEMATOLOGIA
        public void btnAlterarHema_Click(object sender, EventArgs e)
        {
            frm_Hematologia frm_Hematologia = new frm_Hematologia();
            //ABRIR O FORM DE CAD HEMATOLOGIA
            frm_Hematologia.Show();
            //HABILITAR OS CAMPOS PARA PODER ALTERAR
            habilitarCamposParaeditarHema();
            frm_Hematologia.txtId.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[0].Value);
            frm_Hematologia.txtNome.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[1].Value);
            frm_Hematologia.txtCola.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[2].Value);
            frm_Hematologia.txtNdia.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[3].Value);
            frm_Hematologia.txterit.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[4].Value);
            frm_Hematologia.txthb.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[5].Value);
            frm_Hematologia.txtht.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[6].Value);
            frm_Hematologia.txtvmc.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[7].Value);
            frm_Hematologia.txthcm.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[8].Value);
            frm_Hematologia.txtchcm.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[9].Value);
            frm_Hematologia.txtplaq.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[10].Value);
            frm_Hematologia.txtret.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[11].Value);
            frm_Hematologia.txtleuc.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[12].Value);
            frm_Hematologia.txtmie.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[13].Value);
            frm_Hematologia.txtmet.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[14].Value);
            frm_Hematologia.txtbas.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[15].Value);
            frm_Hematologia.txtseg.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[16].Value);
            frm_Hematologia.txteos.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[17].Value);
            frm_Hematologia.txtbaf.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[18].Value);
            frm_Hematologia.txtlintip.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[19].Value);
            frm_Hematologia.txtlinat.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[20].Value);
            frm_Hematologia.txtmono.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[21].Value);
            frm_Hematologia.txtoutras.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[22].Value);
            frm_Hematologia.txtobs.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[23].Value);
            frm_Hematologia.txtabo.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[24].Value);
            frm_Hematologia.txtrh.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[25].Value);
            frm_Hematologia.txtvhs.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[26].Value);
            frm_Hematologia.txtfalci.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[27].Value);
            frm_Hematologia.mskData.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[28].Value);
            frm_Hematologia.txtIdPac.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[30].Value);//id_paciente
            frm_Hematologia.txtIdcola.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[31].Value);//id_colaborador
        }

        //METODO PARA HABILITAR CAMPOS NO FORM HEMATOLOGIA PARA PODER ALTERAR
        public void habilitarCamposParaeditarHema()
        {
            frm_Hematologia frm_Hematologia = new frm_Hematologia();
            
            frm_Hematologia.txtNome.Enabled = false;
            frm_Hematologia.txtNdia.Enabled = true;
            frm_Hematologia.txterit.Enabled = true;
            frm_Hematologia.txthb.Enabled = true;
            frm_Hematologia.txtht.Enabled = true;
            frm_Hematologia.txtvmc.Enabled = true;
            frm_Hematologia.txthcm.Enabled = true;
            frm_Hematologia.txtchcm.Enabled = true;
            frm_Hematologia.txtplaq.Enabled = true;
            frm_Hematologia.txtret.Enabled = true;
            frm_Hematologia.txtleuc.Enabled = true;
            frm_Hematologia.txtmie.Enabled = true;
            frm_Hematologia.txtmet.Enabled = true;
            frm_Hematologia.txtbas.Enabled = true;
            frm_Hematologia.txtseg.Enabled = true;
            frm_Hematologia.txteos.Enabled = true;
            frm_Hematologia.txtbaf.Enabled = true;
            frm_Hematologia.txtlintip.Enabled = true;
            frm_Hematologia.txtlinat.Enabled = true;
            frm_Hematologia.txtmono.Enabled = true;
            frm_Hematologia.txtoutras.Enabled = true;
            frm_Hematologia.txtobs.Enabled = true;
            frm_Hematologia.txtabo.Enabled = true;
            frm_Hematologia.txtrh.Enabled = true;
            frm_Hematologia.txtvhs.Enabled = true;
            frm_Hematologia.txtfalci.Enabled = true;
            frm_Hematologia.mskData.Enabled = true;
            frm_Hematologia.btnAlterarH.Enabled = true;
            frm_Hematologia.btnSelecionarPacHema.Enabled = false;
            frm_Hematologia.btnNovo.Enabled = false;
        }

        //BOTAO EDITAR EXAME MICROBIOLOGIA
        public void btnAlterarMicro_Click(object sender, EventArgs e)
        {
            frm_Microbiologia frm_Microbiologia = new frm_Microbiologia();
            //ABRIR O FORM DE CAD MICROBIOLOGIA
            frm_Microbiologia.Show();
            //HABILITAR OS CAMPOS PARA PODER ALTERAR
            habilitarCamposParaeditarmicro();
            frm_Microbiologia.txtId.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[0].Value);
            frm_Microbiologia.txtNome.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[1].Value);
            frm_Microbiologia.txtCola.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[2].Value);
            frm_Microbiologia.txtNdia.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[3].Value);
            frm_Microbiologia.txtMat.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[4].Value);
            frm_Microbiologia.txtGram.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[5].Value);
            frm_Microbiologia.txtMicr1.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[6].Value);
            frm_Microbiologia.txtCcol.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[7].Value);
            frm_Microbiologia.txtMicr2.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[8].Value);
            frm_Microbiologia.txtCcol2.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[9].Value);
            frm_Microbiologia.txtBaar.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[10].Value);
            frm_Microbiologia.txtGram2.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[11].Value);
            frm_Microbiologia.mskData.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[12].Value);
            frm_Microbiologia.txtIdPac.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[14].Value);//id_paciente
            frm_Microbiologia.txtIdcola.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[15].Value);//id_colaborador
        }

        //METODO PARA HABILITAR CAMPOS NO FORM HEMATOLOGIA PARA PODER ALTERAR
        public void habilitarCamposParaeditarmicro()
        {
            frm_Microbiologia frm_Microbiologia = new frm_Microbiologia();
            frm_Microbiologia.txtNome.Enabled = false;
            frm_Microbiologia.txtNdia.Enabled = true;
            frm_Microbiologia.txtBaar.Enabled = true;
            frm_Microbiologia.txtCcol.Enabled = true;
            frm_Microbiologia.txtCcol2.Enabled = true;
            frm_Microbiologia.txtGram.Enabled = true;
            frm_Microbiologia.txtGram2.Enabled = true;
            frm_Microbiologia.txtId.Enabled = true;
            frm_Microbiologia.txtMat.Enabled = true;
            frm_Microbiologia.txtMicr1.Enabled = true;
            frm_Microbiologia.txtMicr2.Enabled = true;
            frm_Microbiologia.mskData.Enabled = true;
            frm_Microbiologia.btnNovo.Enabled = false;
            frm_Microbiologia.btnAlterarM.Enabled = true;
        }

        //BOTAO ALTERAR EXAME URINALISE
        public void btnAlterarUri_Click(object sender, EventArgs e)
        {
            frm_Urinalise frm_Urinalise = new frm_Urinalise();
            //ABRIR O FORM DE CAD URINALISE
            frm_Urinalise.Show();
            //HABILITAR OS CAMPOS PARA PODER ALTERAR
            habilitarCamposParaeditarUri();
            frm_Urinalise.txtId.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[0].Value);
            frm_Urinalise.txtNome.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[1].Value);
            frm_Urinalise.txtCola.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[2].Value);
            frm_Urinalise.txtNdia.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[3].Value);
            frm_Urinalise.txtcor.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[4].Value);
            frm_Urinalise.txtaspc.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[5].Value);
            frm_Urinalise.txtdens.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[6].Value);
            frm_Urinalise.txtph.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[7].Value);
            frm_Urinalise.txtpt.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[8].Value);
            frm_Urinalise.txtgli.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[9].Value);
            frm_Urinalise.txturo.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[10].Value);
            frm_Urinalise.txtbil.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[11].Value);
            frm_Urinalise.txtcet.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[12].Value);
            frm_Urinalise.txthb.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[13].Value);
            frm_Urinalise.txtnit.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[14].Value);
            frm_Urinalise.txtcels.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[15].Value);
            frm_Urinalise.txtleu.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[16].Value);
            frm_Urinalise.txthem.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[17].Value);
            frm_Urinalise.txtbac.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[18].Value);
            frm_Urinalise.txtcil.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[19].Value);
            frm_Urinalise.txtcrist.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[20].Value);
            frm_Urinalise.txtfmuco.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[21].Value);
            frm_Urinalise.txttrinch.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[22].Value);
            frm_Urinalise.txtoutros1.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[23].Value);
            frm_Urinalise.txtoutros2.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[24].Value);
            frm_Urinalise.mskData.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[25].Value);
            frm_Urinalise.txtIdPac.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[27].Value);//id_paciente
            frm_Urinalise.txtIdcola.Text = System.Convert.ToString(dgConsultarExame.CurrentRow.Cells[28].Value);//id_colaborador
        }


        //METODO PARA HABILITAR CAMPOS NO FORM URINALISE PARA PODER ALTERAR
        public void habilitarCamposParaeditarUri()
        {
            frm_Urinalise frm_Urinalise = new frm_Urinalise();
            frm_Urinalise.txtNome.Enabled = false;
            frm_Urinalise.txtNdia.Enabled = true;
            frm_Urinalise.txtcor.Enabled = true;
            frm_Urinalise.txtaspc.Enabled = true;
            frm_Urinalise.txtdens.Enabled = true;
            frm_Urinalise.txtph.Enabled = true;
            frm_Urinalise.txtpt.Enabled = true;
            frm_Urinalise.txtgli.Enabled = true;
            frm_Urinalise.txturo.Enabled = true;
            frm_Urinalise.txtbil.Enabled = true;
            frm_Urinalise.txtcet.Enabled = true;
            frm_Urinalise.txthb.Enabled = true;
            frm_Urinalise.txtnit.Enabled = true;
            frm_Urinalise.txtcels.Enabled = true;
            frm_Urinalise.txtleu.Enabled = true;
            frm_Urinalise.txthem.Enabled = true;
            frm_Urinalise.txtbac.Enabled = true;
            frm_Urinalise.txtcil.Enabled = true;
            frm_Urinalise.txtcrist.Enabled = true;
            frm_Urinalise.txtfmuco.Enabled = true;
            frm_Urinalise.txttrinch.Enabled = true;
            frm_Urinalise.txtoutros1.Enabled = true;
            frm_Urinalise.txtoutros2.Enabled = true;
            frm_Urinalise.btnAlterarU.Enabled = true;
            frm_Urinalise.btnNovo.Enabled = false;
            frm_Urinalise.mskData.Enabled = true;
        }

        //BOTAO EXCLUIR EXAME BIOQUIMICA
        public void btnExcluirBio_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);
            //SE O TXTID FOR DIFERENTE DE VAZIO FACA
            if (txtId.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        Conexao.Conexao.abrir();
                        cmd = new SqlCommand("sp_excluirExameBio", Conexao.Conexao.con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_exameBio", txtId.Text);

                        cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                        cmd.ExecuteNonQuery();

                        string msg = cmd.Parameters["@mensagem"].Value.ToString();
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

                        ListarBio();
                        ContarLinhas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir os dados " + ex.Message);
                        Conexao.Conexao.fechar();
                    }
                }
            }
        }

        //BOTAO EXCLUIR EXAME HEMATOLOGIA
        public void btnExcluirHema_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);
            //SE O TXTID FOR DIFERENTE DE VAZIO FACA
            if (txtId.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        Conexao.Conexao.abrir();
                        cmd = new SqlCommand("sp_excluirExameHema", Conexao.Conexao.con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_exameHema", txtId.Text);

                        cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                        cmd.ExecuteNonQuery();

                        string msg = cmd.Parameters["@mensagem"].Value.ToString();
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

                        ListarHema();
                        ContarLinhas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir os dados " + ex.Message);
                        Conexao.Conexao.fechar();
                    }
                }
            }
        }

        //BOTAO EXCLUIR EXAME MICRO
        public void btnExcluirMicro_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);
            //SE O TXTID FOR DIFERENTE DE VAZIO FACA
            if (txtId.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        Conexao.Conexao.abrir();
                        cmd = new SqlCommand("sp_excluirExameMicro", Conexao.Conexao.con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_exameMicro", txtId.Text);

                        cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                        cmd.ExecuteNonQuery();

                        string msg = cmd.Parameters["@mensagem"].Value.ToString();
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

                        ListarMicro();

                        btnAlterarMicro.Enabled = false;
                        btnExcluirMicro.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir os dados " + ex.Message);
                        Conexao.Conexao.fechar();
                    }
                }
            }
        }

        //BOTAO EXCLUIR EXAME URINALISE
        public void btnExcluirUri_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);
            //SE O TXTID FOR DIFERENTE DE VAZIO FACA
            if (txtId.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        Conexao.Conexao.abrir();
                        cmd = new SqlCommand("sp_excluirExameUri", Conexao.Conexao.con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_exameUri", txtId.Text);

                        cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                        cmd.ExecuteNonQuery();

                        string msg = cmd.Parameters["@mensagem"].Value.ToString();
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

                        ListarUri();
                        ContarLinhas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir os dados " + ex.Message);
                        Conexao.Conexao.fechar();
                    }
                }
            }
        }
    }
}
