using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nome = Tb_Nome.Text;
            usuario.username = Tb_Username.Text;
            usuario.senha = Tb_Senha.Text;
            usuario.status = Cb_Status.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(N_Nivel.Value, 0));
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
