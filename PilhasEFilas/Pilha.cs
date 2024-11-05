using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhasEFilas
{
	public class Pilha<T>
	{
		public void Empilhar(T valor)
		{
			var novoNo = new No<T>
			{
				Valor = valor,
				Proximo = topo
			};

			topo = novoNo;
		}

		public void Desempilhar()
		{
			if (topo == null)
				throw new Exception("Não é possível desempilhar um no em uma pilha vazia.");

			topo = topo.Proximo;
		}

		public T? Topo
		{
			get
			{
				if (topo == null)
					throw new Exception("Pilha vazia.");

				return topo.Valor;
			}			
		}

		private No<T>? topo = null;
	}
}
