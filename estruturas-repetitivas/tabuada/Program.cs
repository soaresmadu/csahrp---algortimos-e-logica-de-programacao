//Ler um número inteiro N, daí mostrar na tela a tabuada de N para 1 a 10, conforme exemplo.

using System;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            int N, i;

            Console.Write("Deseja a tabuada para qual valor? ");
            N = int.Parse(Console.ReadLine());

            for (i=1;i<=10;i++) {
                Console.WriteLine(N + " x " + i + " = " + (N*i));
            }

 }
 }
} 