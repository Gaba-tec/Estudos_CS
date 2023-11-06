using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {

            var endereco = "contas.txt";

            var fluxoDoArquivo = new FileStream(endereco, FileMode.Open);

            var numeroDeBytesLidos = -1;

            var buffer = new byte[1024];

            while(numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
				EscreveBuffer(buffer);
			}


            Console.ReadLine();
        }

        static void EscreveBuffer(byte[] buffer)
        {

            var utf8 = Encoding.Default;

            var texto = utf8.GetString(buffer);

            //Console.Write(texto);

            foreach (var meuByte in texto)
            {
                Console.Write(meuByte);
            }
        }
    }
} 
 