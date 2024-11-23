//Uma lanchonete possui vários produtos. Cada produto possui um código e um preço. Você deve fazer um programa para ler o código e a quantidade comprada de um produto (suponha um código válido), e daí informar qual o valor a ser pago, com duas casas decimais

using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            int codigo, qtd;
            double preco, valorTotal;

            Console.Write("Codigo do produto comprado: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Qauntidade comprada: ");
            qtd = int.Parse(Console.ReadLine());

            if (codigo == 1) {
                valorTotal = qtd * 5.00;
            } else if (codigo == 2) {
                valorTotal = qtd * 3.50;
            } else if (codigo == 3) {
                valorTotal = qtd * 4.80;
            } else if (codigo == 4) {
                valorTotal = qtd * 8.90;
            } else {
                valorTotal = qtd * 7.32;
            }

            Console.Write("Valor a pagar: R$ " + valorTotal.ToString("F2", CI));
            
 }
 }
} 