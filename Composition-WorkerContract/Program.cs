
using ContratosFuncionario.Entities;
using ContratosFuncionario.Entities.Enums;
using System.Globalization;

namespace ContratosFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department´s name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many Ccontracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter #{i+1} contract data: ");
                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration(hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContrats contrats = new HourContrats(date, valuePerHour, hours);
                worker.AddContract(contrats);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string mothAndYear = Console.ReadLine();
            int moth = int.Parse(mothAndYear.Substring(0,2));
            int year = int.Parse(mothAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {mothAndYear}: {worker.Income(year,moth)}");
        }
    }
}

