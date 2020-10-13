using System;

namespace Atv09_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 3 – Fazer um programa para ler nome e salário de dois funcionários.
              Depois, mostrar o salário médio dos funcionários. */

            Funcionarios nome, salario;
            Funcionarios func01 = new Funcionarios ();
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

            double salariomedio = ((func02.salario + func01.salario)/2); // Calculo do Slario medio //

            Console.WriteLine($"Salário médio: {salariomedio}"); // Impressão de resultado // 
        }
    }
}
