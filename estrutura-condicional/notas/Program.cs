//Fazer um programa para ler as duas notas que um aluno obteve no primeiro e segundo semestres de uma disciplina anual. Em seguida, mostrar a nota final que o aluno obteve (com uma casa decimal) no ano juntamente com um texto explicativo. Caso a nota final do aluno seja inferior a 60.00, mostrar a mensagem "REPROVADO".


using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            double nota1, nota2, notaFinal;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CI);

            notaFinal = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CI));
            if (notaFinal < 60) {
                Console.WriteLine("REPROVADO");
            }
 }
 }
} 
