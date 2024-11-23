//Leia os valores das coordenadas X e Y de um ponto no plano cartesiano. A seguir, determine qual o quadrante ao qual pertence o ponto (Q1, Q2, Q3 ou Q4). Se o ponto estiver na origem, escreva a mensagem “Origem”. Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”.

using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            double x, y;

            Console.Write("Valor de X: ");
            x = double.Parse(Console.ReadLine(), CI);
            Console.Write("Valor de Y: ");
            y = double.Parse(Console.ReadLine(), CI);

            if (x > 0 && y > 0) {
                Console.Write("Q1");
            } else if (x < 0 && y > 0) {
                Console.Write("Q2");
            } else if (x < 0 && y < 0) {
                Console.Write("Q3");
            } else if (x > 0 && y < 0) {
                Console.Write("Q4");
            } else if (x==0 && y==0) {
                Console.Write("ORIGEM");
            } else if (x == 0) {
                Console.Write("Eixo Y");
            } else if (y == 0) {
                Console.Write("Eixo X");
            }
 }
 }
} 

