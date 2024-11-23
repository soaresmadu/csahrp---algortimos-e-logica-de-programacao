//Leia um valor inteiro N. Este valor será a quantidade de números inteiros que serão lidos em seguida. Para cada valor lido, mostre uma mensagem dizendo se este valor lido é PAR ou IMPAR, e também se é POSITIVO ou NEGATIVO. No caso do valor ser igual a zero (0), seu programa deverá imprimir apenas NULO. 

using System;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            int N, i, x;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            for (i=0; i<N; i++) {
                    Console.Write("Digite um numero: ");
                    x = int.Parse(Console.ReadLine());

                    if (x == 0) {
                        Console.WriteLine("NULO");
                    }   
                    else if (x % 2 == 0 && x > 0) {
                        Console.WriteLine("PAR POSITIVO");
                    }
                    else if (x % 2 == 0 && x < 0) {
                        Console.WriteLine("PAR NEGATIVO");
                    }
                    else if (x % 2 != 0 && x > 0) {
                        Console.WriteLine("ÍMPAR POSITIVO");
                    }
                    else if (x % 2 != 0 && x < 0) {
                        Console.WriteLine("ÍMPAR NEGATIVO");
                    }
            }
 }
 }
} 

