using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDuplamenteEncadeada
{
	public class Lista<T>
	{
		public void AdicionarNoInicio(T valor)
		{
			var novoNo = new No<T>
			{
				Valor = valor,
				Proximo = inicio
			};

			if (inicio == null)
				fim = inicio = novoNo;
			else
			{
				inicio.Anterior = novoNo;
				inicio = novoNo;
			}
		}

		public void AdicionarNoFinal(T valor)
		{
			No<T> novoNo = new() { Valor = valor };

			if (fim == null)
				fim = inicio = novoNo;
			else
			{
				novoNo.Anterior = fim;
				fim.Proximo = novoNo;
				fim = novoNo;
			}
		}

		public void RemoverNoInicio()
		{
			if (inicio == null)
				throw new Exception("Não é possível remover elementos de uma lista vazia.");

			inicio = inicio.Proximo;

			if (inicio != null)
				inicio.Anterior = null;
			else
				fim = null;
		}

		public void RemoverNoFinal()
		{
			if (fim == null)
				throw new Exception("Não é possível remover elementos de uma lista vazia.");

			if (inicio?.Proximo == null)
				fim = inicio = null;
			else
			{
				fim = fim.Anterior;
				
				if (fim != null)
					fim.Proximo = null;
			}
		}

		public void ParaCada(Action<T?> executar, bool ordemInversa = false)
		{
			if (inicio == null || fim == null)
				return;

			No<T>? atual;

			if (ordemInversa)
			{
				atual = fim;

				while (atual != null)
				{
					executar(atual.Valor);
					atual = atual.Anterior;
				}
			}
			else
			{
				atual = inicio;

				while (atual != null)
				{
					executar(atual.Valor);
					atual = atual.Proximo;
				}
			}
		}

		//public No? Inicio { get {  return inicio; } }

		private No<T>? inicio = null;
		private No<T>? fim = null;
	}
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ListaSimplesmenteEncadeada
//{
//	public class Lista<T>
//	{
//		public void AdicionarNoInicio(T valor)
//		{
//			var novoNo = new No<T>
//			{
//				Valor = valor,
//				Proximo = inicio
//			};

//			inicio = novoNo;
//		}

//		public void AdicionarNoFinal(T valor)
//		{
//			No<T> novoNo = new() { Valor = valor };

//			if (inicio == null)
//				inicio = novoNo;
//			else
//			{
//				var ultimo = inicio;

//				while (ultimo.Proximo != null)
//					ultimo = ultimo.Proximo;

//				ultimo.Proximo = novoNo;
//			}
//		}

//		public void RemoverNoInicio()
//		{
//			if (inicio == null)
//				throw new Exception("Não é possível remover elementos de uma lista vazia.");

//			inicio = inicio.Proximo;
//		}

//		public void RemoverNoFinal()
//		{
//			if (inicio == null)
//				throw new Exception("Não é possível remover elementos de uma lista vazia.");

//			var penultimo = inicio;

//			if (penultimo.Proximo == null)
//				inicio = null;
//			else
//			{
//				while (penultimo?.Proximo?.Proximo != null)
//				{
//					penultimo = penultimo.Proximo;
//				}

//				if (penultimo != null)
//					penultimo.Proximo = null;
//			}
//		}

//		public void ParaCada(Action<T?> executar)
//		{
//			var atual = inicio;

//			while (atual != null)
//			{
//				executar(atual.Valor);
//				atual = atual.Proximo;
//			}
//		}

//		//public No? Inicio { get {  return inicio; } }

//		private No<T>? inicio = null;
//	}
//}
