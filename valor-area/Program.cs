using valor_area;
using System.Globalization;

Retangulo retangulo = new Retangulo();

Console.WriteLine("Entre com a largura do retângulo: ");
retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com a altura do retângulo: ");
retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = retangulo.Area();
double perimetro = retangulo.Perimetro();
double diagonal = retangulo.Diagonal();

Console.WriteLine("Área: " + area.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Perímetro: " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Diagonal: " + diagonal.ToString("F2", CultureInfo.InvariantCulture));

