using System.Globalization;
using conversos_de_moeda;

namespace conversor_dolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos dólares você vai comprar? ");            
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double real = ConversorDeMoeda.Reais(dolar);
            double iof = ConversorDeMoeda.Iof(dolar);

            Console.WriteLine("Valor da cóta do dólar: " + ConversorDeMoeda.Cota.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor a ser pago em reais: " + iof.ToString("F2", CultureInfo.InvariantCulture));

           
        }
    }
}
