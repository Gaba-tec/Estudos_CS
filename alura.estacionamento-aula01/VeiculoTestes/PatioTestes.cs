using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Testes
{
	public class PatioTestes
	{
		[Fact(DisplayName ="Teste n° 1")]
		public void ValidaFaturamento()
		{
			//Arrange
			var patio = new Patio();
			var veiculo = new Veiculo();
			veiculo.Proprietario = "Gabriel Miranda";
			veiculo.Cor = "Rosa";
			veiculo.Tipo = TipoVeiculo.Automovel;
			veiculo.Modelo = "Ferrari";
			veiculo.Placa = "asd-9999";

			patio.RegistrarEntradaVeiculo(veiculo);
			patio.RegistrarSaidaVeiculo(veiculo.Placa);

			//Act

			double faturamento = patio.TotalFaturado();

			//Assert

			Assert.Equal(2, faturamento);
		}


		[Theory(DisplayName = "Teste n° 2")]
		[InlineData("Andre Silva", "ASD-1498","Preto","Gol")]
		[InlineData("Jose Silva","POL-9242","Cinza","Fusca")]
		[InlineData("Maria Silva","GDR-6524","Azul","Opala")]
		[InlineData("Pedro Silva", "GDR-0101", "Azul", "Corsa")]

		public void ValidaFaturamentoComVariosVeiculos(string proprietario,string placa, string cor, string modelo)
		{
			//Arrange
			Patio patio = new Patio();
			Veiculo veiculo = new Veiculo();
			veiculo.Proprietario= proprietario;
			veiculo.Placa= placa;
			veiculo.Cor= cor;
			veiculo.Modelo= modelo;
			patio.RegistrarEntradaVeiculo(veiculo);
			patio.RegistrarSaidaVeiculo(veiculo.Placa);			
			//Act
			double faturamento = patio.TotalFaturado();
			//Assert
			Assert.Equal(2,faturamento);
		}

		[Fact(DisplayName = "Teste n° 3",Skip = "Teste ainda não implementado.Ignorar")]

		public void ValidaNomeProprietario()
		{

		}

	}
}
