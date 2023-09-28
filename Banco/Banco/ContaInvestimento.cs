namespace Banco
{
	public class ContaInvestimento : Conta, ITributavel
	{
		public ContaInvestimento()
		{
		}

		public override void Deposita(double valor)
		{
			this.Saldo += valor;
		}

		public override void Saque(double valor)
		{
			this.Saldo -= valor;
		}

		public double CalculaTributos()
		{
			return this.Saldo * 0.03;
		}
	}
}