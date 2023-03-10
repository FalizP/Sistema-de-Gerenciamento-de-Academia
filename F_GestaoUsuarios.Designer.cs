namespace Academia
{
    partial class F_GestaoUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cb_MostarSenha = new System.Windows.Forms.CheckBox();
            this.Lb_InfoStatus = new System.Windows.Forms.Label();
            this.N_Nivel = new System.Windows.Forms.NumericUpDown();
            this.Cb_Status = new System.Windows.Forms.ComboBox();
            this.Tb_Senha = new System.Windows.Forms.TextBox();
            this.Lb_Username = new System.Windows.Forms.Label();
            this.Tb_Username = new System.Windows.Forms.TextBox();
            this.Lb_Senha = new System.Windows.Forms.Label();
            this.Tb_Nome = new System.Windows.Forms.TextBox();
            this.Lb_Nivel = new System.Windows.Forms.Label();
            this.Lb_Status = new System.Windows.Forms.Label();
            this.Lb_Nome = new System.Windows.Forms.Label();
            this.Lb_Id = new System.Windows.Forms.Label();
            this.Tb_Id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.Dgv_Usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.N_Nivel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Cb_MostarSenha
            // 
            this.Cb_MostarSenha.AutoSize = true;
            this.Cb_MostarSenha.Checked = true;
            this.Cb_MostarSenha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_MostarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cb_MostarSenha.Location = new System.Drawing.Point(305, 122);
            this.Cb_MostarSenha.Name = "Cb_MostarSenha";
            this.Cb_MostarSenha.Size = new System.Drawing.Size(15, 14);
            this.Cb_MostarSenha.TabIndex = 18;
            this.Cb_MostarSenha.UseVisualStyleBackColor = true;
            this.Cb_MostarSenha.CheckedChanged += new System.EventHandler(this.Cb_MostarSenha_CheckedChanged);
            // 
            // Lb_InfoStatus
            // 
            this.Lb_InfoStatus.AutoSize = true;
            this.Lb_InfoStatus.Location = new System.Drawing.Point(11, 184);
            this.Lb_InfoStatus.Name = "Lb_InfoStatus";
            this.Lb_InfoStatus.Size = new System.Drawing.Size(215, 13);
            this.Lb_InfoStatus.TabIndex = 15;
            this.Lb_InfoStatus.Text = "A = Ativo  |  B = Bloqueado  |  D = Desligado";
            // 
            // N_Nivel
            // 
            this.N_Nivel.Location = new System.Drawing.Point(164, 158);
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
            this.N_Nivel.Size = new System.Drawing.Size(135, 20);
            this.N_Nivel.TabIndex = 17;
            this.N_Nivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cb_Status
            // 
            this.Cb_Status.FormattingEnabled = true;
            this.Cb_Status.Items.AddRange(new object[] {
            "Ativo",
            "Bloqueado",
            "Desligado"});
            this.Cb_Status.Location = new System.Drawing.Point(14, 158);
            this.Cb_Status.Name = "Cb_Status";
            this.Cb_Status.Size = new System.Drawing.Size(135, 21);
            this.Cb_Status.TabIndex = 16;
            // 
            // Tb_Senha
            // 
            this.Tb_Senha.Location = new System.Drawing.Point(164, 119);
            this.Tb_Senha.Name = "Tb_Senha";
            this.Tb_Senha.Size = new System.Drawing.Size(135, 20);
            this.Tb_Senha.TabIndex = 14;
            // 
            // Lb_Username
            // 
            this.Lb_Username.AutoSize = true;
            this.Lb_Username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_Username.Location = new System.Drawing.Point(11, 102);
            this.Lb_Username.Name = "Lb_Username";
            this.Lb_Username.Size = new System.Drawing.Size(55, 13);
            this.Lb_Username.TabIndex = 7;
            this.Lb_Username.Text = "Username";
            // 
            // Tb_Username
            // 
            this.Tb_Username.Location = new System.Drawing.Point(14, 119);
            this.Tb_Username.Name = "Tb_Username";
            this.Tb_Username.Size = new System.Drawing.Size(135, 20);
            this.Tb_Username.TabIndex = 13;
            // 
            // Lb_Senha
            // 
            this.Lb_Senha.AutoSize = true;
            this.Lb_Senha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_Senha.Location = new System.Drawing.Point(161, 103);
            this.Lb_Senha.Name = "Lb_Senha";
            this.Lb_Senha.Size = new System.Drawing.Size(38, 13);
            this.Lb_Senha.TabIndex = 8;
            this.Lb_Senha.Text = "Senha";
            // 
            // Tb_Nome
            // 
            this.Tb_Nome.Location = new System.Drawing.Point(14, 79);
            this.Tb_Nome.Name = "Tb_Nome";
            this.Tb_Nome.Size = new System.Drawing.Size(285, 20);
            this.Tb_Nome.TabIndex = 12;
            // 
            // Lb_Nivel
            // 
            this.Lb_Nivel.AutoSize = true;
            this.Lb_Nivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_Nivel.Location = new System.Drawing.Point(161, 142);
            this.Lb_Nivel.Name = "Lb_Nivel";
            this.Lb_Nivel.Size = new System.Drawing.Size(31, 13);
            this.Lb_Nivel.TabIndex = 9;
            this.Lb_Nivel.Text = "Nivel";
            this.Lb_Nivel.Click += new System.EventHandler(this.Lb_Nivel_Click);
            // 
            // Lb_Status
            // 
            this.Lb_Status.AutoSize = true;
            this.Lb_Status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_Status.Location = new System.Drawing.Point(11, 142);
            this.Lb_Status.Name = "Lb_Status";
            this.Lb_Status.Size = new System.Drawing.Size(37, 13);
            this.Lb_Status.TabIndex = 10;
            this.Lb_Status.Text = "Status";
            this.Lb_Status.Click += new System.EventHandler(this.Lb_Status_Click);
            // 
            // Lb_Nome
            // 
            this.Lb_Nome.AutoSize = true;
            this.Lb_Nome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_Nome.Location = new System.Drawing.Point(11, 62);
            this.Lb_Nome.Name = "Lb_Nome";
            this.Lb_Nome.Size = new System.Drawing.Size(35, 13);
            this.Lb_Nome.TabIndex = 11;
            this.Lb_Nome.Text = "Nome";
            // 
            // Lb_Id
            // 
            this.Lb_Id.AutoSize = true;
            this.Lb_Id.Location = new System.Drawing.Point(11, 12);
            this.Lb_Id.Name = "Lb_Id";
            this.Lb_Id.Size = new System.Drawing.Size(18, 13);
            this.Lb_Id.TabIndex = 19;
            this.Lb_Id.Text = "ID";
            // 
            // Tb_Id
            // 
            this.Tb_Id.Location = new System.Drawing.Point(14, 29);
            this.Tb_Id.Name = "Tb_Id";
            this.Tb_Id.ReadOnly = true;
            this.Tb_Id.Size = new System.Drawing.Size(124, 20);
            this.Tb_Id.TabIndex = 20;
            this.Tb_Id.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Fechar);
            this.panel1.Controls.Add(this.Btn_Excluir);
            this.panel1.Controls.Add(this.Btn_Salvar);
            this.panel1.Controls.Add(this.Btn_Novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 30);
            this.panel1.TabIndex = 21;
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Fechar.Location = new System.Drawing.Point(491, 4);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fechar.TabIndex = 3;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Excluir.Location = new System.Drawing.Point(246, 4);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(111, 23);
            this.Btn_Excluir.TabIndex = 0;
            this.Btn_Excluir.Text = "Excluir Usuário";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salvar.Location = new System.Drawing.Point(129, 4);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(111, 23);
            this.Btn_Salvar.TabIndex = 0;
            this.Btn_Salvar.Text = "Salvar Alterações";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Novo.Location = new System.Drawing.Point(12, 4);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(111, 23);
            this.Btn_Novo.TabIndex = 0;
            this.Btn_Novo.Text = "Novo Usuário";
            this.Btn_Novo.UseVisualStyleBackColor = true;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Dgv_Usuarios
            // 
            this.Dgv_Usuarios.AllowUserToAddRows = false;
            this.Dgv_Usuarios.AllowUserToDeleteRows = false;
            this.Dgv_Usuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Usuarios.EnableHeadersVisualStyles = false;
            this.Dgv_Usuarios.Location = new System.Drawing.Point(326, 12);
            this.Dgv_Usuarios.MultiSelect = false;
            this.Dgv_Usuarios.Name = "Dgv_Usuarios";
            this.Dgv_Usuarios.ReadOnly = true;
            this.Dgv_Usuarios.RowHeadersVisible = false;
            this.Dgv_Usuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Usuarios.Size = new System.Drawing.Size(246, 213);
            this.Dgv_Usuarios.TabIndex = 0;
            this.Dgv_Usuarios.SelectionChanged += new System.EventHandler(this.Dgv_Usuarios_SelectionChanged);
            // 
            // F_GestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.Dgv_Usuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lb_Id);
            this.Controls.Add(this.Tb_Id);
            this.Controls.Add(this.Cb_MostarSenha);
            this.Controls.Add(this.Lb_InfoStatus);
            this.Controls.Add(this.N_Nivel);
            this.Controls.Add(this.Cb_Status);
            this.Controls.Add(this.Tb_Senha);
            this.Controls.Add(this.Lb_Username);
            this.Controls.Add(this.Tb_Username);
            this.Controls.Add(this.Lb_Senha);
            this.Controls.Add(this.Tb_Nome);
            this.Controls.Add(this.Lb_Nivel);
            this.Controls.Add(this.Lb_Status);
            this.Controls.Add(this.Lb_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Usuários";
            this.Load += new System.EventHandler(this.F_GestaoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.N_Nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Cb_MostarSenha;
        private System.Windows.Forms.Label Lb_InfoStatus;
        private System.Windows.Forms.NumericUpDown N_Nivel;
        private System.Windows.Forms.ComboBox Cb_Status;
        private System.Windows.Forms.TextBox Tb_Senha;
        private System.Windows.Forms.Label Lb_Username;
        private System.Windows.Forms.TextBox Tb_Username;
        private System.Windows.Forms.Label Lb_Senha;
        private System.Windows.Forms.TextBox Tb_Nome;
        private System.Windows.Forms.Label Lb_Nivel;
        private System.Windows.Forms.Label Lb_Status;
        private System.Windows.Forms.Label Lb_Nome;
        private System.Windows.Forms.Label Lb_Id;
        private System.Windows.Forms.TextBox Tb_Id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dgv_Usuarios;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.Button Btn_Fechar;
    }
}