using System;
namespace GeradorDeRetangulo{
class classe{
static void Main(String[] args){

Console.WriteLine("bem vindo ao gerador de retângulo");

Console.Write("insira o número de linhas: ");
int linhas = Convert.ToInt32(Console.ReadLine());

Console.Write("insira o número de colunas: ");
int colunas = Convert.ToInt32(Console.ReadLine());

Console.Write("insira o símbolo ou caracter: ");
String simbolo = Console.ReadLine();


for(int i = 0; i < linhas; i++){

	for(int j = 0; j < colunas; j++){
	Console.Write(simbolo);
	}
	Console.WriteLine();
}

}
}
}