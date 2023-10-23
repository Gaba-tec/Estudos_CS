using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosAsync
{
	public class Cenoura
	{
		public static async Task PegaCenoura()
		{
			await Task.Delay(1000);
            Console.WriteLine("Comprando a Cenoura");
			await Task.Delay(3000);
			Console.WriteLine("Voltando para casa com as cenouras");
        }
	}
}
