﻿using System;

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

		public void Deposita(double valor)
		{
			this.Saldo += valor;
		}

		public void Saque(double valor)
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