using System;
using System.Globalization;

namespace Atv10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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
            x.A = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor do segundo lado: "); /* Instrução de inserção de dados */
            x.B = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor do terceiro lado: ");/* Instrução de inserção de dados */
            x.C = double.Parse(Console.ReadLine());


            Console.WriteLine("Entre com as medidas do triangulo Y: "); /* Mensagem inicial */
            Console.WriteLine("Digite valor do primeiro lado: "); /*Instrução de inserção de dados */
            y.A = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor do segundo lado: "); /* Instrução de inserção de dados */
            y.B = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor do terceiro lado: ");/* Instrução de inserção de dados */
            y.C = double.Parse(Console.ReadLine());

            
            double areaX = x.Area();
            double areaY = y.Area();
            Console.WriteLine("Área de X = " + areaX.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F2", CultureInfo.InvariantCulture));


            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

            /* Exercício 2 – Fazer um programa para ler os dados de duas pessoas, depois
                mostrar o nome da pessoa mais velha.*/

            Pessoas nome, idade; /* Classe */

            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.idade = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.idade = double.Parse(Console.ReadLine());

            /*Exercício 3 – Fazer um programa para ler nome e salário de dois funcionários.
              Depois, mostrar o salário médio dos funcionários. */

            Funcionarios nome, salario;
            Funcionarios func01 = new Funcionarios();
            Funcionarios func02 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionario"); // Inserção de dados do segundo funcionário //
            Console.WriteLine("Nome: ");
            func01.nome = (Console.ReadLine());
            Console.WriteLine("Salario: ");
            func01.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario"); // Inserção de dados do segundo funcionário //
            Console.WriteLine("Nome: ");
            func02.nome = (Console.ReadLine());
            Console.WriteLine("Salario: ");
            func02.salario = double.Parse(Console.ReadLine());

            double salariomedio = ((func02.salario + func01.salario) / 2); // Calculo do Slario medio //

            Console.WriteLine($"Salário médio: {salariomedio}"); // Impressão de resultado // 







        }
    }
}
