Console.WriteLine("Digite um valor positivo inteiro: ");
int valor = Convert.ToInt32(Console.ReadLine());
int anterior = 0;
int atual = 1;   

Console.Write("Sequência de Fibonacci: " + anterior);
while (atual <= valor) {
    Console.Write(", " + atual);
    int proximo = anterior + atual;
    anterior = atual;
    atual = proximo;
}