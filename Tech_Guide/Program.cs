DadosCliente cliente = new DadosCliente();

string pessoaRecebida = "elias;elias@elias.com";

cliente.ClienteEmail(pessoaRecebida);

Console.WriteLine(cliente.Email);
