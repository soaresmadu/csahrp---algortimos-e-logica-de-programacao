//Leia um valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, para os quais você deverá calcular e mostrar a média ponderada, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5. Vale lembrar que a média ponderada é a soma de todos os valores multiplicados pelo seu respectivo peso, dividida pela soma dos pesos. 

using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i;
            double x, y, z, media;

            Console.Write("Quantos casos voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            for (i=0; i<N; i++) {
                
                Console.WriteLine("Digite tres numeros: ");
                x = double.Parse(Console.ReadLine(), CI);
                y = double.Parse(Console.ReadLine(), CI);
                z = double.Parse(Console.ReadLine(), CI);

                media = ((x*2) + (y*3) + (z*5)) / 10;

                Console.WriteLine("MÉDIA = " + media.ToString("F1", CI));

            }
 }
 }
} 