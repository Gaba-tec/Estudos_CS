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
	public partial class FormCadastroConta : Form
	{
		private Form1 formPrincipal;
		private Banco.Contas.Conta[] tiposDeContas = {new ContaCorrente(), new ContaPoupanca()};
	

		public FormCadastroConta(Form1 formPrincipal)
		{
			InitializeComponent();
			this.formPrincipal = formPrincipal;
			this.TipoDeConta();
		}

		private void botaoCadastro_Click(object sender, EventArgs e)
		{
			Banco.Contas.Conta novaConta = tiposDeContas[comboTContas.SelectedIndex];
			novaConta.Titular = new Cliente(textoTit.Text);

			this.formPrincipal.AdicionaConta(novaConta);
		}

		private void TipoDeConta()
		{
			comboTContas.Items.Add(new ContaCorrente());
			comboTContas.Items.Add(new ContaPoupanca());
		}

		private void FormCadastroConta_Load(object sender, EventArgs e)
		{
			textoN.Text = Convert.ToString(Banco.Contas.Conta.ProximaConta());
		}
	}
}
