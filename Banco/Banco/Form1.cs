using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
	public partial class Form1 : Form
	{

		private Conta conta;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.conta = new Conta();

			Cliente cliente = new Cliente("Gabriel");

			conta.Titular = cliente;

			textoTitular.Text = conta.Titular.Nome;
			textoNumero.Text = Convert.ToString(conta.Numero);
			textoSaldo.Text = Convert.ToString(conta.Saldo);
		}

		private void deposito(object sender, EventArgs e)
		{
			string valorDigitado = textoValor.Text;
			double valorOperacao = Convert.ToDouble(valorDigitado);
			conta.Deposita(valorOperacao);
			textoSaldo.Text = Convert.ToString(this.conta.Saldo);
			MessageBox.Show("Sucesso");
		}

		private void botaoSaque_Click(object sender, EventArgs e)
		{
			string valorDigitado = textoValor.Text;
			double valorOperacao = Convert.ToDouble(valorDigitado);
			conta.Saque(valorOperacao);
			textoSaldo.Text = Convert.ToString(this.conta.Saldo);
			MessageBox.Show("Sucesso");
		}
	}
}
