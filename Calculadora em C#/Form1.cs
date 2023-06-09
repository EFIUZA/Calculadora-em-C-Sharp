﻿using System.Globalization;

namespace Calculadora_em_C_
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0, valorPorcentagem = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "Soma";
            lblOperacao.Text = "+";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "Soma")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "Subtracao")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "Multiplicar")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "Divisao")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "Subtracao";
            lblOperacao.Text = "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "Multiplicar";
            lblOperacao.Text = "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "Divisao";
            lblOperacao.Text = "/";
        }

        private void btnAoQuadrado_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = Convert.ToString(Math.Pow(valor1, 2));
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = Convert.ToString(Math.Sqrt(valor1));
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            double valorPorcentagem = (valor1 / 100);
            txtResultado.Text = valorPorcentagem.ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";

        }
    }
}