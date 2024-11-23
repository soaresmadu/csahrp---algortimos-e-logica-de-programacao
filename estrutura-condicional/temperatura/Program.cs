//Deseja-se converter uma medida de temperatura da escala Celsius para Fahrenheit ou vice-versa. Para isso, você deve construir um programa que leia a letra "C" ou "F" indicando em qual escala vai ser informada uma temperatura. Em seguida o programa deve mostrar a temperatura na outra escala com duas casas decimais.

using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            double celsius, fahrenheit;
            char temperatura;

            Console.Write("Voce vai digitar a temperatura em qual escala (C/F)? ");
            temperatura = char.Parse(Console.ReadLine());

            if (temperatura == 'F') {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                fahrenheit = double.Parse(Console.ReadLine(), CI);
                celsius = (fahrenheit - 32) / 1.8;
                Console.Write("Temperatura equivalente em Celsius: " + celsius.ToString("F2", CI));
            } else if (temperatura == 'C') {
                Console.Write("Digite a temperatura em Celsius: ");
                celsius = double.Parse(Console.ReadLine(), CI);
                fahrenheit = 1.8*celsius + 32;
                Console.Write("Temperatura equivalente em Fahrenheit: " + fahrenheit.ToString("F2", CI));
            }
 }
 }
} 
