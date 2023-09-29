using System;

namespace Banco.Contas
{
	public class ContaCorrente:Conta,ITributavel
	{

		private static int totalDeContas = 0;

		public ContaCorrente()
		{
			totalDeContas++;
		}

		public override void Deposita(double valor)
		{
			if (valor < 0.0)
			{
				throw new ArgumentException();
			}
			else
			{
				this.Saldo -= valor - 0.10;
			}
		}

		public override void Saque(double valor)
		{
			if (valor < 0.0)
			{
				throw new ArgumentException();
			}

			if (valor + 0.05 > this.Saldo)
			{
				throw new SaldoInsuficienteException();
			}
			else
			{
				this.Saldo -= valor + 0.05;
			}
			
		}

		public double CalculaTributos()
		{
			return this.Saldo * 0.05;
		}

		public static int ProximaConta()
		{
			return ContaCorrente.totalDeContas + 1;
		}

	}
}