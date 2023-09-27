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
	public partial class FormCadastroConta : Form
	{
		private Form1 formPrincipal;
		private Conta[] tiposDeContas = {new Conta(), new ContaCorrente(), new ContaPoupanca()};
	

		public FormCadastroConta(Form1 formPrincipal)
		{
			InitializeComponent();
			this.formPrincipal = formPrincipal;
			this.TipoDeConta();
		}

		private void botaoCadastro_Click(object sender, EventArgs e)
		{
			Conta novaConta = tiposDeContas[comboTContas.SelectedIndex];
			novaConta.Titular = new Cliente(textoTit.Text);
			novaConta.Numero = Convert.ToInt32(textoN.Text);

			this.formPrincipal.AdicionaConta(novaConta);
		}

		private void TipoDeConta()
		{
			comboTContas.Items.Add(new Conta());
			comboTContas.Items.Add(new ContaCorrente());
			comboTContas.Items.Add(new ContaPoupanca());
		}
	}
}
