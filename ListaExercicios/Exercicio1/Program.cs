using System;

class Exercicio1
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Digite dois numeros inteiros: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int resultado = num1 + num2;


        Console.WriteLine("A soma do valor " + num1 + " com o valor " +  num2 + " eh igual a " + resultado);
    }
}