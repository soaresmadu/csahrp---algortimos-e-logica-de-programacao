//Fazer um programa para ler um vetor de N números inteiros. Em seguida, mostrar na tela a média aritmética somente dos números pares lidos, com uma casa decimal. Se nenhum número par for digitado, mostrar a mensagem "NENHUM NUMERO PAR"
 
using System;
using System.Globalization;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i, cont;
            double totalPares, mediaPares;

            cont = 0;
            totalPares = 0;

            Console.Write("Quantos elementos vai ter o vetor? ");
            N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];
 
            for (i=0; i<N; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());

                if (vet[i]%2 == 0) {
                    cont++;
                    totalPares += vet[i];
                }
            }    

            Console.WriteLine();
            if (cont == 0) {
                Console.Write("NENHUM NÚMERO PAR");
            } else {
                mediaPares = totalPares / cont;
                Console.WriteLine("MÉDIA DOS PARES = " + mediaPares.ToString("F1", CI));
            }

 }
 }
}
