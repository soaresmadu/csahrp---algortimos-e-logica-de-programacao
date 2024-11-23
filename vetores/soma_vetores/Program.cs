//Faça um programa para ler dois vetores A e B, contendo N elementos (inteiros) cada. Em seguida, gere um terceiro vetor C onde cada elemento de C é a soma dos elementos correspondentes de A e B. Imprima o vetor C gerado.
 
using System;
namespace Programa {
    class Program {
        static void Main(string[] args) {

            int N, i;

            Console.Write("Quantos valores vai ter cada vetor? ");
            N = int.Parse(Console.ReadLine());

            int[] vetA = new int[N];
            int[] vetB = new int[N];
            int[] vetC = new int[N];

            Console.WriteLine("Digite os valores do vetor A:");
            for (i=0; i<N; i++){
                vetA[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os valores do vetor B:");
            for (i=0; i<N; i++){
                vetB[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("VETOR RESULTANTE: ");
            for (i=0; i<N; i++) {
                vetC[i] = (vetA[i] + vetB[i]);

                Console.WriteLine(vetC[i]);
            }

 }
 }
}
