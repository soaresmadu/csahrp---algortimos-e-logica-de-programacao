//Fazer um programa para ler dois números inteiros M e N (máximo = 10). Em seguida, ler uma matriz de M linhas e N colunas contendo números reais. Gerar um vetor de modo que cada elemento do vetor seja a soma dos elementos da linha correspondente da matriz. Mostrar o vetor gerado. 

using System;
using System.Globalization;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int M, N, i, j;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            M = int.Parse(Console.ReadLine());

            Console.Write("Qual a quantidade de colunas da matriz? ");
            N = int.Parse(Console.ReadLine());

            double[,] mat = new double[M,N];
            double [] vet = new double[M];

            for(i=0; i<M; i++){
                Console.WriteLine("Digite os elementos da "+(i+1)+"a. linha: ");
                    for (j=0; j<N; j++){
                        mat[i,j] = double.Parse(Console.ReadLine(), CI);
                    }
            }

            for(i=0; i<M; i++){
                double soma = 0;
                for (j=0; j<N; j++){
                    soma += mat[i,j];
                }
                vet[i] = soma;
            }
            
            Console.WriteLine("VETOR GERADO: ");
            for(i=0; i<M; i++){
                Console.WriteLine(vet[i].ToString("F1", CI));
            }
        
 }
 }
} 

