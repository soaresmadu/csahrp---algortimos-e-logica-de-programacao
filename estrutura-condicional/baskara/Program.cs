//Fazer um programa para ler os três coeficientes de uma equação do segundo grau. Usando a fórmula de Baskara, calcular e mostrar os valores das raízes x1 e x2 da equação com quatro casas decimais. Se a equação não possuir raízes reais, mostrar uma mensagem.

using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            double a, b, c, delta, x1, x2;

            Console.Write("Coeficiente a: ");
            a = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente b: ");
            b = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente c: ");
            c = double.Parse(Console.ReadLine(), CI);

            delta = (b*b) - 4*a*c;

            if (delta < 0) {
                Console.Write("A equação não possui raízes reais.");
            }
            else {
                x1 = ((-b) + Math.Sqrt(delta)) / (2*a);
                x2 = ((-b) - Math.Sqrt(delta)) / (2*a);

                Console.WriteLine("X1 = " + x1.ToString("F4", CI));
                Console.WriteLine("X2 = " + x2.ToString("F4", CI));
            }

 }
 }
} 
