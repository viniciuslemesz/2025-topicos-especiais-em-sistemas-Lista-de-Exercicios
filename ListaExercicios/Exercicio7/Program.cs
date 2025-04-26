using System;

public class Exercicio05
{
    public static void Main(string[] args)
    {
        
        int[] numero = new int[10];
        int i=0, soma=0;
        
        
        
        for(i=0;i<10;i++)
        {
        Console.Write ($"Indice [{i}]: ");
        numero[i] = int.Parse(Console.ReadLine());
        
        if(numero[i] %2 == 0)
        {
            soma += numero[i];
        }
        
        }
        
        Console.WriteLine($"\nSoma dos numeros pares armazenados: {soma}");
        
    }
}