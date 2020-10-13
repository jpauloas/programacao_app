using System;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Atv09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Exercício 1 – Área do triângulo:
                azer um programa para ler as medidas dos lados de dois triângulos X e Y
                (suponha medidas válidas). Em seguida, mostrar o valor das áreas dos dois
                triângulos e dizer qual dos dois triângulos possui a maior área.
                A fórmula para calcular a área de um triângulo a partir das medidas de seus lados
                a, b e c é a seguinte (fórmula de Heron): */

            triangulo A, B, C;

            triangulo x = new triangulo();
            triangulo y = new triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: "); /* Mensagem inicial */
            Console.WriteLine("Digite valor do primeiro lado: "); /*Instrução de inserção de dados */
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            Console.WriteLine("Digite valor do segundo lado: "); /* Instrução de inserção de dados */
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite valor do terceiro lado: ");/* Instrução de inserção de dados */
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y: "); /* Mensagem inicial */
            Console.WriteLine("Digite valor do primeiro lado: "); /*Instrução de inserção de dados */
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite valor do segundo lado: "); /* Instrução de inserção de dados */
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite valor do terceiro lado: ");/* Instrução de inserção de dados */
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double px = (x.A + x.B + x.C) / 2;           /*Calculo de P */
            double areax = Math.Sqrt (p * (p - x.A) * (p - x.B) * (p - x.C)); /*Calculo da Area*/
            
            double py = (y.A + y.B + y.C) / 2;           /*Calculo de P */
            double areay = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C)); /*Calculo da Area*/


            Console.WriteLine("Área do triangulo X: " + areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do triangulo Y: " + areay.ToString("F4", CultureInfo.InvariantCulture));


            if (areax>areay)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }


        }
    }
}
