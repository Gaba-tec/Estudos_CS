using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosAsync
{
	public class Leite
	{
		public static async Task PegaLeite()
		{
			await Task.Delay(500);
			Console.WriteLine("Comprando o Leite");
			await Task.Delay(1000);
			Console.WriteLine("Voltando para casa com o Leite");
		}
	}
}
