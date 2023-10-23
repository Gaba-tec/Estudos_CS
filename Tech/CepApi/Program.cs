
using CepApi;
using Refit;

class Program
{
	static async Task Main(string[] args)
	{
		try
		{
			var cepClient = RestService.For<ICepApiService>("http://viacep.com.br/ws");
			Console.WriteLine("Informe seu cep:");

			string cepInformado = Console.ReadLine().ToString();
			Console.WriteLine("Consultando informações do cep: " + cepInformado);

			var address = await cepClient.GetAddressAsync(cepInformado);
			Console.WriteLine($"\nLogradouro:{address.Logradouro},\nBairro:{address.Bairro},\nCidade{address.Localidade}");
			Console.ReadKey();

		}
		catch (Exception ex)
		{
			Console.WriteLine("Erro na consulta de cep: " + ex.Message);
		}
	}
}



