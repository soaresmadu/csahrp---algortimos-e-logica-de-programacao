//Fazer um programa para ler a quantidade de glicose no sangue de uma pessoa e depois mostrar na tela a classificação desta glicose de acordo com a tabela de referência.

using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            double glicose;

            Console.Write("Digite a medida da glicose: ");
            glicose = double.Parse(Console.ReadLine(), CI);

            if (glicose <= 100) {
                Console.Write("Classificacao: Normal");
            } else if (glicose > 100 && glicose <= 140) {
                Console.Write("Classificacao: Elevado");
            } else {
                Console.Write("Classificacao: Diabetes");
            }

 }
 }
} 
