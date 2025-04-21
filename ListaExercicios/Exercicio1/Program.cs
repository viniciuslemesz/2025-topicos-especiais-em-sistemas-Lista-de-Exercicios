using System;

public class Exercicio1
{
    public static void Main(string[] args)
    {
        string senha;
        bool temTamanhoMinimo = false;
        bool temMaiuscula = false;
        bool temNumero = false;
        bool temEspecial = false;

        Console.Write("Digite uma senha: ");
        senha = Console.ReadLine();

        if (senha.Length >= 8)
        {
            temTamanhoMinimo = true;
        }

        for (int i = 0; i < senha.Length; i++)
        {
            char c = senha[i];

            if (c >= 'A' && c <= 'Z')
            {
                temMaiuscula = true;
            }

            if (c >= '0' && c <= '9')
            {
                temNumero = true;
            }

            if (c == '@' || c == '!' || c == '#')
            {
                temEspecial = true;
            }
        }

        if (temTamanhoMinimo && temMaiuscula && temNumero && temEspecial)
        {
            Console.WriteLine("Senha forte!");
        }
        else
        {
            Console.WriteLine("Senha fraca. Ela deve conter:");
            if (!temTamanhoMinimo)
            {
                Console.WriteLine("- Pelo menos 8 caracteres");
            }
            if (!temMaiuscula)
            {
                Console.WriteLine("- Pelo menos uma letra maiúscula");
            }
            if (!temNumero)
            {
                Console.WriteLine("- Pelo menos um número");
            }
            if (!temEspecial)
            {
                Console.WriteLine("- Pelo menos um caractere especial (@, !, #)");
            }
        }
    }
}
