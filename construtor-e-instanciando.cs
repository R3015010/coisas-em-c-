using System;


Produto p1 = new Produto("Notebook", 3500.00, 1);


Console.WriteLine(p1.ToString());


public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto(string nome, double preco, int qtd)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = qtd;
    }

    public override string ToString()
        => $"[Produto] {Nome} | R$ {Preco:F2} | qtd: {Quantidade}";
}
