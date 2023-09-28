// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
ListaEncadeada l = new ListaEncadeada();

LinkedList<string> transp = new LinkedList<string>();

transp.AddFirst("Carro");
transp.AddFirst("Aviao");
transp.AddFirst("Navio");
transp.AddFirst("Motocicleta");

l.RetornaLista(transp);

Console.WriteLine("--ADICIONANDO ITENS NO FIM DA LISTA COM LAST");

transp.AddLast("Bicicleta");

l.RetornaLista(transp);

Console.WriteLine("--Adicionando Node na lista");

LinkedListNode<string> no;

no = transp.FindLast("Navio");
transp.AddAfter(no, "Patinete");

l.RetornaLista(transp);

Console.WriteLine("-- Adicionando um item antes do Node Navio --");

no = transp.FindLast("Carro");
transp.AddBefore(no, "Patins");

l.RetornaLista(transp);

//transp.Clear(); Limpa toda lista

//transp.Find("Carro"); Procura o elemento dentro da lista.

Console.WriteLine("-- REMOVENDO ELEMENTO NAVIO --");

transp.Remove("Navio");

l.RetornaLista(transp);

//transp.RemoveFirst(); Remove o primeiro elemento
//transp.RemoveLast(); Remove o segundo elemento
*/

ArrayStruct arrS = new ArrayStruct();

int[] arr = {1,4,3,2};
int[,] arr2d = { { -1, 1, - 1, 0, 0, 0 },{ 0, - 1, 0, 0, 0, 0 },{ -1, - 1, - 1, 0, 0, 0 },{ 0, - 9, 2, - 4, - 4, 0 },{ -7, 0, 0, - 2, 0, 0 },{ 0, 0, - 1, - 2, - 4, 0 } };

 List<List<int>> myList = new List<List<int>>();

myList.Add(new List<int> { 1, 1, 1, 0, 0, 0 });
myList.Add(new List<int> { 0, 1, 0, 0, 0, 0 });
myList.Add(new List<int> { 1, 1, 1, 0, 0, 0 });
myList.Add(new List<int> { 0, 0, 2, 4, 4, 0 });
myList.Add(new List<int> { 0, 0, 0, 2, 0, 0 });
myList.Add(new List<int> { 0, 0, 1, 2, 4, 0 });

Console.WriteLine(myList[0]);


Console.WriteLine(myList.Count);
Console.WriteLine(myList[0][0]);
Console.WriteLine(arr2d.GetLength(0) - 2);



List<List<int>> queries = new List<List<int>>();

queries.Add(new List<int> { 1, 0, 5 });
queries.Add(new List<int> { 1, 1, 7 });
queries.Add(new List<int> { 1, 0, 3 });
queries.Add(new List<int> { 2, 1, 0 });
queries.Add(new List<int> { 2, 1, 1 });

int n = 2;

arrS.dynamicArray(n, queries);

//arrS.hourglassSum(arr2d);

List<int> list = new List<int>(arr);

//arrS.ReverseArr(list);
