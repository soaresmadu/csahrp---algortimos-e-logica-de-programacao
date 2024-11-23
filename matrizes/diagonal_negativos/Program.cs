//Fazer um programa para ler um número inteiro N (máximo = 10) e uma matriz quadrada de ordem N contendo números inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz.

using System;
namespace Programa {
    class Program {
        static void Main(string[] args) {

            int N, i, j, cont;

            cont = 0;

            Console.Write("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N,N];

            for (i=0; i<N; i++) {
                for (j=0; j<N; j++) {
                    Console.Write("Elemento [" + i +","+j+"]: ");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (i=0; i<N; i++) {
                for (j=0; j<N; j++) {
                    if(i==j) {
                        Console.Write(mat[i,j] + " ");
                    }
                    if (mat[i,j] < 0) {
                        cont++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont);
 }
 }
} 
