using InventarioProduto;
using System;
using System.Globalization;

namespace InventarioProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome:");
            p.Nome = Console.ReadLine();
            Console.Write("Preço:");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidadde do Produto:");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do Produto: {p}");
            Console.WriteLine();

            Console.Write("Insira a quantidade a ser adicionada no estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine($"Dados Atualizados do Produto: {p}");
            Console.WriteLine();

            Console.Write("Insira a quantidade a ser removida do estoque: ");
             qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine($"Dados Atualizados do Produto: {p}");
            Console.WriteLine();
        }
    }
}