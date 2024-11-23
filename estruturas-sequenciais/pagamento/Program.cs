//Fazer um programa para ler o nome de um(a) funcionário(a), o valor que ele(a) recebe por hora, e a quantidade de horas trabalhadas por ele(a). Ao final, mostrar o valor do pagamento do funcionário com uma mensagem explicativa.

using System;
using System.Globalization; 

namespace Programa {
    class Program {
    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;
        string nome;
        double valorHora, salario;
        int horas;

        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Valor por hora: ");
        valorHora = double.Parse(Console.ReadLine(), CI);
        Console.Write("Horas trabalhadas: ");
        horas = int.Parse(Console.ReadLine());

        salario = valorHora * horas;

        Console.Write("O pagamento para " + nome + " deve ser R$" + salario.ToString("F2", CI));
        
 }
 }
} 