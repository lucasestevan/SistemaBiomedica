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
    public partial class frm_Bioquimica : Form
    {
        public frm_Bioquimica()
        {
            InitializeComponent();

        }

        public frm_Bioquimica(string nome)
        {
            txtNome.Text = Modelo.Estaticos.nomePaciente;
        }

        public void frm_Biomedicina_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        //METODO DESABILITAR CAMPOS 
        public void DesabilitarCampos()
        {
            txtId.Enabled = false;
            //txtNome.Enabled = false;
            //txtCola.Enabled = false;
            btnSelecionarColaBio.Enabled = false;
            txtNdia.Enabled = false;
            txtCol.Enabled = false;
            txtTri.Enabled = false;
            txtHdl.Enabled = false;
            txtLdl.Enabled = false;
            txtVidl.Enabled = false;
            txtdhe.Enabled = false;
            txtCrea.Enabled = false;
            txtBild.Enabled = false;
            txtTgo.Enabled = false;
            txtTgp.Enabled = false;
            txtFerro.Enabled = false;
            txtProt.Enabled = false;
            txtClor.Enabled = false;
            txtFal.Enabled = false;
            txtCalcio.Enabled = false;
            txtAlb.Enabled = false;
            txtCpk.Enabled = false;
            txtAcur.Enabled = false;
            txtDhl.Enabled = false;
            txtBhcg.Enabled = false;
            txtPhos.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            mskData.Enabled = false;
            btnAlterarBio.Enabled = false;
            btnSelecionarPac.Enabled = false;   
        }

        //BOTAO NOVO
        public void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampo();
            LimparCampos();
            btnNovo.Enabled = false;
        }

        //METODO LIMPAR CAMPOS
        public void LimparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtNdia.Text = "";
            txtCol.Text = "";
            txtTri.Text = "";
            txtHdl.Text = "";
            txtLdl.Text = "";
            txtVidl.Text = "";
            txtdhe.Text = "";
            txtCrea.Text = "";
            txtBild.Text = "";
            txtTgo.Text = "";
            txtTgp.Text = "";
            txtFerro.Text = "";
            txtProt.Text = "";
            txtClor.Text = "";
            txtFal.Text = "";
            txtCalcio.Text = "";
            txtAlb.Text = "";
            txtCpk.Text = "";
            txtAcur.Text = "";
            txtDhl.Text = "";
            txtBhcg.Text = "";
            txtPhos.Text = "";
            mskData.Text = "";
            txtCola.Text = "";
            txtIdcola.Text = "";
            txtIdPac.Text = "";
        }

        //METODO HABILITAR CAMPOS
        public void HabilitarCampo()
        {
            txtId.Enabled = true;
            txtNdia.Enabled = true;
            txtCol.Enabled = true;
            txtTri.Enabled = true;
            txtHdl.Enabled = true;
            txtLdl.Enabled = true;
            txtVidl.Enabled = true;
            txtdhe.Enabled = true;
            txtCrea.Enabled = true;
            txtBild.Enabled = true;
            txtTgo.Enabled = true;
            txtTgp.Enabled = true;
            txtFerro.Enabled = true;
            txtProt.Enabled = true;
            txtClor.Enabled = true;
            txtFal.Enabled = true;
            txtCalcio.Enabled = true;
            txtAlb.Enabled = true;
            txtCpk.Enabled = true;
            txtAcur.Enabled = true;
            txtDhl.Enabled = true;
            txtBhcg.Enabled = true;
            txtPhos.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = true;
            mskData.Enabled = true;
            btnSelecionarColaBio.Enabled = true;
            btnAlterarBio.Enabled = false;
            btnSelecionarPac.Enabled = true;    
        }

        //BOTAO SELECIONAR COLABORADOR
        public void btnSelecionarColaBio_Click(object sender, EventArgs e)
        {
            txtCola.Text = "";
            txtIdcola.Text = "";

            frm_CadColaborador frm_CadColaborador = new frm_CadColaborador();
            //DESABLITAR OS BOTOES PRIMEIRO E DEPOIS CHAMAR O FORM ESTAGIARIO
            frm_CadColaborador.btnSelecionarMicro.Visible = false;
            frm_CadColaborador.btnSelecionarHema.Visible = false;
            frm_CadColaborador.btnSelecionarUri.Visible = false;
            frm_CadColaborador.btnSelecionarBio.Visible = true;
            frm_CadColaborador.ShowDialog();

            //PEGA O QUE ESTÁ NA CLASSE ESTATICA E JOGA NO TXT NOME E ID colaborador
            txtCola.Text = Modelo.Estaticos.nomeColarador;
            txtIdcola.Text = Modelo.Estaticos.idColaborador;
        }

        //BOTAO SELECIONAR PACIENTE 
        public void btnSelecionarPac_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtIdPac.Text = "";
            frm_LocalizarPaciente frm_LocalizarPaciente = new frm_LocalizarPaciente();
            //DESABLITAR OS BOTOES PRIMEIRO E DEPOIS CHAMAR O FORM LOCALIZAR
            frm_LocalizarPaciente.btnSelecionarMicro.Visible = false;
            frm_LocalizarPaciente.btnSelecionarUrina.Visible = false;
            frm_LocalizarPaciente.btnSelecionarHema.Visible = false;
            frm_LocalizarPaciente.btnSelecionarBioq.Visible = true;
            frm_LocalizarPaciente.ShowDialog();

            //PEGA O QUE ESTÁ NA CLASSE ESTATICA E JOGA NO TXT NOME E ID
            txtNome.Text = Modelo.Estaticos.nomePaciente;
            txtIdPac.Text = Modelo.Estaticos.idPaciente;
        }

        // BOTAO SALVAR
        public void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            //SE TODOS OS CAMPOS NAO ESTIVEREM VAZIO FAÇA
            if (txtNome.Text != "" &&
                    txtNdia.Text != "" &&
                    mskData.Text != "" &&
                    txtCol.Text != "" &&
                    txtTri.Text != "" &&
                    txtHdl.Text != "" &&
                    txtLdl.Text != "" &&
                    txtVidl.Text != "" &&
                    txtdhe.Text != "" &&
                    txtCrea.Text != "" &&
                    txtBild.Text != "" &&
                    txtTgo.Text != "" &&
                    txtTgp.Text != "" &&
                    txtFerro.Text != "" &&
                    txtProt.Text != "" &&
                    txtClor.Text != "" &&
                    txtFal.Text != "" &&
                    txtCalcio.Text != "" &&
                    txtAlb.Text != "" &&
                    txtCpk.Text != "" &&
                    txtAcur.Text != "" &&
                    txtDhl.Text != "" &&
                    txtBhcg.Text != "" &&
                    txtPhos.Text != "")
            {
                try
                {
                    Modelo.Estaticos.abrir();
                    cmd = new SqlCommand("sp_salvarExameBio", Modelo.Estaticos.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_paciente", txtIdPac.Text);
                    cmd.Parameters.AddWithValue("@id_colaborador", txtIdcola.Text);
                    cmd.Parameters.AddWithValue("@numeroDia", txtNdia.Text);
                    cmd.Parameters.AddWithValue("@col", txtCol.Text);
                    cmd.Parameters.AddWithValue("@tri", txtTri.Text);
                    cmd.Parameters.AddWithValue("@hdl", txtHdl.Text);
                    cmd.Parameters.AddWithValue("@ldl", txtLdl.Text);
                    cmd.Parameters.AddWithValue("@vi_dl", txtVidl.Text);
                    cmd.Parameters.AddWithValue("@dhe", txtdhe.Text);
                    cmd.Parameters.AddWithValue("@crea", txtCrea.Text);
                    cmd.Parameters.AddWithValue("@bil_d", txtBild.Text);
                    cmd.Parameters.AddWithValue("@tgo", txtTgo.Text);
                    cmd.Parameters.AddWithValue("@tgp", txtTgp.Text);
                    cmd.Parameters.AddWithValue("@ferro", txtFerro.Text);
                    cmd.Parameters.AddWithValue("@prot", txtProt.Text);
                    cmd.Parameters.AddWithValue("@clor", txtClor.Text);
                    cmd.Parameters.AddWithValue("@fal", txtFal.Text);
                    cmd.Parameters.AddWithValue("@calcio", txtCalcio.Text);
                    cmd.Parameters.AddWithValue("@alb", txtAlb.Text);
                    cmd.Parameters.AddWithValue("@cpk", txtCpk.Text);
                    cmd.Parameters.AddWithValue("@ac_ur", txtAcur.Text);
                    cmd.Parameters.AddWithValue("@dhl", txtDhl.Text);
                    cmd.Parameters.AddWithValue("@bhcg", txtBhcg.Text);
                    cmd.Parameters.AddWithValue("@phos", txtPhos.Text);
                    cmd.Parameters.AddWithValue("@data_cadastro", mskData.Text);

                    cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                    cmd.ExecuteNonQuery();

                    string msg = cmd.Parameters["@mensagem"].Value.ToString();
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

                    LimparCampos();
                    DesabilitarCampos();
                    btnSalvar.Enabled = false;
                    btnNovo.Enabled = true;
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

        //BOTAO ALTERAR
        public void btnAlterarBio_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);
            try
            {
                Modelo.Estaticos.abrir();
                cmd = new SqlCommand("sp_editarExameBio", Modelo.Estaticos.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_exameBio", txtId.Text);
                cmd.Parameters.AddWithValue("@id_paciente", txtIdPac.Text);
                cmd.Parameters.AddWithValue("@id_colaborador", txtIdcola.Text);
                cmd.Parameters.AddWithValue("@numeroDia", txtNdia.Text);
                cmd.Parameters.AddWithValue("@col", txtCol.Text);
                cmd.Parameters.AddWithValue("@tri", txtTri.Text);
                cmd.Parameters.AddWithValue("@hdl", txtHdl.Text);
                cmd.Parameters.AddWithValue("@ldl", txtLdl.Text);
                cmd.Parameters.AddWithValue("@vi_dl", txtVidl.Text);
                cmd.Parameters.AddWithValue("@dhe", txtdhe.Text);
                cmd.Parameters.AddWithValue("@crea", txtCrea.Text);
                cmd.Parameters.AddWithValue("@bil_d", txtBild.Text);
                cmd.Parameters.AddWithValue("@tgo", txtTgo.Text);
                cmd.Parameters.AddWithValue("@tgp", txtTgp.Text);
                cmd.Parameters.AddWithValue("@ferro", txtFerro.Text);
                cmd.Parameters.AddWithValue("@prot", txtProt.Text);
                cmd.Parameters.AddWithValue("@clor", txtClor.Text);
                cmd.Parameters.AddWithValue("@fal", txtFal.Text);
                cmd.Parameters.AddWithValue("@calcio", txtCalcio.Text);
                cmd.Parameters.AddWithValue("@alb", txtAlb.Text);
                cmd.Parameters.AddWithValue("@cpk", txtCpk.Text);
                cmd.Parameters.AddWithValue("@ac_ur", txtAcur.Text);
                cmd.Parameters.AddWithValue("@dhl", txtDhl.Text);
                cmd.Parameters.AddWithValue("@bhcg", txtBhcg.Text);
                cmd.Parameters.AddWithValue("@phos", txtPhos.Text);
                cmd.Parameters.AddWithValue("@data_cadastro", mskData.Text);

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                cmd.ExecuteNonQuery();

                string msg = cmd.Parameters["@mensagem"].Value.ToString();
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                LimparCampos();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar os dados " + ex.Message);
                Modelo.Estaticos.fechar();
            }
        }

        internal void Show(object v)
        {
            throw new NotImplementedException();
        }
    }
}
