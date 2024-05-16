using System.Drawing.Text;

namespace Calculadora.WinFormsApp
{
    public partial class TelaCalcular : Form
    {
        public TelaCalcular()
        {
            InitializeComponent();
        }
        private void radioBtnAdicao_CheckedChanged(object sender, EventArgs e, bool operacaoAdicao)
        {
            operacaoAdicao = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int primeiroNumero = Convert.ToInt32(primeiroN.Text);
            int segundoNumero = Convert.ToInt32(segundoN.Text);
            int res = 0;

            bool operacaoAdicao = Convert.ToBoolean(radioBtnAdicao.Text);
            bool operacaoSubtracao = Convert.ToBoolean(radioBtnSubtracao.Text);
            bool operacaoDivisao = Convert.ToBoolean(radioBtnDivisao.Text);
            bool operacaoMultiplicacao = Convert.ToBoolean(radioBtnMultiplicacao.Text);

            List<string> historico = new List<string>();

            if (radioBtnAdicao.Checked)
            {
                int Somar()
                {
                    res = primeiroNumero + segundoNumero;
                    return res;
                    historico.Add($"{primeiroNumero} + {segundoNumero} = {res}");
                }
            }
            if (radioBtnSubtracao.Checked)
            {
                int Subtrair()
                {
                    res = primeiroNumero + segundoNumero;
                    return res;
                    historico.Add($"{primeiroNumero} + {segundoNumero} = {res}");
                }
            }
            if (radioBtnDivisao.Checked)
            {
                int Dividir()
                {
                    res = primeiroNumero + segundoNumero;
                    return res;
                    historico.Add($"{primeiroNumero} + {segundoNumero} = {res}");
                }
            }
            if (radioBtnMultiplicacao.Checked)
            {
                int Multiplicar()
                {
                    res = primeiroNumero + segundoNumero;
                    return res;
                    historico.Add($"{primeiroNumero} + {segundoNumero} = {res}");
                }
            }
            foreach (var item in ListBoxHistorico.Items)
            {
                historico.Add(item.ToString());
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            primeiroN.Clear();
            segundoN.Clear();
            resultado.Text = "0";
            ListBoxHistorico.Text = "Vazio";
        }
    }
}
