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
    public partial class frm_Hematologia : Form
    {
        public frm_Hematologia()
        {
            InitializeComponent();
        }

        private void frm_Hematologia_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        //METODO DESABILITAR CAMPOS
        private void DesabilitarCampos()
        {
            txtId.Enabled = false;
            //txtNome.Enabled = false;
            //txtCola.Enabled = false;
            txtNdia.Enabled = false;
            txterit.Enabled = false;
            txthb.Enabled = false;
            txtht.Enabled = false;
            txtvmc.Enabled = false;
            txthcm.Enabled = false;
            txtchcm.Enabled = false;
            txtplaq.Enabled = false;
            txtret.Enabled = false;
            txtleuc.Enabled = false;
            txtmie.Enabled = false;
            txtmet.Enabled = false;
            txtbas.Enabled = false;
            txtseg.Enabled = false;
            txteos.Enabled = false;
            txtbaf.Enabled = false;
            txtlintip.Enabled = false;
            txtlinat.Enabled = false;
            txtmono.Enabled = false;
            txtoutras.Enabled = false;
            txtobs.Enabled = false;
            txtabo.Enabled = false;
            txtrh.Enabled = false;
            txtvhs.Enabled = false;
            txtfalci.Enabled = false;
            mskData.Enabled = false;
            btnSelecionarColaHema.Enabled = false;
            btnAlterarH.Enabled = false;
            btnSelecionarPacHema.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
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
            txtId.Text = "";
            txtIdcola.Text = "";
            txtIdPac.Text = "";
            txtNome.Text = "";
            txtNdia.Text = "";
            mskData.Text = "";
            txterit.Text = "";
            txthb.Text = "";
            txtht.Text = "";
            txtvmc.Text = "";
            txthcm.Text = "";
            txtchcm.Text = "";
            txtplaq.Text = "";
            txtret.Text = "";
            txtleuc.Text = "";
            txtmie.Text = "";
            txtmet.Text = "";
            txtbas.Text = "";
            txtseg.Text = "";
            txteos.Text = "";
            txtbaf.Text = "";
            txtlintip.Text = "";
            txtlinat.Text = "";
            txtmono.Text = "";
            txtoutras.Text = "";
            txtobs.Text = "";
            txtabo.Text = "";
            txtrh.Text = "";
            txtvhs.Text = "";
            txtfalci.Text = "";
            txtCola.Text = "";
            txtIdcola.Text = "";
            txtIdPac.Text = "";
        }

        //METODO HABILITAR CAMPOS
        public void HabilitarCampo()
        {
            txtNome.Enabled = true;
            txtCola.Enabled = true;
            txtNdia.Enabled = true;
            txterit.Enabled = true;
            txthb.Enabled = true;
            txtht.Enabled = true;
            txtvmc.Enabled = true;
            txthcm.Enabled = true;
            txtchcm.Enabled = true;
            txtplaq.Enabled = true;
            txtret.Enabled = true;
            txtleuc.Enabled = true;
            txtmie.Enabled = true;
            txtmet.Enabled = true;
            txtbas.Enabled = true;
            txtseg.Enabled = true;
            txteos.Enabled = true;
            txtbaf.Enabled = true;
            txtlintip.Enabled = true;
            txtlinat.Enabled = true;
            txtmono.Enabled = true;
            txtoutras.Enabled = true;
            txtobs.Enabled = true;
            txtabo.Enabled = true;
            txtrh.Enabled = true;
            txtvhs.Enabled = true;
            txtfalci.Enabled = true;
            mskData.Enabled = true;
            btnAlterarH.Enabled = false;
            btnSelecionarColaHema.Enabled = true;
            btnSelecionarPacHema.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = true;
        }

        //BOTAO SELECIONAR COLABORADOR
        private void btnSelecionarColaHema_Click(object sender, EventArgs e)
        {
            txtCola.Text = "";
            txtIdcola.Text = "";

            frm_CadColaborador frm_CadColaborador = new frm_CadColaborador();
            //DESABILITAR OS BOTOES PRIMEIRO E DPS CHAMAR O FORM ESTAGIARIO
            frm_CadColaborador.btnSelecionarBio.Visible = false;
            frm_CadColaborador.btnSelecionarMicro.Visible = false;
            frm_CadColaborador.btnSelecionarUri.Visible = false;
            frm_CadColaborador.btnSelecionarHema.Visible = true;
            frm_CadColaborador.ShowDialog();

            //PEGA O QUE ESTÁ NA CLASSE ESTATICA E JOGA NO TXT NOME E ID colaborador
            txtCola.Text = Modelo.Estaticos.nomeColarador;
            txtIdcola.Text = Modelo.Estaticos.idColaborador;
        }

        //BOTAO SELECIONAR PACIENTE
        private void btnSelecionarPacHema_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtIdPac.Text = "";
            frm_LocalizarPaciente frm_LocalizarPaciente = new frm_LocalizarPaciente();
            //DESABILITAR OS BOTOES PRIMEIRO E DPS CHAMAR O FORM LOCALIZAR
            frm_LocalizarPaciente.btnSelecionarUrina.Visible = false;
            frm_LocalizarPaciente.btnSelecionarMicro.Visible = false;
            frm_LocalizarPaciente.btnSelecionarBioq.Visible = false;
            frm_LocalizarPaciente.btnSelecionarHema.Visible = true;
            frm_LocalizarPaciente.ShowDialog();

            //PEGA O QUE ESTÁ NA CLASSE ESTATICA E JOGA NO TXT NOME E ID
            txtNome.Text = Modelo.Estaticos.nomePaciente;
            txtIdPac.Text = Modelo.Estaticos.idPaciente;
        }

        //BOTAO SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            //SE TODOS OS CAMPOS NAO ESTIVEREM VAZIO FAÇA
            if (txtNome.Text != "" &&
                    txtNdia.Text != "" &&
                    mskData.Text != "" &&
                    txterit.Text != "" &&
                    txthb.Text != "" &&
                    txtht.Text != "" &&
                    txtvmc.Text != "" &&
                    txthcm.Text != "" &&
                    txtchcm.Text != "" &&
                    txtplaq.Text != "" &&
                    txtret.Text != "" &&
                    txtleuc.Text != "" &&
                    txtmie.Text != "" &&
                    txtmet.Text != "" &&
                    txtbas.Text != "" &&
                    txtseg.Text != "" &&
                    txteos.Text != "" &&
                    txtbaf.Text != "" &&
                    txtlintip.Text != "" &&
                    txtlinat.Text != "" &&
                    txtmono.Text != "" &&
                    txtoutras.Text != "" &&
                    txtobs.Text != "" &&
                    txtabo.Text != "" &&
                    txtrh.Text != "" &&
                    txtvhs.Text != "" &&
                    txtfalci.Text != "")
            {
                try
                {
                    Modelo.Estaticos.abrir();
                    cmd = new SqlCommand("sp_salvarExameHema", Modelo.Estaticos.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_paciente", txtIdPac.Text);
                    cmd.Parameters.AddWithValue("@id_colaborador", txtIdcola.Text);
                    cmd.Parameters.AddWithValue("@numeroDia", txtNdia.Text);
                    cmd.Parameters.AddWithValue("@erit", txterit.Text);
                    cmd.Parameters.AddWithValue("@hb", txthb.Text);
                    cmd.Parameters.AddWithValue("@ht", txtht.Text);
                    cmd.Parameters.AddWithValue("@vmc", txtvmc.Text);
                    cmd.Parameters.AddWithValue("@hcm", txthcm.Text);
                    cmd.Parameters.AddWithValue("@chcm", txtchcm.Text);
                    cmd.Parameters.AddWithValue("@plaq", txtplaq.Text);
                    cmd.Parameters.AddWithValue("@ret", txtret.Text);
                    cmd.Parameters.AddWithValue("@leuc", txtleuc.Text);
                    cmd.Parameters.AddWithValue("@mie", txtmie.Text);
                    cmd.Parameters.AddWithValue("@met", txtmet.Text);
                    cmd.Parameters.AddWithValue("@bas", txtbas.Text);
                    cmd.Parameters.AddWithValue("@seg", txtseg.Text);
                    cmd.Parameters.AddWithValue("@eos", txteos.Text);
                    cmd.Parameters.AddWithValue("@baf", txtbaf.Text);
                    cmd.Parameters.AddWithValue("@lin_tip", txtlintip.Text);
                    cmd.Parameters.AddWithValue("@lint_at", txtlinat.Text);
                    cmd.Parameters.AddWithValue("@mono", txtmono.Text);
                    cmd.Parameters.AddWithValue("@outras", txtoutras.Text);
                    cmd.Parameters.AddWithValue("@obs", txtobs.Text);
                    cmd.Parameters.AddWithValue("@abo", txtabo.Text);
                    cmd.Parameters.AddWithValue("@rh", txtrh.Text);
                    cmd.Parameters.AddWithValue("@vhs", txtvhs.Text);
                    cmd.Parameters.AddWithValue("@falci", txtfalci.Text);
                    cmd.Parameters.AddWithValue("@data_cadastro", mskData.Text);

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
        private void btnAlterarH_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            try
            {
                Modelo.Estaticos.abrir();
                cmd = new SqlCommand("sp_editarExameHema", Modelo.Estaticos.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_exameHema", txtId.Text);
                cmd.Parameters.AddWithValue("@id_paciente", txtIdPac.Text);
                cmd.Parameters.AddWithValue("@id_colaborador", txtIdcola.Text);
                cmd.Parameters.AddWithValue("@numeroDia", txtNdia.Text);
                cmd.Parameters.AddWithValue("@erit", txterit.Text);
                cmd.Parameters.AddWithValue("@hb", txthb.Text);
                cmd.Parameters.AddWithValue("@ht", txtht.Text);
                cmd.Parameters.AddWithValue("@vmc", txtvmc.Text);
                cmd.Parameters.AddWithValue("@hcm", txthcm.Text);
                cmd.Parameters.AddWithValue("@chcm", txtchcm.Text);
                cmd.Parameters.AddWithValue("@plaq", txtplaq.Text);
                cmd.Parameters.AddWithValue("@ret", txtret.Text);
                cmd.Parameters.AddWithValue("@leuc", txtleuc.Text);
                cmd.Parameters.AddWithValue("@mie", txtmie.Text);
                cmd.Parameters.AddWithValue("@met", txtmet.Text);
                cmd.Parameters.AddWithValue("@bas", txtbas.Text);
                cmd.Parameters.AddWithValue("@seg", txtseg.Text);
                cmd.Parameters.AddWithValue("@eos", txteos.Text);
                cmd.Parameters.AddWithValue("@baf", txtbaf.Text);
                cmd.Parameters.AddWithValue("@lin_tip", txtlintip.Text);
                cmd.Parameters.AddWithValue("@lint_at", txtlinat.Text);
                cmd.Parameters.AddWithValue("@mono", txtmono.Text);
                cmd.Parameters.AddWithValue("@outras", txtoutras.Text);
                cmd.Parameters.AddWithValue("@obs", txtobs.Text);
                cmd.Parameters.AddWithValue("@abo", txtabo.Text);
                cmd.Parameters.AddWithValue("@rh", txtrh.Text);
                cmd.Parameters.AddWithValue("@vhs", txtvhs.Text);
                cmd.Parameters.AddWithValue("@falci", txtfalci.Text);
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
                MessageBox.Show("Erro ao alterar os dados " + ex.Message);
                Modelo.Estaticos.fechar();
            }
        }
    }
}
