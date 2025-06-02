
namespace valor_area
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;
        public double Area()
        {
            double a = (Largura * Altura);
            return a;
        }
        public double Perimetro()
        {
            double p = 2 * (Largura + Altura);
            return p;
        }
        public double Diagonal()
        {
            double d = Math.Sqrt((Largura * Largura) + (Altura * Altura));
            return d;
        }
    }
}


