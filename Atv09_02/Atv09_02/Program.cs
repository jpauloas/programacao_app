using System;
using System.Security.Cryptography;

namespace Atv09_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 2 – Fazer um programa para ler os dados de duas pessoas, depois
                mostrar o nome da pessoa mais velha.*/

            Pessoas nome, idade; /* Classe */

            Pessoas p1 = new Pessoas( );
            Pessoas p2 = new Pessoas( );

            Console.WriteLine("Dados da primeira pessoa: "); 
            Console.WriteLine("Nome: ");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.idade = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            p2.nome = Console.ReadLine( );
            Console.WriteLine("Idade: ");
            p2.idade = double.Parse(Console.ReadLine());

            if (p1.idade > p2.idade) /*Resultado */
            {
                Console.WriteLine($"Pessoas mais velha: {p1.nome}");
            }
            else 
            {
                Console.WriteLine($"Pessoas mais velha: {p2.nome}");
            }


        }
    }
}
