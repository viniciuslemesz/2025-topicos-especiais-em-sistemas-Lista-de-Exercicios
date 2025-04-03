using System;

class Exercicio2
{
static void Main(string[] args)
{

Console.WriteLine("Digite dois numeros inteiros: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if(num1 > num2){
Console.WriteLine("O segundo numero eh menor que o primeiro.");
}
else if(num2 > num1)
{
    Console.WriteLine("O primeiro numero eh menor que o segundo.");
}
else
{
Console.WriteLine("Os numeros sao iguais.");
}


}

}