using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhasEFilas
{
	public class Fila<T>
	{
		public void Adicionar(T valor)
		{
			var novoNo = new No<T> { Valor = valor };

			if (fim == null)
				fim = inicio = novoNo;
			else
			{
				fim.Proximo = novoNo;
				fim = novoNo;
			}
		}

		public void Remover()
		{
			if (inicio == null)
				throw new Exception("A fila está vazia.");

			inicio = inicio.Proximo;

			if (inicio == null)
				fim = null;
		}

		public T? Primeiro
		{
			get
			{
				if (inicio == null)
					throw new Exception("A fila esta vazia.");

				return inicio.Valor;
			}
		}
		private No<T>? inicio = null;
		private No<T>? fim = null;
	}
}
