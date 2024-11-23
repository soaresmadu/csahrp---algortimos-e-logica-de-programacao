//Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres. Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir os nomes dos alunos aprovados, considerando aprovados aqueles cuja média das notas seja maior ou igual a 6.0 (seis). 
 
using System;
using System.Globalization;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i;

            Console.Write("Quantos alunos serao digitados? ");
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            double[] nota1 = new double[N];
            double[] nota2 = new double[N];
            double[] media = new double[N];

            for (i=0; i<N; i++){
                Console.WriteLine("Digite nome, primeira e segunda nota do "+(i+1)+"o aluno: ");
                nomes[i] = Console.ReadLine();
                nota1[i] = double.Parse(Console.ReadLine(), CI);
                nota2[i] = double.Parse(Console.ReadLine(), CI);

                media[i] = (nota1[i] + nota2[i]) / 2;
            }
            
            Console.WriteLine();
            Console.WriteLine("Alunos aprovados:");
            for (i=0; i<N; i++){
                if (media[i] >= 6) {
                    Console.WriteLine(nomes[i]);
                }
            }

 }
 }
}