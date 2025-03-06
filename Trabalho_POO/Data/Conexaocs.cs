using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_POO.Modelos;
using MySql.Data.MySqlClient;


namespace Trabalho_POO.Data
{
    internal static class Conexao
    {
        // String de conexão com o banco de dados
        private static string _strConexao =
            "server=localhost;Port=3306;uid=root;pwd=2024;database=BD_Pergunta;";

        // Objeto de conexão
        private static MySqlConnection? _conexao;

        /// <summary>
        /// Abre uma conexão com o banco de dados
        /// </summary>
        /// <returns>Conexão aberta</returns>
        public static MySqlConnection Conectar()
        {
            try
            {
                _conexao = new MySqlConnection(_strConexao);
                _conexao.Open();
                return _conexao;
            }
            catch (Exception ex)
            {
                // Lança uma exceção com mensagem amigável
                throw new Exception($"Erro ao conectar ao banco de dados: {ex.Message}");
            }
        }

        /// <summary>
        /// Fecha a conexão com o banco de dados
        /// </summary>
        public static void Fechar()
        {
            if (_conexao != null && _conexao.State == System.Data.ConnectionState.Open)
            {
                _conexao.Close();
            }
        }
    }
}
