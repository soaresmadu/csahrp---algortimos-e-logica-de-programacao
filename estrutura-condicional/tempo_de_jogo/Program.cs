//Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas. 

using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int inicial, final, duracao;

            Console.Write("Hora inicial: ");
            inicial = int.Parse(Console.ReadLine());
            Console.Write("Hora final: ");
            final = int.Parse(Console.ReadLine());
            
            if (final > inicial) {
                duracao = final - inicial;
            } else {
                duracao = (24 - inicial) + final;
            }  

            Console.Write("O JOGO DUROU " + duracao + " HORA(S)");
            
 }
 }
} 

