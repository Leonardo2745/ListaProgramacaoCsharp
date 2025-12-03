// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Digite 4 notas para saber a sua média");

double[] numMedia = new double[4];
double soma = 0;

for (int i = 0; i < numMedia.Length;i++)
{
    Console.WriteLine("Digite o " + (i + 1) + "º número:");
    string entrada = Console.ReadLine();
    double numero = double.Parse(entrada);
    numMedia[i] = numero;
    soma += numero;
}

    Console.WriteLine("A média dos números é " + (soma/numMedia.Length));
