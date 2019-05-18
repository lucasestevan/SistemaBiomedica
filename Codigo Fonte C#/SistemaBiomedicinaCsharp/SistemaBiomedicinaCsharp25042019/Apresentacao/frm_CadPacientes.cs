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
    public partial class frm_CadPacientes : Form
    {
        public frm_CadPacientes()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void frm_CadPacientes_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        //METODO DESABILITAR CAMPOS
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            mskCpf.Enabled = false;
            mskRg.Enabled = false;
            cmbSexo.Enabled = false;
            dtpDatanasc.Enabled = false;
            mskTel.Enabled = false;
            mskCel.Enabled = false;
            txtEnd.Enabled = false;
            txtNum.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cmbUf.Enabled = false;
            mskCep.Enabled = false;
            txtResponsavel.Enabled = false;
            txtProntuario.Enabled = false;
            btnSalvar.Enabled = false;
            btnAlterarP.Enabled = false;
        }

        //BOTAO NOVO
        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            LimparCampos();
        }

        //METODO HABILITAR CAMPOS
        public void habilitarCampos()
        {
            txtNome.Enabled = true;
            mskCpf.Enabled = true;
            mskRg.Enabled = true;
            cmbSexo.Enabled = true;
            dtpDatanasc.Enabled = true;
            mskTel.Enabled = true;
            mskCel.Enabled = true;
            txtEnd.Enabled = true;
            txtNum.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cmbUf.Enabled = true;
            mskCep.Enabled = true;
            txtResponsavel.Enabled = true;
            txtProntuario.Enabled = true;
            btnSalvar.Enabled = true;
        }

        //METODO LIMPAR CAMPOS
        private void LimparCampos()
        {
            txtNome.Text = "";
            mskCpf.Text = "";
            mskRg.Text = "";
            cmbSexo.Text = "";
            dtpDatanasc.Text = "";
            mskTel.Text = "";
            mskCel.Text = "";
            txtEnd.Text = "";
            txtNum.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cmbUf.Text = "";
            mskCep.Text = "";
            txtResponsavel.Text = "";
            txtProntuario.Text = "";
        }

        //BOTAO SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            //SE OS CAMPOS NAO ESTIVEREM VAZIOS FAÇA
            if (mskCpf.Text != "" &&
                    txtNome.Text != "" &&
                    mskCpf.Text != "" &&
                    mskRg.Text != "" &&
                    cmbSexo.Text != "" &&
                    txtNum.Text != "" &&
                    dtpDatanasc.Text != "" &&
                    txtEnd.Text != "" &&
                    txtBairro.Text != "" &&
                    txtCidade.Text != "" &&
                    cmbUf.Text != "")
            {
                try
                {
                    Modelo.Estaticos.abrir();
                    cmd = new SqlCommand("sp_salvarPaciente", Modelo.Estaticos.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cpf", mskCpf.Text);
                    cmd.Parameters.AddWithValue("@rg", mskRg.Text);
                    cmd.Parameters.AddWithValue("@sexo", cmbSexo.Text);
                    cmd.Parameters.AddWithValue("@dataNascimento", dtpDatanasc.Text);
                    cmd.Parameters.AddWithValue("@telefone", mskTel.Text);
                    cmd.Parameters.AddWithValue("@celular", mskCel.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEnd.Text);
                    cmd.Parameters.AddWithValue("@numeroCasa", txtNum.Text);
                    cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                    cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                    cmd.Parameters.AddWithValue("@uf", cmbUf.Text);
                    cmd.Parameters.AddWithValue("@cep", mskCep.Text);
                    cmd.Parameters.AddWithValue("@responsavel", txtResponsavel.Text);
                    cmd.Parameters.AddWithValue("@prontuario", txtProntuario.Text);

                    cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                    cmd.ExecuteNonQuery();

                    string msg = cmd.Parameters["@mensagem"].Value.ToString();
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

                    LimparCampos();
                    DesabilitarCampos();
                    btnSalvar.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Salvar os dados" + ex.Message);
                    Modelo.Estaticos.fechar();
                }
            }
            else
            {
                MessageBox.Show("Insira os dados nos campos vazios");
            }
        }

        //BOTAO ALTERAR
        private void btnAlterarP_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);
            try
            {
                Modelo.Estaticos.abrir();
                cmd = new SqlCommand("sp_editarPaciente", Modelo.Estaticos.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", mskCpf.Text);
                cmd.Parameters.AddWithValue("@rg", mskRg.Text);
                cmd.Parameters.AddWithValue("@sexo", cmbSexo.Text);
                cmd.Parameters.AddWithValue("@dataNascimento", dtpDatanasc.Text);
                cmd.Parameters.AddWithValue("@telefone", mskTel.Text);
                cmd.Parameters.AddWithValue("@celular", mskCel.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEnd.Text);
                cmd.Parameters.AddWithValue("@numeroCasa", txtNum.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("@uf", cmbUf.Text);
                cmd.Parameters.AddWithValue("@cep", mskCep.Text);
                cmd.Parameters.AddWithValue("@responsavel", txtResponsavel.Text);
                cmd.Parameters.AddWithValue("@prontuario", txtProntuario.Text);
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
                Modelo.Estaticos.fechar();
            }
        }
    }
}
