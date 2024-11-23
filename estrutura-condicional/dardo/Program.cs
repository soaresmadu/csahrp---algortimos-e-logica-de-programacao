//No arremesso de dardo, o atleta tem três chances para lançar o dardo à maior distância que conseguir. Você deve criar um programa para, dadas as medidas das três tentativas de lançamento, informar qual foi a maior

using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            double a, b, c, maior;
            
            Console.WriteLine("Digite as três distâncias: ");
            a = double.Parse(Console.ReadLine(), CI);
            b = double.Parse(Console.ReadLine(), CI);
            c = double.Parse(Console.ReadLine(), CI);

            if (a > b && a > c) {
                maior = a;
            } else if (b > a && b > c) {
                maior = b;
            } else {
                maior = c;
            }

            Console.Write("MAIOR DISTÂNCIA = " + maior.ToString("F2", CI));

 }
 }
} 
