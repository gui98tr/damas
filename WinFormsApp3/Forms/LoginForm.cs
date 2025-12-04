using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp3.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string nome = nometxt.Text;
            string email = emailtxt.Text;
            string senha = senhatxt.Text;
            if(nome.Length != null || senha.Length != null)
            {
                if (senha.Length < 6)
                {
                    lblMensagem.ForeColor = Color.Red;
                    lblMensagem.Text = "A senha deve ter pelo menos 6 caracteres.";
                    return;
                }

                if (nome.Length < 3)
                {
                    lblMensagem.ForeColor = Color.Red;
                    lblMenssage2.Text = "O nome de usuário deve ter pelo menos 3 caracteres.";
                    return;
                }
                Usuario usuario = new Usuario();
                usuario.nome = nome;
                usuario.email = email;
                usuario.senha = senha;
                UsuarioRepositorio repo = new UsuarioRepositorio(BdUtil.ConnectionString);
                repo.InserirUsuario(usuario);
                this.Close();
            }
            else
            {
                lblMensagem.ForeColor = Color.Red;
                lblMenssage2.Text = "Insira o nome de usuario e senha";
                Thread.Sleep(1200);
                lblMensagem.ForeColor = lblMensagem.BackColor;
                return;
            }
        }
    }
}
