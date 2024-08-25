namespace Calculadora
{
    partial class CALCULADORA
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
            txt_Resul = new TextBox();
            lbl_Operacao = new Label();
            btn_Sete = new Button();
            btn_Oito = new Button();
            btn_Nove = new Button();
            btn_Divisao = new Button();
            btn_Multi = new Button();
            btn_Seis = new Button();
            btn_Cinco = new Button();
            btn_Quatro = new Button();
            btn_Menos = new Button();
            btn_Tres = new Button();
            btn_Dois = new Button();
            btn_Um = new Button();
            btn_Mais = new Button();
            btn_Igual = new Button();
            btn_Zero = new Button();
            btn_Virgula = new Button();
            btn_Apag = new Button();
            SuspendLayout();
            // 
            // txt_Resul
            // 
            txt_Resul.BackColor = SystemColors.Menu;
            txt_Resul.Location = new Point(33, 28);
            txt_Resul.Name = "txt_Resul";
            txt_Resul.ReadOnly = true;
            txt_Resul.Size = new Size(310, 27);
            txt_Resul.TabIndex = 0;
            txt_Resul.TextAlign = HorizontalAlignment.Right;
            // 
            // lbl_Operacao
            // 
            lbl_Operacao.AutoSize = true;
            lbl_Operacao.Location = new Point(41, 31);
            lbl_Operacao.Name = "lbl_Operacao";
            lbl_Operacao.Size = new Size(0, 20);
            lbl_Operacao.TabIndex = 1;
            // 
            // btn_Sete
            // 
            btn_Sete.BackColor = SystemColors.AppWorkspace;
            btn_Sete.Location = new Point(33, 118);
            btn_Sete.Name = "btn_Sete";
            btn_Sete.Size = new Size(73, 73);
            btn_Sete.TabIndex = 2;
            btn_Sete.Text = "7";
            btn_Sete.UseVisualStyleBackColor = false;
            btn_Sete.Click += btn_Sete_Click;
            // 
            // btn_Oito
            // 
            btn_Oito.BackColor = SystemColors.AppWorkspace;
            btn_Oito.Location = new Point(112, 118);
            btn_Oito.Name = "btn_Oito";
            btn_Oito.Size = new Size(73, 73);
            btn_Oito.TabIndex = 11;
            btn_Oito.Text = "8";
            btn_Oito.UseVisualStyleBackColor = false;
            btn_Oito.Click += btn_Oito_Click;
            // 
            // btn_Nove
            // 
            btn_Nove.BackColor = SystemColors.AppWorkspace;
            btn_Nove.Location = new Point(193, 118);
            btn_Nove.Name = "btn_Nove";
            btn_Nove.Size = new Size(73, 73);
            btn_Nove.TabIndex = 12;
            btn_Nove.Text = "9";
            btn_Nove.UseVisualStyleBackColor = false;
            btn_Nove.Click += btn_Nove_Click;
            // 
            // btn_Divisao
            // 
            btn_Divisao.BackColor = SystemColors.AppWorkspace;
            btn_Divisao.Location = new Point(270, 118);
            btn_Divisao.Name = "btn_Divisao";
            btn_Divisao.Size = new Size(73, 73);
            btn_Divisao.TabIndex = 13;
            btn_Divisao.Text = "/";
            btn_Divisao.UseVisualStyleBackColor = false;
            btn_Divisao.Click += btn_Divisao_Click;
            // 
            // btn_Multi
            // 
            btn_Multi.BackColor = SystemColors.AppWorkspace;
            btn_Multi.Location = new Point(270, 197);
            btn_Multi.Name = "btn_Multi";
            btn_Multi.Size = new Size(73, 73);
            btn_Multi.TabIndex = 17;
            btn_Multi.Text = "*";
            btn_Multi.UseVisualStyleBackColor = false;
            btn_Multi.Click += btn_Multi_Click;
            // 
            // btn_Seis
            // 
            btn_Seis.BackColor = SystemColors.AppWorkspace;
            btn_Seis.Location = new Point(191, 197);
            btn_Seis.Name = "btn_Seis";
            btn_Seis.Size = new Size(73, 73);
            btn_Seis.TabIndex = 16;
            btn_Seis.Text = "6";
            btn_Seis.UseVisualStyleBackColor = false;
            btn_Seis.Click += btn_Seis_Click;
            // 
            // btn_Cinco
            // 
            btn_Cinco.BackColor = SystemColors.AppWorkspace;
            btn_Cinco.Location = new Point(112, 197);
            btn_Cinco.Name = "btn_Cinco";
            btn_Cinco.Size = new Size(73, 73);
            btn_Cinco.TabIndex = 15;
            btn_Cinco.Text = "5";
            btn_Cinco.UseVisualStyleBackColor = false;
            btn_Cinco.Click += btn_Cinco_Click;
            // 
            // btn_Quatro
            // 
            btn_Quatro.BackColor = SystemColors.AppWorkspace;
            btn_Quatro.Location = new Point(33, 197);
            btn_Quatro.Name = "btn_Quatro";
            btn_Quatro.Size = new Size(73, 73);
            btn_Quatro.TabIndex = 14;
            btn_Quatro.Text = "4";
            btn_Quatro.UseVisualStyleBackColor = false;
            btn_Quatro.Click += btn_Quatro_Click;
            // 
            // btn_Menos
            // 
            btn_Menos.BackColor = SystemColors.AppWorkspace;
            btn_Menos.Location = new Point(270, 276);
            btn_Menos.Name = "btn_Menos";
            btn_Menos.Size = new Size(73, 73);
            btn_Menos.TabIndex = 21;
            btn_Menos.Text = "-";
            btn_Menos.UseVisualStyleBackColor = false;
            btn_Menos.Click += btn_Menos_Click;
            // 
            // btn_Tres
            // 
            btn_Tres.BackColor = SystemColors.AppWorkspace;
            btn_Tres.Location = new Point(191, 276);
            btn_Tres.Name = "btn_Tres";
            btn_Tres.Size = new Size(73, 73);
            btn_Tres.TabIndex = 20;
            btn_Tres.Text = "3";
            btn_Tres.UseVisualStyleBackColor = false;
            btn_Tres.Click += btn_Tres_Click;
            // 
            // btn_Dois
            // 
            btn_Dois.BackColor = SystemColors.AppWorkspace;
            btn_Dois.Location = new Point(112, 276);
            btn_Dois.Name = "btn_Dois";
            btn_Dois.Size = new Size(73, 73);
            btn_Dois.TabIndex = 19;
            btn_Dois.Text = "2";
            btn_Dois.UseVisualStyleBackColor = false;
            btn_Dois.Click += btn_Dois_Click;
            // 
            // btn_Um
            // 
            btn_Um.BackColor = SystemColors.AppWorkspace;
            btn_Um.Location = new Point(33, 276);
            btn_Um.Name = "btn_Um";
            btn_Um.Size = new Size(73, 73);
            btn_Um.TabIndex = 18;
            btn_Um.Text = "1";
            btn_Um.UseVisualStyleBackColor = false;
            btn_Um.Click += btn_Um_Click;
            // 
            // btn_Mais
            // 
            btn_Mais.BackColor = SystemColors.AppWorkspace;
            btn_Mais.Location = new Point(270, 355);
            btn_Mais.Name = "btn_Mais";
            btn_Mais.Size = new Size(73, 73);
            btn_Mais.TabIndex = 25;
            btn_Mais.Text = "+";
            btn_Mais.UseVisualStyleBackColor = false;
            btn_Mais.Click += btn_Mais_Click;
            // 
            // btn_Igual
            // 
            btn_Igual.BackColor = SystemColors.AppWorkspace;
            btn_Igual.Location = new Point(191, 355);
            btn_Igual.Name = "btn_Igual";
            btn_Igual.Size = new Size(73, 73);
            btn_Igual.TabIndex = 24;
            btn_Igual.Text = "=";
            btn_Igual.UseVisualStyleBackColor = false;
            btn_Igual.Click += btn_Igual_Click;
            // 
            // btn_Zero
            // 
            btn_Zero.BackColor = SystemColors.AppWorkspace;
            btn_Zero.Location = new Point(112, 355);
            btn_Zero.Name = "btn_Zero";
            btn_Zero.Size = new Size(73, 73);
            btn_Zero.TabIndex = 23;
            btn_Zero.Text = "0";
            btn_Zero.UseVisualStyleBackColor = false;
            btn_Zero.Click += btn_Zero_Click;
            // 
            // btn_Virgula
            // 
            btn_Virgula.BackColor = SystemColors.AppWorkspace;
            btn_Virgula.Location = new Point(33, 355);
            btn_Virgula.Name = "btn_Virgula";
            btn_Virgula.Size = new Size(73, 73);
            btn_Virgula.TabIndex = 22;
            btn_Virgula.Text = ",";
            btn_Virgula.UseVisualStyleBackColor = false;
            btn_Virgula.Click += btn_Virgula_Click;
            // 
            // btn_Apag
            // 
            btn_Apag.BackColor = SystemColors.AppWorkspace;
            btn_Apag.Location = new Point(270, 71);
            btn_Apag.Name = "btn_Apag";
            btn_Apag.Size = new Size(73, 41);
            btn_Apag.TabIndex = 26;
            btn_Apag.Text = "C";
            btn_Apag.UseVisualStyleBackColor = false;
            btn_Apag.Click += btn_Apag_Click;
            // 
            // CALCULADORA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(369, 454);
            Controls.Add(btn_Apag);
            Controls.Add(btn_Mais);
            Controls.Add(btn_Igual);
            Controls.Add(btn_Zero);
            Controls.Add(btn_Virgula);
            Controls.Add(btn_Menos);
            Controls.Add(btn_Tres);
            Controls.Add(btn_Dois);
            Controls.Add(btn_Um);
            Controls.Add(btn_Multi);
            Controls.Add(btn_Seis);
            Controls.Add(btn_Cinco);
            Controls.Add(btn_Quatro);
            Controls.Add(btn_Divisao);
            Controls.Add(btn_Nove);
            Controls.Add(btn_Oito);
            Controls.Add(btn_Sete);
            Controls.Add(lbl_Operacao);
            Controls.Add(txt_Resul);
            Name = "CALCULADORA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CALCULADORA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Resul;
        private Label lbl_Operacao;
        private Button btn_Sete;
        private Button btn_Oito;
        private Button btn_Nove;
        private Button btn_Divisao;
        private Button btn_Multi;
        private Button btn_Seis;
        private Button btn_Cinco;
        private Button btn_Quatro;
        private Button btn_Menos;
        private Button btn_Tres;
        private Button btn_Dois;
        private Button btn_Um;
        private Button btn_Mais;
        private Button btn_Igual;
        private Button btn_Zero;
        private Button btn_Virgula;
        private Button btn_Apag;
    }
}
