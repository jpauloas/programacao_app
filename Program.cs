using System;
using System.Collections.Generic;

namespace Atv20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* 1) Crie uma lista com 10 livros.
                2) Utilize cada um dos métodos estudadas hoje.
                3) Utilizando POO. Crie um programa que solicite dados para bebidas. */

            List<string> ListaQ1 = new List<string>() {"Orgulho e Preconceito", "O Pequeno Príncipe",
                                                        "1984", "Dom Quixote de la Mancha", "Dom Casmurro",
                                                        "O Conde de Monte Cristo", "Um Estudo em Vermelho",
                                                         " O Processo", " Cem Anos de Solidão", "Eu, Robô",
                                                        "Guerra e Paz ", "Grande Sertão: Veredas", "A Redoma de Vidro",
                                                         "A Hora da Estrela", "Ensaio Sobre a Cegueira " };

            ListaQ1.Insert(6, "O Banquete"); // Adiciona um novo elemendo na 6º posição 
            ListaQ1.Add("Hamlet "); // Adcionar um novo elemrnto a lista na ultima posição

            string q2 = ListaQ1.Find(x => x[0] == 'O'); // busca pelos elementos da lista que começam por O
            string ultimo_com_G = ListaQ1.FindLast(x => x[0] == 'G'); Console.WriteLine(q2); // encontra o ultimo elemento
            int primeiro_com_G = ListaQ1.FindIndex(x => x[0] == 'G');  // busca aqueles o primeiro elemento com a letra G
            int ultimo_com_G_2 = ListaQ1.FindLastIndex(x => x[0] == 'G'); // busca pelo ultimo com a legra G
            List<string> ListaQ2 = ListaQ1.FindAll(x => x.Length == 12); // busca aqueles elementos com tamanho de 12 caracteres
            ListaQ1.Remove("1984"); // Removendo um titulo
            ListaQ1.RemoveAll(x => x[0] == 'C'); // Removendo titulos que começam por C
            ListaQ1.RemoveAt(7); // remove o 7 elemento
            ListaQ1.RemoveRange(1, 4); // removendo da primeira a 4º posição











        }
    }
}
