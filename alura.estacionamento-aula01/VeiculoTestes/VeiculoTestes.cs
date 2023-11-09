using Alura.Estacionamento.Modelos;
using System.Numerics;

namespace Estacionamento.Testes
{
	public class VeiculoTestes
	{
		[Fact]
		public void TestaVeiculoAcelerar()
		{
			//Arrange
			Veiculo veiculo = new Veiculo();

			//Act
			veiculo.Acelerar(10);

			//Assert
			Assert.Equal(100, veiculo.VelocidadeAtual);
		}

		[Fact]
		public void TestaVeiculoFrear()
		{
			//Arrange
			Veiculo veiculo = new Veiculo();

			//Act
			veiculo.Frear(10);

			//Assert
			Assert.Equal(-150,veiculo.VelocidadeAtual);
		}
	}
}