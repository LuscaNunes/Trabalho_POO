using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_POO.Data;

namespace Trabalho_POO
{
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                // Tenta abrir a conexão
                using (MySqlConnection conexao = Conexao.Conectar())
                {
                    MessageBox.Show("Conexão bem-sucedida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Se ocorrer erro, exibe a mensagem
                MessageBox.Show($"Falha na conexão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Verifica se o ID foi digitado
            if (string.IsNullOrEmpty(txtIdPesquisa.Text))
            {
                MessageBox.Show("Digite um ID válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Converte o ID para inteiro
                int id = Convert.ToInt32(txtIdPesquisa.Text);

                // Busca no banco de dados
                using (MySqlConnection conexao = Conexao.Conectar())
                {
                    string query = "SELECT * FROM Perguntas WHERE Id = @Id";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Id", id);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preenche os campos com os dados encontrados
                            txtPergunta.Text = reader["Pergunta"].ToString();
                            txtRespostaCorreta.Text = reader["RespostaCerta"].ToString();
                            txtRespostaErrada1.Text = reader["RespostaErrada1"].ToString();
                            txtRespostaErrada2.Text = reader["RespostaErrada2"].ToString();
                            txtRespostaErrada3.Text = reader["RespostaErrada3"].ToString();
                            txtRespostaErrada4.Text = reader["RespostaErrada4"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Pergunta não encontrada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampos();
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ID inválido! Digite um número inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtPergunta.Clear();
            txtRespostaCorreta.Clear();
            txtRespostaErrada1.Clear();
            txtRespostaErrada2.Clear();
            txtRespostaErrada3.Clear();
            txtRespostaErrada4.Clear();
        }
    }
    
}
