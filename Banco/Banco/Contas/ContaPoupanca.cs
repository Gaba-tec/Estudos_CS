using System;
using System.Linq.Expressions;

namespace Banco.Contas
{
	public class ContaPoupanca: Conta
	{
		public ContaPoupanca()
		{
		}


		public override void Deposita(double valor)
		{
			if (valor < 0.0)
			{
				throw new ArgumentException();
			}
			else
			{
				this.Saldo -= valor - 0.01;
			}
			
		}

		public override void Saque(double valor)
		{

			if(valor < 0.0)
			{
				throw new ArgumentException();
			}

			if(valor + 0.10 > this.Saldo)
			{
				throw new SaldoInsuficienteException();
			}
			else
			{
				this.Saldo -= valor + 0.10;
			}
		}

	}
}