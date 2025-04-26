using System;

public class Exercicio1
{
    public static void Main(string[] args)
    {
        // Declarando variaveis a serem usadas.
        // Usando tipo bool para verificação, inicializando com false e alterando para true caso contenha as condições requisitadas
        string senha;
        bool verificarTamanho = false;
        bool verificarMaiuscula = false;
        bool verificarNumero = false;
        bool verificarCaracterEspecial = false;

        Console.WriteLine("---CADASTRO DE SENHA---");
        Console.Write("Digite uma senha: ");
        // Lendo a mensagem e armazenando em uma variavel 'senha'
        senha = Console.ReadLine(); 

        // verificando se mensagem armazenada na variavel 'senha' possui pelo menos 8 caracteres, caso seja verdade a variavel verificarTamanho se torna "true".
        if (senha.Length > 7)
        {
            verificarTamanho = true;
        }


// Utilizando o tamanho(Length) da variavel 'senha' para percorrer a quantidade de caracteres existente
// i como contador
        for (int i = 0; i < senha.Length; i++)
{
    
    //Colocando cada caracter da posição atual da variavel 'senha' dentro de uma variavel 'caracter' para que assim seja feita as verificações em cada caracter individualmente
    char caracter = senha[i];

    if (char.IsUpper(caracter))
    {
        verificarMaiuscula = true;
    }

    if (char.IsDigit(caracter))
    {
        verificarNumero = true;
    }

    if ("!@#$%¨&*".Contains(caracter))
    {
        verificarCaracterEspecial = true;
    }
}

        // Condicional verifica se as variaveis para verificação são verdadeiras, por ser do tipo boolean estou verificando se é true (caso a verificação fosse para false adicionaria o '!' antes da variavel)
        if (verificarTamanho && verificarMaiuscula && verificarNumero && verificarCaracterEspecial)
        {
            Console.WriteLine("/-------/\nSenha forte cadastrada.");
        }
        else
        {
            // else para uma mensagem fora das condições do if
            Console.WriteLine("/-------/\nSenha fraca, deve conter:");
            // uso do '!' antes das variaveis do tipo boolean para verificar se são falsas, informando mensagens especificas.
            if (!verificarTamanho)
            {
                Console.WriteLine("- 8 caracteres");
            }
            if (!verificarMaiuscula)
            {
                Console.WriteLine("- Letra maiuscula");
            }
            if (!verificarNumero)
            {
                Console.WriteLine("- Numero");
            }
            if (!verificarCaracterEspecial)
            {
                Console.WriteLine("- Caractere especial");
            }
        }
    }
}
