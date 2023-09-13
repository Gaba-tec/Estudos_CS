namespace Banco
{
	public class ContaCorrente:Conta
	{

		public override void Deposita(double valor)
		{
			base.Deposita(valor - 0.10);
		}

		public override void Saque(double valor)
		{
			base.Saque(valor + 0.05);
		}

	}
}