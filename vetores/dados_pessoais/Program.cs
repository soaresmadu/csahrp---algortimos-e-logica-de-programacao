//Tem-se um conjunto de dados contendo a altura e o gênero (M, F) de N pessoas. Fazer um programa que calcule e escreva a maior e a menor altura do grupo, a média de altura das mulheres, e o número de homens. 
 
using System;
using System.Globalization;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i, contHomens, contMulheres;
            double menorAltura, maiorAltura, totalMulheres, mediaMulheres;

            contHomens = 0;
            contMulheres = 0;
            totalMulheres = 0;

            Console.Write("Quantas pessoas serao digitadas? ");
            N = int.Parse(Console.ReadLine());

            double[] alturas = new double[N];
            char[] generos = new char[N];

            for (i=0; i<N; i++){
                Console.Write("Altura da "+(i+1)+"a pessoa: ");
                alturas[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write("Genero da "+(i+1)+"a pessoa: ");
                generos[i] = char.Parse(Console.ReadLine());

                if(generos[i] == 'F'){
                    totalMulheres += alturas[i];
                    contMulheres++;
                } else {
                    contHomens++;
                }
            }

            mediaMulheres = totalMulheres / contMulheres;

            menorAltura = alturas[0];
            maiorAltura = alturas[0];

            for (i=0; i<N; i++){
                if(alturas[i] < menorAltura){
                    menorAltura = alturas[i];
                } else if (alturas[i] > maiorAltura){
                    maiorAltura = alturas[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CI));
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CI));
            Console.WriteLine("Média das alturas das nulheres = " + mediaMulheres.ToString("F2", CI));
            Console.WriteLine("Número de homens = " + contHomens);

 }
 }
}