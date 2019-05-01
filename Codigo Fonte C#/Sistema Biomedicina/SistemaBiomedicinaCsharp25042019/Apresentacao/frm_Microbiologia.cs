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
    public partial class frm_Microbiologia : Form
    {
        public frm_Microbiologia()
        {
            InitializeComponent();
        }

        public void frm_Microbiologia_Load(object sender, EventArgs e)
        {
            DesabilitarCampo();
        }

        //METODO DESABILITAR CAMPOS
        private void DesabilitarCampo()
        {
            //txtNome.Enabled = false;
            //txtCola.Enabled = false;
            mskData.Enabled = false;
            txtNdia.Enabled = false;
            txtId.Enabled = false;
            txtMat.Enabled = false;
            txtGram.Enabled = false;
            txtGram2.Enabled = false;
            txtMicr1.Enabled = false;
            txtCcol.Enabled = false;
            txtCcol2.Enabled = false;
            txtMicr2.Enabled = false;
            txtBaar.Enabled = false;
            btncad.Enabled = false;
            btnSelecionarColaMicro.Enabled = false;
            btnSelecionarPacMicro.Enabled = false;
            btnAlterarM.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampo();
            LimparCampos();
        }

        //METODO LIMPAR OS CAMPOS
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCola.Text = "";
            txtId.Text = "";
            txtIdcola.Text = "";
            txtIdPac.Text = "";
            mskData.Text = "";
            txtNdia.Text = "";
            txtId.Text = "";
            txtMat.Text = "";
            txtGram.Text = "";
            txtGram2.Text = "";
            txtMicr1.Text = "";
            txtCcol.Text = "";
            txtCcol2.Text = "";
            txtMicr2.Text = "";
            txtBaar.Text = "";
            txtCola.Text = "";
            txtIdcola.Text = "";
            txtIdPac.Text = "";
        }

        //METODO HABILITAR CAMPOS
        private void HabilitarCampo()
        {
            mskData.Enabled = true;
            txtNdia.Enabled = true;
            txtId.Enabled = true;
            txtMat.Enabled = true;
            txtGram.Enabled = true;
            txtGram2.Enabled = true;
            txtMicr1.Enabled = true;
            txtCcol.Enabled = true;
            txtCcol2.Enabled = true;
            txtMicr2.Enabled = true;
            txtBaar.Enabled = true;
            btncad.Enabled = true;
            btnSelecionarColaMicro.Enabled = true;
            btnSelecionarPacMicro.Enabled = true;
        }

        //BOTAO SELECIONAR COLABORADOR MICRO
        private void btnSelecionarColaMicro_Click(object sender, EventArgs e)
        {
            frm_CadColaborador frm_CadColaborador = new frm_CadColaborador();
            txtCola.Text = "";
            txtIdcola.Text = "";
            //DESABILITAR OS BOTOES NAO NECESSARIOS E CHAMMAR O FORM ESTAGIARIO
            frm_CadColaborador.btnSelecionarBio.Visible = false;
            frm_CadColaborador.btnSelecionarHema.Visible = false;
            frm_CadColaborador.btnSelecionarUri.Visible = false;
            frm_CadColaborador.btnSelecionarMicro.Visible = true;
            frm_CadColaborador.ShowDialog();
        }

        //BOTAO SELECIONAR PACIENTE
        private void btnSelecionarPacMicro_Click(object sender, EventArgs e)
        {
            txtCola.Text = "";
            txtIdcola.Text = "";
            frm_LocalizarPaciente frm_LocalizarPaciente = new frm_LocalizarPaciente();
            //DESABILITAR OS BOTOES NAO NECESSARIOS E CHAMMAR O FORM colaborador
            frm_LocalizarPaciente.btnSelecionarBioq.Visible = false;
            frm_LocalizarPaciente.btnSelecionarHema.Visible = false;
            frm_LocalizarPaciente.btnSelecionarUrina.Visible = false;
            frm_LocalizarPaciente.btnSelecionarMicro.Visible = true;
            frm_LocalizarPaciente.ShowDialog();
        }

        //BOTAO SALVAR
        private void btncad_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            //SE TODOS OS CAMPOS NAO ESTIVEREM VAZIO FAÇA
            if (txtNome.Text != "" &&
                txtCola.Text != "" &&
                mskData.Text != "" &&
                txtNdia.Text != "" &&
                txtMat.Text != "" &&
                txtGram.Text != "" &&
                txtGram2.Text != "" &&
                txtMicr1.Text != "" &&
                txtCcol.Text != "" &&
                txtCcol2.Text != "" &&
                txtMicr2.Text != "" &&
                txtBaar.Text != "")
            {
                try
                {
                    Conexao.Conexao.abrir();
                    cmd = new SqlCommand("sp_salvarExameMicro", Conexao.Conexao.con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_paciente", txtIdPac.Text);
                    cmd.Parameters.AddWithValue("@id_colaborador", txtIdcola.Text);
                    cmd.Parameters.AddWithValue("@numeroDia", txtNdia.Text);
                    cmd.Parameters.AddWithValue("@mat", txtMat.Text);
                    cmd.Parameters.AddWithValue("@gram", txtGram.Text);
                    cmd.Parameters.AddWithValue("@micr_1", txtMicr1.Text);
                    cmd.Parameters.AddWithValue("@c_col", txtCcol.Text);
                    cmd.Parameters.AddWithValue("@micro_2", txtMicr2.Text);
                    cmd.Parameters.AddWithValue("@c_col_2", txtCcol2.Text);
                    cmd.Parameters.AddWithValue("@baar", txtBaar.Text);
                    cmd.Parameters.AddWithValue("@bil_d", txtGram2.Text);
                    cmd.Parameters.AddWithValue("@data_cadastro", mskData.Text);

                    cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                    cmd.ExecuteNonQuery();

                    string msg = cmd.Parameters["@mensagem"].Value.ToString();
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

                    LimparCampos();
                    DesabilitarCampo();
                    btncad.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Salvar os dados" + ex.Message);
                    Conexao.Conexao.fechar();
                }
            }
            else
            {
                MessageBox.Show("Insira os dados nos campos vazios");
            }
        }

        //BOTAO ALTERAR
        public void btnAlterarM_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            try
            {
                Conexao.Conexao.abrir();
                cmd = new SqlCommand("sp_editarExameMicro", Conexao.Conexao.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_exameMicro", txtId.Text);
                cmd.Parameters.AddWithValue("@id_paciente", txtIdPac.Text);
                cmd.Parameters.AddWithValue("@id_colaborador", txtIdcola.Text);
                cmd.Parameters.AddWithValue("@numeroDia", txtNdia.Text);
                cmd.Parameters.AddWithValue("@mat", txtMat.Text);
                cmd.Parameters.AddWithValue("@gram", txtGram.Text);
                cmd.Parameters.AddWithValue("@micr_1", txtMicr1.Text);
                cmd.Parameters.AddWithValue("@c_col", txtCcol.Text);
                cmd.Parameters.AddWithValue("@micro_2", txtMicr2.Text);
                cmd.Parameters.AddWithValue("@c_col_2", txtCcol2.Text);
                cmd.Parameters.AddWithValue("@baar", txtBaar.Text);
                cmd.Parameters.AddWithValue("@bil_d", txtGram2.Text);
                cmd.Parameters.AddWithValue("@data_cadastro", mskData.Text);

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                cmd.ExecuteNonQuery();

                string msg = cmd.Parameters["@mensagem"].Value.ToString();
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

                LimparCampos();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar os dados" + ex.Message);
                Conexao.Conexao.fechar();
            }
        }

        //BOTAO PARA CHAMAR A VISUALIZAO DA IMPRESSAO
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog1.Text = "Impressão exame Microbiologia";
            PrintPreviewDialog1.Width = 900; //TAMANHO DA LARGURA
            PrintPreviewDialog1.Height = 700; //TAMANHO DA ALTURA

            PrintPreviewDialog1.Document = PrintDocument1; //CHAMAR O DOCUMENTO
            PrintPreviewDialog1.ShowDialog();
        }

        //DEFINIR OQUE IMPRIMIR( OQ IMPRIMIR, FONT, PINCEL, onde fazer isso condernadas
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Nome:", txtNome.Font, Brushes.Black, 100, 100); //NOME
            e.Graphics.DrawString(txtNome.Text, txtNome.Font, Brushes.Black, 140, 100);
            e.Graphics.DrawString("Data:", mskData.Font, Brushes.Black, 100, 125); //DATA
            e.Graphics.DrawString(mskData.Text, mskData.Font, Brushes.Black, 140, 125);
        }
    }
}
