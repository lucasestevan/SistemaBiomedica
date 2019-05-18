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
    public partial class frm_LocalizarPaciente : Form
    {
        public frm_LocalizarPaciente()
        {
            InitializeComponent();
        }

        private void frm_LocalizarPaciente_Load(object sender, EventArgs e)
        {
            DesabilarCampos();
        }

        //METODO DESABILITAR CAMPOS
        private void DesabilarCampos()
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSelecionarMicro.Enabled = false;
            btnSelecionarUrina.Enabled = false;
            btnSelecionarBioq.Enabled = false;
            btnSelecionarHema.Enabled = false;
        }

        //BOTAO PESQUISAR
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //FAZER A BUSCA PELO NOME
            if (txtnome.Text == "")
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
                    da = new SqlDataAdapter("sp_buscarPacientesNome", Modelo.Estaticos.con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@Nome", txtnome.Text);
                    da.Fill(dt);
                    dgLocalizarPac.DataSource = dt;

                    //metodo contar linhas
                    ContarLinhas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no metodo listar " + ex.Message, "Erro" , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    Modelo.Estaticos.fechar();
                }
            }
            FormatarDgPaciente();
            ContarLinhas();
        }

        //METODO FORMATAR O DG PACIENTE
        private void FormatarDgPaciente()
        {
            dgLocalizarPac.Columns[0].Visible = false; //ID PACIENTE
            dgLocalizarPac.Columns[1].HeaderText = "Nome";
            dgLocalizarPac.Columns[2].HeaderText = "CPF";
            dgLocalizarPac.Columns[3].HeaderText = "RG";
            dgLocalizarPac.Columns[4].HeaderText = "Sexo";
            dgLocalizarPac.Columns[5].HeaderText = "Dt. Nascimento";
            dgLocalizarPac.Columns[6].HeaderText = "Telefone";
            dgLocalizarPac.Columns[7].HeaderText = "Celular";
            dgLocalizarPac.Columns[8].HeaderText = "Endereço";
            dgLocalizarPac.Columns[9].HeaderText = "Num";
            dgLocalizarPac.Columns[10].HeaderText = "Bairro";
            dgLocalizarPac.Columns[11].HeaderText = "Cidade";
            dgLocalizarPac.Columns[12].HeaderText = "Uf";
            dgLocalizarPac.Columns[13].HeaderText = "CEP";
            dgLocalizarPac.Columns[14].HeaderText = "Responsavel";
            dgLocalizarPac.Columns[15].HeaderText = "Prontuario";
        }

        //metodo contar linhas
        private void ContarLinhas()
        {
            int total = dgLocalizarPac.Rows.Count;
            lblTotal.Text = System.Convert.ToString(total);
        }

        //METODO LISTAR
        private void Listar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            try
            {
                Modelo.Estaticos.abrir();
                da = new SqlDataAdapter("SELECT * FROM pacientes", Modelo.Estaticos.con);
                //PREENCHER A TABELA
                da.Fill(dt);
                dgLocalizarPac.DataSource = dt;

                ContarLinhas();
                FormatarDgPaciente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no metodo listar " + ex.Message, "Erro" , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                Modelo.Estaticos.fechar();
            }
        }

        //BOTAO ALTERAR PACIENTE
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frm_CadPacientes frm_CadPacientes = new frm_CadPacientes();
            //ABRIR O FORM DE CAD DE PACIENTE
            frm_CadPacientes.Show();

            //HABILITAR CAMPOS e botao alterar NO FORM PARA PODER ALTERAR
            frm_CadPacientes.habilitarCampos();
            frm_CadPacientes.btnAlterarP.Enabled = true;
            frm_CadPacientes.btnSalvar.Enabled = false;
            frm_CadPacientes.btnNovo.Enabled = false;

            // ENVIAR PARA OS DADOS AO FORM PARA ALTERAR
            frm_CadPacientes.txtNome.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[1].Value);
            frm_CadPacientes.mskCpf.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[2].Value);
            frm_CadPacientes.mskRg.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[3].Value);
            frm_CadPacientes.cmbSexo.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[4].Value);
            frm_CadPacientes.dtpDatanasc.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[5].Value);
            frm_CadPacientes.mskTel.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[6].Value);
            frm_CadPacientes.mskCel.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[7].Value);
            frm_CadPacientes.txtEnd.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[8].Value);
            frm_CadPacientes.txtNum.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[9].Value);
            frm_CadPacientes.txtBairro.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[10].Value);
            frm_CadPacientes.txtCidade.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[11].Value);
            frm_CadPacientes.cmbUf.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[12].Value);
            frm_CadPacientes.mskCep.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[13].Value);
            frm_CadPacientes.txtResponsavel.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[14].Value);
            frm_CadPacientes.txtProntuario.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[15].Value);
        }

        //METODO HABILITAR CAMPO DO FORM PACIENTE PARA EDITAR
        private void habilitarCamposParaeditar()
        {
            frm_CadPacientes frm_CadPacientes = new frm_CadPacientes();
            frm_CadPacientes.txtNome.Enabled = true;
            frm_CadPacientes.mskCpf.Enabled = false;
            frm_CadPacientes.mskRg.Enabled = true;
            frm_CadPacientes.cmbSexo.Enabled = true;
            frm_CadPacientes.dtpDatanasc.Enabled = true;
            frm_CadPacientes.mskTel.Enabled = true;
            frm_CadPacientes.mskCel.Enabled = true;
            frm_CadPacientes.txtEnd.Enabled = true;
            frm_CadPacientes.txtNum.Enabled = true;
            frm_CadPacientes.txtBairro.Enabled = true;
            frm_CadPacientes.txtCidade.Enabled = true;
            frm_CadPacientes.cmbUf.Enabled = true;
            frm_CadPacientes.mskCep.Enabled = true;
            frm_CadPacientes.txtResponsavel.Enabled = true;
            frm_CadPacientes.txtProntuario.Enabled = true;
            frm_CadPacientes.btnSalvar.Enabled = false;
            frm_CadPacientes.btnNovo.Enabled = false;
            frm_CadPacientes.btnAlterarP.Enabled = true;
        }

        //METODO EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            if (txtIdPac.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        Modelo.Estaticos.abrir();
                        cmd = new SqlCommand("sp_excluirPaciente", Modelo.Estaticos.con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_paciente", txtIdPac.Text);

                        cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                        cmd.ExecuteNonQuery();

                        string msg = cmd.Parameters["@mensagem"].Value.ToString();
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
                        Listar();

                        btnAlterar.Enabled = false;
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
       
        //BOTAO SELECIONAR PACIENTE NOME E A ID DA GRID E JOGAR PARA MICROBIOLOGIA
        public void btnSelecionarMicro_Click(object sender, EventArgs e)
        {
            //SELECIONA O ID E O NOME E MANDA PARA A CLASSE ESTATICA
            Modelo.Estaticos.idPaciente = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[0].Value);
            Modelo.Estaticos.nomePaciente = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[1].Value);

            this.Close();
            this.Dispose();

        }

        //BOTAO SELECIONAR PACIENTE NOME E A ID DA GRID E JOGAR PARA URINALISE
        private void btnSelecionarUrina_Click(object sender, EventArgs e)
        {
            //SELECIONA O ID E O NOME E MANDA PARA A CLASSE ESTATICA
            Modelo.Estaticos.idPaciente = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[0].Value);
            Modelo.Estaticos.nomePaciente = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[1].Value);

            this.Close();
            this.Dispose();
        }

        //BOTAO SELECIONAR PACIENTE NOME E A ID DA GRID E JOGAR PARA HEMATOLOGIA
        private void btnSelecionarHema_Click(object sender, EventArgs e)
        {
            //SELECIONA O ID E O NOME E MANDA PARA A CLASSE ESTATICA
            Modelo.Estaticos.idPaciente = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[0].Value);
            Modelo.Estaticos.nomePaciente = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[1].Value);

            this.Close();
            this.Dispose();
        }

        //BOTAO SELECIONAR PACIENTE NOME E A ID DA GRID E JOGAR PARA BIOQUIMICA
        private void btnSelecionarBioq_Click(object sender, EventArgs e)
        {
            //SELECIONA O ID E O NOME E MANDA PARA A CLASSE ESTATICA
            Modelo.Estaticos.idPaciente = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[0].Value);
            Modelo.Estaticos.nomePaciente = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[1].Value);

            this.Close();
            this.Dispose();
        }

        //METODO AO CLIKAR NA GRID HABILITAR BOTOES PARA EDITAR E EXLCUIR
        private void dgLocalizarPac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
            txtIdPac.Text = System.Convert.ToString(dgLocalizarPac.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSelecionarUrina.Enabled = true;
            btnSelecionarBioq.Enabled = true;
            btnSelecionarHema.Enabled = true;
            btnSelecionarMicro.Enabled = true;
        }
    }
}
