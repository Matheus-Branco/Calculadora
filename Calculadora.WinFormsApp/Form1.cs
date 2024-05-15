namespace Calculadora.WinFormsApp
{
    public partial class TelaCalcular : Form
    {
        public TelaCalcular()
        {
            InitializeComponent();
        }

        private void BtnCalcular(object sender, EventArgs e)
        {
            int primeiroNumero = Convert.ToInt32(primeiroN.Text);
            int segundoNumero = Convert.ToInt32(segundoN.Text);
            int res = 0;

            bool operacaoAdicao = Convert.ToBoolean(radioBtnAdicao.Text);
            bool operacaoSubtracao = Convert.ToBoolean(radioBtnSubtracao.Text);
            bool operacaoDivisao = Convert.ToBoolean(radioBtnDivisao.Text);
            bool operacaoMultiplicacao = Convert.ToBoolean(radioBtnMultiplicacao.Text);

            

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
