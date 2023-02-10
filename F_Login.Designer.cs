namespace Academia
{
    partial class F_Login
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
            this.components = new System.ComponentModel.Container();
            this.Lb_username = new System.Windows.Forms.Label();
            this.Tb_username = new System.Windows.Forms.TextBox();
            this.Lb_senha = new System.Windows.Forms.Label();
            this.Tb_senha = new System.Windows.Forms.TextBox();
            this.Btn_logar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Cb_mostrarSenha = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Lb_username
            // 
            this.Lb_username.AutoSize = true;
            this.Lb_username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_username.Location = new System.Drawing.Point(23, 9);
            this.Lb_username.Name = "Lb_username";
            this.Lb_username.Size = new System.Drawing.Size(55, 13);
            this.Lb_username.TabIndex = 0;
            this.Lb_username.Text = "Username";
            this.Lb_username.Click += new System.EventHandler(this.Lb_username_Click);
            // 
            // Tb_username
            // 
            this.Tb_username.Location = new System.Drawing.Point(12, 25);
            this.Tb_username.MaxLength = 30;
            this.Tb_username.Name = "Tb_username";
            this.Tb_username.Size = new System.Drawing.Size(190, 20);
            this.Tb_username.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Tb_username, "Insira seu nome de usuário.");
            // 
            // Lb_senha
            // 
            this.Lb_senha.AutoSize = true;
            this.Lb_senha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_senha.Location = new System.Drawing.Point(23, 55);
            this.Lb_senha.Name = "Lb_senha";
            this.Lb_senha.Size = new System.Drawing.Size(38, 13);
            this.Lb_senha.TabIndex = 0;
            this.Lb_senha.Text = "Senha";
            this.Lb_senha.Click += new System.EventHandler(this.Lb_senha_Click);
            // 
            // Tb_senha
            // 
            this.Tb_senha.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Tb_senha.Location = new System.Drawing.Point(12, 71);
            this.Tb_senha.MaxLength = 20;
            this.Tb_senha.Name = "Tb_senha";
            this.Tb_senha.Size = new System.Drawing.Size(190, 20);
            this.Tb_senha.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Tb_senha, "Insira sua senha.");
            this.Tb_senha.UseSystemPasswordChar = true;
            // 
            // Btn_logar
            // 
            this.Btn_logar.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_logar.Location = new System.Drawing.Point(12, 120);
            this.Btn_logar.Name = "Btn_logar";
            this.Btn_logar.Size = new System.Drawing.Size(190, 23);
            this.Btn_logar.TabIndex = 4;
            this.Btn_logar.Text = "Logar";
            this.Btn_logar.UseVisualStyleBackColor = true;
            this.Btn_logar.Click += new System.EventHandler(this.Btn_logar_Click);
            this.Btn_logar.MouseLeave += new System.EventHandler(this.Btn_logar_MouseLeave);
            this.Btn_logar.MouseHover += new System.EventHandler(this.Btn_logar_MouseHover);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cancelar.Location = new System.Drawing.Point(26, 154);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(168, 23);
            this.Btn_cancelar.TabIndex = 5;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Cb_mostrarSenha
            // 
            this.Cb_mostrarSenha.AutoSize = true;
            this.Cb_mostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cb_mostrarSenha.Location = new System.Drawing.Point(12, 97);
            this.Cb_mostrarSenha.Name = "Cb_mostrarSenha";
            this.Cb_mostrarSenha.Size = new System.Drawing.Size(95, 17);
            this.Cb_mostrarSenha.TabIndex = 3;
            this.Cb_mostrarSenha.Text = "Mostrar Senha";
            this.Cb_mostrarSenha.UseVisualStyleBackColor = true;
            this.Cb_mostrarSenha.CheckedChanged += new System.EventHandler(this.MostrarSenha_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 250;
            this.toolTip1.ReshowDelay = 0;
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 213);
            this.Controls.Add(this.Cb_mostrarSenha);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_logar);
            this.Controls.Add(this.Tb_senha);
            this.Controls.Add(this.Lb_senha);
            this.Controls.Add(this.Tb_username);
            this.Controls.Add(this.Lb_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_username;
        private System.Windows.Forms.TextBox Tb_username;
        private System.Windows.Forms.Label Lb_senha;
        private System.Windows.Forms.TextBox Tb_senha;
        private System.Windows.Forms.Button Btn_logar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.CheckBox Cb_mostrarSenha;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}