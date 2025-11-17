namespace ProjetoAutoeças4Semestre
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLoginEmail = new System.Windows.Forms.TextBox();
            this.TxtLoginSenha = new System.Windows.Forms.TextBox();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.linkNovoFuncionario = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjetoAutoeças4Semestre.Properties.Resources.imgLogin;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(364, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 528);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Impact", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(125, 100);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(120, 54);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.BackColor = System.Drawing.Color.Transparent;
            this.LEmail.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.Location = new System.Drawing.Point(141, 179);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(83, 33);
            this.LEmail.TabIndex = 1;
            this.LEmail.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // TxtLoginEmail
            // 
            this.TxtLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLoginEmail.Location = new System.Drawing.Point(52, 224);
            this.TxtLoginEmail.Name = "TxtLoginEmail";
            this.TxtLoginEmail.Size = new System.Drawing.Size(260, 30);
            this.TxtLoginEmail.TabIndex = 1;
            this.TxtLoginEmail.TextChanged += new System.EventHandler(this.Txtemail_TextChanged);
            // 
            // TxtLoginSenha
            // 
            this.TxtLoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLoginSenha.Location = new System.Drawing.Point(52, 334);
            this.TxtLoginSenha.Name = "TxtLoginSenha";
            this.TxtLoginSenha.Size = new System.Drawing.Size(260, 30);
            this.TxtLoginSenha.TabIndex = 2;
            this.TxtLoginSenha.UseSystemPasswordChar = true;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnEntrar.FlatAppearance.BorderSize = 0;
            this.BtnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnEntrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.Location = new System.Drawing.Point(90, 395);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(185, 66);
            this.BtnEntrar.TabIndex = 3;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // linkNovoFuncionario
            // 
            this.linkNovoFuncionario.AutoSize = true;
            this.linkNovoFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.linkNovoFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkNovoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNovoFuncionario.Location = new System.Drawing.Point(130, 501);
            this.linkNovoFuncionario.Name = "linkNovoFuncionario";
            this.linkNovoFuncionario.Size = new System.Drawing.Size(115, 17);
            this.linkNovoFuncionario.TabIndex = 8;
            this.linkNovoFuncionario.TabStop = true;
            this.linkNovoFuncionario.Text = "Novo funcionario";
            this.linkNovoFuncionario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNovoFuncionario_LinkClicked);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoAutoeças4Semestre.Properties.Resources.gradient4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 527);
            this.Controls.Add(this.linkNovoFuncionario);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.TxtLoginSenha);
            this.Controls.Add(this.TxtLoginEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turbo Auto Peças";
            this.Load += new System.EventHandler(this.FLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLoginEmail;
        private System.Windows.Forms.TextBox TxtLoginSenha;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.LinkLabel linkNovoFuncionario;
    }
}

