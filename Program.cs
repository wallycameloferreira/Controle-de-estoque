// See https://aka.ms/new-console-template for more information

using System.Globalization;
using ConsoleApp1;

Produto produto = new Produto();

Console.WriteLine("Entre com os dados abaixo");
Console.Write("Nome do produto: ");
produto.Nome = Console.ReadLine();
Console.Write("Preço: ");
produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade: ");
produto.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine(produto.ToString());
Console.Write("Digite o numero a ser adicionado em estoque: ");
produto.AdicionarEmEstoque(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
Console.WriteLine(produto.ToString());
Console.Write("Digite o numero a ser removido em estoque: ");
produto.RemoverEmEstoque(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
Console.WriteLine(produto.ToString());