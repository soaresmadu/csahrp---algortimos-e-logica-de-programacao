//Fazer um programa para ler uma duração de tempo em segundos, daí imprimir na tela esta duração no formato horas:minutos:segundos. 

using System;
using System.Globalization; 

namespace Programa {
    class Program {
    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;
        int horas, minutos, segundos;

        Console.Write("Digite a duracao em segundos: ");
        segundos = int.Parse(Console.ReadLine());

        horas = segundos / 3600;
        minutos = (segundos % 3600) / 60;
        segundos %= 60;

        Console.WriteLine(horas+":"+minutos+":"+segundos);
 }
 }
} 

