//Uma operadora de telefonia cobra R$ 50.00 por um plano básico que dá direito a 100 minutos de telefone. Cada minuto que exceder a franquia de 100 minutos custa R$ 2.00. Fazer um programa para ler a quantidade de minutos que uma pessoa consumiu, daí mostrar o valor a ser pago. 

using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            double minutos, valorTotal;

            Console.Write("Digite a quantidade de minutos: ");
            minutos = double.Parse(Console.ReadLine(), CI);

            if (minutos <= 100) {
                valorTotal = 50;
            }
            else {
                valorTotal = ((minutos - 100) * 2) + 50;
            }

            Console.Write("Valor a pagar: R$ " + valorTotal.ToString("F2", CI));
 }
 }
} 
