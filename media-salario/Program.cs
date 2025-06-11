using System.Globalization;
namespace media_salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DadosFuncionario funcionario1 = new DadosFuncionario();
            DadosFuncionario funcionario2 = new DadosFuncionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine();
            double media = (funcionario1.Salario + funcionario2.Salario) / 2.0;

            Console.WriteLine("A média salarial é: " + media.ToString("F2", CultureInfo.InvariantCulture)); 
            
        }
    }
}
