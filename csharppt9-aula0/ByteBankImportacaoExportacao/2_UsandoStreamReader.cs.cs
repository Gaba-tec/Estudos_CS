using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
	partial class Program
	{
		static void LendoArquivoCsvComStreamReader()
		{
			var endereco = "contas.txt";

			using (var fluxoDeArquivo = new FileStream(endereco, FileMode.Open))
			using (var leitor = new StreamReader(fluxoDeArquivo))
			{
				while (!leitor.EndOfStream)
				{
					var linha = leitor.ReadLine();

					var contaCorrente = ConverterStringParaContaCorrente(linha);

					var msg = $"{contaCorrente.Titular.Nome} : Conta número {contaCorrente.Numero}, ag. {contaCorrente.Agencia}, Saldo {contaCorrente.Saldo}";


					Console.WriteLine(msg);
				}
			}
		}

		static ContaCorrente ConverterStringParaContaCorrente(string linha)
		{
			var campo = linha.Split(',');

			var agencia = campo[0];
			var numero = campo[1];
			var saldo = campo[2].Replace('.', ',');
			var nomeDoTitular = campo[3];

			var agenciaComInt = int.Parse(agencia);
			var numeroComInt = int.Parse(numero);

			var saldoComDouble = double.Parse(saldo);

			Cliente cliente = new Cliente();
			cliente.Nome = nomeDoTitular;

			var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
			resultado.Depositar(saldoComDouble);
			resultado.Titular = cliente;

			return resultado;
		}
	}
}