namespace Banco
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
			this.Saldo -= valor - 0.10;
		}

		public override void Saque(double valor)
		{
			this.Saldo -= valor + 0.05;
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