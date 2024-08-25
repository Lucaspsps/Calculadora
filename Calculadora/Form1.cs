namespace Calculadora
{
    public partial class CALCULADORA : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public CALCULADORA()
        {
            InitializeComponent();
        }

        private void btn_Zero_Click(object sender, EventArgs e)
        {
            txt_Resul.Text += "0";
        }

        private void btn_Um_Click(object sender, EventArgs e)
        {
            txt_Resul.Text += "1";
        }

        private void btn_Dois_Click(object sender, EventArgs e)
        {
            txt_Resul.Text += "2";
        }

        private void btn_Tres_Click(object sender, EventArgs e)
        {
            txt_Resul.Text += "3";
        }

        private void btn_Quatro_Click(object sender, EventArgs e)
        {
            txt_Resul.Text += "4";
        }

        private void btn_Cinco_Click(object sender, EventArgs e)
        {
            txt_Resul.Text += "5";
        }

        private void btn_Seis_Click(object sender, EventArgs e)
        {
            txt_Resul.Text += "6";
        }

        private void btn_Sete_Click(object sender, EventArgs e)
        {
            txt_Resul.Text += "7";
        }

        private void btn_Oito_Click(object sender, EventArgs e)
        {
            txt_Resul.Text += "8";
        }

        private void btn_Nove_Click(object sender, EventArgs e)
        {
            txt_Resul.Text += "9";
        }

        private void btn_Mais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txt_Resul.Text);
            txt_Resul.Text = "";
            lbl_Operacao.Text = "+";
        }

        private void btn_Menos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txt_Resul.Text);
            txt_Resul.Text = "";
            lbl_Operacao.Text = "-";
        }

        private void btn_Multi_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txt_Resul.Text);
            txt_Resul.Text = "";
            lbl_Operacao.Text = "*";
        }

        private void btn_Divisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txt_Resul.Text);
            txt_Resul.Text = "";
            lbl_Operacao.Text = "/";
        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txt_Resul.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txt_Resul.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txt_Resul.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txt_Resul.Text);
                    break;
            }
            txt_Resul.Text = Convert.ToString(Resultado);
            lbl_Operacao.Text = "=";
        }

        private void btn_Virgula_Click(object sender, EventArgs e)
        {
            if (!txt_Resul.Text.Contains(","))
                txt_Resul.Text += ",";
        }

        private void btn_Apag_Click(object sender, EventArgs e)
        {
            txt_Resul.Text = "";
            lbl_Operacao.Text = "";
        }
    }
}
