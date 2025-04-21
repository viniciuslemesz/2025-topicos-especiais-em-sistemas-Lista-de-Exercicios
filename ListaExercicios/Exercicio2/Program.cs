// Tabuada Completa com Laço
//Solicite ao usuário um número e imprima a tabuada completa dele (de 1 a 10),
//utilizando um for.
using System;

public class Exercicio1
{
    public static void Main(string[] args)
    {
       int numero;
       
       Console.Write("Digite um numero: ");
       numero = int.Parse(Console.ReadLine());
   
   for(int i=1;i<=10;i++)
   {
       Console.WriteLine(numero + "x" + i + "= " + numero*i);
   }
   
        
    }
}