using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        String botaoSelecionado = "";
        Button botaoClicado;
        double valor1;
    
        public object Resultado { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void apagar_Click(object sender, EventArgs e)
        {
            caixatexto.Clear();
        }
        
        // Inicio dos operadores --> + - * / =

        private void soma_Click(object sender, EventArgs e)
        {
            
            botaoClicado = (Button)sender;
            botaoSelecionado = "+";
            valor1 = double.Parse(caixatexto.Text);
            caixatexto.Clear();
            valorAnterior.Text = Convert.ToString(valor1) + " " + botaoSelecionado;
        }
        private void subtracao_Click(object sender, EventArgs e)
        {
            botaoClicado = (Button)sender;
            botaoSelecionado = "-";
            valor1 = double.Parse(caixatexto.Text);
            caixatexto.Clear();
            valorAnterior.Text = Convert.ToString(valor1) + " " + botaoSelecionado;
        }
        private void multiplicacao_Click(object sender, EventArgs e)
        {
            botaoClicado = (Button)sender;
            botaoSelecionado = "*";
            valor1 = double.Parse(caixatexto.Text);
            caixatexto.Clear();
            valorAnterior.Text = Convert.ToString(valor1) + " " + botaoSelecionado;
        }
        private void divisao_Click(object sender, EventArgs e)
        {
            botaoClicado = (Button)sender;
            botaoSelecionado = "/";
            valor1 = double.Parse(caixatexto.Text);
            caixatexto.Clear();
            valorAnterior.Text = Convert.ToString(valor1) + " " + botaoSelecionado;
        }
        private void igualdade_Click(object sender, EventArgs e)
        {
            switch (botaoSelecionado)
            {
                case "+":
                    Double conta =  valor1 + Double.Parse(caixatexto.Text);
                    caixatexto.Text = conta.ToString();
                    break;

                case "-":
                    Double conta1 = valor1 - Double.Parse(caixatexto.Text);
                    caixatexto.Text = conta1.ToString();
                    break;

                case "*":
                    Double conta2 = valor1 * Double.Parse(caixatexto.Text);
                    caixatexto.Text = conta2.ToString();
                    break;

                case "/":
                    Double conta3 = valor1 / Double.Parse(caixatexto.Text);
                    caixatexto.Text = conta3.ToString();
                    break;
            }
        }
        // Fim operadores

        private void numero0_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            caixatexto.Text = caixatexto.Text + botaoClicado.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            caixatexto.Text = caixatexto.Text + botaoClicado.Text;
        }
        private void numero2_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            caixatexto.Text = caixatexto.Text + botaoClicado.Text; 
        }
        private void numero3_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            caixatexto.Text = caixatexto.Text + botaoClicado.Text; 
        }
        private void numero4_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            caixatexto.Text = caixatexto.Text + botaoClicado.Text;  
        }

        private void numero5_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            caixatexto.Text = caixatexto.Text + botaoClicado.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            caixatexto.Text = caixatexto.Text + botaoClicado.Text;  
        }

        private void numero7_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            caixatexto.Text = caixatexto.Text + botaoClicado.Text;  
        }

        private void numero8_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            caixatexto.Text = caixatexto.Text + botaoClicado.Text; 
        }

        private void numero9_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            caixatexto.Text = caixatexto.Text + botaoClicado.Text;   
        }
        
    }
}
