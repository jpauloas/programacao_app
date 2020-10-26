using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 01 - 
             * Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto
                seria o valor de uma circunferência e do volume de uma esfera para um raio
                daquele valor. Informar também o valor de PI com duas casas decimais.
                Formulas:
                Circunferência = 2 x Pi x raio
                Volume = 4/3 x Pi x raio3 */

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = q1circ.Circunferencia(raio);
            Console.WriteLine("Circunferência é de: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            /* Exercicio 02 - 
             *  Faça um programa para ler a cotação do dólar, e depois um valor em dólares
                a ser comprado por uma pessoa em reais. Informar quantos reais a pessoa vai
                pelos dólares, considerando ainda que a pessoa terá que pagar 6 % de
                IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda para ser
                responsável pelos cálculos.*/

            Console.Write("Entre o valor atual do dolar em reais:  ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre o valor de dolares que deseja comprar:  ");
            double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double conversao = ConversorDeMoeda.conv(dolar,compra);
            Console.WriteLine($"O valor a ser pago para a compra de U$ {compra} é de:" + conversao.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

