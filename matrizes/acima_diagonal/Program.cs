//Ler um inteiro N e uma matriz quadrada de ordem N contendo números inteiros. Mostrar a soma dos elementos acima da diagonal principal. Um exemplo de números acima da diagonal principal é mostrado ao lado (no caso as células com fundo cinza).

using System;
namespace Programa {
    class Program {
        static void Main(string[] args) {

            int N, i, j;

            Console.Write("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N,N]; 

            for (i=0; i<N; i++){
                for(j=0; j<N; j++) {
                    Console.Write("Elemento ["+ i+","+j+"]: ");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }

            int soma = 0;

            for (i=0; i<N; i++){
                for(j=0; j<N; j++) {
                    if(j>i) {
                        soma += mat[i,j];
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = " + soma);
        
 }
 }
} 

