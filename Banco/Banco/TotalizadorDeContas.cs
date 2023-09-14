namespace Banco
{
	public class TotalizadorDeContas
	{
		public double SaldoTotal {get;private set;}

		public void Adiciona(Conta conta)
		{
			this.SaldoTotal += conta.Saldo;
		}

	}
}