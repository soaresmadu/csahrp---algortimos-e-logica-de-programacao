//Fazer um programa para ler a distância total (em km) percorrida por um carro, bem como o total de combustível gasto por este carro ao percorrer tal distância. Seu programa deve mostrar o consumo médio do carro, com três casas decimais.

using System;
using System.Globalization; 

namespace Programa {
    class Program {
    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;
        double distancia, combustivel, consumo;

        Console.Write("Distancia Percorrida: ");
        distancia = double.Parse(Console.ReadLine(), CI);
        Console.Write("Combustível Gasto: ");
        combustivel = double.Parse(Console.ReadLine(), CI);

        consumo = distancia / combustivel;

        Console.Write("Consumo médio = " + consumo.ToString("F3", CI));
        
 }
 }
} 
