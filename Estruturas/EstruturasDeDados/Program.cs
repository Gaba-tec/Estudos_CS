// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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

