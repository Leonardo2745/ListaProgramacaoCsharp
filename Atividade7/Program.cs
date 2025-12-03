// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite 10 números inteiros");
int[] vetor = new int[10];
int soma = 0, media = 0, numMaiorMed = 0;

for (int i = 0; i < vetor.Length; i++)
{
    Console.Write("Digite o " + (i + 1) + "º número: ");
    string entrada = Console.ReadLine();
    int num = int.Parse(entrada);
    vetor[i] = num;

    soma += num;

}

media = (soma / vetor.Length);

Console.WriteLine("A média dos números digitados é: " + media);


for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] > media)
    {
        numMaiorMed += 1;
    }
}

Console.Write("Quantidade de números maiores que a média: " + numMaiorMed);