using System;

namespace ATV06
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Questão 01 */ 
            Console.WriteLine("Entrada de Dados: ");

            Console.WriteLine("Digite o  nome:");
            string q1_nome01 = Console.ReadLine();
            Console.WriteLine("Digite o Telefone:");
            string q1_telefone01 = Console.ReadLine();
            Console.WriteLine("Digite o Saldo Bancário: ");
            string q1_saldo01 = Console.ReadLine();

            Console.WriteLine("Digite o  nome:");
            string q1_nome02 = Console.ReadLine();
            Console.WriteLine("Digite o Telefone:");
            string q1_telefone02 = Console.ReadLine();
            Console.WriteLine("Digite o Saldo Bancário: ");
            string q1_saldo02 = Console.ReadLine();

            Console.WriteLine("Digite o  nome:");
            string q1_nome03 = Console.ReadLine();
            Console.WriteLine("Digite o Telefone:");
            string q1_telefone03 = Console.ReadLine();
            Console.WriteLine("Digite o Saldo Bancário: ");
            string q1_saldo03 = Console.ReadLine();

            Console.WriteLine("Saída de Dados:");
            Console.WriteLine($"Contato 01 - {q1_nome01}, o telefone é {q1_telefone01}. Saldo bancário: R$ {q1_saldo01} reais");
            Console.WriteLine($"Contato 02 - {q1_nome02}, o telefone é {q1_telefone02}. Saldo bancário: R$ {q1_saldo02} reais");
            Console.WriteLine($"Contato 03 - {q1_nome03}, o telefone é {q1_telefone03}. Saldo bancário: R$ {q1_saldo03} reais");

            /* Questão 02 */

            Console.WriteLine("Digite dois numeros e te retornaremos os resultados para as operações:");
            Console.WriteLine("");
            Console.WriteLine("Digite o valor do primeiro numero: ");
            double q2_n1 = Console.ReadLine();
            Console.WriteLine("Digite o valor do segundo numero: ");
            double q2_n2 = Console.ReadLine();

            double q2_soma = q2_n1 + q2_n2;
            double q2_produto = q2_n1 * q2_n2;
            double q2_op1 = (q2_n1 * q2_n2) / q2_n2;
            double q2_op2 = (q2_n1 * q2_n2) - q2_n1;
            Console.WriteLine($"A soma dos dois valores é de: {q2_soma}");
            Console.WriteLine($"O produto dos dois valores é de: {q2_produto}");
            Console.WriteLine($"O valor do produto dividido pelo segundo valor é de: {q2_op1}");
            Console.WriteLine($"O valor do produto menos o primeiro valor é de: {q2_op1}");

            /* Questão 03 */

            Console.WriteLine(1 * 1);
            Console.WriteLine(1 * 2);
            Console.WriteLine(1 * 3);
            Console.WriteLine(1 * 4);
            Console.WriteLine(1 * 5);
            Console.WriteLine(1 * 6);
            Console.WriteLine(1 * 7);
            Console.WriteLine(1 * 8);
            Console.WriteLine(1 * 9);
            Console.WriteLine(1 * 10);

            /* Questão 04 */

            Console.WriteLine("Entre com seu nome completo: ");
            string q4_nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            string q4_quartos = Console.ReadLine();
            Console.WriteLine("Entre com o preço de um produto: ");
            string q4_preco = Console.ReadLine();

            Console.WriteLine(q4_nome);
            Console.WriteLine(q4_quartos);
            Console.WriteLine(q4_preco);


        }
    }
}
