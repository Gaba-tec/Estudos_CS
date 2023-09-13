namespace Banco
{
	public class ContaPoupanca: Conta
	{
		public ContaPoupanca()
		{
		}

		public override void Saque(double valor)
		{
			this.Saldo -= valor + 0.10;
		}

	}
}