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
        static void Main(string[] args) 
        {

			//Criando e escrevendo em um arquivo
			File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

			Console.WriteLine("Arquivo escrevendoComAClasseFile criado!");



			//Lendo todos os bytes
			var bytesArquivo = File.ReadAllBytes("contas.txt");
			Console.WriteLine($"Arquivo contas.txt possui{bytesArquivo.Length} bytes");



			// Lendo todas as linhas de um arquivo
			var linhas = File.ReadAllLines("contas.txt");
			Console.WriteLine(linhas.Length);

			foreach (var linha in linhas)
			{
				Console.WriteLine(linha);
			}

			Console.WriteLine("Aplicação finalizada...");

			Console.ReadLine();
		}

	}
} 
 