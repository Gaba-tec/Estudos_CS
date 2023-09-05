// Como funcionar a Estrutura de Dados - Pilha

// Instancia da Classe Stack do tipo Genérica
Stack<string> minhaPilha = new Stack<string>();

// Adicionando itens na pilha

minhaPilha.Push("Carta número 01");
minhaPilha.Push("Carta número 02");
minhaPilha.Push("Carta número 03");
minhaPilha.Push("Carta número 04");
minhaPilha.Push("Carta número 05");

// Saída
Console.WriteLine("---TESTANDO O MÉTODO PUSH---");
foreach(string itens in minhaPilha){
    Console.WriteLine(itens);
}

// Removendo itens na pilha
Console.WriteLine("---TESTANDO O MÉTODO POP---");

minhaPilha.Pop(); // Remove o ultimo item adicionado.

foreach(string itens in minhaPilha){
    Console.WriteLine(itens);
}

// Existe também o Método Clear() que exclui todos os elementos da lista.

// Obtendo o elemento superior da pilha

Console.WriteLine("---OBTENDO O ELEMENTO SUPERIOR DA PILHA---");

// Método Peek() retorna o elemento do topo da pilha sem remove-lo

Console.WriteLine(minhaPilha.Peek());

Console.WriteLine("---PROCURANDO ELEMENTOS NA LISTA---");

// Para verificar se o elemento existe na pilha devemos utilizar o método Contains(nomeDoElemento);

if(minhaPilha.Contains("Carta número 03") == true)
{
    Console.WriteLine("O elemento existe dentro da pilha");
}
else
{
    Console.WriteLine("O elemento não existe dentro da pilha");
}

Console.WriteLine("---VERIFICANDO QUANTOS ELEMENTOS EXISTEM DENTRO DA PILHA---");

// Para conferir quantos elementos existem dentro da pilha usamos Count();

Console.WriteLine(minhaPilha.Count());