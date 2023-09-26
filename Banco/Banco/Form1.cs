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
		private int numeroDeContas;


		public void AdicionaConta(Conta conta)
		{
			this.contas[this.numeroDeContas] = conta;
			numeroDeContas++;
			comboContas.Items.Add("Titular: " + conta.Titular.Nome);
		}

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


			foreach (Conta conta in contas)
			{
				comboContas.Items.Add(conta.Titular.Nome);
			}
		}

		private void Deposito(object sender, EventArgs e)
		{
			int indice = comboContas.SelectedIndex;

			string valorDigitado = textoValor.Text;
			double valorOperacao = Convert.ToDouble(valorDigitado);
			contas[indice].Deposita(valorOperacao);
			textoSaldo.Text = Convert.ToString(this.contas[indice].Saldo);
			MessageBox.Show("Sucesso");
		}

		private void botaoSaque_Click(object sender, EventArgs e)
		{
			int indice = comboContas.SelectedIndex;

			string valorDigitado = textoValor.Text;
			double valorOperacao = Convert.ToDouble(valorDigitado);
			contas[indice].Saque(valorOperacao);
			textoSaldo.Text = Convert.ToString(this.contas[indice].Saldo);
			MessageBox.Show("Sucesso");
		}


		private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
		{
			int indice = comboContas.SelectedIndex;

			Conta selecionada = this.contas[indice];
			textoTitular.Text = Convert.ToString(selecionada.Titular.Nome);
			textoSaldo.Text = Convert.ToString(selecionada.Saldo);
			textoNumero.Text = Convert.ToString(selecionada.Numero);
		}
	}
}
