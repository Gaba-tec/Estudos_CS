using System;

namespace Banco.Contas
{
	public abstract class Conta
	{

		public int Numero { get; set; }

		public double Saldo { get; protected set; }
		public Cliente Titular { get; internal set; }

		private static int numeroDeContas;

		public Conta()
		{
			Conta.numeroDeContas++;
			this.Numero = Conta.numeroDeContas;
		}

		public abstract void Deposita(double valor);
	

		public abstract void Saque(double valor);

		public static int ProximaConta()
		{
			return numeroDeContas + 1;
		}
	}
}