//Ler uma matriz quadrada de ordem N, contendo números reais. Em seguida, fazer a seguintes ações:
//a) calcular e imprimir a soma de todos os elementos positivos da matriz.
//b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
//c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
//d) imprimir os elementos da diagonal principal da matriz.
//e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada.

using System;
using System.Globalization;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i, j, x, y;
            double somaPositivos;

            somaPositivos = 0;

            Console.Write("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            double[,] mat = new double[N,N]; 

            for (i=0; i<N; i++){
                for(j=0; j<N; j++) {
                    Console.Write("Elemento ["+ i+","+j+"]: ");
                    mat[i,j] = double.Parse(Console.ReadLine());

                    if (mat[i,j] > 0) {
                        somaPositivos += mat[i,j];
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("SOMA DOS POSITIVOS: " + somaPositivos.ToString("F1", CI));

            Console.WriteLine();
            Console.Write("Escolha uma linha: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");
            for (i=x; i<=x; i++){
                for(j=0; j<N; j++) {   
                    Console.Write(mat[i,j].ToString("F1", CI) + "  ");
                }
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Escolha uma coluna: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("COLUNA ESCOLHIDA: ");
            for (i=0; i<N; i++){
                for(j=y; j<=y; j++) {   
                    Console.Write(mat[i,j].ToString("F1", CI) + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (i=0; i<N; i++){
                for(j=0; j<N; j++) {
                    if (i == j){
                        Console.Write(mat[i,j].ToString("F1", CI) + "  ");
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("MATRIZ ALTERADA: ");
             for (i=0; i<N; i++){
                for(j=0; j<N; j++) {
                    if (mat[i,j] < 0){
                        mat[i,j] = Math.Pow(mat[i, j], 2);
                    }
                    Console.Write(mat[i,j].ToString("F1", CI) + "  ");
                }
                Console.WriteLine();
            }   
 }
 }
} 