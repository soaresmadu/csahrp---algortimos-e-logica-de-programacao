//Fazer um programa para ler um número inteiro N e depois um vetor de N números reais. Em seguida, mostrar na tela a média aritmética de todos elementos com três casas decimais. Depois mostrar todos os elementos do vetor que estejam abaixo da média, com uma casa decimal cada. 
 
using System;
using System.Globalization;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i;
            double totalVetor, mediaVetor;

            totalVetor = 0;

            Console.Write("Quantos valores vai ter cada vetor? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (i=0; i<N; i++) {
                Console.Write("Digite um número: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            
                totalVetor += vet[i];
            }

            mediaVetor = totalVetor / N;

            Console.WriteLine();
            Console.WriteLine("MÉDIA DO VETOR = " + mediaVetor.ToString("F3", CI));
            Console.WriteLine("ELEMENTOS ABAIXO DA MÉDIA:");

            for (i=0; i<N; i++) {
                if(vet[i] < mediaVetor) {
                    Console.WriteLine(vet[i].ToString("F2", CI));
                }
            }

 }
 }
}