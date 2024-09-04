Console.WriteLine("Digite um valor em real(R$): ");
double valor = Convert.ToDouble(Console.ReadLine());
double valorDolar = valor / 5.17;
double valorEuro = valor / 6.14;
double valorPeso = valor / 0.05;
Console.WriteLine("Valor convertido em:\nDolar: " + valorDolar + "\nEuro: " + valorEuro + "\nPasos Argentinos: " + valorPeso);