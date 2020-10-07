using System;

namespace ATV7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1 ) Faça um programa que solicite do usuário a temperatura ambiente. */

            Console.WriteLine("Exercicio 01"); 
            Console.WriteLine("Digite o valor da temperatura ambiente: ");
            int temp = int.Parse(Console.ReadLine()); /* Leitura de dados do tipo inteiro */

            if (temp < 20)  /*  a) Se estiver abaixo de 20ºc.Escreva: "Frio"  */
             {
                Console.WriteLine("Frio");
             }
            else if (temp < 26) /*  b) Se estiver entre 20ºc e 26ºc.Escreva: "Bom"  */
             {
                Console.WriteLine("Bom");
             }
            else if (temp > 26) /*  c ) Se estiver acima de 26ºc.Escreva: "Quente"  */
             {
                Console.WriteLine("Quente");
             }

            /* 2 ) Faça um programa que solicite do usuário a umidade relativa do ar.*/
            
            Console.WriteLine("Exercicio 02");
            Console.WriteLine("Digite o valor da umidade relativa do ar: ");
            int umidade = int.Parse(Console.ReadLine()); /* Leitura de dados do tipo inteiro */

            if (umidade < 20)  /*  e ) Se estiver abaixo de abaixo de 20 %.Escreva: "Help!"  */
            {
                    Console.WriteLine("Help!");
            }
            else if (umidade < 30) /*  c ) Se a umidade estiver entre 20 % de 30 %.Escreva: "Estado de atenção!"  */
            {
                    Console.WriteLine("Estado de atenção!");
            }
            else if (umidade < 50) /* b ) Se a umidade estiver entre 30 % e 50 %.Escreva: "Ruim"  */
            {
                    Console.WriteLine("Ruim");
            }
            else if (umidade < 80) /* a) Se a umidade estiver entre  50 % e 80 %.Escreva: "Ideal"   */
            {
                    Console.WriteLine("Ideal");
            }
            else if (umidade > 80) /* d ) Se estiver acima de 80 %.Escreva: "Grande possibilidade de chuvas"  */
            {
                    Console.WriteLine("Grande possibilidade de chuvas");
            }

        }
    }
}
