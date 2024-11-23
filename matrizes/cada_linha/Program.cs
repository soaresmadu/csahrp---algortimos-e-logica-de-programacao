//Ler um inteiro N e uma matriz quadrada de ordem N (máximo = 10). Mostrar qual o maior elemento de cada linha. Suponha não haver empates.

using System;
namespace Programa {
    class Program {
        static void Main(string[] args) {

            int N, i, j;

            Console.Write("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (i=0; i<N; i++){
                for(j=0; j<N; j++) {
                    Console.Write("Elemento ["+ i+","+j+"]: ");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }
     
            Console.WriteLine("MAIOR ELEMENTO DE CADA LINHA: ");
            for (i=0; i<N; i++){
                int maior = 0;
                for(j=0; j<N; j++) {
                    if (mat[i,j] > maior) {
                        maior = mat[i,j];
                    }
                }
                Console.WriteLine(maior);
            }
        
 }
 }
} 