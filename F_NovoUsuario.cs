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
            Usuario usuario = new Usuario(
                nome: Tb_Nome.Text,
                username: Tb_Username.Text,
                senha: Tb_Senha.Text,
                status: Cb_Status.Text,
                nivel: Convert.ToInt32(N_Nivel.Value)
            );
            Banco.NovoUsuario(usuario);
            LimparCampos();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
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

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
