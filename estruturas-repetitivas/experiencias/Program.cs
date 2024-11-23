//Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda para organizar os experimentos de um laboratório o qual ela é responsável. Ela quer saber no final do ano, quantas cobaias foram utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada. Este laboratório em especial utiliza três tipos de cobaias: sapos, ratos e coelhos. Para obter estas informações, ela sabe exatamente o número de experimentos que foram realizados, o tipo de cobaia utilizada e a quantidade de cobaias utilizadas em cada experimento. Faça um programa que leia um valor inteiro N que indica os vários casos de teste que vem a seguir. Cada caso de teste contém um inteiro que representa a quantidade de cobaias utilizadas e uma letra ('C', 'R' ou 'S'), indicando o tipo de cobaia (R:Rato S:Sapo C:Coelho). Apresente o total de cobaias utilizadas, o total de cada tipo de cobaia utilizada e o percentual de cada uma em relação ao total de cobaias utilizadas, sendo que o percentual deve ser apresentado com dois dígitos após o ponto. 

using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i, x, coelhos, ratos, sapos, total;
            char tipo;
            double perCoelho, perRato, perSapo;

            coelhos = 0;
            ratos = 0;
            sapos = 0;
            total = 0;

            Console.Write("Quantos casos de teste serao digitados? ");
            N = int.Parse(Console.ReadLine());

            for (i=0; i<N; i++) {
                Console.Write("Quantidade de cobaias: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Tipo de cobaias: ");
                tipo = char.Parse(Console.ReadLine());

                if (tipo == 'C') {
                    coelhos += x;
                } else if (tipo == 'R') {
                    ratos += x;
                } else if (tipo == 'S') {
                    sapos += x;
                }

                total += x;
            }

            perCoelho = 100.00*coelhos/total;
            perRato = 100.00*ratos/total;
            perSapo = 100.00*sapos/total;

            Console.WriteLine("RELATORIO FINAL: ");
            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);

            Console.WriteLine("Percentual de coelhos: " + perCoelho.ToString("F2", CI) + "%");
            Console.WriteLine("Percentual de ratos: " + perRato.ToString("F2", CI) + "%");
            Console.WriteLine("Percentual de sapos: " + perSapo.ToString("F2", CI) + "%");
 }
 }
} 
