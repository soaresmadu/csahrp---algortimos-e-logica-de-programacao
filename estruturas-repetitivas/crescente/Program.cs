//Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada X e Y uma mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente. O programa deve finalizar quando forem digitados dois valores iguais

using System;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            int x, y;

            Console.WriteLine("Digite dois números: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y) {
                if(x > y) {
                    Console.WriteLine("DECRESCENTE!");
                }
                else {
                    Console.WriteLine("CRESCENTE!");
                }

                Console.WriteLine("Digite outros dois números: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
 }
 }
} 
