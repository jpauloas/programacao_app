using System;
using System.Globalization;

namespace Atv11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Fazer um programa para ler os valores da largura e altura de um retângulo.
            // Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma
            // classe como mostrado no projeto a baixo. //

            Retangulo A;
            A = new Retangulo();

            Console.WriteLine("Programa que calcula a Area, Perimetro e Diagonal de um retangulo");
            Console.WriteLine("Digite a medida da largura do retangulo:");
            A.ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite com a medida da altura do retangulo:");
            A.ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = A.AREA();
            double perimetro = A.PERIMETRO();
            double diagonal = A.DIAGONAL();

            Console.WriteLine("Área = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));

            // Fazer um programa para ler os dados de um funcionário (nome, salário bruto
            // e imposto). Em seguida, mostrar os dados do funcionário(nome e salário
            // líquido).Em seguida, aumentar o salário do funcionário com base em uma
            // porcentagem dada(somente o salário bruto é afetado pela porcentagem) e
            // mostrar novamente os dados do funcionário.Use a classe projetada abaixo. //


            Q02 B;
            B = new Q02();

            Console.WriteLine("Programa que o salário liquido de um funcionário");
            Console.WriteLine("Nome: ");
            B.NOME = Console.ReadLine();
            Console.WriteLine("Salário");
            B.SALARIO = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto");
            B.IMPOSTO = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a porcentagem para aumentar o salário");
            double aumento = double.Parse(Console.ReadLine());
            B.AumentarSalario(aumento);


            Console.WriteLine($"Dados atualizados: {B.NOME} , R$ {B.SALARIO}");


            //Fazer um programa para ler o nome de um aluno e as três notas que ele
            // obteve nos três trimestres do ano(primeiro trimestre vale 30 e o segundo e
            // terceiro valem 35 cada).Ao final, mostrar qual a nota final do aluno no ano.Dizer
            // também se o aluno está APROVADO ou REPROVADO e, em caso negativo,
            //quantos pontos faltam para o aluno obter o mínimo para ser aprovado(que é 60
            // pontos). Você deve criar uma classe Aluno para resolver este problema. //

            Q03 C;
            C = new Q03();

            Console.WriteLine("Programa que retorna a situação academica de um aluno");
            Console.WriteLine("Nome do aluno: ");
            C.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            C.n1 = double.Parse(Console.ReadLine());
            C.n2 = double.Parse(Console.ReadLine());
            C.n3 = double.Parse(Console.ReadLine());

            double situacao = C.soma();

            Console.WriteLine("NOTA FINAL: " + situacao.ToString("F2", CultureInfo.InvariantCulture));

            if (situacao > 60)
            {
                Console.WriteLine("Aprovado");
            }
            else 
            {
                Console.WriteLine("Reprovado");
            }





        }
    }
}
