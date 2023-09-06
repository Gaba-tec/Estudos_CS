/*
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
*/

// --- COMO FUNCIONA A ESTRUTURA DE DADOS FILA EM C# ---

// Fila Padrão de coleção Genérica
Queue<string> diasSemana = new Queue<string>();
diasSemana.Enqueue("Segunda-Feira");
diasSemana.Enqueue("Terça-Feira");
diasSemana.Enqueue("Quarta-Feira");
diasSemana.Enqueue("Quinta-Feira");
diasSemana.Enqueue("Sexta-Feira");

//Outros Construtores da classe Queue

int[] array1 = new int[] {2,4,6,8};
Queue<int> pares = new Queue<int>(array1);

var lista = new List<string>(){"uva", "pera"};
var frutas = new Queue<string>(lista);

var impares = new Queue<int>(3);
impares.Enqueue(1);
impares.Enqueue(3);
impares.Enqueue(5);

// Propriedades e Métodos

// Propriedade

impares.Count(); // Retorna o total de itens na fila

// Métodos

diasSemana.Enqueue("Sábado"); // Inclui um item no final da fila
diasSemana.Dequeue(); // retorna um item no começo da fila e o remove
diasSemana.Peek(); // retorna o item do inicio da fila sem remover
diasSemana.Contains("Segunda-Feira"); // verifica se o item existe na fila e retorna true ou false
diasSemana.Clear(); // Remove todos os elementos da fila;