Console.WriteLine("Digite um número: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite outro número: ");
double n2 = Convert.ToDouble(Console.ReadLine());

if(n1 > n2){
    Console.WriteLine(n1 + " é maior que " + n2 + ".");
}else if(n1 < n2){
    Console.WriteLine(n1 + " é menor que " + n2 + ".");
}else{
    Console.WriteLine("Os dois valores são iguais.");
}