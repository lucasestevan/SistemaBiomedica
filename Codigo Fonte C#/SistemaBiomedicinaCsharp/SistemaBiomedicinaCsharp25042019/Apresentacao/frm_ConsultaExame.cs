﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBiomedicinaCsharp25042019.Apresentacao.Impressao;

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
            btnImprimirBio.Enabled = false;
            btnImprimirHema.Enabled = false;
            btnImprimirMicro.Enabled = false;
            btnImprimirUri.Enabled = false;
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
            btnImprimirBio.Enabled = true;
            btnAlterarBio.Visible = true;
            btnLocalizarBio.Visible = true;
            btnExcluirBio.Visible = true;
            btnImprimirBio.Visible = true;
            btnExcluirMicro.Visible = false;
            btnAlterarMicro.Visible = false;
            btnLocalizarMicro.Visible = false;
            btnExcluirUri.Visible = false;
            btnAlterarUri.Visible = false;
            btnLocalizarUri.Visible = false;
            btnExcluirHema.Visible = false;
            btnAlterarHema.Visible = false;
            btnLocalizarHema.Visible = false;
            btnImprimirHema.Visible = false;
            btnImprimirMicro.Visible = false;
            btnImprimirUri.Visible = false;

        }

        //RADIO BUTON CHECADO HABILITAR BOTOES DE HEMATOLOGIA
        public void rbHematologia_CheckedChanged(object sender, EventArgs e)
        {
            btnAlterarHema.Enabled = true;
            btnLocalizarHema.Enabled = true;
            btnExcluirHema.Enabled = true;
            btnImprimirHema.Enabled = true;
            btnAlterarHema.Visible = true;
            btnLocalizarHema.Visible = true;
            btnExcluirHema.Visible = true;
            btnImprimirHema.Visible = true;
            btnExcluirMicro.Visible = false;
            btnAlterarMicro.Visible = false;
            btnLocalizarMicro.Visible = false;
            btnAlterarBio.Visible = false;
            btnExcluirBio.Visible = false;
            btnLocalizarBio.Visible = false;
            btnExcluirUri.Visible = false;
            btnAlterarUri.Visible = false;
            btnLocalizarUri.Visible = false;
            btnImprimirBio.Visible = false;
            btnImprimirMicro.Visible = false;
            btnImprimirUri.Visible = false;
        }

        //RADIO BUTON CHECADO HABILITAR BOTOES DE MICROBIOLOGIA
        public void rbMicrobiologia_CheckedChanged(object sender, EventArgs e)
        {
            btnAlterarMicro.Enabled = true;
            btnLocalizarMicro.Enabled = true;
            btnExcluirMicro.Enabled = true;
            btnImprimirMicro.Enabled = true;
            btnAlterarMicro.Visible = true;
            btnLocalizarMicro.Visible = true;
            btnExcluirMicro.Visible = true;
            btnImprimirMicro.Visible = true;
            btnAlterarBio.Visible = false;
            btnExcluirBio.Visible = false;
            btnLocalizarBio.Visible = false;
            btnExcluirUri.Visible = false;
            btnAlterarUri.Visible = false;
            btnLocalizarUri.Visible = false;
            btnExcluirHema.Visible = false;
            btnAlterarHema.Visible = false;
            btnLocalizarHema.Visible = false;
            btnImprimirBio.Visible = false;
            btnImprimirHema.Visible = false;
            btnImprimirUri.Visible = false;
        }

        //RADIO BUTON CHECADO HABILITAR BOTOES DE URINALISE
        public void rbUrinalise_CheckedChanged(object sender, EventArgs e)
        {
            btnAlterarUri.Enabled = true;
            btnLocalizarUri.Enabled = true;
            btnExcluirUri.Enabled = true;
            btnImprimirUri.Enabled = true;
            btnAlterarUri.Visible = true;
            btnLocalizarUri.Visible = true;
            btnExcluirUri.Visible = true;
            btnImprimirUri.Visible = true;
            btnExcluirMicro.Visible = false;
            btnAlterarMicro.Visible = false;
            btnLocalizarMicro.Visible = false;
            btnAlterarBio.Visible = false;
            btnExcluirBio.Visible = false;
            btnLocalizarBio.Visible = false;
            btnExcluirHema.Visible = false;
            btnAlterarHema.Visible = false;
            btnLocalizarHema.Visible = false;
            btnImprimirBio.Visible = false;
            btnImprimirHema.Visible = false;
            btnImprimirMicro.Visible = false;
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
            if (txtIdExame.Text == "")
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
                    Modelo.Estaticos.abrir();
                    da = new SqlDataAdapter("sp_BuscarExameBioID", Modelo.Estaticos.con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@id_exameBio", txtIdExame.Text);
                    da.Fill(dt);
                    dgConsultarExame.DataSource = dt;

                    //metodo contar linhas
                    ContarLinhas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no metodo listar " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    Modelo.Estaticos.fechar();
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
                Modelo.Estaticos.abrir();
                //FAZER UM INNER JOIN PARA MESCLAR MAIS DE UMA TABELA (SIGLA exaB. = tabela de exame) ( SIGLA pac. = tabela de paciente) (SIGLA col. = tabela de colaborador)
                da = new SqlDataAdapter(@"SELECT exaB.id_exameBio, pac.nome, col.nome, exaB.numeroDia, exaB.col, exaB.tri, exaB.hdl, exaB.ldl, exaB.vi_dl, exaB.dhe,
                exaB.crea, exaB.tgo, exaB.tgp, exaB.bil_d, exaB.ferro, exaB.prot, exaB.clor, exaB.fal, exaB.calcio, exaB.alb, exaB.cpk, exaB.ac_ur, exaB.dhl, exaB.bhcg, exaB.phos,
                exaB.data_cadastro, exaB.mensagem, exaB.id_paciente,
                exaB.id_colaborador FROM examesBioquimica as exaB INNER JOIN pacientes as pac on exaB.id_paciente = pac.id_paciente
                INNER JOIN colaboradores as col on exaB.id_colaborador = col.id_colaborador", Modelo.Estaticos.con);
                //PREENCHER A TABELA
                da.Fill(dt);
                dgConsultarExame.DataSource = dt;

                ContarLinhas();
                FormatarDgConsultarExameBio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no metodo listar " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                Modelo.Estaticos.fechar();
            }
        }

        //BOTAO PESQUISAR EXAME HEMATOLOGIA
        public void btnLocalizarHema_Click(object sender, EventArgs e)
        {
            dgConsultarExame.ClearSelection();
            //SE TXT NOME ESTIVER VAZIO FACA 
            if (txtIdExame.Text == "")
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
                    Modelo.Estaticos.abrir();
                    da = new SqlDataAdapter("sp_BuscarExameHemaID", Modelo.Estaticos.con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@id_exameHema", txtIdExame.Text);
                    da.Fill(dt);
                    dgConsultarExame.DataSource = dt;

                    ContarLinhas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no metodo listar " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    Modelo.Estaticos.fechar();
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
                Modelo.Estaticos.abrir();
                //FAZER UM INNER JOIN PARA MESCLAR MAIS DE UMA TABELA (SIGLA exaH. = tabela de exame) ( SIGLA pac. = tabela de paciente) (SIGLA col. = tabela de colaborador)
                da = new SqlDataAdapter(@"SELECT exaH.id_exameHema, pac.nome, col.nome, exaH.numeroDia, exaH.erit, exaH.hb, exaH.ht, exaH.vmc, exaH.hcm, exaH.chcm,
                exaH.plaq, exaH.ret, exaH.leuc, exaH.mie, exaH.met, exaH.bas, exaH.seg, exaH.eos, exaH.baf, exaH.lin_tip, exaH.lint_at, exaH.mono, exaH.outras, exaH.obs, exaH.abo, exaH.rh, exaH.vhs, exaH.falci,
                exaH.data_cadastro, exaH.mensagem, exaH.id_paciente,
                exaH.id_colaborador FROM examesHematologia as exaH INNER JOIN pacientes as pac on exaH.id_paciente = pac.id_paciente
                INNER JOIN colaboradores as col on exaH.id_colaborador = col.id_colaborador", Modelo.Estaticos.con);
                //PREENCHER A TABELA
                da.Fill(dt);
                dgConsultarExame.DataSource = dt;

                ContarLinhas();
                FormatarDgConsultarExameHema();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no metodo listar " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                Modelo.Estaticos.fechar();
            }
        }

        //BOTAOLOCALIZAR EXAME MICROBIOLOGIA
        public void btnLocalizarMicro_Click(object sender, EventArgs e)
        {
            dgConsultarExame.ClearSelection();

            //SE O TXT NOME ESTIVER VAZIO FACA
            if (txtIdExame.Text == "")
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
                    Modelo.Estaticos.abrir();
                    da = new SqlDataAdapter("sp_BuscarExameMicroID", Modelo.Estaticos.con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@id_exameMicro", txtIdExame.Text);
                    da.Fill(dt);
                    dgConsultarExame.DataSource = dt;

                    ContarLinhas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no metodo listar " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    Modelo.Estaticos.fechar();
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
                Modelo.Estaticos.abrir();
                //FAZER UM INNER JOIN PARA MESCLAR MAIS DE UMA TABELA (SIGLA exaM. = tabela de exame) ( SIGLA pac. = tabela de paciente) (SIGLA col. = tabela de colaborador)
                da = new SqlDataAdapter(@"SELECT exaM.id_exameMicro, pac.nome, col.nome, exaM.numeroDia, exaM.mat, exaM.gram, exaM.micr_1, exaM.c_col, exaM.micro_2, exaM.c_col_2,
                exaM.baar, exaM.bil_d, exaM.data_cadastro, exaM.mensagem, exaM.id_paciente,
                exaM.id_colaborador FROM examesMicrobiologia as exaM INNER JOIN pacientes as pac on exaM.id_paciente = pac.id_paciente
                INNER JOIN colaboradores as col on exaM.id_colaborador = col.id_colaborador", Modelo.Estaticos.con);
                //PREENCHER A TABELA
                da.Fill(dt);
                dgConsultarExame.DataSource = dt;

                ContarLinhas();
                FormatarDgConsultarExameMicro();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no metodo listar " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                Modelo.Estaticos.fechar();
            }
        }

        //BOTAO LOCALIZAR EXAME URINALISE
        public void btnLocalizarUri_Click(object sender, EventArgs e)
        {
            dgConsultarExame.ClearSelection();

            //SE O TXT NOME ESTIVER VAZIO FACA
            if (txtIdExame.Text == "")
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
                    Modelo.Estaticos.abrir();
                    da = new SqlDataAdapter("sp_BuscarExameUriID", Modelo.Estaticos.con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@id_exameUri", txtIdExame.Text);
                    da.Fill(dt);
                    dgConsultarExame.DataSource = dt;

                    ContarLinhas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no metodo listar " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    Modelo.Estaticos.fechar();
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
                INNER JOIN colaboradores as col on exaU.id_colaborador = col.id_colaborador", Modelo.Estaticos.con);
                //PREENCHER A TABELA
                da.Fill(dt);
                dgConsultarExame.DataSource = dt;

                ContarLinhas();
                FormatarDgConsultarExameUri();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no metodo listar " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                Modelo.Estaticos.fechar();
            }
        }

        //BOTAO ALTERAR EXAME BIOQUIMICA
        public void btnAlterarBio_Click(object sender, EventArgs e)
        {
            frm_Bioquimica frm_Bioquimica = new frm_Bioquimica();
            //ABRIR O FORM DE CAD BIOQUIMICA
            frm_Bioquimica.Show();

            //HABILITAR CAMPOS e botao alterar NO FORM PARA PODER ALTERAR
            frm_Bioquimica.HabilitarCampo();
            frm_Bioquimica.btnAlterarBio.Enabled = true;
            frm_Bioquimica.btnSalvar.Enabled = false;
            frm_Bioquimica.btnNovo.Enabled = false;

            // ENVIAR PARA OS DADOS AO FORM PARA ALTERAR
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


        //BOTAO ALTERAR EXAME HEMATOLOGIA
        public void btnAlterarHema_Click(object sender, EventArgs e)
        {
            frm_Hematologia frm_Hematologia = new frm_Hematologia();
            //ABRIR O FORM DE CAD HEMATOLOGIA
            frm_Hematologia.Show();

            //HABILITAR CAMPOS e botao alterar NO FORM  PARA PODER ALTERAR
            frm_Hematologia.HabilitarCampo();
            frm_Hematologia.btnAlterarH.Enabled = true;
            frm_Hematologia.btnSalvar.Enabled = false;
            frm_Hematologia.btnNovo.Enabled = false;

            // ENVIAR PARA OS DADOS AO FORM PARA ALTERAR
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


        //BOTAO EDITAR EXAME MICROBIOLOGIA
        public void btnAlterarMicro_Click(object sender, EventArgs e)
        {
            frm_Microbiologia frm_Microbiologia = new frm_Microbiologia();
            //ABRIR O FORM DE CAD MICROBIOLOGIA
            frm_Microbiologia.Show();

            //HABILITAR CAMPOS e botao alterar NO FORM  PARA PODER ALTERAR
            frm_Microbiologia.HabilitarCampo();
            frm_Microbiologia.btnAlterarM.Enabled = true;
            frm_Microbiologia.btnNovo.Enabled = false;
            frm_Microbiologia.btncad.Enabled = false;

            //ENVIAR PARA OS DADOS AO FORM PARA ALTERAR
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



        //BOTAO ALTERAR EXAME URINALISE
        public void btnAlterarUri_Click(object sender, EventArgs e)
        {
            frm_Urinalise frm_Urinalise = new frm_Urinalise();
            //ABRIR O FORM DE CAD URINALISE
            frm_Urinalise.Show();

            //HABILITAR CAMPOS e botao alterar NO FORM  PARA PODER ALTERAR
            frm_Urinalise.HabilitarCampo();
            frm_Urinalise.btnAlterarU.Enabled = true;
            frm_Urinalise.btnNovo.Enabled = false;
            frm_Urinalise.btnSalvar.Enabled = false;

            //ENVIAR PARA OS DADOS AO FORM PARA ALTERAR
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
                        Modelo.Estaticos.abrir();
                        cmd = new SqlCommand("sp_excluirExameBio", Modelo.Estaticos.con);
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
                        Modelo.Estaticos.fechar();
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
                        Modelo.Estaticos.abrir();
                        cmd = new SqlCommand("sp_excluirExameHema", Modelo.Estaticos.con);
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
                        Modelo.Estaticos.fechar();
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
                        Modelo.Estaticos.abrir();
                        cmd = new SqlCommand("sp_excluirExameMicro", Modelo.Estaticos.con);
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
                        Modelo.Estaticos.fechar();
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
                        Modelo.Estaticos.abrir();
                        cmd = new SqlCommand("sp_excluirExameUri", Modelo.Estaticos.con);
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
                        Modelo.Estaticos.fechar();
                    }
                }
            }
        }

        //BOTAO IMPRIMIR BIOQUIMICA
        private void BtnImprimirBio_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Imprimir Exame selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            //SE O ESCOLHER SIM FAÇA
            if (msg == DialogResult.Yes)
            {
                Apresentacao.frm_ImpressaoBioquimica impressaoBio = new Apresentacao.frm_ImpressaoBioquimica();
                //PEGA OQUE TA NA DATA GRID E MANDA PARA O ESTATICO E DPS PARA IMPRESSAO
                Modelo.Estaticos.nome = Convert.ToString(dgConsultarExame.CurrentRow.Cells[1].Value);
                Modelo.Estaticos.datacol = Convert.ToString(dgConsultarExame.CurrentRow.Cells[25].Value);
                Modelo.Estaticos.colaborador = Convert.ToString(dgConsultarExame.CurrentRow.Cells[2].Value);
                Modelo.Estaticos.COLESTEROL = Convert.ToString(dgConsultarExame.CurrentRow.Cells[4].Value);
                Modelo.Estaticos.TRI = Convert.ToString(dgConsultarExame.CurrentRow.Cells[5].Value);
                Modelo.Estaticos.HDL = Convert.ToString(dgConsultarExame.CurrentRow.Cells[6].Value);
                Modelo.Estaticos.LDL = Convert.ToString(dgConsultarExame.CurrentRow.Cells[7].Value);
                Modelo.Estaticos.VI_DL = Convert.ToString(dgConsultarExame.CurrentRow.Cells[8].Value);
                Modelo.Estaticos.DHE = Convert.ToString(dgConsultarExame.CurrentRow.Cells[9].Value);
                Modelo.Estaticos.CREATINA = Convert.ToString(dgConsultarExame.CurrentRow.Cells[10].Value);
                Modelo.Estaticos.TGO = Convert.ToString(dgConsultarExame.CurrentRow.Cells[11].Value);
                Modelo.Estaticos.TGP = Convert.ToString(dgConsultarExame.CurrentRow.Cells[12].Value);
                Modelo.Estaticos.BIL_D = Convert.ToString(dgConsultarExame.CurrentRow.Cells[13].Value);
                Modelo.Estaticos.FERRO = Convert.ToString(dgConsultarExame.CurrentRow.Cells[14].Value);
                Modelo.Estaticos.PROTEINA = Convert.ToString(dgConsultarExame.CurrentRow.Cells[15].Value);
                Modelo.Estaticos.CLOR = Convert.ToString(dgConsultarExame.CurrentRow.Cells[16].Value);
                Modelo.Estaticos.FAL = Convert.ToString(dgConsultarExame.CurrentRow.Cells[17].Value);
                Modelo.Estaticos.CALCIO = Convert.ToString(dgConsultarExame.CurrentRow.Cells[18].Value);
                Modelo.Estaticos.ALBUMINA = Convert.ToString(dgConsultarExame.CurrentRow.Cells[19].Value);
                Modelo.Estaticos.CPK = Convert.ToString(dgConsultarExame.CurrentRow.Cells[20].Value);
                Modelo.Estaticos.ACIDO_URICO = Convert.ToString(dgConsultarExame.CurrentRow.Cells[21].Value);
                Modelo.Estaticos.DHL = Convert.ToString(dgConsultarExame.CurrentRow.Cells[22].Value);
                Modelo.Estaticos.BHCQ = Convert.ToString(dgConsultarExame.CurrentRow.Cells[23].Value);
                Modelo.Estaticos.PHOS = Convert.ToString(dgConsultarExame.CurrentRow.Cells[24].Value);

                impressaoBio.ShowDialog();
            }
        }

        //BOTAO IMPRIMIR EXAME HEMATOLOGIA
        private void BtnImprimirHema_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Imprimir Exame selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            //SE O ESCOLHER SIM FAÇA
            if (msg == DialogResult.Yes)
            {
                Apresentacao.Impressao.frm_ImpressaoHematologia impressaoHema = new Apresentacao.Impressao.frm_ImpressaoHematologia();
                //PEGA OQUE TA NA DATA GRID E MANDA PARA O ESTATICO E DPS PARA IMPRESSAO
                Modelo.Estaticos.nomeHema = Convert.ToString(dgConsultarExame.CurrentRow.Cells[1].Value);
                Modelo.Estaticos.datacolHema = Convert.ToString(dgConsultarExame.CurrentRow.Cells[28].Value);
                Modelo.Estaticos.colaboradorHema = Convert.ToString(dgConsultarExame.CurrentRow.Cells[2].Value);
                Modelo.Estaticos.Eritocitos = Convert.ToString(dgConsultarExame.CurrentRow.Cells[4].Value);
                Modelo.Estaticos.Hemoglobina = Convert.ToString(dgConsultarExame.CurrentRow.Cells[5].Value);
                Modelo.Estaticos.Hematocrito = Convert.ToString(dgConsultarExame.CurrentRow.Cells[6].Value);
                Modelo.Estaticos.VCM = Convert.ToString(dgConsultarExame.CurrentRow.Cells[7].Value);
                Modelo.Estaticos.HCM = Convert.ToString(dgConsultarExame.CurrentRow.Cells[8].Value);
                Modelo.Estaticos.CHCM = Convert.ToString(dgConsultarExame.CurrentRow.Cells[9].Value);
                Modelo.Estaticos.Plaquetas = Convert.ToString(dgConsultarExame.CurrentRow.Cells[10].Value);
                Modelo.Estaticos.Reticulocitos = Convert.ToString(dgConsultarExame.CurrentRow.Cells[11].Value);
                Modelo.Estaticos.Leucocitos = Convert.ToString(dgConsultarExame.CurrentRow.Cells[12].Value);
                Modelo.Estaticos.Mielocitos = Convert.ToString(dgConsultarExame.CurrentRow.Cells[13].Value);
                Modelo.Estaticos.Metamielocitos = Convert.ToString(dgConsultarExame.CurrentRow.Cells[14].Value);
                Modelo.Estaticos.Bastonetes = Convert.ToString(dgConsultarExame.CurrentRow.Cells[15].Value);
                Modelo.Estaticos.Segmentados = Convert.ToString(dgConsultarExame.CurrentRow.Cells[16].Value);
                Modelo.Estaticos.Eosinofilos = Convert.ToString(dgConsultarExame.CurrentRow.Cells[17].Value);
                Modelo.Estaticos.Basofilos = Convert.ToString(dgConsultarExame.CurrentRow.Cells[18].Value);
                Modelo.Estaticos.Linfoticos_Tipicos = Convert.ToString(dgConsultarExame.CurrentRow.Cells[19].Value);
                Modelo.Estaticos.Linfoticos_Atipicos = Convert.ToString(dgConsultarExame.CurrentRow.Cells[20].Value);
                Modelo.Estaticos.Monocitos = Convert.ToString(dgConsultarExame.CurrentRow.Cells[21].Value);
                Modelo.Estaticos.Outras = Convert.ToString(dgConsultarExame.CurrentRow.Cells[22].Value);
                Modelo.Estaticos.Observacao = Convert.ToString(dgConsultarExame.CurrentRow.Cells[23].Value);
                Modelo.Estaticos.ABO = Convert.ToString(dgConsultarExame.CurrentRow.Cells[24].Value);
                Modelo.Estaticos.RH = Convert.ToString(dgConsultarExame.CurrentRow.Cells[25].Value);
                Modelo.Estaticos.VHS = Convert.ToString(dgConsultarExame.CurrentRow.Cells[26].Value);
                Modelo.Estaticos.Falci = Convert.ToString(dgConsultarExame.CurrentRow.Cells[27].Value);
                impressaoHema.ShowDialog();
            }
        }

        //BOTAO IMPRIMIR MICROBIOLOGIA
        private void BtnImprimirMicro_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Imprimir Exame selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            //SE O ESCOLHER SIM FAÇA
            if (msg == DialogResult.Yes)
            {
                Apresentacao.Impressao.frm_ImpressaoMicrobiologia impressaoMicro = new Apresentacao.Impressao.frm_ImpressaoMicrobiologia();
                //PEGA OQUE TA NA DATA GRID E MANDA PARA O ESTATICO E DPS PARA IMPRESSAO
                Modelo.Estaticos.nomeMicro = Convert.ToString(dgConsultarExame.CurrentRow.Cells[1].Value);
                Modelo.Estaticos.datacolMicro = Convert.ToString(dgConsultarExame.CurrentRow.Cells[12].Value);
                Modelo.Estaticos.colaboradorMicro = Convert.ToString(dgConsultarExame.CurrentRow.Cells[2].Value);
                Modelo.Estaticos.Material_utilizado = Convert.ToString(dgConsultarExame.CurrentRow.Cells[4].Value);
                Modelo.Estaticos.Gram = Convert.ToString(dgConsultarExame.CurrentRow.Cells[5].Value);
                Modelo.Estaticos.Micro1 = Convert.ToString(dgConsultarExame.CurrentRow.Cells[6].Value);
                Modelo.Estaticos.C_Col = Convert.ToString(dgConsultarExame.CurrentRow.Cells[7].Value);
                Modelo.Estaticos.Micro2 = Convert.ToString(dgConsultarExame.CurrentRow.Cells[8].Value);
                Modelo.Estaticos.C_Col2 = Convert.ToString(dgConsultarExame.CurrentRow.Cells[9].Value);
                Modelo.Estaticos.Baar = Convert.ToString(dgConsultarExame.CurrentRow.Cells[10].Value);
                Modelo.Estaticos.Gram_2 = Convert.ToString(dgConsultarExame.CurrentRow.Cells[11].Value);
                impressaoMicro.ShowDialog();
            }
        }

        //BOTAO IMPRIMIR EXAME URINALISE
        private void BtnImprimirUri_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Imprimir Exame selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            //SE O ESCOLHER SIM FAÇA
            if (msg == DialogResult.Yes)
            {
                Apresentacao.Impressao.frm_ImpressaoUrinalise impressaoUri = new Apresentacao.Impressao.frm_ImpressaoUrinalise();
                //PEGA OQUE TA NA DATA GRID E MANDA PARA O ESTATICO E DPS PARA IMPRESSAO
                Modelo.Estaticos.nomeUri = Convert.ToString(dgConsultarExame.CurrentRow.Cells[1].Value);
                Modelo.Estaticos.datacolUri = Convert.ToString(dgConsultarExame.CurrentRow.Cells[25].Value);
                Modelo.Estaticos.colaboradorUri = Convert.ToString(dgConsultarExame.CurrentRow.Cells[2].Value);
                Modelo.Estaticos.Cor = Convert.ToString(dgConsultarExame.CurrentRow.Cells[4].Value);
                Modelo.Estaticos.Aspecto = Convert.ToString(dgConsultarExame.CurrentRow.Cells[5].Value);
                Modelo.Estaticos.Densidade = Convert.ToString(dgConsultarExame.CurrentRow.Cells[6].Value);
                Modelo.Estaticos.Reacao_pH = Convert.ToString(dgConsultarExame.CurrentRow.Cells[7].Value);
                Modelo.Estaticos.Proteinas = Convert.ToString(dgConsultarExame.CurrentRow.Cells[8].Value);
                Modelo.Estaticos.Glicose = Convert.ToString(dgConsultarExame.CurrentRow.Cells[9].Value);
                Modelo.Estaticos.Urobiolinogenio = Convert.ToString(dgConsultarExame.CurrentRow.Cells[10].Value);
                Modelo.Estaticos.Bilirrubinas = Convert.ToString(dgConsultarExame.CurrentRow.Cells[11].Value);
                Modelo.Estaticos.Corpos_Cetonicos = Convert.ToString(dgConsultarExame.CurrentRow.Cells[12].Value);
                Modelo.Estaticos.HemoglobinaBio = Convert.ToString(dgConsultarExame.CurrentRow.Cells[13].Value);
                Modelo.Estaticos.Nitrito = Convert.ToString(dgConsultarExame.CurrentRow.Cells[14].Value);
                Modelo.Estaticos.Celulas_Epiteliais = Convert.ToString(dgConsultarExame.CurrentRow.Cells[15].Value);
                Modelo.Estaticos.LeucocitosBio = Convert.ToString(dgConsultarExame.CurrentRow.Cells[16].Value);
                Modelo.Estaticos.Hemacias = Convert.ToString(dgConsultarExame.CurrentRow.Cells[17].Value);
                Modelo.Estaticos.Bacterias = Convert.ToString(dgConsultarExame.CurrentRow.Cells[18].Value);
                Modelo.Estaticos.Cilindros = Convert.ToString(dgConsultarExame.CurrentRow.Cells[19].Value);
                Modelo.Estaticos.Cristais = Convert.ToString(dgConsultarExame.CurrentRow.Cells[20].Value);
                Modelo.Estaticos.Filamentos_de_muco = Convert.ToString(dgConsultarExame.CurrentRow.Cells[21].Value);
                Modelo.Estaticos.Trinch = Convert.ToString(dgConsultarExame.CurrentRow.Cells[22].Value);
                Modelo.Estaticos.Outros_Elementos1 = Convert.ToString(dgConsultarExame.CurrentRow.Cells[23].Value);
                Modelo.Estaticos.Outros_Elementos2 = Convert.ToString(dgConsultarExame.CurrentRow.Cells[24].Value);
                impressaoUri.ShowDialog();
            }
        }
    }
}
