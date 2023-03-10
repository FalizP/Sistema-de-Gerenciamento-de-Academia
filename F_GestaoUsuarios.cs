using System;
using System.Data;
using System.Windows.Forms;

namespace Academia
{
    public partial class F_GestaoUsuarios : Form
    {
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void Lb_Nivel_Click(object sender, EventArgs e)
        {
            N_Nivel.Focus();
        }

        private void Lb_Status_Click(object sender, EventArgs e)
        {
            Cb_Status.Focus();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AtualizarF_GestaoUsuarios()
        {
            Dgv_Usuarios.DataSource = Banco.ObterUsuarioIdNome();
        }
        private void F_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            AtualizarF_GestaoUsuarios();
            Dgv_Usuarios.Columns[0].Width = 50;
            Dgv_Usuarios.Columns[1].Width = 160;
        }

        private void Dgv_Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int quantidadeLinhas = dataGridView.SelectedRows.Count;
            if (dataGridView.SelectedRows.Count > 0)
            {
                string id = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                DataTable dataTable = Banco.ObterDadosUsuario(id);

                Tb_Id.Text = dataTable.Rows[0].Field<Int64>($"{Globais.Db_IdUsuario}").ToString();
                Tb_Nome.Text = dataTable.Rows[0].Field<string>($"{Globais.Db_NomeUsuario}");
                Tb_Username.Text = dataTable.Rows[0].Field<string>($"{Globais.Db_Username}");
                Tb_Senha.Text = dataTable.Rows[0].Field<string>($"{Globais.Db_SenhaUsuario}");
                Cb_Status.Text = dataTable.Rows[0].Field<string>($"{Globais.Db_StatusUsuario}");
                N_Nivel.Text = dataTable.Rows[0].Field<Int64>($"{Globais.Db_NivelUsuario}").ToString();
            }
        }

        private void Cb_MostarSenha_CheckedChanged(object sender, EventArgs e)
        {
            Tb_Senha.UseSystemPasswordChar = Tb_Senha.UseSystemPasswordChar == false;
        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            f_NovoUsuario.ShowDialog();
            AtualizarF_GestaoUsuarios();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = Dgv_Usuarios.SelectedRows[0].Index;

            Usuario usuario = new Usuario(
                id: Tb_Id.Text,
                nome: Tb_Nome.Text,
                username: Tb_Username.Text,
                senha: Tb_Senha.Text,
                status: Cb_Status.Text,
                nivel: Convert.ToInt32(N_Nivel.Value)
            );
            Banco.AtualizarUsuario(usuario);

            Dgv_Usuarios[1, linhaSelecionada].Value = Tb_Nome.Text;
            Dgv_Usuarios.CurrentCell = Dgv_Usuarios[0, linhaSelecionada];
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Confirma e exclusão do usuário \"{Tb_Nome.Text}\"?", "Excluir?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Banco.DeletarUsuario(Tb_Id.Text);
                Dgv_Usuarios.Rows.Remove(Dgv_Usuarios.CurrentRow);
            }
        }
    }
}
