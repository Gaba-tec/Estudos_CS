namespace Banco
{
	public class TotalizadorDeContas
	{
		public double SaldoTotal {get;private set;}

		public void Acumula(Conta c)
		{
			this.SaldoTotal += c.Saldo;
		}

	}
}