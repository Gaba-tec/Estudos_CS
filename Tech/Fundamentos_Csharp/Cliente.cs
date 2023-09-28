using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp
{
	public class Cliente
	{
		public string Email { get; private set; }

		private string[] dadosCliente;

		public void RetornaEmail(string cliente)
		{
			dadosCliente = cliente.Split(';');

			this.Email = dadosCliente[1];
		}
	}
}
