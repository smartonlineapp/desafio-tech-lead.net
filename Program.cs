using System;

namespace Challenge;

class Program
{
    /*
     * Você precisa escrever um programa em C# que verifica se uma palavra ou frase é um palíndromo.
     * Um palíndromo é uma sequência de caracteres que é igual quando lida da esquerda para a direita
     * e da direita para esquerda, ignorando espaços, pontuação e capitalização.
     * Por exemplo, a palavra 'radar' é um palíndromo.
     * O número de interações/computações, não pode ser superior ao tamanho da string.
    */

    static void Main(string[] _)
    {
        string input = "Socorram-me, subi no ônibus em Marrocos!";

        bool isPalindrome = IsPalindrome(input);

        Console.WriteLine(isPalindrome);

        Console.ReadKey();
    }

    static bool IsPalindrome(string str)
    {
        return false;
    }
}
