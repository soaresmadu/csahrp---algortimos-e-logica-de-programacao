//Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo.

using System;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            int N, i, dentro, fora, x;

            dentro = 0;
            fora = 0;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            for (i=0; i<N; i++) {
                    Console.Write("Digite um numero: ");
                    x = int.Parse(Console.ReadLine());

                    if (x >= 10 && x <= 20) {
                        dentro++;
                    }
                    else {
                        fora++;
                    }
            }
            Console.WriteLine(dentro + " DENTRO");
            Console.WriteLine(fora + " FORA");
 }
 }
} 
