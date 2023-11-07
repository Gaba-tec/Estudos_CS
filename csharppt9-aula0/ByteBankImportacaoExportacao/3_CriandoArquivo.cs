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
	}
}