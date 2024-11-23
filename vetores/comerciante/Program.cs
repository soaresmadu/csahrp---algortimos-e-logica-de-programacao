//Tem-se um conjunto de dados contendo a altura e o gênero (M, F) de N pessoas. Fazer um programa que calcule e escreva a maior e a menor altura do grupo, a média de altura das mulheres, e o número de homens. 
 
using System;
using System.Globalization;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i, abaixo, entre, acima;
            double totalCompra, totalVenda, totalLucro;

            totalCompra = 0;
            totalVenda = 0;
            totalLucro = 0;
            abaixo = 0;
            entre = 0;
            acima = 0;

            Console.Write("Serão digitados dados de quantos produtos? ");
            N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            double[] compra = new double[N];
            double[] venda = new double[N];
            double[] lucro = new double[N];
            double[] porcent = new double[N];

            for (i=0; i<N; i++) {
                Console.WriteLine("Produto "+(i+1)+":");
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Preco de compra: ");
                compra[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write("Preco de venda: ");
                venda[i] = double.Parse(Console.ReadLine(), CI);

                totalCompra += compra[i];
                totalVenda += venda[i];
                lucro[i] = venda[i] - compra[i];
                totalLucro += lucro[i];
            }
            
            for (i=0; i<N; i++) {
                porcent[i] = 100*lucro[i]/compra[i];

                if(porcent[i] < 10) {
                    abaixo++;
                } else if (porcent[i] >= 10 && porcent[i] <= 20) {
                    entre++;
                } else {
                    acima++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("RELATORIO FINAL: ");
            Console.WriteLine("Lucro abaixo de 10%: " + abaixo);
            Console.WriteLine("Lucro entre 10% e 20%: " + entre);
            Console.WriteLine("Lucro acima de 20%: " + acima);
            Console.WriteLine("Valor total de compra: R$" + totalCompra.ToString("F2", CI));
            Console.WriteLine("Valor total de venda: R$" + totalVenda.ToString("F2", CI));
            Console.WriteLine("Lucro total: R$" + totalLucro.ToString("F2", CI));

 }
 }
}