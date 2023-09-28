using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Fundamentos_Csharp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string pessoaRecebida = "elias;elias@elias.com";

			Cliente cliente = new Cliente();

			//cliente.RetornaEmail(pessoaRecebida);

			//Console.WriteLine(cliente.Email); // SubString e Slipt

			DateTime data = new DateTime();

            Console.WriteLine(data);

			//----

			Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-br", false);

			int ano = 2023;
			int mes = 09;
			int dia = 28;

			int hora = 17;
			int minuto = 48;
			int segundo = 50;

			DateTime dataEntrada = DateTime.Now;

            Console.WriteLine(dataEntrada);

            Console.ReadLine();
		}
	}
}
