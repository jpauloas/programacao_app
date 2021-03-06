﻿using System;

namespace Lista_3
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 1. Crie um programa que leia 6 valores inteiros e, em seguida, mostre na tela os
                valores lidos. */

            int[] vetor1 = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Informe o " + i + "° número inteiro: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in vetor1)
            {
                Console.WriteLine(i);
            }

            /* 2. Faça um programa que possua um vetor denominado A que armazene 6 números
                inteiros. O programa deve executar os seguintes passos:
                a) Atribua os seguintes valores a esse vetor: 1, 0, 5, -2, -5, 7.
                b) Armazene em uma variável inteira (simples) a soma entre os valores das
                posições. A[0], A[1] e A[5] do vetor e mostre na tela esta soma.
                c) Modifique o vetor na posição 4, atribuindo a esta posição o valor 100.
                d) Mostre na tela cada valor do vetor A, um em cada linha. */

            int[] A = new int[6] { 1, 0, 5, -2, -5, 7 };
            int soma2 = A[0] + A[1] + A[5];
            Console.WriteLine(soma2);
            A[4] = 100;
            foreach (int i in A)
            {
                Console.WriteLine(i);
            }

            /* 3. Ler um conjunto de números reais, armazenando-o em vetor e calcular o quadrado
                dos componentes deste vetor, armazenando o resultado em outro vetor. Os conjuntos
                têm 10 elementos cada. Imprimir todos os conjuntos. */

            double[] vetor3 = new double[10];
            double[] outrovetor3 = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe o " + i + "° número real: ");
                vetor3[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                outrovetor3[i] = Math.Pow(vetor3[i], 2.0);
            }
            Console.WriteLine();

            foreach (int i in vetor3)
            {
                Console.WriteLine(i.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();

            foreach (int i in outrovetor3)
            {
                Console.WriteLine(i.ToString("F2", CultureInfo.InvariantCulture));
            }

            /* 4. Faça um programa que leia um vetor de 8 posições e, em seguida, leia também dois
                valores X e Y quaisquer correspondentes a duas posições no vetor. Ao final seu
                programa deverá escrever a soma dos valores encontrados nas respectivas posições
                X e Y. */

            double[] vetor4 = new double[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Informe o " + i + "° número: ");
                vetor4[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Informe o valor da posição X correspondente ao vetor: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da posição Y correspondente ao vetor: ");
            int y = int.Parse(Console.ReadLine());
            double soma = vetor4[x] + vetor4[y];
            Console.WriteLine("A soma dos valores das posições X = " + x + " e Y =  " + y + " é igual a: " + soma);

            /* 5. Leia um vetor de 10 posições. Contar e escrever quantos valores pares ele possui. */
            double[] vetor5 = new double[10];
            int pares5 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe o " + i + "° valor do vetor: ");
                vetor5[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (vetor5[i] % 2 == 0)
                {
                    pares5 += 1;
                }
            }
            Console.WriteLine("O vetor possui " + pares5 + " valores pares.");

            /* 6. Faça um programa que receba do usuário um vetor com 10 posições. Em seguida
                    deverá ser impresso o maior e o menor elemento do vetor. */
            double[] vetor6 = new double[10];
            double maior = 0;
            double menor = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe o " + i + "° valor do vetor: ");
                vetor6[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            foreach (int i in vetor6)
            {
                Console.WriteLine(i);
            }

            if (10 > 0)
            {
                maior = vetor6[0];
                menor = vetor6[0];
            }
            for (int i = 0; i < 10; i++)
            {
                if (maior < vetor6[i])
                {
                    maior = vetor6[i];
                }
                if (menor > vetor6[i])
                {
                    menor = vetor6[i];
                }
            }
            Console.WriteLine("Maior elemento: " + maior);
            Console.WriteLine("Menor elemento: " + menor);

            /* 7. Escreva um programa que leia 10 números inteiros e os armazene em um vetor.
                Imprima o vetor, o maior elemento e a posição que ele se encontra. */

            int[] vetor7 = new int[10];
            int maior7 = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe o " + i + "° valor inteiro do vetor: ");
                vetor7[i] = int.Parse(Console.ReadLine());

            }
            foreach (int i in vetor7)
            {
                Console.WriteLine(i);
            }

            if (10 > 0)
            {
                maior7 = vetor7[0];
            }
            for (int i = 0; i < 10; i++)
            {
                if (maior7 < vetor7[i])
                {
                    maior7 = vetor7[i];
                }
            }
            Console.WriteLine("Maior elemento: " + maior7);


            /* 8.Crie um programa que leia 6 valores inteiros e, em seguida, mostre na tela os
            valores lidos na ordem inversa. */

            int [] q8 = new int [6];
            int i;

            for (i = 0; i < 6; i++)
            {

                Console.WriteLine(" Digite um numero: "); // Lê os valores

                q8[i] = int.Parse(Console.ReadLine()); 


            }

            for (i = 6; i > 0; i--)
            {
                Console.WriteLine(i + $"º Valor: {q8[i]} ");
            }


            /* 9.Crie um programa que leia 6 valores inteiros pares e, em seguida, mostre na tela os
             valores lidos na ordem inversa. */


            int[] q9 = new int[6];
            
            for (i = 0; i < 6; i++)
            {

                Console.WriteLine($"Informe o {i+1} número: ");
                q9[i] = int.Parse(Console.ReadLine());

                while (q9[i] % 2 != 0)
                {
                    Console.WriteLine($"{q9[i]} Não é um valor valido, tente novamente ");
                    Console.WriteLine($"Informe o {i + 1} número: ");

                    q9[i] = int.Parse(Console.ReadLine());

                }

            }


            for (i = 6; i > 0; i--)
            {
                Console.WriteLine(i + $"º Valor: {q8[i]} ");
            }




            /* 10.Faça um programa para ler a nota da prova de 15 alunos e armazene num vetor,
             calcule e imprima a média geral. */

            double[] q10 = new double[15];
            double soma = 0;

            for (i = 0; i < 6; i++)
            {

                Console.WriteLine($"Insira a nota do {i+1}º aluno: "); 

                q10[i] = double.Parse(Console.ReadLine());
                soma += q10[i];

            }

            Console.WriteLine("A média de notas é de " + ( soma / 15 ));

            /* 11.Faça um programa que preencha um vetor com 10 números reais, calcule e
            mostre a quantidade de números negativos e a soma dos números positivos desse
            vetor. */

            double[] q11 = new double[15];
            double somapos = 0;
            int somaneg = 0;

            for (i = 0; i < 10; i++)
            {

                Console.WriteLine($"Insira a nota do {i + 1}º aluno: ");

                q10[i] = double.Parse(Console.ReadLine());
                if (q10[i] < 0)
                {
                    somaneg++;
                }

                somapos += q10[i];

            }

            Console.WriteLine($"A soma dos temos foi de  {somapos}, sendo {somaneg} numeros negativos"));

            /* 12.Fazer um programa para ler 5 valores e, em seguida, mostrar todos os valores
            lidos juntamente com o maior, o menor e a média dos valores. */

            double[] q12 = new double[15];
            double q12_maior = 0;
            double q12_menor = 0;
            double q12_soma = 0 ;

            for (i = 1; i < 5; i++)
            {

                Console.WriteLine($"Insira o {i + 1}º valor: ");

                q12[i] = double.Parse(Console.ReadLine());
                if (q12[i] < q12[i - 1])
                {
                    q12_menor = q12[i];
                }

                q12[i] = double.Parse(Console.ReadLine());
                if (q10[i] > q10[i - 1])
                {
                    q12_maior = q12[i];
                }

                q12_soma += q12[i];

            }

            Console.WriteLine($"A média dos termos é  {q12_soma/5}, sendo {q12_maior} o maior valor e {q12_menor} o menor");



            /* 13.Fazer um programa para ler 5 valores e, em seguida, mostrar a posição onde se
            encontram o maior e o menor valor.*/





        }
    }
}
