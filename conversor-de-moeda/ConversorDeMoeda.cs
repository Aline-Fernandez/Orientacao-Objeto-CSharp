

namespace conversor_de_moeda {
    internal class ConversorDeMoeda {
        public static double Cota = 3.10;

        public static double Reais(double dolar) {
            return Cota * dolar;
        }
        public static double Iof(double dolar) {
            return Cota * dolar * 1.06;
        }
    }
    
}
