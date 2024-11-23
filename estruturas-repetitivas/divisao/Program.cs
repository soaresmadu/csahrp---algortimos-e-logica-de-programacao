//Escreva um algoritmo que leia dois números e imprima o resultado da divisão do primeiro pelo segundo. Caso não for possível, mostre a mensagem “DIVISAO IMPOSSIVEL”. 

using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i;
            double x, y, divisao;

            Console.Write("Quantos casos voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            for (i=0; i<N; i++) {
                
                Console.Write("Entre com o numerador: ");
                x = double.Parse(Console.ReadLine(), CI);

                Console.Write("Entre com o  denominador: ");
                y = double.Parse(Console.ReadLine(), CI);

                if (y != 0) {
                    divisao = x / y;
                    Console.WriteLine("DIVISAO = " + divisao.ToString("F2", CI));
                } else {
                    Console.WriteLine("DIVISAO IMPOSSIVEL");
                }
            
            }
 }
 }
} 