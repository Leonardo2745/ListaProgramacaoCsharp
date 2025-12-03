// See https://aka.ms/new-console-template for more information

int[] vetorA = {5, 7, 2, 3, 4};

int[] vetorB = {2, 9, 5, 7, 1};

int[] vetorC = vetorA.Concat(vetorB).ToArray();



for (int i = 0; i < vetorC.Length; i++)  // i vai de 0 até n-2
{
    // Loop interno: percorre o vetor comparando elementos adjacentes
    for (int j = 0; j < vetorC.Length - 1; j++) // "- i" porque o maior já está no final
    {
        // Verifica se o elemento atual é maior que o próximo
        if (vetorC[j] > vetorC[j + 1])
        {
            // Troca os elementos de lugar
            int temp = vetorC[j];
            vetorC[j] = vetorC[j + 1];
            vetorC[j + 1] = temp;
        }
        
    }


}

for (int i =0;i < vetorC.Length; i++)
{
    Console.Write(vetorC[i] + " ");

}


