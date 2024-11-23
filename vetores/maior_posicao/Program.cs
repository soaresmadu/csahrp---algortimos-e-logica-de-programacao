//Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número do vetor (supor não haver empates). Mostrar também a posição do maior elemento, considerando a primeira posição como 0 (zero). 
 
using System;
using System.Globalization;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i, posicaoMaior;
            double maiorValor;

            Console.Write("Quantos números você vai digitar? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (i=0; i<N; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            maiorValor = vet[0];
            posicaoMaior = 0;

            for (i=0; i<N; i++) {
                if (vet[i] > maiorValor) {
                    maiorValor = vet[i];
                    posicaoMaior = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("MAIOR VALOR = " + maiorValor.ToString("F1", CI));
            Console.WriteLine("POSIÇÃO DO MAIOR VALOR = " + posicaoMaior);

 }
 }
}