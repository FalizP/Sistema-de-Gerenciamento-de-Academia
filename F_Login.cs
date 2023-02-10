using System;
using System.Data;
using System.Windows.Forms;

namespace Academia
{
    public partial class F_Login : Form
    {
        readonly Form1 form1;
        DataTable dataTable = new DataTable();
        public F_Login(Form1 f)
        {
            InitializeComponent();
            this.form1 = f;
            Tb_username.Text = "ad";
            Tb_senha.Text = "ad1";

        }

        private void Btn_logar_Click(object sender, EventArgs e)
        {
            string username = Tb_username.Text;
            string senha = Tb_senha.Text;

            if (username == "" && senha == "")
            {
                MessageBox.Show("Os campos Username e Senha não podem estar vazios!");
                Tb_username.Focus();
                return;
            }
            else if (username == "")
            {
                MessageBox.Show("O campo Username não pode estar vazio!");
                Tb_username.Focus();
                return;
            }
            else if (senha == "")
            {
                MessageBox.Show("O campo Senha não pode estar vazio!");
                Tb_username.Focus();
                return;
            }
            else if (username == senha)
            {
                Tb_username.Text = Tb_senha.Text = "";
                MessageBox.Show("O nome de usuário deve ser diferente da senha!");
                Tb_username.Focus();
                return;
            }

            string sql = $"SELECT * FROM tb_usuarios WHERE T_USERNAME = '{username}' AND T_SENHA = '{senha}'";
            dataTable = Banco.Consulta(sql);

            if (dataTable.Rows.Count == 1)
            {
                form1.Lb_acesso.Text = dataTable.Rows[0].Field<Int64>("N_NIVEL").ToString();
                form1.Lb_nomeUsuario.Text = dataTable.Rows[0].Field<string>("T_NOME");
                form1.pb_ledLogado.Image = Properties.Resources.led_verde;
                Globais.isLogado = true;
                Globais.nivel = int.Parse(dataTable.Rows[0].Field<Int64>("N_NIVEL").ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }

        }

        private void Btn_logar_MouseHover(object sender, EventArgs e)
        {
            Btn_logar.Cursor = Cursors.No;
            if ((Tb_username.Text == "" && Tb_senha.Text == ""))
            {
                toolTip1.Show("Preencha todos os campos!", Btn_logar);
            }
            else if (Tb_username.Text == "")
            {
                toolTip1.Show("O campo Username não pode estar vazio!", Tb_username);
            }
            else if (Tb_senha.Text == "")
            {
                toolTip1.Show("O campo Senha não pode estar vazio!", Tb_senha);
            }
            else if (Tb_username.Text == Tb_senha.Text)
            {
                toolTip1.Show("O nome de usuário deve ser diferente da senha!", Btn_logar);
            }
            else
            {
                Btn_logar.Cursor = Cursors.Hand;
            }
        }

        private void Btn_logar_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.RemoveAll();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lb_username_Click(object sender, EventArgs e)
        {
            Tb_username.Focus();
        }

        private void Lb_senha_Click(object sender, EventArgs e)
        {
            Tb_senha.Focus();
        }

        private void MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            Tb_senha.UseSystemPasswordChar = Tb_senha.UseSystemPasswordChar == false;
        }

    }
}
