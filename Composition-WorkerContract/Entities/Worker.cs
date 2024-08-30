using ContratosFuncionario.Entities.Enums;

namespace ContratosFuncionario.Entities
{
    class Worker
    {
        public string Name {  get; set; }
        public WorkerLevel Level {  get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        
        public List<HourContrats> Contracts { get; set; } = new List<HourContrats>();

        public Worker()
        {
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContrats contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContrats contract)
        {
            Contracts.Remove(contract);
        }
        public double Income ( int year,  int month)
        {
            double sum = BaseSalary;
            foreach (HourContrats contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }

}
