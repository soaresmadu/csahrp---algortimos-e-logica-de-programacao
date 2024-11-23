//Leia 2 valores inteiros X e Y (em qualquer ordem). A seguir, calcule e mostre a soma dos números impares entre eles.

using System;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            int x, y, troca, i, somaImpares;

            somaImpares = 0;

            Console.WriteLine("Digite dois numeros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y) {
                troca = x;
                x = y;
                y = troca;
            }

            for (i = (x+1); i < y ;i++) {
                if (i % 2 != 0) {
                    somaImpares += i;   
                }
            }

            Console.Write("SOMA DOS IMPARES = " + somaImpares);
        
 }
 }
} 
