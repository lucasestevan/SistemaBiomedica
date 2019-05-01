using SistemaBiomedicinaCsharp25042019.Apresentacao;
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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {

            // CRIAR VARIAVEL
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            

            //VERIFICAR SE OS CAMPOS ESTAO VAZIOS
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha os campos vazios!!");

                //SE NAO ESTIVER VAZIO FAZER CONEXAO COM O BD
            }
            else
            {
                SqlCommand cmd = new SqlCommand("login", Conexao.Conexao.con);
                try
                {
                    Conexao.Conexao.abrir();
                    cmd.CommandType = (System.Data.CommandType)4; //SE FOR IGUAL A 4 ELE CONSEGUIU ENCONTRAR A INFORMACAO
                    cmd.Parameters.AddWithValue("@nome", usuario);
                    cmd.Parameters.AddWithValue("@cpf", senha);
                    cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;

                    //EXECUTAR NOSSA CONSULTA
                    cmd.ExecuteNonQuery();

                    Conexao.Conexao.usuarioNome = txtUsuario.Text;

                    string msg = System.Convert.ToString(cmd.Parameters["@msg"].Value);
                    MessageBox.Show(msg);

                    //VERIFICAR QUAL MENSAGEM RETORNOU
                    if (msg == "Dados Incorretos")
                    {
                        this.txtUsuario.Clear();
                        this.txtSenha.Clear();
                        this.txtUsuario.Focus();
                    }
                    else
                    {
                        frm_Menu frmMenu = new frm_Menu();
                        this.Hide();
                        frmMenu.ShowDialog();
                        this.Close();
                        
                        this.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao fazer login", "Erro" + ex.Message);
                    Conexao.Conexao.fechar();
                }
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
