namespace Banco.Conta
{
	public class TotalizadorDeContas
	{
		public double SaldoTotal {get;private set;}

		public void Acumula(Banco.Contas.Conta c)
		{
			this.SaldoTotal += c.Saldo;
		}

	}
}