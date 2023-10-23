using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosAsync
{
	public class Ovos
	{
		private static int OvosDisponiveis = 12;

		public static async Task<int> PegaOvos()
		{
			await Task.Delay(1000);
			Console.WriteLine("Comprando os Ovos");
			await Task.Delay(2000);
			OvosDisponiveis -= 6;
			Console.WriteLine("Voltando para casa com os ovos");

			return OvosDisponiveis;
		}
	}
}
