//Fazer um programa para ler um número natural N (valor máximo: 15), e depois calcular e mostrar o fatorial de N. 

using System;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            int N, i;
            double fat;

            fat = 1;

            Console.Write("Quantos casos voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            for (i=1; i<=N; i++) {
                fat *= i;
            }

            Console.Write("FATORIAL = " + fat);
 }
 }
} 