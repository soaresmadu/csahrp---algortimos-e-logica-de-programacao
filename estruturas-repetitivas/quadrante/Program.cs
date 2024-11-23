//Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence (Q1, Q2, Q3 ou Q4). O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). 

using System;
using System.Globalization;
namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            double x, y;
            
            Console.WriteLine("Digite os valores das coordenadas X e Y: ");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("QUADRANTE Q1");
                } else if (x < 0 && y > 0) {
                    Console.WriteLine("QUADRANTE Q2");
                } else if (x < 0 && y < 0) {
                    Console.WriteLine("QUADRANTE Q3");
                } else if (x > 0 && y < 0) {
                    Console.WriteLine("QUADRANTE Q4");
                }

                Console.WriteLine("Digite os valores das coordenadas X e Y: ");
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
            }

 }
 }
} 
