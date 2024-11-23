//Fazer um programa para calcular o troco no processo de pagamento de um produto de uma mercearia. O programa deve ler o preço unitário do produto, a quantidade de unidades compradas deste produto, e o valor em dinheiro dado pelo cliente. Seu programa deve mostrar o valor do troco a ser devolvido ao cliente. Se o dinheiro dado pelo cliente não for suficiente, mostrar uma mensagem informando o valor restante.

using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            double preco, dinheiro, totalProduto, troco, valorFaltante;
            int qtd;

            Console.Write("Preço unitário do produto: ");
            preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            qtd = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            dinheiro = double.Parse(Console.ReadLine(), CI);

            totalProduto = qtd * preco;

            if (dinheiro >= totalProduto) {
                troco = dinheiro - totalProduto;
                Console.Write("TROCO = " + troco.ToString("F2", CI));
            }
            else {
                valorFaltante = totalProduto - dinheiro;
                Console.Write("DINHEIRO INSUFICIENTE. FALTAM R$ " + valorFaltante.ToString("F2", CI));
            }

 }
 }
} 
