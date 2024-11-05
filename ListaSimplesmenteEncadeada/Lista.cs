using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimplesmenteEncadeada
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
				inicio = novoNo;
		}

		public void AdicionarNoFinal(T valor)
		{
			No<T> novoNo = new() { Valor = valor };

			if (fim == null)
				fim = inicio = novoNo;
			else
			{
				fim.Proximo = novoNo;
				fim = novoNo;
			}
		}

		public void RemoverNoInicio()
		{
			if (inicio == null)
				throw new Exception("Não é possível remover elementos de uma lista vazia.");

			inicio = inicio.Proximo;

			if (inicio == null)
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
				var penultimo = inicio;

				while (penultimo?.Proximo?.Proximo != null)
					penultimo = penultimo.Proximo;

				if (penultimo != null)
					penultimo.Proximo = null;
			}
		}

		public void ParaCada(Action<T?> executar)
		{
			if (inicio == null || fim == null)
				return;

			No<T>? atual;

			atual = inicio;

			while (atual != null)
			{
				executar(atual.Valor);
				atual = atual.Proximo;
			}
		}

		//Na prova, se não conseguir fazer o ParaCada, faça:
		public No<T>? Inicio => inicio;



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
