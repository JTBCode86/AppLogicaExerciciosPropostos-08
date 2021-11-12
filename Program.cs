using System;
using System.Globalization;

namespace AppLogicaExerciciosPropostos_08
{
    /// <summary>
    /// Exercícios sobre Estrutura Condicional (if-else)
    /// Calcular a aliquota de imposto com base no salario
    /// </summary>
    class Program
    {
        public static void aplicaAliquotaImposto(double salario) 
        {
            double imposto;
            if (salario<= 2000.00)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.01)
            {
                imposto = (salario - 2000.00) * 0.08;
            }
            else if (salario <= 4500.00)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do seu salario: ");
            double salario =double.Parse(Console.ReadLine());
            aplicaAliquotaImposto(salario);
            
            Console.ReadLine();
        }
    }
}
