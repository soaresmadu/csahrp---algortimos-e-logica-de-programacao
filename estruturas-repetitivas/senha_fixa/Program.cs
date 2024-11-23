//Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida! Tente novamente:". Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002. 

using System;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            
            int senha;

            Console.Write("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.Write("Senha Invalida! Tente novamente: ");
                senha = int.Parse(Console.ReadLine()); 
            }

            Console.Write("Acesso permitido!");
 }
 }
} 
