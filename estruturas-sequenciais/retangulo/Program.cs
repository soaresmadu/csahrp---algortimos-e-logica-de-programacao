//Fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o valor da área, perímetro e diagonal deste retângulo, com quatro casas decimais.

using System;
using System.Globalization; 

namespace Programa {
    class Program {
    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;
        double baseRetangulo, altura;

        Console.Write("Base do retangulo: ");
        baseRetangulo = double.Parse(Console.ReadLine(), CI);
        Console.Write("Altura do retangulo: ");
        altura = double.Parse(Console.ReadLine(), CI);

        double area = baseRetangulo * altura;
        double perimetro = (baseRetangulo*2) + (altura*2);
        double diagonal = Math.Sqrt((baseRetangulo*baseRetangulo) + (altura*altura));

        Console.WriteLine("AREA = " + area.ToString("F4", CI));
        Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CI));
        Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));
        
 }
 }
} 
