namespace Banco
{
	public class ContaPoupanca: Conta
	{
		public ContaPoupanca()
		{
		}


		public override void Deposita(double valor)
		{
			this.Saldo -= valor - 0.01;
		}

		public override void Saque(double valor)
		{
			this.Saldo -= valor + 0.10;
		}

	}
}