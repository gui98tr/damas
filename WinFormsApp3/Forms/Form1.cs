using MySqlX.XDevAPI.Common;
using WinFormsApp3.Forms;

namespace WinFormsApp3
{
    public partial class SingInForm1 : Form
    {
        public SingInForm1()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            LoginForm loginf = new LoginForm();
            loginf.ShowDialog();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            /*UsuarioRepositorio repo = new UsuarioRepositorio(BdUtil.ConnectionString);
            string nome = txtnome.Text;
            string senha = txtsenha.Text;
            Usuario usuario1 = new Usuario();
            usuario1.nome = nome;
           usuario1.senha = senha;
            Usuario usuario2 = new Usuario();
           usuario2 = repo.ObterUsuario(nome, senha);*/
            try
            {
                //if(usuario2 != null)
                //{
                    DamasForms damas = new DamasForms();
                    damas.ShowDialog();
                    this.Close();
                //}

                //else
                  //  labelerro.ForeColor = Color.Red;
            }
            catch (Exception ex) 
            {
                labelerro.ForeColor = Color.Red;
            }
        }
    }
}
