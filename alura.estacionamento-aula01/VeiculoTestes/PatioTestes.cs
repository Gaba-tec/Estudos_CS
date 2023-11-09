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
		[Fact]
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
	}
}
