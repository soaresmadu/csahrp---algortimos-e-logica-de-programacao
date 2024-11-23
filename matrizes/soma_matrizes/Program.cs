//Fazer um programa para ler duas matrizes de números inteiros A e B, contendo de M linhas e N colunas cada (M e N máximo = 10). Depois, gerar uma terceira matriz C onde cada elemento desta é a soma dos elementos correspondentes das matrizes originais. Imprimir na tela a matriz gerada. 

using System;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            int M, N, i, j;

            Console.Write("Quantas linhas vai ter cada matriz? ");
            M = int.Parse(Console.ReadLine());

            Console.Write("Quantas colunass vai ter cada matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] matA = new int[M, N];
            int[,] matB = new int[M, N];
            int[,] matC = new int[M, N];

            Console.WriteLine("Digite os valores da matriz A: "); 
            for (i=0; i<M; i++){
                for(j=0; j<N; j++) {
                    Console.Write("Elemento ["+ i+","+j+"]: ");
                    matA[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Digite os valores da matriz B: "); 
            for (i=0; i<M; i++){
                for(j=0; j<N; j++) {
                    Console.Write("Elemento ["+ i+","+j+"]: ");
                    matB[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("MATRIZ GERADA: ");
            for (i=0; i<M; i++){
                for(j=0; j<N; j++) {
                    matC[i,j] = matA[i,j] + matB[i,j];
                    Console.Write(matC[i,j] + " ");
                }
                Console.WriteLine();
            }
 }
 }
} 
