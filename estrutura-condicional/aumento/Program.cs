//Uma empresa vai conceder um aumento percentual de salário aos seus funcionários dependendo de quanto cada pessoa ganha, conforme tabela ao lado. Fazer um programa para ler o salário de uma pessoa, daí mostrar qual o novo salário desta pessoa depois do aumento, quanto foi o aumento e qual foi a porcentagem de aumento. 


using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            double salario, aumento, novoSalario, porcent;

            Console.Write("Digite o salario da pessoa: ");
            salario = double.Parse(Console.ReadLine(), CI);

            if (salario <= 1000) {
                aumento = salario * 0.20;
                novoSalario = salario + aumento;
                Console.WriteLine("Novo salário = " + novoSalario.ToString("F2", CI));
                Console.WriteLine("Aumento = " + aumento.ToString("F2", CI));
                Console.WriteLine("Porcentagem = 20%");
            } else if (salario > 1000 && salario <= 3000) {
                aumento = salario * 0.15;
                novoSalario = salario + aumento;
                Console.WriteLine("Novo salário = " + novoSalario.ToString("F2", CI));
                Console.WriteLine("Aumento = " + aumento.ToString("F2", CI));
                Console.WriteLine("Porcentagem = 15%");
            } else if (salario > 3000 && salario <= 8000) {
                aumento = salario * 0.10;
                novoSalario = salario + aumento;
                Console.WriteLine("Novo salário = " + novoSalario.ToString("F2", CI));
                Console.WriteLine("Aumento = " + aumento.ToString("F2", CI));
                Console.WriteLine("Porcentagem = 10%");
            } else {
                aumento = salario * 0.05;
                novoSalario = salario + aumento;
                Console.WriteLine("Novo salário = " + novoSalario.ToString("F2", CI));
                Console.WriteLine("Aumento = " + aumento.ToString("F2", CI));
                Console.WriteLine("Porcentagem = 5%");
            }
 }
 }
} 

