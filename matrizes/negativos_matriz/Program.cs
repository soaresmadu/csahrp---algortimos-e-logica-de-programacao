//Ler dois números M e N (máximo = 10), e depois ler uma matriz MxN de números inteiros, conforme exemplo. Em seguida, mostrar na tela somente os números negativos da matriz. 

using System;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            int M, N, i, j;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            M = int.Parse(Console.ReadLine());

            Console.Write("Qual a quantidade de colunas da matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M,N];

            for (i=0; i<M; i++){
                for(j=0; j<N; j++) {
                    Console.Write("Elemento ["+ i+","+j+"]: ");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("VALORES NEGATIVOS: ");
            for (i=0; i<M; i++){
                for(j=0; j<N; j++) {
                    if(mat[i,j] < 0){
                        Console.WriteLine(mat[i,j]);
                    }
                }
            }         
        
 }
 }
} 