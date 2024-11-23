//Um posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4, devendo então mostrar a mensagem "MUITO OBRIGADO", bem como as quantidades de cada combustível. 

using System;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            int alcool, gasolina, diesel, codigo;

            alcool = 0;
            gasolina = 0;
            diesel = 0;

            Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
            codigo = int.Parse(Console.ReadLine());

            while (codigo != 4) {
                if (codigo == 1) {
                    alcool++;
                }    
                else if (codigo == 2) {
                    gasolina++;
                }
                else if (codigo == 3) {
                    diesel++;
                }

                Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
 }
 }
} 
