using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1º número: ");
            double n1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número: ");
            double n2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação que você quer utilizar +,-,*,/: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    double valor = n1 + n2;
                    Console.WriteLine("O resultado da sua conta é "+ valor);
                    break;
                case "-":
                    valor = n1 - n2;
                    Console.WriteLine("O resultado da sua conta é "+ valor);
                    break;
                case "*":
                    valor = n1 * n2;
                    Console.WriteLine("O resultado da sua conta é "+ valor);
                    break;
                case "/":
                    valor = n1 / n2;
                    Console.WriteLine("O resultado da sua conta é "+ valor);
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
