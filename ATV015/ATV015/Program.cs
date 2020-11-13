using System;

namespace ATV015
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio A //
            Console.Write("Progerama que calcula a area, periometro e diagonal de um retangulo");
            Console.WriteLine();
            Retangulo r = new Retangulo(3.0, 5.0);
            r.SetLargura(2.0);
            r.SetAltura(5.0);
            Console.WriteLine(r.GetLargura());
            Console.WriteLine(r.GetAltura());

            // Exercicio B //
            Console.WriteLine("Programa de controladoria de estoque");
            Console.WriteLine();
            Produto p = new Produto("TV", 500.00, 10);
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());

            // Exercicio C //
            Professor p = new Professor("Aguinaldo", "Souza", 35334444, true);
            p.SetOculos(false);
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetSobrenome());
            Console.WriteLine(p.GetTelefone());
            Console.WriteLine(p.GetOculos());

            // Exercicio D //
            Aluno a = new Aluno("Carolina", "carolina@gmail.com", "Belo Horizonte", true);
            a.SetNome("Bruna");
            a.SetEmail("bruna@gmail.com");
            a.SetCidade("Nova Lima");
            a.SetStatus(false);
            Console.WriteLine(a.GetNome());
            Console.WriteLine(a.GetEmail());
            Console.WriteLine(a.GetCidade());
            Console.WriteLine(a.GetStatus());

        }
    }
}
