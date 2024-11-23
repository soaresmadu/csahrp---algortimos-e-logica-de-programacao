//Fazer um programa para ler nome, idade e altura de N pessoas, conforme exemplo. Depois, mostrar na tela a altura média das pessoas, e mostrar também a porcentagem de pessoas com menos de 16 anos, bem como os nomes dessas pessoas caso houver. 

using System;
using System.Globalization;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i;
            double alturaTotal, alturaMedia, menorDe, percentMenor;

            menorDe = 0;
            alturaTotal = 0;

            Console.Write("Quantas pessoas serao digitadas? ");
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N]; 
            int[] idades = new int[N]; 
            double[] alturas = new double[N]; 

            for (i=0; i<N; i++) {
                Console.WriteLine("Dados da " +(i+1)+ "a pessoa: ");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                alturas[i] = double.Parse(Console.ReadLine(), CI);

                if (idades[i] < 16) {
                    menorDe++;
                }
                alturaTotal += alturas[i];
            }

            alturaMedia = alturaTotal / N;
            percentMenor = (menorDe*100)/N;

            Console.WriteLine();
            Console.WriteLine("Altura média: " + alturaMedia.ToString("F2", CI));
            Console.WriteLine("Pessoas com menos de 16 anos:  " + percentMenor.ToString("F1", CI) + "%");
                for (i=0; i<N; i++) {
                    if(idades[i] < 16) {
                        Console.WriteLine(nomes[i]);
                    }
                }

 }
 }
}