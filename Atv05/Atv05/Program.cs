using System;

namespace Atv05
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1 ) Some dois números e exiba o resultado */ 
            double q1_n1 = 10;
            double q1_n2 = 5;
            double soma = q1_n1 + q1_n2;
            Console.WriteLine($"A soma de {q1_n1} com {q1_n2} é de: {soma}");

            /* 2 ) Subtraia um número por outro e exiba o resultado */
            double q2_n1 = 10;
            double q2_n2 = 5;
            double sub = q2_n1 - q2_n2;
            Console.WriteLine($"A subtração de {q2_n1} com {q2_n2} é de: {sub}");

            /* 3 ) Multiplique dois números e exiba o resultado */
            double q3_n1 = 10;
            double q3_n2 = 5;
            double mult = q3_n1 * q3_n2;
            Console.WriteLine($"O produto de {q3_n1} por {q3_n2} é de: {mult}");

            /* 4 ) Divida um número por outro e exiba o resultado */
            double q4_n1 = 10;
            double q4_n2 = 5;
            double divd = q4_n1 / q4_n2;
            Console.WriteLine($"A divisão de {q4_n1} por {q4_n2} é de: {divd}");

            /* 5 ) Faça uma média de 3 números */
            double q5_n1 = 10;
            double q5_n2 = 5;
            double q5_n3 = 2;
            double med = (q5_n1 + q5_n2 + q5_n3) / 3;
            Console.WriteLine($"A média dos valores {q5_n1}, {q5_n2} e {q5_n3} é de: {med}");

            /* 6 ) Atribua um valor a uma variável do tipo inteiro e exiba seu antecessor. */
            int q6_n1 = 10;
            int q6_n2 = q6_n1--;
            Console.WriteLine($"O antecessor de {q6_n1} é: {q6_n2}");

            /* 7 ) Atribua um valor a uma variável do tipo inteiro e exiba seu sucessor. */
            int q7_n1 = 10;
            int q7_n2 = q7_n1++;
            Console.WriteLine($"O sucessor de {q7_n1} é: {q7_n2}");

            /* 8 ) Verifique na internet quanto está valendo o dólar e converta R$ 100,00 para dólares. */
            double q8_n1 = 100.00;
            double q8_n2 = 5.61;
            double cota = q8_n1 * q8_n2;
            Console.WriteLine($"O sucessor de {q8_n1} é: {q8_n2}");

            /* 9 ) Verifique na internet quanto está valendo o euro e converta € 100,00 para reais. */
            double q9_n1 = 100.00;
            double q9_n2 = 5.61;
            double cotadolar = q9_n1 * q9_n2;
            Console.WriteLine($"A converção de R$ {q9_n1} para dolar a {q9_n2} é de: {cotadolar}");

            /* 10 ) Verifique na internet quanto está valendo o bitcoin e converta R$ 300,00 para bitcoin. Utilizando o Math */
            double q10_n1 = 100.00;
            double q10_n2 = 0.0000016;
            double cotabit = q10_n1 * q10_n2;
            Console.WriteLine($"A converção de R$ {q10_n1} para bitcoin a {q10_n2} é de: {cotabit}");

            /* 11 ) Faça um programa que calcule a raiz quadrada de 64. */
            double q11_n1 = 64;
            double q11_n2 = Math.Sqrt(q11_n1);
            Console.WriteLine($"A raiz quadrada de {q11_n1} é {q11_n2}");

            /* 12 ) Faça um programa que calcule a potencia de 2 elevado a 128 */
            double q12_n1 = 2;
            double q12_n2 = Math.Pow(q12_n1,128);
            Console.WriteLine($"A potencia de {q12_n1} é {q12_n2}");



        }
    }
}
