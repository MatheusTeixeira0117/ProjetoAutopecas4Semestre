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
                 if (!string.IsNullOrWhiteSpace(TxtLoginEmail.Text) && !string.IsNullOrWhiteSpace(TxtLoginSenha.Text))
                {
                    string email = TxtLoginEmail.Text.Trim();
                    string senha = TxtLoginSenha.Text.Trim();

                    // Cria o objeto que faz a consulta
                    CadastroFuncionario loginFuncionario = new CadastroFuncionario(email, senha);
                    MySqlDataReader reader = loginFuncionario.loginFuncionario();

                    // Se achou algum registro
                    if (reader != null && reader.Read()) 
                    {

                        this.Hide();

                        FPrincipal principal = new FPrincipal();
                        principal.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos!");
                        TxtLoginEmail.Clear();
                        TxtLoginSenha.Clear();
                        TxtLoginEmail.Focus();
                    }

                    reader?.Close();
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
                MessageBox.Show("Algo deu errado" + ex.Message);
            }
        }

        private void Txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

