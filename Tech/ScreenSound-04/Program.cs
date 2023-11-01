using ScreenSound_04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
	try
	{
		string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
		var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
		musicas[0].ExibirMusica();
	}
	catch (Exception ex)
	{
		Console.WriteLine($"Houve um erro do tipo: {ex.Message}");
	}


	
}
