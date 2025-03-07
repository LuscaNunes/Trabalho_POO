namespace Trabalho_POO
{
    partial class Edicao
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
            label1 = new Label();
            label2 = new Label();
            txtIdPesquisa = new TextBox();
            btnPesquisar = new Button();
            grpEdicao = new GroupBox();
            lblPergunta = new Label();
            txtPergunta = new TextBox();
            lblRespostaCorreta = new Label();
            txtRespostaCorreta = new TextBox();
            lblRespostasErradas = new Label();
            txtRespostaErrada1 = new TextBox();
            txtRespostaErrada2 = new TextBox();
            txtRespostaErrada3 = new TextBox();
            txtRespostaErrada4 = new TextBox();
            btnSalvar = new Button();
            btnForm1 = new Button();
            grpEdicao.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 22);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Edição pergunta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 72);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 1;
            label2.Text = "ID da Pergunta:";
            // 
            // txtIdPesquisa
            // 
            txtIdPesquisa.Location = new Point(147, 69);
            txtIdPesquisa.Name = "txtIdPesquisa";
            txtIdPesquisa.Size = new Size(81, 27);
            txtIdPesquisa.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(545, 68);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(197, 29);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // grpEdicao
            // 
            grpEdicao.Controls.Add(txtPergunta);
            grpEdicao.Controls.Add(lblPergunta);
            grpEdicao.Controls.Add(txtRespostaErrada4);
            grpEdicao.Controls.Add(txtRespostaCorreta);
            grpEdicao.Controls.Add(txtRespostaErrada3);
            grpEdicao.Controls.Add(lblRespostaCorreta);
            grpEdicao.Controls.Add(txtRespostaErrada2);
            grpEdicao.Controls.Add(lblRespostasErradas);
            grpEdicao.Controls.Add(txtRespostaErrada1);
            grpEdicao.Location = new Point(31, 133);
            grpEdicao.Name = "grpEdicao";
            grpEdicao.Size = new Size(522, 286);
            grpEdicao.TabIndex = 4;
            grpEdicao.TabStop = false;
            grpEdicao.Text = "Editar Pergunta";
            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.Location = new Point(15, 44);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(70, 20);
            lblPergunta.TabIndex = 5;
            lblPergunta.Text = "Pergunta:";
            // 
            // txtPergunta
            // 
            txtPergunta.Location = new Point(91, 41);
            txtPergunta.Name = "txtPergunta";
            txtPergunta.Size = new Size(351, 27);
            txtPergunta.TabIndex = 6;
            // 
            // lblRespostaCorreta
            // 
            lblRespostaCorreta.AutoSize = true;
            lblRespostaCorreta.Location = new Point(18, 86);
            lblRespostaCorreta.Name = "lblRespostaCorreta";
            lblRespostaCorreta.Size = new Size(125, 20);
            lblRespostaCorreta.TabIndex = 7;
            lblRespostaCorreta.Text = "Resposta Correta:";
            lblRespostaCorreta.Click += label3_Click;
            // 
            // txtRespostaCorreta
            // 
            txtRespostaCorreta.Location = new Point(149, 83);
            txtRespostaCorreta.Name = "txtRespostaCorreta";
            txtRespostaCorreta.Size = new Size(351, 27);
            txtRespostaCorreta.TabIndex = 8;
            // 
            // lblRespostasErradas
            // 
            lblRespostasErradas.AutoSize = true;
            lblRespostasErradas.Location = new Point(18, 130);
            lblRespostasErradas.Name = "lblRespostasErradas";
            lblRespostasErradas.Size = new Size(131, 20);
            lblRespostasErradas.TabIndex = 9;
            lblRespostasErradas.Text = "Respostas Erradas:";
            lblRespostasErradas.Click += label3_Click_1;
            // 
            // txtRespostaErrada1
            // 
            txtRespostaErrada1.Location = new Point(155, 127);
            txtRespostaErrada1.Name = "txtRespostaErrada1";
            txtRespostaErrada1.Size = new Size(351, 27);
            txtRespostaErrada1.TabIndex = 10;
            // 
            // txtRespostaErrada2
            // 
            txtRespostaErrada2.Location = new Point(155, 160);
            txtRespostaErrada2.Name = "txtRespostaErrada2";
            txtRespostaErrada2.Size = new Size(351, 27);
            txtRespostaErrada2.TabIndex = 11;
            // 
            // txtRespostaErrada3
            // 
            txtRespostaErrada3.Location = new Point(155, 193);
            txtRespostaErrada3.Name = "txtRespostaErrada3";
            txtRespostaErrada3.Size = new Size(351, 27);
            txtRespostaErrada3.TabIndex = 12;
            // 
            // txtRespostaErrada4
            // 
            txtRespostaErrada4.Location = new Point(155, 226);
            txtRespostaErrada4.Name = "txtRespostaErrada4";
            txtRespostaErrada4.Size = new Size(351, 27);
            txtRespostaErrada4.TabIndex = 13;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(636, 227);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(152, 29);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar Alterações";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnForm1
            // 
            btnForm1.Location = new Point(7, 12);
            btnForm1.Name = "btnForm1";
            btnForm1.Size = new Size(94, 29);
            btnForm1.TabIndex = 15;
            btnForm1.Text = "Voltar";
            btnForm1.UseVisualStyleBackColor = true;
            btnForm1.Click += button1_Click;
            // 
            // Edicao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForm1);
            Controls.Add(btnSalvar);
            Controls.Add(grpEdicao);
            Controls.Add(btnPesquisar);
            Controls.Add(txtIdPesquisa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Edicao";
            Text = "Edicao";
            grpEdicao.ResumeLayout(false);
            grpEdicao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIdPesquisa;
        private Button btnPesquisar;
        private GroupBox grpEdicao;
        private Label lblPergunta;
        private TextBox txtPergunta;
        private Label lblRespostaCorreta;
        private TextBox txtRespostaCorreta;
        private Label lblRespostasErradas;
        private TextBox txtRespostaErrada1;
        private TextBox txtRespostaErrada2;
        private TextBox txtRespostaErrada3;
        private TextBox txtRespostaErrada4;
        private Button btnSalvar;
        private Button btnForm1;
    }
}