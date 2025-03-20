class Program
{

    static void Main(string[] args)
    {

        // Criar vetor de inteiros
        int[] vetor = new int[10];

        // Criar um gerador de números aleatórios
        Random r = new Random();

        // Exibir um número aleatório para teste
        Console.WriteLine(r.Next(1000));
        Console.Write("\n");
        
        // Preencher o vetor com números aleatórios
        for (int i = 0; i < vetor.Length; i++)
        {
        vetor[i] = r.Next(1000);
    
        }

        // Exibir o vetor original
        for (int i = 0; i < vetor.Length; i++)
        {
        Console.Write(vetor[i] + " ");
        }

        Array.Sort(vetor);

        Console.WriteLine("\n");
        // Exibir o vetor ordenado
        for (int i = 0; i < vetor.Length; i++)
        {
        Console.Write(vetor[i] + " ");
        }

        Console.WriteLine("\n");
  
    }

}