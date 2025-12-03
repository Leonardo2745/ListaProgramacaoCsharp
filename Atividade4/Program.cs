// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um número inteiro para saber o seu fatorial:");

string entrada = Console.ReadLine();
int num = int.Parse(entrada);


int Fatorial(int x)
{
    int fatorial = 1;

    for (int i = 1; i <= x; i++)
    {
        fatorial *= i;
    }

    return fatorial;
}



Console.WriteLine("O fatorial do número " + num + " é : " + Fatorial(num));
