using System.Globalization;


namespace Exercicio02Classes
{
     class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario( double perct)
        {
            SalarioBruto += SalarioBruto * ( perct/100);
        }

        public override string ToString()
        {
            return $"Funcionário : {Nome}, $ {SalarioLiquido().ToString(("F2"), CultureInfo.InvariantCulture)}";
        }
    }
}
