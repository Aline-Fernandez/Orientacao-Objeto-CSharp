﻿using System.Globalization;

namespace aumento_salarial_imposto {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
           return SalarioBruto - Imposto;
        }
        public void AumentoSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }
        public override string ToString() {
            return Nome
                + ", R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
