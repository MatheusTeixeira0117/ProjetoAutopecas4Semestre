namespace ProjetoAutoeças4Semestre.Forms
{
    partial class FormProduto
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
            this.BtnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblPreco = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCadastrarFuncionario
            // 
            this.BtnCadastrarFuncionario.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarFuncionario.Location = new System.Drawing.Point(590, 377);
            this.BtnCadastrarFuncionario.Name = "BtnCadastrarFuncionario";
            this.BtnCadastrarFuncionario.Size = new System.Drawing.Size(170, 50);
            this.BtnCadastrarFuncionario.TabIndex = 19;
            this.BtnCadastrarFuncionario.Text = "Cadastrar";
            this.BtnCadastrarFuncionario.UseVisualStyleBackColor = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(30, 140);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(203, 30);
            this.TxtEmail.TabIndex = 18;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(30, 407);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(250, 20);
            this.TxtCpf.TabIndex = 17;
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(30, 67);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(523, 30);
            this.TxtNome.TabIndex = 15;
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.BackColor = System.Drawing.Color.Transparent;
            this.LblCpf.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpf.Location = new System.Drawing.Point(25, 366);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(303, 37);
            this.LblCpf.TabIndex = 13;
            this.LblCpf.Text = "Quantidade em estoque";
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.BackColor = System.Drawing.Color.Transparent;
            this.LblPreco.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreco.Location = new System.Drawing.Point(28, 100);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(83, 37);
            this.LblPreco.TabIndex = 12;
            this.LblPreco.Text = "Preço";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.BackColor = System.Drawing.Color.Transparent;
            this.LblNome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(25, 27);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(90, 37);
            this.LblNome.TabIndex = 11;
            this.LblNome.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 217);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(536, 146);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Descrição";
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoAutoeças4Semestre.Properties.Resources.gradient4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCadastrarFuncionario);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.LblNome);
            this.DoubleBuffered = true;
            this.Name = "FormProduto";
            this.Text = "FormProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCadastrarFuncionario;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}