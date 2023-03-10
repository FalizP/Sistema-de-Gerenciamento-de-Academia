namespace Academia
{
    partial class F_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_Hora = new System.Windows.Forms.Label();
            this.Lb_infoUsuario = new System.Windows.Forms.Label();
            this.Lb_Usuario = new System.Windows.Forms.Label();
            this.Lb_Acesso = new System.Windows.Forms.Label();
            this.Lb_infoAcesso = new System.Windows.Forms.Label();
            this.pb_ledLogado = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NovoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.Lb_Hora);
            this.panel1.Controls.Add(this.Lb_infoUsuario);
            this.panel1.Controls.Add(this.Lb_Usuario);
            this.panel1.Controls.Add(this.Lb_Acesso);
            this.panel1.Controls.Add(this.Lb_infoAcesso);
            this.panel1.Controls.Add(this.pb_ledLogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 35);
            this.panel1.TabIndex = 0;
            // 
            // Lb_Hora
            // 
            this.Lb_Hora.AutoSize = true;
            this.Lb_Hora.Location = new System.Drawing.Point(424, 10);
            this.Lb_Hora.Name = "Lb_Hora";
            this.Lb_Hora.Size = new System.Drawing.Size(43, 13);
            this.Lb_Hora.TabIndex = 5;
            this.Lb_Hora.Text = "Hora:  ||";
            // 
            // Lb_infoUsuario
            // 
            this.Lb_infoUsuario.AutoSize = true;
            this.Lb_infoUsuario.Location = new System.Drawing.Point(134, 10);
            this.Lb_infoUsuario.Name = "Lb_infoUsuario";
            this.Lb_infoUsuario.Size = new System.Drawing.Size(46, 13);
            this.Lb_infoUsuario.TabIndex = 4;
            this.Lb_infoUsuario.Text = "Usuário:";
            // 
            // Lb_Usuario
            // 
            this.Lb_Usuario.AutoSize = true;
            this.Lb_Usuario.Location = new System.Drawing.Point(186, 10);
            this.Lb_Usuario.Name = "Lb_Usuario";
            this.Lb_Usuario.Size = new System.Drawing.Size(16, 13);
            this.Lb_Usuario.TabIndex = 3;
            this.Lb_Usuario.Text = "...";
            // 
            // Lb_Acesso
            // 
            this.Lb_Acesso.AutoSize = true;
            this.Lb_Acesso.Location = new System.Drawing.Point(91, 10);
            this.Lb_Acesso.Name = "Lb_Acesso";
            this.Lb_Acesso.Size = new System.Drawing.Size(13, 13);
            this.Lb_Acesso.TabIndex = 2;
            this.Lb_Acesso.Text = "0";
            // 
            // Lb_infoAcesso
            // 
            this.Lb_infoAcesso.AutoSize = true;
            this.Lb_infoAcesso.Location = new System.Drawing.Point(40, 10);
            this.Lb_infoAcesso.Name = "Lb_infoAcesso";
            this.Lb_infoAcesso.Size = new System.Drawing.Size(45, 13);
            this.Lb_infoAcesso.TabIndex = 1;
            this.Lb_infoAcesso.Text = "Acesso:";
            // 
            // pb_ledLogado
            // 
            this.pb_ledLogado.Image = global::Academia.Properties.Resources.led_vermelho;
            this.pb_ledLogado.Location = new System.Drawing.Point(2, 3);
            this.pb_ledLogado.Name = "pb_ledLogado";
            this.pb_ledLogado.Size = new System.Drawing.Size(30, 30);
            this.pb_ledLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ledLogado.TabIndex = 0;
            this.pb_ledLogado.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.lOGINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAlunoToolStripMenuItem,
            this.gestãoDeAlunosToolStripMenuItem});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // novoAlunoToolStripMenuItem
            // 
            this.novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            this.novoAlunoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.novoAlunoToolStripMenuItem.Text = "Novo Aluno";
            this.novoAlunoToolStripMenuItem.Click += new System.EventHandler(this.NovoAlunoToolStripMenuItem_Click);
            // 
            // gestãoDeAlunosToolStripMenuItem
            // 
            this.gestãoDeAlunosToolStripMenuItem.Name = "gestãoDeAlunosToolStripMenuItem";
            this.gestãoDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gestãoDeAlunosToolStripMenuItem.Text = "Gestão de Alunos";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovoUsuarioToolStripMenuItem,
            this.gestãoDeUsuáriosToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // NovoUsuarioToolStripMenuItem
            // 
            this.NovoUsuarioToolStripMenuItem.Name = "NovoUsuarioToolStripMenuItem";
            this.NovoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.NovoUsuarioToolStripMenuItem.Text = "Novo Usuário";
            this.NovoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.NovoUsuarioToolStripMenuItem_Click);
            // 
            // gestãoDeUsuáriosToolStripMenuItem
            // 
            this.gestãoDeUsuáriosToolStripMenuItem.Name = "gestãoDeUsuáriosToolStripMenuItem";
            this.gestãoDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gestãoDeUsuáriosToolStripMenuItem.Text = "Gestão de Usuários";
            this.gestãoDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.GestãoDeUsuáriosToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.BancoDeDadosToolStripMenuItem_Click);
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOnToolStripMenuItem,
            this.logOffToolStripMenuItem});
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // logOnToolStripMenuItem
            // 
            this.logOnToolStripMenuItem.Name = "logOnToolStripMenuItem";
            this.logOnToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.logOnToolStripMenuItem.Text = "LogOn";
            this.logOnToolStripMenuItem.Click += new System.EventHandler(this.LogOnToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.logOffToolStripMenuItem.Text = "LogOff";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.LogOffToolStripMenuItem_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lb_infoAcesso;
        public System.Windows.Forms.PictureBox pb_ledLogado;
        private System.Windows.Forms.Label Lb_infoUsuario;
        public System.Windows.Forms.Label Lb_Acesso;
        public System.Windows.Forms.Label Lb_Usuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NovoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        public System.Windows.Forms.Label Lb_Hora;
    }
}

