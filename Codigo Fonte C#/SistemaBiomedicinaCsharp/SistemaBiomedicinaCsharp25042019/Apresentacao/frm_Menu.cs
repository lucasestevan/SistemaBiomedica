using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiomedicinaCsharp25042019.Apresentacao
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void Botaologout_Click(object sender, EventArgs e)
        {
            //MOSTRAR MENSAGEM SE QUER SAIR AO CLIKAR NO LOGOUT
            DialogResult msg = MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //SE O ESCOLHER SIM
            if (msg == DialogResult.Yes)
            {
                frm_Login frm_Login = new frm_Login();
                this.Hide();
                frm_Login.ShowDialog();
                this.Visible = false;
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToShortDateString();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            //MOSTRAR USUARIO LOGADO
            lblUsuarioo.Text = Modelo.Estaticos.usuarioNome;
        }

        private void tsmPaciente_Click(object sender, EventArgs e)
        {
            frm_CadPacientes frm_CadPacientes = new frm_CadPacientes();
            frm_CadPacientes.ShowDialog();
        }

        private void tsmColaborador_Click(object sender, EventArgs e)
        {
            frm_CadColaborador frm_CadColaborador = new frm_CadColaborador();
            frm_CadColaborador.ShowDialog();
        }

        private void tsmLocalizar_Click(object sender, EventArgs e)
        {
            frm_LocalizarPaciente frm_LocalizarPaciente = new frm_LocalizarPaciente();
            frm_LocalizarPaciente.ShowDialog();
        }

        private void tsmConsultaExame_Click(object sender, EventArgs e)
        {
            frm_ConsultaExame frm_ConsultaExame = new frm_ConsultaExame();
            frm_ConsultaExame.ShowDialog();
        }

        private void tsmHema_Click(object sender, EventArgs e)
        {
            frm_Hematologia frm_Hematologia = new frm_Hematologia();
            frm_Hematologia.ShowDialog();
        }

        private void tsmUri_Click(object sender, EventArgs e)
        {
            frm_Urinalise frm_Urinalise = new frm_Urinalise();
            frm_Urinalise.ShowDialog();
        }

        private void tsmMicro_Click(object sender, EventArgs e)
        {
            frm_Microbiologia frm_Microbiologia = new frm_Microbiologia();
            frm_Microbiologia.ShowDialog();
        }

        private void tsmBio_Click(object sender, EventArgs e)
        {
            frm_Bioquimica frm_Bioquimica = new frm_Bioquimica();
            frm_Bioquimica.ShowDialog();
        }
    }
}
