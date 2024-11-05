using ListaSimplesmenteEncadeada;

var lista = new Lista<string>();

lista.AdicionarNoInicio("sete");  //7
Imprimir(lista);
lista.AdicionarNoInicio("dez"); //10 7
Imprimir(lista);
lista.AdicionarNoFinal("três");   //10 7 3
Imprimir(lista);
lista.AdicionarNoFinal("cinco");   //10 7 3 5
Imprimir(lista);

lista.RemoverNoInicio();     //7 3 5
Imprimir(lista);



void Imprimir<T>(Lista<T> lista)
{
	//lista.ParaCada(x => Console.Write($"{x}  "));
	var atual = lista.Inicio;

	while (atual != null)
	{
		Console.Write($"{atual.Valor}  ");
		atual = atual.Proximo;
	}

	Console.WriteLine();
}