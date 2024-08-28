int tamanho = 100;
int[] vetor = new int[tamanho];

Random random = new Random();
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = random.Next(1000);
}

for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

bool troca = false;
do
{
        troca = false;
        for(int i = 0; i < vetor.Length - 1; i++)
        {
            if(vetor[i] > vetor[i + 1])
            {
                int aux = vetor[i];
                vetor[i] = vetor[i + 1];
                vetor[i + 1] = aux;
                troca = true;
            }
        }   
} while (troca == true);

Console.WriteLine("\n");
for(int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}