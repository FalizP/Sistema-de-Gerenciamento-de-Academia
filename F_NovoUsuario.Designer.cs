namespace Academia
{
    partial class F_NovoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Nome = new System.Windows.Forms.TextBox();
            this.Lb_Senha = new System.Windows.Forms.Label();
            this.Tb_Username = new System.Windows.Forms.TextBox();
            this.Lb_Username = new System.Windows.Forms.Label();
            this.Tb_Senha = new System.Windows.Forms.TextBox();
            this.Cb_Status = new System.Windows.Forms.ComboBox();
            this.N_Nivel = new System.Windows.Forms.NumericUpDown();
            this.Lb_Satus = new System.Windows.Forms.Label();
            this.Lb_Nivel = new System.Windows.Forms.Label();
            this.Lb_InfoStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.Cb_MostarSenha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.N_Nivel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // Tb_Nome
            // 
            this.Tb_Nome.Location = new System.Drawing.Point(25, 42);
            this.Tb_Nome.Name = "Tb_Nome";
            this.Tb_Nome.Size = new System.Drawing.Size(284, 20);
            this.Tb_Nome.TabIndex = 1;
            // 
            // Lb_Senha
            // 
            this.Lb_Senha.AutoSize = true;
            this.Lb_Senha.Location = new System.Drawing.Point(474, 26);
            this.Lb_Senha.Name = "Lb_Senha";
            this.Lb_Senha.Size = new System.Drawing.Size(38, 13);
            this.Lb_Senha.TabIndex = 0;
            this.Lb_Senha.Text = "Senha";
            // 
            // Tb_Username
            // 
            this.Tb_Username.Location = new System.Drawing.Point(331, 42);
            this.Tb_Username.Name = "Tb_Username";
            this.Tb_Username.Size = new System.Drawing.Size(124, 20);
            this.Tb_Username.TabIndex = 2;
            // 
            // Lb_Username
            // 
            this.Lb_Username.AutoSize = true;
            this.Lb_Username.Location = new System.Drawing.Point(328, 25);
            this.Lb_Username.Name = "Lb_Username";
            this.Lb_Username.Size = new System.Drawing.Size(55, 13);
            this.Lb_Username.TabIndex = 0;
            this.Lb_Username.Text = "Username";
            // 
            // Tb_Senha
            // 
            this.Tb_Senha.Location = new System.Drawing.Point(477, 42);
            this.Tb_Senha.Name = "Tb_Senha";
            this.Tb_Senha.Size = new System.Drawing.Size(124, 20);
            this.Tb_Senha.TabIndex = 3;
            // 
            // Cb_Status
            // 
            this.Cb_Status.FormattingEnabled = true;
            this.Cb_Status.Items.AddRange(new object[] {
            "Ativo",
            "Bloqueado",
            "Desligado"});
            this.Cb_Status.Location = new System.Drawing.Point(25, 90);
            this.Cb_Status.Name = "Cb_Status";
            this.Cb_Status.Size = new System.Drawing.Size(124, 21);
            this.Cb_Status.TabIndex = 4;
            // 
            // N_Nivel
            // 
            this.N_Nivel.Location = new System.Drawing.Point(171, 91);
            this.N_Nivel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.N_Nivel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N_Nivel.Name = "N_Nivel";
            this.N_Nivel.Size = new System.Drawing.Size(124, 20);
            this.N_Nivel.TabIndex = 5;
            this.N_Nivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lb_Satus
            // 
            this.Lb_Satus.AutoSize = true;
            this.Lb_Satus.Location = new System.Drawing.Point(22, 74);
            this.Lb_Satus.Name = "Lb_Satus";
            this.Lb_Satus.Size = new System.Drawing.Size(37, 13);
            this.Lb_Satus.TabIndex = 0;
            this.Lb_Satus.Text = "Status";
            // 
            // Lb_Nivel
            // 
            this.Lb_Nivel.AutoSize = true;
            this.Lb_Nivel.Location = new System.Drawing.Point(168, 74);
            this.Lb_Nivel.Name = "Lb_Nivel";
            this.Lb_Nivel.Size = new System.Drawing.Size(31, 13);
            this.Lb_Nivel.TabIndex = 0;
            this.Lb_Nivel.Text = "Nivel";
            // 
            // Lb_InfoStatus
            // 
            this.Lb_InfoStatus.AutoSize = true;
            this.Lb_InfoStatus.Location = new System.Drawing.Point(22, 129);
            this.Lb_InfoStatus.Name = "Lb_InfoStatus";
            this.Lb_InfoStatus.Size = new System.Drawing.Size(215, 13);
            this.Lb_InfoStatus.TabIndex = 4;
            this.Lb_InfoStatus.Text = "A = Ativo  |  B = Bloqueado  |  D = Desligado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Fechar);
            this.panel1.Controls.Add(this.Btn_Cancelar);
            this.panel1.Controls.Add(this.Btn_Novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 35);
            this.panel1.TabIndex = 5;
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Fechar.Location = new System.Drawing.Point(537, 3);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fechar.TabIndex = 8;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancelar.Location = new System.Drawing.Point(93, 3);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 7;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Novo.Location = new System.Drawing.Point(12, 3);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.Btn_Novo.TabIndex = 9;
            this.Btn_Novo.Text = "Novo";
            this.Btn_Novo.UseVisualStyleBackColor = true;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Cb_MostarSenha
            // 
            this.Cb_MostarSenha.AutoSize = true;
            this.Cb_MostarSenha.Checked = true;
            this.Cb_MostarSenha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_MostarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cb_MostarSenha.Location = new System.Drawing.Point(477, 74);
            this.Cb_MostarSenha.Name = "Cb_MostarSenha";
            this.Cb_MostarSenha.Size = new System.Drawing.Size(95, 17);
            this.Cb_MostarSenha.TabIndex = 6;
            this.Cb_MostarSenha.Text = "Mostrar Senha";
            this.Cb_MostarSenha.UseVisualStyleBackColor = true;
            this.Cb_MostarSenha.CheckedChanged += new System.EventHandler(this.Cb_MostarSenha_CheckedChanged);
            // 
            // F_NovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 247);
            this.Controls.Add(this.Cb_MostarSenha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lb_InfoStatus);
            this.Controls.Add(this.N_Nivel);
            this.Controls.Add(this.Cb_Status);
            this.Controls.Add(this.Tb_Senha);
            this.Controls.Add(this.Lb_Username);
            this.Controls.Add(this.Tb_Username);
            this.Controls.Add(this.Lb_Senha);
            this.Controls.Add(this.Tb_Nome);
            this.Controls.Add(this.Lb_Nivel);
            this.Controls.Add(this.Lb_Satus);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NovoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.N_Nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Nome;
        private System.Windows.Forms.Label Lb_Senha;
        private System.Windows.Forms.TextBox Tb_Username;
        private System.Windows.Forms.Label Lb_Username;
        private System.Windows.Forms.TextBox Tb_Senha;
        private System.Windows.Forms.ComboBox Cb_Status;
        private System.Windows.Forms.NumericUpDown N_Nivel;
        private System.Windows.Forms.Label Lb_Satus;
        private System.Windows.Forms.Label Lb_Nivel;
        private System.Windows.Forms.Label Lb_InfoStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.CheckBox Cb_MostarSenha;
    }
}