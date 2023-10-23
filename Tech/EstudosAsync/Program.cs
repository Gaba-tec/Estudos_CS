using EstudosAsync;
using System.Runtime.CompilerServices;


static async Task Main(string[] args)
{
	await CompraIngredientes();
	await TesteAsync();
}

await Main(args);
Teste();


 static async Task CompraIngredientes()
{
	Console.WriteLine("Iniciando Programa de busca de ingredientes...");
	Console.WriteLine("Comprando Ingredientes, por favor aguarde...");
	var tasks = new List<Task>();
	tasks.Add(Farinha.PegaFarinha());
	tasks.Add(Cenoura.PegaCenoura());
	tasks.Add(Leite.PegaLeite());
	tasks.Add(Ovos.PegaOvos());

	await Task.WhenAll(tasks.ToArray());

}

static void Teste()
{
    Console.WriteLine("Testando o método Teste");
	for(int i = 1; i <= 10; i++)
	{
        Console.WriteLine(i);
    }
}

static async Task TesteAsync()
{
	Console.WriteLine("Entrando no método de teste Async");
    await Task.Delay(10000);
	Console.WriteLine("Saindo do método de teste Async");

}



