// See https://aka.ms/new-console-template for more information
public class ListaEncadeada
{
	public ListaEncadeada()
	{
	}

	public void RetornaLista(LinkedList<string> transp)
	{
		foreach (string t in transp)
		{
			Console.WriteLine($"Transportes: {t}");
		}
	}
}