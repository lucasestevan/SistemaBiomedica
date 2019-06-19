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
    public partial class frm_Urinalise : Form
    {
        public frm_Urinalise()
        {
            InitializeComponent();
        }

        private void frm_Urinalise_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        //METODO DESABILITAR CAMPOS URINALISE
        private void DesabilitarCampos()
        {
            //txtNome.Enabled = false;
            //txtCola.Enabled = false;
            txtId.Enabled = false;
            mskData.Enabled = false;
            txtNdia.Enabled = false;
            txtaspc.Enabled = false;
            txtbac.Enabled = false;
            txtbil.Enabled = false;
            txtcels.Enabled = false;
            txtcet.Enabled = false;
            txtcil.Enabled = false;
            txtcor.Enabled = false;
            txtcrist.Enabled = false;
            txtdens.Enabled = false;
            txtfmuco.Enabled = false;
            txtgli.Enabled = false;
            txthb.Enabled = false;
            txthem.Enabled = false;
            txtleu.Enabled = false;
            txtnit.Enabled = false;
            txtoutros1.Enabled = false;
            txtoutros2.Enabled = false;
            txtph.Enabled = false;
            txtpt.Enabled = false;
            txttrinch.Enabled = false;
            txturo.Enabled = false;
            btnSalvar.Enabled = false;
            btnSelecionarColaUri.Enabled = false;
            btnSelecionarPacUri.Enabled = false;
            btnAlterarU.Enabled = false;
        }

        //BOTAO NOVO
        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampo();
            LimparCampos();
            btnNovo.Enabled = false;
        }

        //METODO LIMPAR CAMPOS URINALISE
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCola.Text = "";
            txtId.Text = "";
            mskData.Text = "";
            txtNdia.Text = "";
            txtaspc.Text = "";
            txtbac.Text = "";
            txtbil.Text = "";
            txtcels.Text = "";
            txtcet.Text = "";
            txtcil.Text = "";
            txtcor.Text = "";
            txtcrist.Text = "";
            txtdens.Text = "";
            txtfmuco.Text = "";
            txtgli.Text = "";
            txthb.Text = "";
            txthem.Text = "";
            txtleu.Text = "";
            txtnit.Text = "";
            txtoutros1.Text = "";
            txtoutros2.Text = "";
            txtph.Text = "";
            txtpt.Text = "";
            txttrinch.Text = "";
            txturo.Text = "";
            txtIdcola.Text = "";
            txtIdPac.Text = "";
        }

        //METODO HABIlITAR CAMPOS URINALISE
        public void HabilitarCampo()
        {
            txtId.Enabled = true;
            mskData.Enabled = true;
            txtNdia.Enabled = true;
            txtaspc.Enabled = true;
            txtbac.Enabled = true;
            txtbil.Enabled = true;
            txtcels.Enabled = true;
            txtcet.Enabled = true;
            txtcil.Enabled = true;
            txtcor.Enabled = true;
            txtcrist.Enabled = true;
            txtdens.Enabled = true;
            txtfmuco.Enabled = true;
            txtgli.Enabled = true;
            txthb.Enabled = true;
            txthem.Enabled = true;
            txtleu.Enabled = true;
            txtnit.Enabled = true;
            txtoutros1.Enabled = true;
            txtoutros2.Enabled = true;
            txtph.Enabled = true;
            txtpt.Enabled = true;
            txttrinch.Enabled = true;
            txturo.Enabled = true;
            btnSalvar.Enabled = true;
            btnSelecionarPacUri.Enabled = true;
            btnSelecionarColaUri.Enabled = true;
        }

        //BOTAO SELECIONAR PACIENTE
        private void btnSelecionarPacUri_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtIdPac.Text = "";
            frm_LocalizarPaciente frm_LocalizarPaciente = new frm_LocalizarPaciente();
            //DESABILITAR OS BOTOES PRIMEIRO E DEPOIS CHAMAR O FORM LOCALIZAR
            frm_LocalizarPaciente.btnSelecionarUrina.Visible = true;
            frm_LocalizarPaciente.btnSelecionarMicro.Visible = false;
            frm_LocalizarPaciente.btnSelecionarBioq.Visible = false;
            frm_LocalizarPaciente.btnSelecionarHema.Visible = false;
            frm_LocalizarPaciente.ShowDialog();

            //PEGA O QUE ESTÁ NA CLASSE ESTATICA E JOGA NO TXT NOME E ID
            txtNome.Text = Modelo.Estaticos.nomePaciente;
            txtIdPac.Text = Modelo.Estaticos.idPaciente;
        }

        //BOTAO SELECIONAR COLABORADOR
        private void btnSelecionarColaUri_Click(object sender, EventArgs e)
        {
            txtCola.Text = "";
            txtIdcola.Text = "";

            frm_CadColaborador frm_CadColaborador = new frm_CadColaborador();
            //'DESABLITAR OS BOTOES PRIMEIRO E DEPOIS CHAMAR O FORM ESTAGIARIO
            frm_CadColaborador.btnSelecionarBio.Visible = false;
            frm_CadColaborador.btnSelecionarMicro.Visible = false;
            frm_CadColaborador.btnSelecionarHema.Visible = false;
            frm_CadColaborador.btnSelecionarUri.Visible = true;
            frm_CadColaborador.ShowDialog();

            //PEGA O QUE ESTÁ NA CLASSE ESTATICA E JOGA NO TXT NOME E ID colaborador
            txtCola.Text = Modelo.Estaticos.nomeColarador;
            txtIdcola.Text = Modelo.Estaticos.idColaborador;
        }

        //BOTAO SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            //SE TODOS OS CAMPOS NAO ESTIVEREM VAZIO FAÇA
            if (txtNome.Text != "" &&
                txtCola.Text != "" &&
                mskData.Text != "" &&
                txtNdia.Text != "" &&
                txtaspc.Text != "" &&
                txtbac.Text != "" &&
                txtbil.Text != "" &&
                txtcels.Text != "" &&
                txtcet.Text != "" &&
                txtcil.Text != "" &&
                txtcor.Text != "" &&
                txtcrist.Text != "" &&
                txtdens.Text != "" &&
                txtfmuco.Text != "" &&
                txtgli.Text != "" &&
                txthb.Text != "" &&
                txthem.Text != "" &&
                txtleu.Text != "" &&
                txtnit.Text != "" &&
                txtoutros1.Text != "" &&
                txtoutros2.Text != "" &&
                txtph.Text != "" &&
                txtpt.Text != "" &&
                txttrinch.Text != "" &&
                txturo.Text != "")
            {
                try
                {
                    Modelo.Estaticos.abrir();
                    cmd = new SqlCommand("sp_salvarExameUri", Modelo.Estaticos.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_paciente", txtIdPac.Text);
                    cmd.Parameters.AddWithValue("@id_colaborador", txtIdcola.Text);
                    cmd.Parameters.AddWithValue("@numeroDia", txtNdia.Text);
                    cmd.Parameters.AddWithValue("@aspc", txtaspc.Text);
                    cmd.Parameters.AddWithValue("@bac", txtbac.Text);
                    cmd.Parameters.AddWithValue("@bil", txtbil.Text);
                    cmd.Parameters.AddWithValue("@cels", txtcels.Text);
                    cmd.Parameters.AddWithValue("@cet", txtcet.Text);
                    cmd.Parameters.AddWithValue("@cil", txtcil.Text);
                    cmd.Parameters.AddWithValue("@cor", txtcor.Text);
                    cmd.Parameters.AddWithValue("@crist", txtcrist.Text);
                    cmd.Parameters.AddWithValue("@dens", txtdens.Text);
                    cmd.Parameters.AddWithValue("@f_muco", txtfmuco.Text);
                    cmd.Parameters.AddWithValue("@gli", txtgli.Text);
                    cmd.Parameters.AddWithValue("@hb", txthb.Text);
                    cmd.Parameters.AddWithValue("@hem", txthem.Text);
                    cmd.Parameters.AddWithValue("@leuc", txtleu.Text);
                    cmd.Parameters.AddWithValue("@nit", txtnit.Text);
                    cmd.Parameters.AddWithValue("@outros1", txtoutros1.Text);
                    cmd.Parameters.AddWithValue("@outros2", txtoutros2.Text);
                    cmd.Parameters.AddWithValue("@ph", txtph.Text);
                    cmd.Parameters.AddWithValue("@pt", txtpt.Text);
                    cmd.Parameters.AddWithValue("@trinch", txttrinch.Text);
                    cmd.Parameters.AddWithValue("@uro", txturo.Text);
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
        private void btnAlterarU_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);
            try
            {
                Modelo.Estaticos.abrir();
                cmd = new SqlCommand("sp_editarExameUri", Modelo.Estaticos.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_exameUri", txtId.Text);
                cmd.Parameters.AddWithValue("@id_paciente", txtIdPac.Text);
                cmd.Parameters.AddWithValue("@id_colaborador", txtIdcola.Text);
                cmd.Parameters.AddWithValue("@numeroDia", txtNdia.Text);
                cmd.Parameters.AddWithValue("@aspc", txtaspc.Text);
                cmd.Parameters.AddWithValue("@bac", txtbac.Text);
                cmd.Parameters.AddWithValue("@bil", txtbil.Text);
                cmd.Parameters.AddWithValue("@cels", txtcels.Text);
                cmd.Parameters.AddWithValue("@cet", txtcet.Text);
                cmd.Parameters.AddWithValue("@cil", txtcil.Text);
                cmd.Parameters.AddWithValue("@cor", txtcor.Text);
                cmd.Parameters.AddWithValue("@crist", txtcrist.Text);
                cmd.Parameters.AddWithValue("@dens", txtdens.Text);
                cmd.Parameters.AddWithValue("@f_muco", txtfmuco.Text);
                cmd.Parameters.AddWithValue("@gli", txtgli.Text);
                cmd.Parameters.AddWithValue("@hb", txthb.Text);
                cmd.Parameters.AddWithValue("@hem", txthem.Text);
                cmd.Parameters.AddWithValue("@leuc", txtleu.Text);
                cmd.Parameters.AddWithValue("@nit", txtnit.Text);
                cmd.Parameters.AddWithValue("@outros1", txtoutros1.Text);
                cmd.Parameters.AddWithValue("@outros2", txtoutros2.Text);
                cmd.Parameters.AddWithValue("@ph", txtph.Text);
                cmd.Parameters.AddWithValue("@pt", txtpt.Text);
                cmd.Parameters.AddWithValue("@trinch", txttrinch.Text);
                cmd.Parameters.AddWithValue("@uro", txturo.Text);
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
