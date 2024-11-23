//Faça um programa que leia um número inteiro positivo N (máximo = 10) e depois N números inteiros e armazene-os em um vetor. Em seguida, mostrar na tela todos os números negativos lidos.

using System;
namespace Programa {
    class Program {
        static void Main(string[] args) {

            int N, i;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            int[] vet = new int[N]; 

            for (i=0; i<N; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("NÚMEROS NEGATIVOS: ");
            for (i=0; i<N; i++) {
                if (vet[i] < 0){
                    Console.WriteLine(vet[i]);
                }
            }
 }
 }
}
