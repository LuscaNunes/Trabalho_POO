using MySql.Data.MySqlClient;
using Trabalho_POO.Data;

namespace Trabalho_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click_Click(object sender, EventArgs e)
        {
            try
            {
                // Passo 1: Capturar os valores dos campos
                string pergunta = textPergunta.Text.Trim();
                string respostaCorreta = textResCorreta.Text.Trim();
                string respostaErrada1 = textReErrada1.Text.Trim();
                string respostaErrada2 = textReErrada2.Text.Trim();
                string respostaErrada3 = textReErrada3.Text.Trim();
                string respostaErrada4 = textReErrada4.Text.Trim();

                if (respostaCorreta.Equals(respostaErrada1) ||
                respostaCorreta.Equals(respostaErrada2) ||
                respostaCorreta.Equals(respostaErrada3) ||
                respostaCorreta.Equals(respostaErrada4))
                {
                    MessageBox.Show("A resposta correta não pode ser igual a uma resposta errada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Passo 2: Validar campos obrigatórios
                if (string.IsNullOrEmpty(pergunta))
                {
                    MessageBox.Show("Digite a pergunta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(respostaCorreta))
                {
                    MessageBox.Show("Digite a resposta correta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Passo 3: Salvar no banco de dados
                using (MySqlConnection conexao = Conexao.Conectar())
                {
                    string query = @"
                INSERT INTO Perguntas (Pergunta, RespostaCerta, RespostaErrada1, RespostaErrada2, RespostaErrada3, RespostaErrada4)
                VALUES (@Pergunta, @RespostaCerta, @RespostaErrada1, @RespostaErrada2, @RespostaErrada3, @RespostaErrada4)";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Pergunta", pergunta);
                        comando.Parameters.AddWithValue("@RespostaCerta", respostaCorreta);
                        comando.Parameters.AddWithValue("@RespostaErrada1", respostaErrada1);
                        comando.Parameters.AddWithValue("@RespostaErrada2", respostaErrada2);
                        comando.Parameters.AddWithValue("@RespostaErrada3", respostaErrada3);
                        comando.Parameters.AddWithValue("@RespostaErrada4", respostaErrada4);


                        comando.ExecuteNonQuery();
                    }
                }

                // Passo 4: Feedback de sucesso e limpeza dos campos
                MessageBox.Show("Pergunta salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparCampos()
        {
            textPergunta.Clear();
            textResCorreta.Clear();
            textReErrada1.Clear();
            textReErrada2.Clear();
            textReErrada3.Clear();
            textReErrada4.Clear();
        }

        private void btnPainel_Click(object sender, EventArgs e)
        {
            // Cria uma instância do Painel
            Painel painel = new Painel();

            // Oculta a tela atual
            this.Hide();

            // Abre o Painel
            painel.Show();
        }

        private void textPergunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textResCorreta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textReErrada1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textReErrada2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textReErrada3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textReErrada4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdicao_Click(object sender, EventArgs e)
        {
            Edicao edicao = new Edicao();
            this.Hide();
            edicao.Show();
        }
    }
}
