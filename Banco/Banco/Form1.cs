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

		private Conta[] contas;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			contas = new Conta[3];

			this.contas[0] = new Conta();
			this.contas[0].Titular = new Cliente("victor");
			this.contas[0].Numero = 1;

			this.contas[1] = new ContaPoupanca();
			this.contas[1].Titular = new Cliente("mauricio");
			this.contas[1].Numero = 2;

			this.contas[2] = new ContaCorrente();
			this.contas[2].Titular = new Cliente("osni");
			this.contas[2].Numero = 3;

			Cliente cliente = new Cliente("Gabriel");


			contas[0].Titular = cliente;

			TotalizadorDeContas totalContas = new TotalizadorDeContas();

			totalContas.Adiciona(contas[0]);

			textoTitular.Text = contas[0].Titular.Nome;
			textoNumero.Text = Convert.ToString(contas[0].Numero);
			textoSaldo.Text = Convert.ToString(contas[0].Saldo);
		}

		private void Deposito(object sender, EventArgs e)
		{
			string valorDigitado = textoValor.Text;
			double valorOperacao = Convert.ToDouble(valorDigitado);
			contas[0].Deposita(valorOperacao);
			textoSaldo.Text = Convert.ToString(this.contas[0].Saldo);
			MessageBox.Show("Sucesso");
		}

		private void botaoSaque_Click(object sender, EventArgs e)
		{
			string valorDigitado = textoValor.Text;
			double valorOperacao = Convert.ToDouble(valorDigitado);
			contas[0].Saque(valorOperacao);
			textoSaldo.Text = Convert.ToString(this.contas[0].Saldo);
			MessageBox.Show("Sucesso");
		}

		private void botaoBusca_Click(object sender, EventArgs e)
		{
			int indice = Convert.ToInt32(textoIndice.Text);
			Conta seleciona = this.contas[indice];
			textoNumero.Text = Convert.ToString(seleciona.Numero);
			textoTitular.Text = seleciona.Titular.Nome;
			textoSaldo.Text = Convert.ToString(seleciona.Saldo);
		}
	}
}
