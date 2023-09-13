using System;

namespace Banco
{
	public class Conta
	{

		public int Numero { get; set; }

		public double Saldo { get; protected set; }
		public Cliente Titular { get; internal set; }

		public Conta()
		{

		}

		public virtual void Deposita(double valor)
		{
			this.Saldo += valor;
		}

		public virtual void Saque(double valor)
		{
			if(this.Saldo >= valor)
			{
				this.Saldo -= valor;
			}
			else
			{
				System.Windows.Forms.MessageBox.Show("Saldo Insuficiente!");
			}
		}
	}
}