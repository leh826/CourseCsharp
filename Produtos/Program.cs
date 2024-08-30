using Produtos.Entities;
using System.Globalization;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i+1} data");
                Console.Write("Common, used or imported (c/u/i)?");
                char op = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                switch (op)
                {
                    case 'c':
                            list.Add(new Product(name, price));
                            break;
                    case 'u':
                            Console.Write("Manufacture date (DD/MM/YYYY): ");
                            DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                            list.Add(new UsedProduct(name, price,manufactureDate));
                            break;
                    case 'i':
                            Console.Write("Custom fee: ");
                            double customfee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                            list.Add(new ImportedProduct(name, price,customfee));
                            break;
                    default:
                            Console.WriteLine("Inválido!");
                    return;
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product pd in list)
            {
                Console.WriteLine(pd.PriceTag());
            }
        }   
    }
}