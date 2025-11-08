using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAutoeças4Semestre
{
    internal class ConecxaoBanco
    {
        private const string servidor = "localhost";
        private const string bancoDados = "dBTurboAutoPecas";
        private const string usuario = "root";
        private const string senha = "002027";

        static public string conexaoBanco = $"server = {servidor};user id = {usuario};database = {bancoDados};passWord ={senha}";
    }
}
