namespace Trabalho_POO
{
    partial class Painel
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
            btnTestarConexao = new Button();
            label1 = new Label();
            txtIdPesquisa = new TextBox();
            btnPesquisar = new Button();
            lblPergunta = new Label();
            txtPergunta = new TextBox();
            lblRespostaCorreta = new Label();
            txtRespostaCorreta = new TextBox();
            lblRespostasErradas = new Label();
            txtRespostaErrada1 = new TextBox();
            txtRespostaErrada2 = new TextBox();
            txtRespostaErrada3 = new TextBox();
            txtRespostaErrada4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnForm1 = new Button();
            SuspendLayout();
            // 
            // btnTestarConexao
            // 
            btnTestarConexao.Location = new Point(131, 409);
            btnTestarConexao.Name = "btnTestarConexao";
            btnTestarConexao.Size = new Size(223, 29);
            btnTestarConexao.TabIndex = 0;
            btnTestarConexao.Text = "conexão com banco de dados";
            btnTestarConexao.UseVisualStyleBackColor = true;
            btnTestarConexao.Click += btnTestarConexao_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 64);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 1;
            label1.Text = "Digite o ID da Pergunta:";
            // 
            // txtIdPesquisa
            // 
            txtIdPesquisa.Location = new Point(198, 61);
            txtIdPesquisa.Name = "txtIdPesquisa";
            txtIdPesquisa.Size = new Size(125, 27);
            txtIdPesquisa.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(547, 65);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.Location = new Point(36, 103);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(70, 20);
            lblPergunta.TabIndex = 4;
            lblPergunta.Text = "Pergunta:";
            // 
            // txtPergunta
            // 
            txtPergunta.Location = new Point(112, 100);
            txtPergunta.Name = "txtPergunta";
            txtPergunta.Size = new Size(474, 27);
            txtPergunta.TabIndex = 5;
            // 
            // lblRespostaCorreta
            // 
            lblRespostaCorreta.AutoSize = true;
            lblRespostaCorreta.Location = new Point(36, 154);
            lblRespostaCorreta.Name = "lblRespostaCorreta";
            lblRespostaCorreta.Size = new Size(125, 20);
            lblRespostaCorreta.TabIndex = 6;
            lblRespostaCorreta.Text = "Resposta Correta:";
            // 
            // txtRespostaCorreta
            // 
            txtRespostaCorreta.Location = new Point(167, 151);
            txtRespostaCorreta.Name = "txtRespostaCorreta";
            txtRespostaCorreta.Size = new Size(419, 27);
            txtRespostaCorreta.TabIndex = 7;
            // 
            // lblRespostasErradas
            // 
            lblRespostasErradas.AutoSize = true;
            lblRespostasErradas.Location = new Point(36, 216);
            lblRespostasErradas.Name = "lblRespostasErradas";
            lblRespostasErradas.Size = new Size(131, 20);
            lblRespostasErradas.TabIndex = 8;
            lblRespostasErradas.Text = "Respostas Erradas:";
            // 
            // txtRespostaErrada1
            // 
            txtRespostaErrada1.Location = new Point(167, 213);
            txtRespostaErrada1.Name = "txtRespostaErrada1";
            txtRespostaErrada1.Size = new Size(419, 27);
            txtRespostaErrada1.TabIndex = 9;
            // 
            // txtRespostaErrada2
            // 
            txtRespostaErrada2.Location = new Point(167, 257);
            txtRespostaErrada2.Name = "txtRespostaErrada2";
            txtRespostaErrada2.Size = new Size(419, 27);
            txtRespostaErrada2.TabIndex = 10;
            // 
            // txtRespostaErrada3
            // 
            txtRespostaErrada3.Location = new Point(167, 300);
            txtRespostaErrada3.Name = "txtRespostaErrada3";
            txtRespostaErrada3.Size = new Size(419, 27);
            txtRespostaErrada3.TabIndex = 11;
            // 
            // txtRespostaErrada4
            // 
            txtRespostaErrada4.Location = new Point(167, 351);
            txtRespostaErrada4.Name = "txtRespostaErrada4";
            txtRespostaErrada4.Size = new Size(419, 27);
            txtRespostaErrada4.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 9);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 13;
            label2.Text = "Pesquisa de pergunta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 413);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 14;
            label3.Text = "teste conexão";
            // 
            // btnForm1
            // 
            btnForm1.Location = new Point(21, 12);
            btnForm1.Name = "btnForm1";
            btnForm1.Size = new Size(94, 29);
            btnForm1.TabIndex = 15;
            btnForm1.Text = "Voltar";
            btnForm1.UseVisualStyleBackColor = true;
            btnForm1.Click += btnForm1_Click;
            // 
            // Painel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForm1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRespostaErrada4);
            Controls.Add(txtRespostaErrada3);
            Controls.Add(txtRespostaErrada2);
            Controls.Add(txtRespostaErrada1);
            Controls.Add(lblRespostasErradas);
            Controls.Add(txtRespostaCorreta);
            Controls.Add(lblRespostaCorreta);
            Controls.Add(txtPergunta);
            Controls.Add(lblPergunta);
            Controls.Add(btnPesquisar);
            Controls.Add(txtIdPesquisa);
            Controls.Add(label1);
            Controls.Add(btnTestarConexao);
            Name = "Painel";
            Text = "Painel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTestarConexao;
        private Label label1;
        private TextBox txtIdPesquisa;
        private Button btnPesquisar;
        private Label lblPergunta;
        private TextBox txtPergunta;
        private Label lblRespostaCorreta;
        private TextBox txtRespostaCorreta;
        private Label lblRespostasErradas;
        private TextBox txtRespostaErrada1;
        private TextBox txtRespostaErrada2;
        private TextBox txtRespostaErrada3;
        private TextBox txtRespostaErrada4;
        private Label label2;
        private Label label3;
        private Button btnForm1;
    }
}