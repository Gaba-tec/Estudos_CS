class ListaEncadeada
{
    // LISTA DUPLAMENTE ENCADEADA 

    LinkedList<String> transp = new LinkedList<String>();
    
    transp.AddFirst("Carro");
    transp.AddFirst("Aviao");
    transp.AddFirst("Navio");
    transp.AddFirst("Motocicleta");

    foreach (string t in transp)
    {
        Console.WriteLine($"Transportes: {t}");
    }

    
}