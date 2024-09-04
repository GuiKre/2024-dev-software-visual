int[] vetor = new int[1000];
Random random = new Random();

for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = random.Next(1, 10001);
}

BubbleSort(vetor);

Console.WriteLine("Vetor ordenado (Bubble Sort):");
foreach (int valor in vetor)
{
    Console.Write(valor + " ");
}

Console.WriteLine();

static void BubbleSort(int[] vetor){
    int n = vetor.Length;
    bool trocou;

    for (int i = 0; i < n - 1; i++){
        trocou = false;
        for (int j = 0; j < n - i - 1; j++)
        {
            if (vetor[j] > vetor[j + 1])
            {
                int temp = vetor[j];
                vetor[j] = vetor[j + 1];
                vetor[j + 1] = temp;
                trocou = true;
            }
        }

        if (!trocou){
            break;
        }
    }
}

Console.WriteLine();
Console.WriteLine();

int[] vetor2 = new int[1000];
Random random2 = new Random();

for (int i = 0; i < vetor.Length; i++)
{
    vetor2[i] = random2.Next(1, 10001); 
}

Array.Sort(vetor2);

Console.WriteLine("Vetor ordenado (Array.Sort):");
foreach (int valor in vetor2)
{
    Console.Write(valor + " ");
}