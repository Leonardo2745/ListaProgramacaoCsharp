// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite quantos números da sequência de Fibonacci serão mostrados: ");
int n = 0, primeiro = 0, segundo = 1, proximo = 0;

string entrada = Console.ReadLine();
n = int.Parse(entrada);

Console.WriteLine("Os " + n + " primeiros números da sequência de Fibonacci são:");

for (int i = 1; i <= n; i++)
{
    Console.Write(primeiro + " ");
    
    proximo = primeiro + segundo;
    primeiro = segundo;
    segundo = proximo;
}