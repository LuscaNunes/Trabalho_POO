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
    public partial class Edicao : Form
    {
        public Edicao()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdPesquisa.Text))
            {
                MessageBox.Show("Digite um ID para pesquisar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtIdPesquisa.Text);

                using (MySqlConnection conexao = Conexao.Conectar())
                {
                    string query = "SELECT * FROM Perguntas WHERE Id = @Id";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Id", id);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preenche os campos para edição
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
                MessageBox.Show($"Erro: {ex.Message}", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdPesquisa.Text))
            {
                MessageBox.Show("Pesquise um ID antes de editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtIdPesquisa.Text);

                using (MySqlConnection conexao = Conexao.Conectar())
                {
                    string query = @"
                UPDATE Perguntas 
                SET 
                    Pergunta = @Pergunta,
                    RespostaCerta = @RespostaCerta,
                    RespostaErrada1 = @RespostaErrada1,
                    RespostaErrada2 = @RespostaErrada2,
                    RespostaErrada3 = @RespostaErrada3,
                    RespostaErrada4 = @RespostaErrada4
                WHERE Id = @Id";

                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.Parameters.AddWithValue("@Pergunta", txtPergunta.Text);
                    comando.Parameters.AddWithValue("@RespostaCerta", txtRespostaCorreta.Text);
                    comando.Parameters.AddWithValue("@RespostaErrada1", txtRespostaErrada1.Text);
                    comando.Parameters.AddWithValue("@RespostaErrada2", txtRespostaErrada2.Text);
                    comando.Parameters.AddWithValue("@RespostaErrada3", txtRespostaErrada3.Text);
                    comando.Parameters.AddWithValue("@RespostaErrada4", txtRespostaErrada4.Text);

                    int linhasAfetadas = comando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Pergunta atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma pergunta foi atualizada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ID inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtIdPesquisa.Clear();
            txtPergunta.Clear();
            txtRespostaCorreta.Clear();
            txtRespostaErrada1.Clear();
            txtRespostaErrada2.Clear();
            txtRespostaErrada3.Clear();
            txtRespostaErrada4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }

}
