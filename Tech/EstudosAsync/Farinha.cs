using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosAsync
{
	public class Farinha
	{
		public static async Task PegaFarinha() 
		{
			await Task.Delay(1000);
			Console.WriteLine("Comprando a Farinha");
			await Task.Delay(9000);
			Console.WriteLine("Voltando para casa com a Farinha");
		}
	}
}
