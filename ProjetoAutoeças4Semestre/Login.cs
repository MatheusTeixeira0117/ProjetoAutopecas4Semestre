using MySql.Data.MySqlClient;
using ProjetoAutoeças4Semestre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAutoeças4Semestre
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
        }

        private void linkNovoFuncionario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroNovoFuncionario novoCadastro = new CadastroNovoFuncionario();     
            novoCadastro.Show();
            this.Hide(); 

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validação básica
                if (!string.IsNullOrWhiteSpace(TxtLoginEmail.Text) &&
                    !string.IsNullOrWhiteSpace(TxtLoginSenha.Text))
                {
                    string email = TxtLoginEmail.Text.Trim();
                    string senha = TxtLoginSenha.Text.Trim();

                    // Objeto de login
                    CadastroFuncionario loginFuncionario = new CadastroFuncionario(email, senha);

                    bool loginOk = loginFuncionario.loginFuncionario();

                    if (loginOk)
                    {
                        // Garantir que o cursor não fique preso como carregando
                        Application.UseWaitCursor = false;
                        this.UseWaitCursor = false;
                        Cursor.Current = Cursors.Default;

                        // Abre a tela principal
                        FPrincipal principal = new FPrincipal();
                        principal.Show();

                        // Oculta a tela de login
                        this.Hide();

                        // Fecha o app quando a principal fechar
                        principal.FormClosed += (s, args) => this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos!");
                        TxtLoginEmail.Clear();
                        TxtLoginSenha.Clear();
                        TxtLoginEmail.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher os campos corretamente.");
                    TxtLoginEmail.Clear();
                    TxtLoginSenha.Clear();
                    TxtLoginEmail.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado: " + ex.Message);
            }
        }



        private void Txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

