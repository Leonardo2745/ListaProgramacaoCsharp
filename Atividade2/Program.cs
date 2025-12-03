// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um número inteiro:");
String entrada = Console.ReadLine();
int num = int.Parse(entrada);

if (num % 2 == 0)
{
    Console.WriteLine("O número " + num + " é par!");
}
else
{
    Console.WriteLine("O número " + num + " é ímpar!");
}
