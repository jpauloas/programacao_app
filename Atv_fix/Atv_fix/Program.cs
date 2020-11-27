using System;
using System.Globalization;

namespace Atv_fix
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Utilizando vetor e foreach: 
            //  1) Crie um programa que leia 6 valores inteiros e, em seguida, mostre na tela os valores lidos.
            
            Console.WriteLine(" Programa que leia 6 valores inteiros e, em seguida, mostre na tela os valores lidos.");
            int[] q1 = new int[6];
            int cont;
            int a;
            for (cont = 0; cont < 6; cont++ )
            {
                Console.WriteLine($"Digite o valor do {cont}º numero");
                q1[cont] = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine(" ");
            Console.WriteLine($"Você digitou os seguintes valores");
            Console.WriteLine(" ");

            foreach (int c in q1)
            {
                Console.WriteLine(c);
                Console.WriteLine(" ");

            }


            //  2) Crie um programa que leia 6 nomes e, em seguida, mostre na tela os valores lidos. */

            Console.WriteLine(" Programa que leia 6 nomes inteiros e, em seguida, mostre na tela os valores lidos.");
            string[] q2 = new string[6];
            
            for (cont = 0; cont < 6; cont++)
            {
                Console.WriteLine($"Digite o valor do {cont}º numero");
                q2[cont] = Console.ReadLine();
            }

            Console.WriteLine(" ");
            Console.WriteLine($"Você digitou os seguintes valores");
            Console.WriteLine(" ");

            foreach (string c in q2)
            {
                Console.WriteLine(c);
                Console.WriteLine(" ");
            }

        }
    }
}
