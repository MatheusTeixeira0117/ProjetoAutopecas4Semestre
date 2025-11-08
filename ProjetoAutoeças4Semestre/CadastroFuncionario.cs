using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAutoeças4Semestre
{
    internal class CadastroFuncionario
    {
        private String nome;
        private String email;
        private String cpf;
        private String senha;


        public CadastroFuncionario(String email, String senha)
        {  
            this.email = email;
            this.senha = senha;
        }

        public CadastroFuncionario(String nome, String email, String cpf, String senha)
        {
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.senha = senha;
        }

        public String Nome
        {
            get { return nome; }
            set { nome  = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        public bool cadastrarNovoFuncionario()
        {
            try
            {
                MySqlConnection mySqlConnect = new MySqlConnection(ConecxaoBanco.conexaoBanco);
                mySqlConnect.Open();

                String insert = $"Insert Into funcionario (nome,email,cpf,senha) " +
                    $"values ('{Nome}','{Email}','{Cpf}','{Senha}')";

                MySqlCommand mySqlCommand = mySqlConnect.CreateCommand();
                mySqlCommand.CommandText = insert;

                mySqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Algo deu errado!" + ex.Message);
                return false;
            }
        }

        public MySqlDataReader loginFuncionario()
        {
            try
            {
                MySqlConnection mySqlConnect = new MySqlConnection(ConecxaoBanco.conexaoBanco);
                mySqlConnect.Open();

                string sql = "SELECT * FROM funcionario WHERE email = @Email AND senha = @Senha";

                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnect);
                cmd.Parameters.AddWithValue("@Email", this.Email);
                cmd.Parameters.AddWithValue("@Senha", this.Senha);

                MySqlDataReader reader = cmd.ExecuteReader();
                return reader; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Banco de dados - Método Loginfuncionario: " + ex.Message);
                return null;
            }
    }
}
}
