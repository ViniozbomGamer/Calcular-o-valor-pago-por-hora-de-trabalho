using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_o_valor_pago_por_hora_de_trabalho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ValT, ValH, resultado;

            Console.WriteLine("Digite o Salário:");
            ValT = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite as horas trabalhadas:");
            ValH = double.Parse(Console.ReadLine());
            resultado = ValT / ValH;
            Console.WriteLine("Valor pago por hora de trabalho = " + resultado);



            Console.ReadKey();
            
        }
    }
}
