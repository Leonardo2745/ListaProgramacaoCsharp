// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite 5 números:" + "\n");
int[] vetor = new int[5];


for (int i = 0; i < vetor.Length; i++)
{
    Console.Write("Digite o " + (i + 1) + "º número: ");
    string entrada = Console.ReadLine();
    int num = int.Parse(entrada);
    vetor[i] = num;

}

Console.WriteLine("\nOs valores inseridos de trás pra frente são: ");

for(int i = vetor.Length - 1; i >= 0; i--)
{
    Console.Write(vetor[i] + " ");
}



