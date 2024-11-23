//Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida: - Imprimir todos os elementos do vetor - Mostrar na tela a soma e a média dos elementos do vetor.

using System;
using System.Globalization;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i;
            double soma, media;

            soma = 0;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N]; 

            for (i=0; i<N; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);

                soma += vet[i];
            }

            media = soma/N;

            Console.Write("VALORES = ");
            for (i=0; i<N; i++) {
                    Console.Write(vet[i].ToString("F2", CI) + " ");
            }
            Console.WriteLine();
            Console.WriteLine("SOMA = " + soma.ToString("F2", CI));
            Console.WriteLine("MEDIA = " + media.ToString("F2", CI));

 }
 }
}