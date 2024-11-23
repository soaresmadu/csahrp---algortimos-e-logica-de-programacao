//Fazer um programa para ler dois números inteiros, e dizer se um número é múltiplo do outro. Os números podem ser digitados em qualquer ordem. 

using System;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            int x, y;

            Console.WriteLine("Digite dois números inteiros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x%y == 0 || y%x ==0) {
                Console.Write("Os números são múltiplos entre si.");
            } else {
                Console.Write("Os números não são múltiplos entre si.");
            }
            
 }
 }
} 