//Fazer um programa para ler três medidas A, B e C. Em seguida, calcular e mostrar (imprimir os dados com quatro casas decimais):
//a) a área do quadrado que tem lado A
//b) a área do triângulo retângulo que base A e altura B
//c) a área do trapézio que tem bases A e B, e altura C

using System;
using System.Globalization; 

namespace Programa {
    class Program {
    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;
        double a, b, c, areaQuadrado, areaTriangulo, areaTrapezio;

        Console.Write("Digite a medida A: ");
        a = double.Parse(Console.ReadLine(), CI);
        Console.Write("Digite a medida B: ");
        b = double.Parse(Console.ReadLine(), CI);
        Console.Write("Digite a medida C: ");
        c = double.Parse(Console.ReadLine(), CI);

        areaQuadrado = a * a;
        areaTriangulo = (a * b) / 2;
        areaTrapezio = ((a+b)*c) / 2;

        Console.WriteLine("AREA DO QUADRADO = " + areaQuadrado.ToString("F4", CI));
        Console.WriteLine("AREA DO TRIANGULO = " + areaTriangulo.ToString("F4", CI));
        Console.WriteLine("AREA DO TRAPEZIO = " + areaTrapezio.ToString("F4", CI));
        
 }
 }
} 

