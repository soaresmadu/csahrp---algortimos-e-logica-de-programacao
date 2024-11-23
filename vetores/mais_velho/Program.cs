//Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. Os nomes devem ser armazenados em um vetor, e as idades em um outro vetor. Depois, mostrar na tela o nome da pessoa mais velha.
 
using System;
using System.Globalization;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i, idadeMaior;
            string maisVelho;

            Console.Write("Quantas pessoas você vai digitar? ");
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];

            for (i=0; i<N; i++) {
                Console.WriteLine("Dados da "+(i+1)+"a pessoa:");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
            }
 
            maisVelho = nomes[0];
            idadeMaior = idades[0];

            for (i=0; i<N; i++) {
                if(idades[i] > idadeMaior) {
                    maisVelho = nomes[i];
                    idadeMaior = idades[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pessoa mais velha: " + maisVelho);

 }
 }
}
