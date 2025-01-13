namespace ConsoleApp1;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

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
        return $"Dados do produto: {Nome} $ {Preco}, {Quantidade} unidades, Total {ValorTotalEmEstoque()}";
    }
}