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
    public partial class frm_CadColaborador : Form
    {
        public frm_CadColaborador()
        {
            InitializeComponent();
        }

        private void frm_CadColaborador_Load(object sender, EventArgs e)
        {
            DesabilitarCampo();
        }

        //METODO DESABILITAR CAMPOS
        private void DesabilitarCampo()
        {
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            mskCpf.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            cmbNivel.Enabled = false;
            btnPesquisar.Enabled = true;
        }

        //BOTAO NOVO
        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampo();
            LimparCampos();
        }

        //METODO LIMPAR CAMPOS
        private void LimparCampos()
        {
            txtNome.Text = "";
            mskCpf.Text = "";
            cmbNivel.Text = "";
            txtSenha.Text = "";
        }

        //METODO HABILITAR CAMPOS 
        private void HabilitarCampo()
        {
            txtNome.Enabled = true;
            mskCpf.Enabled = true;
            btnSalvar.Enabled = true;
            btnPesquisar.Enabled = true;
            cmbNivel.Enabled = true;
            txtSenha.Enabled = true;
        }

        //BOTAO PESQUISAR
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                Listar();
            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = default(SqlDataAdapter);

                try
                {
                    Modelo.Estaticos.abrir();
                    da = new SqlDataAdapter("sp_buscarEstagiarioNome", Modelo.Estaticos.con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@Nome", txtNome.Text);
                    da.Fill(dt);
                    dgColaborador.DataSource = dt;

                    //metodo contar linhas
                    ContarLinhas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no metodo listar " + ex.Message, "Erro" , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    Modelo.Estaticos.fechar();
                }
            }
        }

        //METODO CONTAR LINHAS
        private void ContarLinhas()
        {
            int total = dgColaborador.Rows.Count;
            lbltotal.Text = System.Convert.ToString(total);
        }

        //METODO LISTAR
        private void Listar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);

            try
            {
                Modelo.Estaticos.abrir();
                da = new SqlDataAdapter("SELECT * FROM colaboradores", Modelo.Estaticos.con);
                //PREENCHER A TABELA
                da.Fill(dt);
                dgColaborador.DataSource = dt;

                ContarLinhas();
                FormatarDgColaborador();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no metodo listar " + ex.Message);
                Modelo.Estaticos.fechar();
            }
        }

        //METODO FORMATAR DG COLABORADOR
        private void FormatarDgColaborador()
        {
            dgColaborador.Columns[0].Visible = false; //id
            dgColaborador.Columns[1].HeaderText = "Nome";
            dgColaborador.Columns[2].HeaderText = "CPF";
            dgColaborador.Columns[3].HeaderText = "Nível";
            dgColaborador.Columns[4].Visible = false; // senha
        }

        //BOTAO SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            if (mskCpf.Text != "   .   .   .  " &&
                    txtNome.Text != "" &&
                    txtSenha.Text != "" &&
                    cmbNivel.Text != "")
            {
                try
                {
                    Modelo.Estaticos.abrir();
                    cmd = new SqlCommand("sp_salvarEstagiario", Modelo.Estaticos.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                    cmd.Parameters.AddWithValue("@cpf", mskCpf.Text);
                    cmd.Parameters.AddWithValue("@nivel", cmbNivel.Text);
                    cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                    cmd.ExecuteNonQuery();

                    string msg = cmd.Parameters["@mensagem"].Value.ToString();
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    Listar();
                    LimparCampos();

                    btnSalvar.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Salvar os dados " + ex.Message);
                    Modelo.Estaticos.fechar();
                }
            }
            else
            {
                MessageBox.Show("Insira os dados nos campos vazios");
            }
        }

        //BOTAO EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);
            if (mskCpf.Text != "" &&
                    txtNome.Text != "" &&
                    txtSenha.Text != "" &&
                    cmbNivel.Text != "")
            {
                try
                {
                    Modelo.Estaticos.abrir();
                    cmd = new SqlCommand("sp_editarEstagiario", Modelo.Estaticos.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_colaborador", txtId.Text);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                    cmd.Parameters.AddWithValue("@cpf", mskCpf.Text);
                    cmd.Parameters.AddWithValue("@nivel", cmbNivel.Text);
                    cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                    cmd.ExecuteNonQuery();

                    string msg = cmd.Parameters["@mensagem"].Value.ToString();
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    Listar();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Editar os dados " + ex.Message);
                    Modelo.Estaticos.fechar();
                }
            }
            else
            {
                MessageBox.Show("Insira os dados nos campos vazios");
            }
        }

        //AO CLICKAR NA GRID habilita os botoes editar e excluir
        private void dgColaborador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;

            //habilitar campos NOME, CPF E NIVEL PARA EDITAR
            HabilitarCampo();

            //DESABILITA O BT SALVAR PARA SOMENTE EDITAR
            btnSalvar.Enabled = false;

            //TRAZ DE VOLTA OS CAMPOS SELECIONADOS PARA EDITAR
            txtId.Text = System.Convert.ToString(dgColaborador.CurrentRow.Cells[0].Value);
            txtNome.Text = System.Convert.ToString(dgColaborador.CurrentRow.Cells[1].Value);
            mskCpf.Text = System.Convert.ToString(dgColaborador.CurrentRow.Cells[2].Value);
            cmbNivel.Text = System.Convert.ToString(dgColaborador.CurrentRow.Cells[3].Value);
        }

        //BOTAO EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            if (txtId.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        Modelo.Estaticos.abrir();
                        cmd = new SqlCommand("sp_excluirEstagiario", Modelo.Estaticos.con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_colaborador", txtId.Text);

                        cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                        cmd.ExecuteNonQuery();

                        string msg = cmd.Parameters["@mensagem"].Value.ToString();
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

                        Listar();
                        LimparCampos();

                        btnEditar.Enabled = false;
                        btnExcluir.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir os dados " + ex.Message);
                        Modelo.Estaticos.fechar();
                    }
                }
            }
        }

        //BOTAo SELECIONAR COLABORADOR PARA BIOQUIMICA
        public void btnSelecionarBio_Click(object sender, EventArgs e)
        {
            //SELECIONA O ID E O NOME E MANDA PARA A CLASSE ESTATICA
            Modelo.Estaticos.idColaborador = System.Convert.ToString(dgColaborador.CurrentRow.Cells[0].Value);
            Modelo.Estaticos.nomeColarador = System.Convert.ToString(dgColaborador.CurrentRow.Cells[1].Value);

            this.Close();
            this.Dispose();
        }

        //BOTAR SELECIONAR COLABORADOR PARA HEMATOLOGIA
        private void btnSelecionarHema_Click(object sender, EventArgs e)
        {
            //SELECIONA O ID E O NOME E MANDA PARA A CLASSE ESTATICA
            Modelo.Estaticos.idColaborador = System.Convert.ToString(dgColaborador.CurrentRow.Cells[0].Value);
            Modelo.Estaticos.nomeColarador = System.Convert.ToString(dgColaborador.CurrentRow.Cells[1].Value);

            this.Close();
            this.Dispose();
        }

        //BOTAR SELECIONAR COLABORADOR PARA URINALISE
        private void btnSelecionarUri_Click(object sender, EventArgs e)
        {
            //SELECIONA O ID E O NOME E MANDA PARA A CLASSE ESTATICA
            Modelo.Estaticos.idColaborador = System.Convert.ToString(dgColaborador.CurrentRow.Cells[0].Value);
            Modelo.Estaticos.nomeColarador = System.Convert.ToString(dgColaborador.CurrentRow.Cells[1].Value);

            this.Close();
            this.Dispose();
        }

        //BOTAR SELECIONAR COLABORADOR PARA MICROBIOLOGIA
        private void btnSelecionarMicro_Click(object sender, EventArgs e)
        {
            //SELECIONA O ID E O NOME E MANDA PARA A CLASSE ESTATICA
            Modelo.Estaticos.idColaborador = System.Convert.ToString(dgColaborador.CurrentRow.Cells[0].Value);
            Modelo.Estaticos.nomeColarador = System.Convert.ToString(dgColaborador.CurrentRow.Cells[1].Value);

            this.Close();
            this.Dispose();
        }
    }
}
