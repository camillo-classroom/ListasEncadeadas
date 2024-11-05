using PilhasEFilas;

var fila = new Fila<int>();
fila.Adicionar(10); //10
Console.WriteLine(fila.Primeiro);
fila.Adicionar(7);  //10 7
Console.WriteLine(fila.Primeiro);
fila.Adicionar(2);  //10 7 2
Console.WriteLine(fila.Primeiro);
fila.Remover();     //7 2
Console.WriteLine(fila.Primeiro);
fila.Remover();     //2
Console.WriteLine(fila.Primeiro);
fila.Remover();     //

//var pilha = new Pilha<int>();
//pilha.Empilhar(10); //10
//Console.WriteLine(pilha.Topo);
//pilha.Empilhar(7);  //7 10
//Console.WriteLine(pilha.Topo);
//pilha.Empilhar(2);  //2 7 10
//Console.WriteLine(pilha.Topo);
//pilha.Desempilhar();//7 10
//Console.WriteLine(pilha.Topo);
//pilha.Desempilhar();//10
//Console.WriteLine(pilha.Topo);
//pilha.Desempilhar();//
