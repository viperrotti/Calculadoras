namespace Calculadoras
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmIMC_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double peso, altura;
            peso = Convert.ToDouble(txbPeso.Text);
            altura = Convert.ToDouble(txbAltura.Text);

            var (descricaoImc, resultadoImc) = CalcularIMC(peso, altura/100);

            lblResposta.Text = $"{descricaoImc}\nSeu IMC: {resultadoImc.ToString("F1")} kg/m²";
        }

        private (string,double) CalcularIMC (double peso, double altura)
        {
            double imc = peso / (altura * altura);

            var resultado = imc switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso normal",
                >= 25 and < 30 => "Sobrepeso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido"
            };

            return (resultado, imc);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbPeso.Text = string.Empty;
            txbAltura.Text = string.Empty;
            lblResposta.Text = string.Empty;
        }
    }
}