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
		static void LidandoComFileStreamDiretamente()
		{

			var endereco = "contas.txt";

			using (var fluxoDoArquivo = new FileStream(endereco, FileMode.Open))
			{
				var numeroDeBytesLidos = -1;

				var buffer = new byte[1024];

				while (numeroDeBytesLidos != 0)
				{
					numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
					EscreveBuffer(buffer, numeroDeBytesLidos);
				}
			}
		}


		static void EscreveBuffer(byte[] buffer, int bytesLidos)
		{

			var utf8 = Encoding.Default;

			var texto = utf8.GetString(buffer, 0, bytesLidos);

			Console.Write(texto);
		}
	}
}
