using System.Globalization;

namespace Exercicio02Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario pessoa = new Funcionario();

            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            pessoa.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            pessoa.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(pessoa);
            Console.WriteLine();

            Console.Write("Digite a porcetagem para aumentar o salário: ");
            double porcetagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pessoa.AumentarSalario(porcetagem);

            Console.WriteLine();
            Console.WriteLine(pessoa);

        }
    }
}