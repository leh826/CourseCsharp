using System;
using System.Globalization;

namespace InventarioProduto
{
    class Produto {
       public string Nome;
       public double Preco;
       public int Quantidade;

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return $"{Nome}" +
                $", $ {Preco}" +
                $", {Quantidade} unidades" +
                $", Total: $ " +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
