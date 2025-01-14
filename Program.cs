// See https://aka.ms/new-console-template for more information

using System.Globalization;
using ConsoleApp1;



Console.WriteLine("Entre com os dados abaixo");
Console.Write("Nome do produto: ");
string nome = Console.ReadLine();

Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade: ");
int Quantidade = int.Parse(Console.ReadLine());

Produto produto = new Produto(nome, preco, Quantidade);

Console.WriteLine(produto);
Console.Write("Digite o numero a ser adicionado em estoque: ");
produto.AdicionarEmEstoque(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine(produto);
Console.Write("Digite o numero a ser removido em estoque: ");

produto.RemoverEmEstoque(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
Console.WriteLine(produto); 