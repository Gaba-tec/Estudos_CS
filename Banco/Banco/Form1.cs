using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;

namespace Banco
{
	public partial class Form1 : Form
	{

		private Banco.Contas.Conta[] contas;
		private int numeroDeContas;


		public void AdicionaConta(Banco.Contas.Conta conta)
		{
			this.contas[this.numeroDeContas] = conta;
			numeroDeContas++;
			comboContas.Items.Add("Titular: " + conta.Titular.Nome);
			ContaInvestimento investimento = new ContaInvestimento();
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.contas = new Banco.Contas.Conta[10];

			Banco.Contas.Conta c1 = new ContaCorrente();
			c1.Titular = new Cliente("victor");
			c1.Numero = 1;
			this.AdicionaConta(c1);

			Banco.Contas.Conta c2 = new ContaPoupanca();
			c2.Titular = new Cliente("mauricio");
			c2.Numero = 2;
			this.AdicionaConta(c2);

			Banco.Contas.Conta c3 = new ContaCorrente();
			c3.Titular = new Cliente("osni");
			c3.Numero = 3;
			this.AdicionaConta(c3);
		}

		private void Deposito(object sender, EventArgs e)
		{
			int indice = comboContas.SelectedIndex;

			string valorDigitado = textoValor.Text;
			double valorOperacao = Convert.ToDouble(valorDigitado);
			try
			{
				contas[indice].Deposita(valorOperacao);
				textoSaldo.Text = Convert.ToString(this.contas[indice].Saldo);
				MessageBox.Show("Deposito realizado com sucesso");
			}
			catch(ArgumentException ex)
			{
				MessageBox.Show("Valor invalido");
			}
			
		}

		private void botaoSaque_Click(object sender, EventArgs e)
		{
		
				int indice = comboContas.SelectedIndex;

				string valorDigitado = textoValor.Text;
				double valorOperacao = Convert.ToDouble(valorDigitado);
			
			try
			{
				contas[indice].Saque(valorOperacao);
				textoSaldo.Text = Convert.ToString(this.contas[indice].Saldo);
				MessageBox.Show("Dinheiro Liberado");
			}
			catch(SaldoInsuficienteException ex)
			{
				MessageBox.Show("Saldo insuficiente");
			}
			catch(ArgumentException ax)
			{
				MessageBox.Show("Não é possível sacar um valor negativo");
			}
			
		}


		private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
		{
			int indice = comboContas.SelectedIndex;

			Banco.Contas.Conta selecionada = this.contas[indice];
			textoTitular.Text = Convert.ToString(selecionada.Titular.Nome);
			textoSaldo.Text = Convert.ToString(selecionada.Saldo);
			textoNumero.Text = Convert.ToString(selecionada.Numero);
		}

		private void botaoNovaConta_Click(object sender, EventArgs e)
		{
			FormCadastroConta formCadastroConta = new FormCadastroConta(this);
			formCadastroConta.ShowDialog();
		}

		private void botaoImpostos_Click(object sender, EventArgs e)
		{
			ContaCorrente conta = new ContaCorrente();
			conta.Deposita(200);

			SeguroDeVida sv = new SeguroDeVida();

			TotalizadorDeTributos totalizador = new TotalizadorDeTributos();

			totalizador.Adiciona(conta);

			MessageBox.Show("Total: " + totalizador.Total);
			totalizador.Adiciona(sv);
			MessageBox.Show("Total: " + totalizador.Total);

		}
	}
}
