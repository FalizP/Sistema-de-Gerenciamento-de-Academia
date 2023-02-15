using System;
using System.Windows.Forms;

namespace Academia
{
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nome = Tb_Nome.Text;
            usuario.username = Tb_Username.Text;
            usuario.senha = Tb_Senha.Text;
            usuario.status = Cb_Status.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(N_Nivel.Value, 0));

            Banco.NovoUsuario(usuario);
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Tb_Nome.Clear();
            Tb_Username.Clear();
            Tb_Senha.Clear();
            Cb_Status.Text = "";
            N_Nivel.Value = 1;
            Btn_Novo.Focus();
        }

        private void Cb_MostarSenha_CheckedChanged(object sender, EventArgs e)
        {
            Tb_Senha.UseSystemPasswordChar = !Cb_MostarSenha.Checked;
        }
    }
}
