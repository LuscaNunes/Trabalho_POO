namespace Trabalho_POO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalvar_Click = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textPergunta = new TextBox();
            textResCorreta = new TextBox();
            textReErrada1 = new TextBox();
            textReErrada2 = new TextBox();
            textReErrada4 = new TextBox();
            textReErrada3 = new TextBox();
            btnPainel = new Button();
            btnEdicao = new Button();
            SuspendLayout();
            // 
            // btnSalvar_Click
            // 
            btnSalvar_Click.Location = new Point(662, 89);
            btnSalvar_Click.Name = "btnSalvar_Click";
            btnSalvar_Click.Size = new Size(94, 29);
            btnSalvar_Click.TabIndex = 0;
            btnSalvar_Click.Text = "Salvar";
            btnSalvar_Click.UseVisualStyleBackColor = true;
            btnSalvar_Click.Click += btnSalvar_Click_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 29);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Perguntas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 92);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Pergunta:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 164);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 3;
            label3.Text = "Resposta Correta:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 215);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 4;
            label4.Text = "Outras Respostas:";
            // 
            // textPergunta
            // 
            textPergunta.Location = new Point(92, 89);
            textPergunta.Name = "textPergunta";
            textPergunta.Size = new Size(472, 27);
            textPergunta.TabIndex = 5;
            textPergunta.TextChanged += textPergunta_TextChanged;
            // 
            // textResCorreta
            // 
            textResCorreta.Location = new Point(147, 161);
            textResCorreta.Name = "textResCorreta";
            textResCorreta.Size = new Size(472, 27);
            textResCorreta.TabIndex = 6;
            textResCorreta.TextChanged += textResCorreta_TextChanged;
            // 
            // textReErrada1
            // 
            textReErrada1.Location = new Point(147, 215);
            textReErrada1.Name = "textReErrada1";
            textReErrada1.Size = new Size(472, 27);
            textReErrada1.TabIndex = 7;
            textReErrada1.TextChanged += textReErrada1_TextChanged;
            // 
            // textReErrada2
            // 
            textReErrada2.Location = new Point(147, 257);
            textReErrada2.Name = "textReErrada2";
            textReErrada2.Size = new Size(472, 27);
            textReErrada2.TabIndex = 8;
            textReErrada2.TextChanged += textReErrada2_TextChanged;
            // 
            // textReErrada4
            // 
            textReErrada4.Location = new Point(147, 346);
            textReErrada4.Name = "textReErrada4";
            textReErrada4.Size = new Size(472, 27);
            textReErrada4.TabIndex = 10;
            textReErrada4.TextChanged += textReErrada4_TextChanged;
            // 
            // textReErrada3
            // 
            textReErrada3.Location = new Point(147, 304);
            textReErrada3.Name = "textReErrada3";
            textReErrada3.Size = new Size(472, 27);
            textReErrada3.TabIndex = 9;
            textReErrada3.TextChanged += textReErrada3_TextChanged;
            // 
            // btnPainel
            // 
            btnPainel.Location = new Point(634, 155);
            btnPainel.Name = "btnPainel";
            btnPainel.Size = new Size(154, 29);
            btnPainel.TabIndex = 11;
            btnPainel.Text = "Ir para Pesquisa";
            btnPainel.UseVisualStyleBackColor = true;
            btnPainel.Click += btnPainel_Click;
            // 
            // btnEdicao
            // 
            btnEdicao.Location = new Point(634, 190);
            btnEdicao.Name = "btnEdicao";
            btnEdicao.Size = new Size(154, 29);
            btnEdicao.TabIndex = 13;
            btnEdicao.Text = "Ir para Edição";
            btnEdicao.UseVisualStyleBackColor = true;
            btnEdicao.Click += btnEdicao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdicao);
            Controls.Add(btnPainel);
            Controls.Add(textReErrada4);
            Controls.Add(textReErrada3);
            Controls.Add(textReErrada2);
            Controls.Add(textReErrada1);
            Controls.Add(textResCorreta);
            Controls.Add(textPergunta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalvar_Click);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar_Click;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textPergunta;
        private TextBox textResCorreta;
        private TextBox textReErrada1;
        private TextBox textReErrada2;
        private TextBox textReErrada4;
        private TextBox textReErrada3;
        private Button btnPainel;
        private Button btnEdicao;
    }
}
