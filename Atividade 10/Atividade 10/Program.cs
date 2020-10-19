using System;

namespace Atividade_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 1 - Fazer um programa para ler as medidas dos lados de dois triângulos X e Y
            (suponha medidas válidas). Em seguida, mostrar o valor das áreas dos dois
            triângulos e dizer qual dos dois triângulos possui a maior área. */

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine();

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.Area();
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            double areaY = y.Area();
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }


            /* Exercício 3 – Fazer um programa para ler nome e salário de dois funcionários.
              Depois, mostrar o salário médio dos funcionários. */

            Media_funcionarios M1;
            M1 = new Media_funcionarios();


            Console.WriteLine("Dados do primeiro funcionario"); // Inserção de dados do primeiro  funcionário //
            Console.WriteLine("    ");
            Console.WriteLine("Nome: "); 
            string M1.Nome1 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Salario: ");
            M1.Salario1 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            
            Console.WriteLine("Dados do segundo funcionario"); // Inserção de dados do segundo funcionário //
            Console.WriteLine("    ");
            Console.WriteLine("Nome: ");
            string M1.Nome2 = Console.ReadLine();
            Console.WriteLine("    ");
            Console.WriteLine("Salário: ");
            M1.Salario2 = double.Parse(Console.ReadLine());

            double resultado = M1.resultado(); // Calculo do Salario medio //

            Console.WriteLine($"A média dos salários de {M1.Nome1} e {M1.Nome2} é igual a {resultado.ToString("F2", CultureInfo.InvariantCulture)}"); // Impressão de resultado //

        }

    }
}
