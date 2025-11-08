namespace ProjetoAutoeças4Semestre
{
    partial class CadastroNovoFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroNovoFuncionario));
            this.LblNome = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.BackColor = System.Drawing.Color.Transparent;
            this.LblNome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(98, 49);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(70, 30);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.BackColor = System.Drawing.Color.Transparent;
            this.LblEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(98, 115);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(63, 30);
            this.LblEmail.TabIndex = 1;
            this.LblEmail.Text = "Email";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.BackColor = System.Drawing.Color.Transparent;
            this.LblCpf.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpf.Location = new System.Drawing.Point(98, 191);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(45, 30);
            this.LblCpf.TabIndex = 2;
            this.LblCpf.Text = "Cpf";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.BackColor = System.Drawing.Color.Transparent;
            this.LblSenha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(98, 264);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(70, 30);
            this.LblSenha.TabIndex = 3;
            this.LblSenha.Text = "Senha";
            this.LblSenha.Click += new System.EventHandler(this.LblSenha_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(103, 82);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(289, 20);
            this.TxtNome.TabIndex = 5;
            this.TxtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(103, 297);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(289, 20);
            this.TxtSenha.TabIndex = 6;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(103, 224);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(289, 20);
            this.TxtCpf.TabIndex = 7;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(103, 148);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(289, 20);
            this.TxtEmail.TabIndex = 8;
            // 
            // BtnCadastrarFuncionario
            // 
            this.BtnCadastrarFuncionario.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarFuncionario.Location = new System.Drawing.Point(154, 338);
            this.BtnCadastrarFuncionario.Name = "BtnCadastrarFuncionario";
            this.BtnCadastrarFuncionario.Size = new System.Drawing.Size(170, 50);
            this.BtnCadastrarFuncionario.TabIndex = 10;
            this.BtnCadastrarFuncionario.Text = "Cadastrar";
            this.BtnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.BtnCadastrarFuncionario.Click += new System.EventHandler(this.BtnCadastrarFuncionario_Click);
            // 
            // CadastroNovoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoAutoeças4Semestre.Properties.Resources.gradient4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.BtnCadastrarFuncionario);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblNome);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroNovoFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroNovoFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnCadastrarFuncionario;
    }
}