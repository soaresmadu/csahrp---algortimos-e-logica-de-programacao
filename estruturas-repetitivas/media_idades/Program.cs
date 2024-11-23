//Faça um programa para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. O último dado, que não entrará nos cálculos, contém um valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos. Se for entrado um valor negativo na primeira vez, mostrar a mensagem "IMPOSSIVEL CALCULAR"

using System;
using System.Globalization;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int idade, cont;
            double media, soma;

            soma = 0;
            cont = 0;
            
            Console.WriteLine("Digite as idades: ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 0) {
                Console.Write("IMPOSSÍVEL CALCULAR");
            }
            else {
                while (idade >= 0) {
                    soma = soma + idade;
                    cont = cont + 1;
                    idade = int.Parse(Console.ReadLine());
                }

                media = soma / cont;
                Console.Write("MEDIA = " + media.ToString("F2", CI));
            }
 }
 }
} 
