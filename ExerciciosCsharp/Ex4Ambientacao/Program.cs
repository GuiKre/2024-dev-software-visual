Console.WriteLine("Digite uma idade: ");
int idade = Convert.ToInt16(Console.ReadLine());

if( idade >=0 && idade <= 13){
    Console.WriteLine("Criança.");
}else if(idade > 13 && idade <= 18){
    Console.WriteLine("Adolescente.");
}else if(idade > 18 && idade <= 60){
    Console.WriteLine("Adulto.");
}else if(idade > 60){
    Console.WriteLine("Idoso.");
}else{
    Console.WriteLine("Valor inválido.");
}