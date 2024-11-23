//Fazer um programa para ler o valor "r" do raio de um círculo, e depois mostrar o valor da área do círculo com três casas decimais.

using System;
using System.Globalization; 

namespace Programa {
    class Program {
    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;
        double raio, area;

        Console.Write("Digite o valor do raio do circulo: ");
        raio = double.Parse(Console.ReadLine(), CI);

        area = (raio*raio) * 3.14159;

        Console.WriteLine("AREA = " + area.ToString("F3", CI));
        
 }
 }
} 
