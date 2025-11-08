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
    public partial class CadastroNovoFuncionario : Form
    {
        public CadastroNovoFuncionario()
        {
            InitializeComponent();
        }

        private void LblSenha_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCadastrarFuncionario_Click(object sender, EventArgs e)
        {

             CadastroFuncionario CadFuncionario = new CadastroFuncionario(TxtNome.Text, TxtEmail.Text, TxtCpf.Text, TxtSenha.Text);

            try
            {
                if (!TxtNome.Text.Equals("") && !TxtEmail.Text.Equals("") && !TxtCpf.Text.Equals("") && !TxtSenha.Text.Equals("")) 
                {

                    if (CadFuncionario.cadastrarNovoFuncionario())
                    {
                        MessageBox.Show("Novo funcionario cadastrado com sucesso!");
                        this.Close();

                        FLogin login = new FLogin();
                        login.Show();

                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar novo funcionario!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor Preencher os campos Corretamente");
                    TxtNome.Clear();
                    TxtEmail.Clear();
                    TxtCpf.Clear();
                    TxtSenha.Clear();
                    TxtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado" + ex.Message);
            }
        }
    }
}
