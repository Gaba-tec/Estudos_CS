﻿using ByteBankImportacaoExportacao.Modelos;
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
            var endereco = "contas.txt";

            using(var fluxoDeArquivo = new FileStream(endereco, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while(!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    Console.WriteLine(linha);
                }
            }



            Console.ReadLine();
        }

        
    }
} 
 