//Fazer um programa para ler dois valores inteiros X e Y, e depois mostrar na tela o valor da soma destes números.

using System;

namespace Programa {
    class Program {
    static void Main(string[] args) {

        int x, y, soma;
        
        Console.Write("Digite o valor de X: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor de Y: ");
        y = int.Parse(Console.ReadLine());

        soma = x + y;

        Console.WriteLine("SOMA = " + soma);
        
 }
 }
} 
