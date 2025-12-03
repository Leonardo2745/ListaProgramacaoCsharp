// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insira a temperatura para ser convertida (ºC):");
string entrada = Console.ReadLine();
double c = double.Parse(entrada);
double f = 0;

f = (c * 1.8 + 32);

Console.WriteLine("A temperatura de " + c + "ºC convertida para Fahrenheit é : " + f + "ºF");

