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

Console.WriteLine("\n");

// Ordenar o vetor usando Bubble Sort
bool troca;
    do
    {
      troca = false;
      for (int i = 0; i < vetor.Length - 1; i++)
    {
        // Trocar valores se necessário
        if (vetor[i] > vetor[i + 1]) 
         {
        int aux = vetor[i];
        vetor[i] = vetor[i + 1];
        vetor[i + 1] = aux;
        troca = true;
        }
     }
        } while (troca == true);

        // Exibir o vetor ordenado
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }

        Console.WriteLine("\n");
  
