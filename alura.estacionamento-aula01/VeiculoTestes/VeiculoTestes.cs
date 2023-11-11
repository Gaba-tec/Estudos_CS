using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System.Numerics;
using Xunit.Abstractions;

namespace Estacionamento.Testes
{
	public class VeiculoTestes:IDisposable
	{
		public ITestOutputHelper Output { get; }
		private Veiculo veiculo;

		public VeiculoTestes(ITestOutputHelper output)
		{
			Output = output;
			output.WriteLine("Execução do construtor");
			veiculo = new Veiculo();
			veiculo.Tipo = TipoVeiculo.Automovel;
		}

		[Fact]
		public void TestaVeiculoAcelerarComParametro10()
		{
			//Arrange
			//Veiculo veiculo = new Veiculo();

			//Act
			veiculo.Acelerar(10);

			//Assert
			Assert.Equal(100, veiculo.VelocidadeAtual);
		}

		[Fact]
		public void TestaVeiculoFrearComParametro10()
		{
			//Arrange
			//Veiculo veiculo = new Veiculo();

			//Act
			veiculo.Frear(10);

			//Assert
			Assert.Equal(-150,veiculo.VelocidadeAtual);
		}

		[Fact]

		public void FichaInformacaoDoVeiculo()
		{
			//Arrange
			//Veiculo veiculo = new Veiculo();
			veiculo.Proprietario = "José Silva";
			veiculo.Tipo = TipoVeiculo.Automovel;
			veiculo.Placa = "ZXC-8524";
			veiculo.Cor = "Verde";
			veiculo.Modelo = "Opala";

			//Act
			var dados = veiculo.ToString();

			//Assert
			Assert.Contains("Ficha do Veículo",dados);

		}

		public void Dispose()
		{
			Output.WriteLine("Execução do Cleanup: Limpando os objetos.");
		}
	}
}