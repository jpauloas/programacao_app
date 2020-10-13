using System;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Trabalho02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1 - Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos. //

            Console.WriteLine("Programa que retorna o valor da soma de dois numeros inteiros.");
            Console.WriteLine("Insira o primeiro valor: ");
            int num01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            int num02 = int.Parse(Console.ReadLine());
            double soma = num01 + num02;
            Console.WriteLine($"O valor da soma é igual a: {soma}");


            // Exercício 2 - Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos. //
            Console.WriteLine("Programa que retorna o valor da area de um circulo");
            Console.WriteLine("Insira valor do raio: ");
            double q2_raio = double.Parse(Console.ReadLine());
            double q2_area = (3.1415 * q2_raio * q2_raio);
            Console.WriteLine($"O valor da área do circulo é de: {q2_area}");


            // Exercício 3 - Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
            Console.WriteLine("Programa que retorna o resultado da operação A*C - B*D");
            Console.WriteLine("Insirao o valor de A: ");
            double q4_A = double.Parse(Console.ReadLine());
            Console.WriteLine("Insirao o valor de B: ");
            double q4_B = double.Parse(Console.ReadLine());
            Console.WriteLine("Insirao o valor de C: ");
            double q4_C = double.Parse(Console.ReadLine());
            Console.WriteLine("Insirao o valor de D: ");
            double q4_D = double.Parse(Console.ReadLine());
            double q4_resp = q4_A * q4_C - q4_B * q4_D;
            Console.WriteLine($"O resultado é: {q4_resp}");


            // Exercício 4  - Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas decimais. //
            Console.WriteLine("Programa que retorna o valor do salário de um funcionário");
            Console.WriteLine("Insira o numero do funcionário: ");
            int q3_num = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero de horas trabalhadas: ");
            int q3_hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da hora de trabalho: ");
            double q3_valor = double.Parse(Console.ReadLine());

            double q3_salario = q3_hora * q3_valor;

            Console.WriteLine($"O salário deste funcionário será de R$ {q3_salario}");

            // Exercício 5 - Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.
            Console.WriteLine("Programa que retorna o valor a ser pago pelo montante de dois produtos");
            Console.WriteLine("Insira o numero do primeiro produto: ");
            int q5_num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da quantidade do primeiro produto: ");
            int q5_qtd1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do preço do primeiro produto: ");
            double q5_valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o numero do segundo produto: ");
            int q5_num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da quantidade do segundo produto: ");
            int q5_qtd2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do preço do segundo produto: ");
            double q5_valor2 = double.Parse(Console.ReadLine());

            double q5_total = q5_qtd1 * q5_valor1 + q5_qtd2 * q5_valor2;

            Console.WriteLine($"O total a se pagar é {q5_total}");


            // Exercício 6 - Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.Em seguida, calcule e mostre:
            //                  a) a área do triângulo retângulo que tem A por base e C por altura.       //
            //                  b) a área do círculo de raio C. (pi = 3.14159)                           //
            //                  c) a área do trapézio que tem A e B por bases e C por altura.           //
            //                  d) a área do quadrado que tem lado B.                                  //
            //                  e) a área do retângulo que tem lados A e B.                           //

            Console.WriteLine("Programa que retorna o valor da área de divesas formas geometricas a partir de 3 valores");
            Console.WriteLine("Insira o numero do primeiro valor: ");
            double q6_A = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero do segundo valor: ");
            double q6_B = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero do terceiro valor: ");
            double q6_C = double.Parse(Console.ReadLine());

            double q6_areaA = 2; ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            double q6_areaB = 3.14159 * q6_C * q6_C;
            double q6_areaC = 3; ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            double q6_areaD = q6_B * q6_B;
            double q6_areaE = q6_A * q6_B;

            Console.WriteLine($"A área do triângulo retângulo que tem A por base e C por altura: {q6_areaA}");
            Console.WriteLine($"A área do círculo de raio C. (pi = 3.14159): {q6_areaB}");
            Console.WriteLine($"A área do trapézio que tem A e B por bases e C por altura: {q6_areaC}");
            Console.WriteLine($"A área do quadrado que tem lado B: {q6_areaD}");
            Console.WriteLine($"A área do retângulo que tem lados A e B: {q6_areaE}");


            // Exercício 7 - Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não. //
            Console.WriteLine("Programa que retorna se um numero é negativo ou não");
            Console.WriteLine("Insira o valor de analise: ");
            double q7 = double.Parse(Console.ReadLine());
            if (q7 < 0)
            {
                Console.WriteLine("O numero é negativo!");
            }
            else
            {
                Console.WriteLine("O numero é positivo!");
            }


            // Exercício 8 - Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.//
            Console.WriteLine("Programa que retorna se um numero é par ou ímpar");
            Console.WriteLine("Insira o valor de analise: ");
            double q8 = double.Parse(Console.ReadLine());

            if (q8 % 2 = 0)
            {
                Console.WriteLine("O numero é par!");
            }
            else
            {
                Console.WriteLine("O numero é ímpar!");
            }


            // Exercício 9 - Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao são Multiplos", indicando se os valores lidos são múltiplos entre si.//
            // Atenção: os números devem poder ser digitados em ordem crescente ou decrescente. // 
            Console.WriteLine("Programa que retorna se um numero é multiplo de outro");
            Console.WriteLine("Insira o valor do primeiro numero: ");
            double q91 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do segundo numero: ");
            double q92 = double.Parse(Console.ReadLine());
            if (q91 % q92 = 0)
            {
                Console.WriteLine($"O numero {q91} é multiplo de {q92}");
            }
            else
            {
                Console.WriteLine($"O numero {q91} não é multiplo de {q92}");
            }


            // Exercício 10 - Leia a hora inicial e a hora final de um jogo. A seguir calcule a //
            //duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em //
            //outro, tendo uma duração mínima de 1 hora e máxima de 24 horas. //
            Console.WriteLine("Programa que retorna o valor do total de horas de um jogo.");
            Console.WriteLine("Insira a hora inicial: ");
            int q10_s = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a hora final: ");
            int q10_e = int.Parse(Console.ReadLine());
            int q10_total = q10_e - q10_s;
            if (q10_total > 24)
            {
                Console.WriteLine("Excedeu o máximo para uma partida!");
            }
            else if (q10_total < 1 ) 
            {
                Console.WriteLine("Tempo de jogo insuficiente");
            }


            // Exercício 11- Com base na tabela abaixo, escreva um programa que leia o
            // código de um item e a quantidade deste item.A seguir, calcule e mostre o valor
            // da conta a pagar. // 
            Console.WriteLine("Programa que lê o codigo de um item e retorna o valor a ser pago");
            Console.WriteLine(" ");
            Console.WriteLine("[-------LANCHONETE-------]");
            Console.WriteLine(" ");
            Console.WriteLine("  [1] Cachorro Quente R$ 4.00");
            Console.WriteLine("  [2] X-Salada R$ 4.50");
            Console.WriteLine("  [3] X-Bacon R$ 5.00");
            Console.WriteLine("  [4] Torrada Simples R$ 2.00");
            Console.WriteLine("  [5] Refrigerante 1.50\n");
            Console.WriteLine("  ");
            Console.WriteLine("Digite o codigo do produto que gostaria de comprar: ");
            int q11_cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos você quer comprar: ");
            int q10_qtd = int.Parse(Console.ReadLine());
            if (q11_cod == 1)
            {
                double q11_total = 4 * q10_qtd;
            }
            else if (q11_cod == 2)
            {
                double q11_total = 4.5 * q10_qtd;
            }
            else if (q11_cod == 3)
            {
                double q11_total = 5 * q10_qtd;
            }
            else if (q11_cod == 4)
            {
                double q11_total = 2 * q10_qtd;
            }
            else if (q11_cod == 5)
            {
                double q11_total = 1.5 * q10_qtd;
            }


            // Exercício 12 - Você deve fazer um programa que leia um valor qualquer e
            // apresente uma mensagem dizendo em qual dos seguintes intervalos([0, 25],
            // (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não
            // estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora
            // de intervalo”.
            Console.WriteLine("Programa que lê um valor e responde em qual intervalo ele ta");
            Console.WriteLine("Digite o valor: ");
            double q12 = double.Parse(Console.ReadLine());
            if (q12 < 25)
            {
                Console.WriteLine("Esta no intervalo de 0 a 25");
            }
            else if (q12 < 50)
            {
                Console.WriteLine("Esta no intervalo de 25 a 50");
            }
            else if (q12 < 75)
            {
                Console.WriteLine("Esta no intervalo de 50 a 75");
            }
            else if (q12 < 100)
            {
                Console.WriteLine("Esta no intervalo de 75 a 100");
            }
            else if (q12 < 0 || q12>100)
            {
                Console.WriteLine("Fora do intervalo!");
            }


            // Exercício 13 - Leia 2 valores com uma casa decimal (x e y), que devem
            // representar as coordenadas de um ponto em um plano. A seguir, determine qual
            // o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos
            // ou na origem(x = y = 0).
            // Se o ponto estiver na origem, escreva a mensagem “Origem”.
            // Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme
            // for a situação. // 
            Console.WriteLine("Programa que retorna qual quadrante se encontram as cordenadas");
            Console.WriteLine("Insira a posição para o eixo X: ");
            double q13_X = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a posição para o eixo Y: ");
            double q13_Y = double.Parse(Console.ReadLine());

            if (q13_X > 0 && q13_Y > 0)
            {
                Console.WriteLine("Esta presente no primeiro quadrante!");
            }
            else if (q13_X < 0 && q13_Y > 0)
            {
                Console.WriteLine("Esta presente no segundo quadrante!");
            }
            else if (q13_X < 0 && q13_Y < 0)
            {
                Console.WriteLine("Esta presente no terceiro quadrante!");
            }
            else if (q13_X > 0 && q13_Y < 0)
            {
                Console.WriteLine("Esta presente no quarto quadrante!");
            }
            else if (q13_X == 0 && q13_Y == 0)
            {
                Console.WriteLine("Esta na origem!");
            }
            else if (q13_X != 0 && q13_Y == 0)
            {
                Console.WriteLine("Esta no eixo Y!");
            }
            else if (q13_X == 0 && q13_Y != 0)
            {
                Console.WriteLine("Esta no eixo X!");
            }


            // Exercício 14 - - Em um país imaginário denominado Lisarb, todos os habitantes
            // ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos
            // corruptos e os recursos arrecadados são utilizados em benefício da população,
            // sem qualquer desvio.A moeda deste país é o Rombus, cujo símbolo é o R$. Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa
            // de Lisarb.Em seguida, calcule e mostre o valor que esta pessoa deve pagar de
            // Imposto de Renda, segundo a tabela abaixo. //
            Console.WriteLine("Programa que retorna o quanto se deve pagar no imposto de renda");
            Console.WriteLine("Insira o valor do salario: ");
            double q14 = double.Parse(Console.ReadLine());
            double imposto = 0;
            if (q14 > 2000)
            {
                Console.WriteLine("Isento!");
            }
            else if (q14 < 3000)
            {
                imposto = (q14 - 2000) * 0.08;
                Console.WriteLine($"O total a ser pago é: {imposto}");
            }
            else if (q14 < 4500)
            {
                imposto = (q14 - 3000) * 0.18 + (1000*0.8);
                Console.WriteLine($"O total a ser pago é: {imposto}");
            }
            else if (q14 > 4500)
            {
                imposto = (q14 - 4500) * 0.28 + (1000 * 0.8) + (1000 * 0.18);
                Console.WriteLine($"O total a ser pago é: {imposto}");
            }



            // Exercício 15 - Escreva um programa que repita a leitura de uma senha até que
            // ela seja válida.Para cada leitura de senha incorreta informada, escrever a
            // mensagem "Senha Invalida".Quando a senha for informada corretamente deve
            // ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.
            // Considere que a senha correta é o valor 2002. //
            string q15certa = "2002";
            Console.WriteLine("Programa que retorna se a senha é correta");
            bool senha = false;

            while (senha = false)
            {
                Console.WriteLine("Insira a senha: ");
                string q15 = Console.ReadLine();

                if (q15 == q15certa)
                {
                    Console.WriteLine("Acesso permitido");
                    senha = true;
                }
                else
                {
                    Console.WriteLine("Senha invalida");
                    senha = false;
                }

            }            

            // Exercício 16 - - Escreva um programa para ler as coordenadas (X,Y) de uma //
            // quantidade indeterminada de pontos no sistema cartesiano.Para cada ponto //
            // escrever o quadrante a que ele pertence.O algoritmo será encerrado quando //
            // pelo menos uma de duas coordenadas for NULA(nesta situação sem escrever //
            // mensagem alguma).//

            Console.WriteLine("Programa que retorna qual quadrante se encontram as cordenadas");
            Console.WriteLine("Insira a posição para o eixo X: ");
            double q16_X = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a posição para o eixo Y: ");
            double q16_Y = double.Parse(Console.ReadLine());

            if (q16_X > 0 && q16_Y > 0)
            {
                Console.WriteLine("Esta presente no primeiro quadrante!");
            }
            else if (q16_X < 0 && q16_Y > 0)
            {
                Console.WriteLine("Esta presente no segundo quadrante!");
            }
            else if (q16_X < 0 && q16_Y < 0)
            {
                Console.WriteLine("Esta presente no terceiro quadrante!");
            }
            else if (q16_X > 0 && q16_Y < 0)
            {
                Console.WriteLine("Esta presente no quarto quadrante!");
            }

            // Exercício 17 - Um Posto de combustíveis deseja determinar qual de seus
            // produtos tem a preferência de seus clientes.Escreva um algoritmo para ler o tipo
            // de combustível abastecido(codificado da seguinte forma:
            Console.WriteLine("Programa que retorna quais os combustiveis preferidos");
            Console.WriteLine("Insira o codigo referente a sua preferencia de combustivel ");
            int q17 = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            bool cont = true;

            while (cont = true)
            {

                while (q17 != 4)
                {

                    Console.WriteLine("Insira o codigo referente a sua preferencia de combustivel ");
                    Console.WriteLine("1.Álcool");
                    Console.WriteLine("2.Gasolina ");
                    Console.WriteLine("3.Diesel");
                    Console.WriteLine("4.Fim");
                    int q17_X = int.Parse(Console.ReadLine());
                    if (q17 = 1)
                    {
                        alcool = alcool + 1
                    }

                    else if (q17 = 2)
                    {
                        gasolina = gasolina + 1

                    }

                    else if (q17 = 3)
                    {
                        diesel = diesel + 1
                    }
                    else if (q17 = 4)
                    {
                        Console.WriteLine("Muito Obrigado!");
                    }

                    else
                    {
                        Console.WriteLine("Codigo invalido! Tente novamente.");
                    }

                    Console.WriteLine("Deseja continuar a votação?");
                    Console.WriteLine("1.Sim");
                    Console.WriteLine("2.Não ");
                    int q17 = int.Parse(Console.ReadLine());
                    if (q17 = 1)
                    {
                        cont = true;
                    }

                    else if (q17 = 2)
                    {
                        cont = false
                    }
                }
            }

            Console.WriteLine("Resultado");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");

            // Exercício 18 - Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os
            // ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso. //
            
            Console.WriteLine("Programa que retorna os numeros impares");
            Console.WriteLine("Digite o valor maximo do intervalo: ");
            int q18 = int.Parse(Console.ReadLine());
            cont = 0;
            while (cont < q18)
            {
                cont = cont + 1;

                if (cont % 2 =! 0)
                {
                    Console.WriteLine(cont + " impar");
                    cont = cont + 1;
                }
                else
                {
                    cont = cont + 1;
                }
            }

            // Exercício 19 - Leia um valor inteiro N. Este valor será a quantidade de valores
            // inteiros X que serão lidos em seguida.
            // Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos
            // estão fora do intervalo, mostrando essas informações conforme exemplo(use a
            // palavra "in" para dentro do intervalo, e "out" para fora do intervalo). //

            int q19_cont = 0;
            Console.WriteLine("Programa responde se o numero inserido esta entre o intervalo de 10 a 20");
            Console.WriteLine("Quantas analises deseja fazer? ");
            int q19 = int.Parse(Console.ReadLine());
            while (q19_cont < q19)
            {
                Console.WriteLine("Digite o valor: ");
                int q19_num = int.Parse(Console.ReadLine());
                if (10 < q19_num < 20)
                {
                    Console.WriteLine(q19_num + " out");
                }
                else
                {
                    Console.WriteLine(q19_num + " in");
                }
                cont = cont + 1;
            }

            // Exercício 20 - Leia 1 valor inteiro N, que representa o número de casos de teste
            // que vem a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles
            // com uma casa decimal.Apresente a média ponderada para cada um destes
            // conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor
            // tem peso 3 e o terceiro valor tem peso 5. //


            // Exercício 21 - Fazer um programa para ler um número N. Depois leia N pares de
            // números e mostre a divisão do primeiro pelo segundo.Se o denominador for
            // igual a zero, mostrar a mensagem "divisao impossivel".
            // Exercício 22 - Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial
            // de N = N * (N - 1) * (N - 2) * (N - 3) * ... *1.Lembrando que, por definição, fatorial de
            // 0 é 1.// 


            // Exercício 23 - Ler um número inteiro N e calcular todos os seus divisores.



            // Exercício 24 - Fazer um programa para ler um número inteiro positivo N. O
            // programa deve então mostrar na tela N linhas, começando de 1 até N.Para cada
            // linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            // exemplo. //





        }
    }
}
