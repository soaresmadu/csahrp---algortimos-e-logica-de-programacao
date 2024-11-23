//Leia um valor inteiro X. Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.

using System;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            int x, i;

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());

            for (i=1; i<=x; i++) {
                if (i%2 != 0) {
                    Console.WriteLine(i);
                }
            }
        
 }
 }
} 

