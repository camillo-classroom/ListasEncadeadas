using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDuplamenteEncadeada
{
	public class No<T>
	{
		public T? Valor { get; set; }

		public No<T>? Proximo { get; set; }
		public No<T>? Anterior { get; set; }
	}
}
