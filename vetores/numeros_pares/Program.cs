//Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela todos os números pares, e também a quantidade de números pares. 

using System;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            int N, i, cont;
            cont = 0;

            Console.Write("Quantos números você vai digitar? ");
            N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];

            for (i=0; i<N; i++) {
                Console.Write("Digite um número: ");
                vet[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine();
            Console.WriteLine("NÚMEROS PARES: ");
            for (i=0; i<N; i++) {
                if (vet[i]%2 == 0) {
                    cont++;
                    Console.Write(vet[i] + "  ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("QUANTIDADE DE PARES = " + cont);

 }
 }
}