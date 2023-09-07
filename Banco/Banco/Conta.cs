namespace Banco
{
	public class Conta
	{

		public int Numero { get; set; }

		public double Saldo { get; private set; }
		public Cliente Titular { get; internal set; }

		public Conta()
		{

		}
	}
}