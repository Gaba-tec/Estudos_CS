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
		static void CriarArquivos()
		{
			var caminhoNovoArquivo = "contasExportadas.csv";

			using(var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
			{
				var contaComString = "456,7895,4785.40, Gustavo Santos";

				var encoding = Encoding.UTF8;

				var bytes = encoding.GetBytes(contaComString);

				fluxoDoArquivo.Write(bytes, 0, bytes.Length);
			}
		}

		static void CriarArquivoComWrite()
		{
			var caminhoArquivo = "contasExportadas.csv";

			using(var fluxoDoArquivo = new FileStream(caminhoArquivo, FileMode.CreateNew))
			using(var escritor = new StreamWriter(fluxoDoArquivo))
			{
				escritor.Write("456,65465,456.0,Pedro");
			}
		}
	}
}