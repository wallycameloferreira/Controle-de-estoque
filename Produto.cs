namespace ConsoleApp1;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public double ValorTotalEmEstoque()
    {
        return Quantidade * Preco;
    }

    public int AdicionarEmEstoque(int quantidade)
    {
        return this.Quantidade += quantidade;
    }

    public void RemoverEmEstoque(int quantidade)
    {
        Quantidade -= quantidade;
    }

    public override string ToString()
    {
        return $"Dados do produto: {Nome} R$ {Preco.ToString("F2")}, {Quantidade} unidades, Total R$ {ValorTotalEmEstoque().ToString("F2")}";
    }
}