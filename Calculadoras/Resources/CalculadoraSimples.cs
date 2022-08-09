using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoras.Resources
{
    public partial class frmCalcSimples : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        string operacao = "";

        public frmCalcSimples()
        {
            InitializeComponent();
        }
                     
        private void btn0_Click(object sender, EventArgs e)
        {
            txbDisplay.Text += btn0.Text;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txbDisplay.Text += btn1.Text;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txbDisplay.Text += btn2.Text;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txbDisplay.Text += btn3.Text;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txbDisplay.Text += btn4.Text;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txbDisplay.Text += btn5.Text;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txbDisplay.Text += btn6.Text;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txbDisplay.Text += btn7.Text;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txbDisplay.Text += btn8.Text;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txbDisplay.Text += btn9.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbDisplay.Clear();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txbDisplay.Text);
            operacao = "add";
            txbDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txbDisplay.Text);
            operacao = "div";
            txbDisplay.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txbDisplay.Text);
            operacao = "mult";
            txbDisplay.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txbDisplay.Text);
            operacao = "sub";
            txbDisplay.Clear();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(txbDisplay.Text);
            txbDisplay.Clear();
            double resultado = Operacao(valor1, operacao, valor2);
            txbDisplay.Text = (resultado > 9999999999) ? resultado.ToString("E5"):resultado.ToString();
            valor1 = resultado;
            valor2 = 0;
        }

        private double Operacao(double valor1, string operacao, double valor2)
        {
            var resultado = operacao switch
            {
                "div" => valor1 / valor2,
                "sub" => valor1 - valor2,
                "add" => valor1 + valor2,
                "mult" => valor1 * valor2,
                _ => 0
            };
            return resultado;
        }
    }
}
