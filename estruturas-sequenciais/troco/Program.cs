//Fazer um programa para calcular o troco no processo de pagamento de um produto de uma mercearia. O programa deve ler o preço unitário do produto, a quantidade de //unidades compradas deste produto, e o valor em dinheiro dado pelo cliente (suponha que haja dinheiro suficiente). Seu programa deve mostrar o valor do troco a ser devolvido ao cliente. 

using System;
using System.Globalization; 

namespace Programa {
    class Program {
    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;
        double preco, recebido, troco;
        int qtd;

        Console.Write("Preço unitário do produto: ");
        preco = double.Parse(Console.ReadLine(), CI);
        Console.Write("Quantidade comprada: ");
        qtd = int.Parse(Console.ReadLine());
        Console.Write("Dinheiro recebido: ");
        recebido = double.Parse(Console.ReadLine(), CI);

        troco = recebido - (preco * qtd);

        Console.Write("TROCO = " + troco.ToString("F2", CI));
 }
 }
} 
