using System;

namespace Atv03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  1 ) Faça um programa que exiba na tela os seguintes dados da sua família.
                a ) Nome
                b ) grau de parentesco
                c ) idade
                d ) gênero
                c ) livro proferido */

                    string ex01_mae_nome = "Carmem Miranda";
                    string ex01_mae_grau = "primeiro";
                    int ex01_mae_idade = 43;
                    string ex01_mae_genero = "Feminino";
                    string ex01_mae_livro = "Biblia";

                    string ex01_pai_nome = "Flaviano";
                    string ex01_pai_grau = "primeiro";
                    int ex01_pai_idade = 42;
                    string ex01_pai_genero = "Masculino";
                    string ex01_pai_livro = "Biblia";

                    Console.WriteLine( "Minha mãe se chama {0}, ela é do {1} grau, tem {2} anos, do genero {3}, e gosta muito de ler {4}", ex01_mae_nome, ex01_mae_grau, ex01_mae_idade, ex01_mae_genero, ex01_mae_livro);
                    Console.WriteLine("Meu pai se chama {ex01_pai_nome}, ela é do { ex01_pai_grau} grau, tem {ex01_pai_idade} anos, do genero {ex01_pai_genero}, e gosta muito de ler {ex01_pai_livro}");


            /* 2 )Faça um programa que imprima na tela os seguintes dados sobre você
               a ) Nome
               b ) idade
               c ) salario pretendido
               d ) data de nascimento         
               e ) filme preferido  */

                    string ex01_eu_nome = "Joao Paulo";
                    int ex01_eu_idade = 19;
                    int  ex01_eu_salario = 1200;
                    string ex01_eu_nasc = "13/08/200";
                    string ex01_eu_livro = "avatar";

                    Console.WriteLine ("Sou {ex01_eu_nome}, tenho {ex01_eu_idade} anos, gostaria de receber um salário de {ex01_eu_salario}, nasci em {ex01_eu_nasc} e meu livro favorito é {ex01_eu_livro}");


            /* 3 ) Faça um programa que imprima na tela as informações  abaixo sobre três livros.
               a ) nome do livro
               b ) autor
               c ) editora
               d ) quantidade de páginas
               e ) ano de lançamento */

                    string ex03_nome_livro = "A arte da guerra";
                    string ex03_autor = "Sun Tzu";
                    string ex03_editora = "Jardim dos Livros";
                    int ex03_paginas = 105;
                    int ex03_lancamento = 2017;

                    Console.WriteLine("O nome do livro é {ex03_nome_livro}, foi escrito por {ex03_autor}, publicado pela editora {ex03_editora} no ano de {ex03_lancamento}, e possui {ex03_paginas} paginas");

            /*  4 )Faça um programa que imprima na tela as informações abaixo sobre três filmes.
                a ) nome do filme
                b ) diretor
                c ) ano de lançamento
                d ) valor do orçamento
                e ) gênero do filme
                f ) protagonista */

                    string ex04_nome_filme = "Vingadores: Ultimato";
                    string ex04_diretor = "Joe Russo,  Anthony Russo ";
                    int ex04_lancamento = 2019;
                    int ex04_orcamento = 356;
                    string ex04_genero = "Aventura";
                    string ex04_protagonista = "Homem de ferro";

                    string ex04_nome_filme2 = "Thor: Ragnarok";
                    string ex04_diretor2 = "Taika Waititi";
                    int ex04_lancamento2 = 2017;
                    int ex04_orcamento2 = 854;
                    string ex04_genero2 = "Aventura";
                    string ex04_protagonista2 = "Thor";

                    string ex04_nome_filme3 = "Capitão América: O Primeiro Vingador";
                    string ex04_diretor3 = "Joe Johnston";
                    int ex04_lancamento3 = 2011;
                    int ex04_orcamento3 = 370;
                    string ex04_genero3 = "Aventura";
                    string ex04_protagonista3 = "Capitão America";

                    Console.WriteLine("O filme {ex04_nome_filme}, do genero {ex04_genero}, foi dirigido por {ex04_diretor} e lançado em {ex04_lancamento}, com o orçamento de {ex04_orcamento}, tendo como protagonista {ex04_protagonista}");
                    Console.WriteLine("O filme {ex04_nome_filme2}, do genero {ex04_genero2}, foi dirigido por {ex04_diretor2} e lançado em {ex04_lancamento2}, com o orçamento de {ex04_orcamento2}, tendo como protagonista {ex04_protagonista2}");
                    Console.WriteLine("O filme {ex04_nome_filme3}, do genero {ex04_genero3}, foi dirigido por {ex04_diretor3} e lançado em {ex04_lancamento3}, com o orçamento de {ex04_orcamento3}, tendo como protagonista {ex04_protagonista3}");











        }
    }
}
