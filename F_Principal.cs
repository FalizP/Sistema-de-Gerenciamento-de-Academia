using System;
using System.Linq;
using System.Windows.Forms;

namespace Academia
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void LogOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void LogOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lb_Acesso.Text = "0";
            Lb_Usuario.Text = "...";
            pb_ledLogado.Image = Properties.Resources.led_vermelho;
            Globais.isLogado = false;
            Globais.nivel = 0;
        }

        private void BancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.isLogado)
            {
                if (Globais.nivel == 3)
                {

                }
                else
                {
                    MessageBox.Show("Nível de acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }

        private void NovoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.isLogado)
            {
                if (Globais.nivel >= 2)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nível de acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }

        private void GestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.isLogado)
            {
                if (Globais.nivel >= 2)
                {
                    F_GestaoUsuarios f_GestaUsuarios = new F_GestaoUsuarios();
                    f_GestaUsuarios.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nível de acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }

        private void NovoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.isLogado)
            {

            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }

    }
}
