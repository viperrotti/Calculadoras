using System.Data;

namespace Calculadoras.Resources
{
    public partial class frmCalcSimples : Form
    {

        string expressao = "";

        public frmCalcSimples()
        {
            InitializeComponent();
        }

        private void click(object sender, EventArgs e)
        {
            var text = (sender as Button).Text;
            txbDisplay.Text += text;
            expressao += text;
        }

        private void opClick(object sender, EventArgs e)
        {
            var text = (sender as Button).Text;
            expressao += text;
            txbDisplay.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbDisplay.Clear();
            expressao = "";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if(expressao == "∞"){
                expressao = "0";
            }
            DataTable Calc = new DataTable();
            var resultado = Calc.Compute(expressao, "");
            double valor = Double.Parse(resultado.ToString());
            txbDisplay.Text = (valor > 9999999999) ? valor.ToString("E5") : valor.ToString();
            expressao = resultado.ToString();
        }

        private void txbDisplay_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
