using System;

namespace Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 1 */
            //Leia um número e exiba seu sucessor.//

            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("O sucessor desse número é: " + n1++);


            /* Exercicio 2 */

            /*Calcular a média final (usando a ponderação da UFRN) dadas as notas das 3 provas e
              produzir uma saída com a média e a situação do aluno de acordo com o seguinte critério:
              média >= 7, aprovado; 5 < média < 7, recuperação; média < 5, reprovado.*/

            Console.Write("Digite a nota da primeira prova: ");
            float q2_p1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a nota da segunda prova: ");
            float q2_p2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a nota da terceira prova: ");
            float q2_p3 = float.Parse(Console.ReadLine());

            float media = (q2_p1 + q2_p2 + q2_p3) / 3;
            if (media < 5)
            {
                Console.WriteLine($"A média das notas do aluno é {media} e a situação: Reprovado");
            }
            else if (media < 7)
            {
                Console.WriteLine($"A média das notas do aluno é {media} e a situação: Recuperação");
            }
            else if (media >= 7)
            {
                Console.WriteLine("A média das notas do aluno é {media} e a situação: Aprovado");
            }


            /* Exercicio 3 */
            /* Calcular a quantidade dinheiro gasta por um fumante. Dados: o número de anos que ele
                fuma, o no de cigarros fumados por dia e o preço de uma carteira. */


            Console.Write("Digite o numero de anos: ");
            int anos = int.Parse(Console.ReadLine());
            Console.Write("Digite o total de cigarros fumados por dia: ");
            int numC = int.Parse(Console.ReadLine());
            Console.Write("Digite o preço de uma carteira: ");
            float precoC = float.Parse(Console.ReadLine());

            float gastoC = (numC * 365 * anos * precoC);
            Console.WriteLine("A quantidade de dinheiro gasta pelo fumante é de: " + gastoC);


            /* Exercicio 4 */
            /*Ler dois números inteiros, x e y, e imprimir o quociente e o resto da divisão inteira entre
              eles.*/

            Console.Write("Digite um número inteiro: ");
            int q401 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número inteiro: ");
            int q402 = int.Parse(Console.ReadLine());
            int q4_quociente = q401 / q402;
            int q4_resto = q401 % q402;
            Console.WriteLine($"O quociente da divisão de {q401} por {q402} é {q4_quociente} e o resto é {q4_resto}");


            /* Exercicio 6 */

            /*Para ler dois valores reais do teclado, calcular e imprimir na tela:
             a) A soma destes valores b) O produto deles c) O quociente entre eles*/

            Console.Write("Informe um valor: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe outro valor: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double soma = valor1 + valor2;
            double produto = valor1 * valor2;
            double quociente = valor1 / valor2;

            Console.WriteLine("A soma de " + valor1 + " e " + valor2 + " é igual a: " + soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O produto de " + valor1 + " e " + valor2 + " é igual a: " + produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O quociente de " + valor1 + " e " + valor2 + " é igual a: " + quociente.ToString("F2", CultureInfo.InvariantCulture));


            /* Exercicio 7*/
            /*Para ler 3 números reais do teclado e verificar se o primeiro é maior que a soma dos outros
              dois.*/

            Console.Write("Informe o primeiro valor: ");
            double q7v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o segundo valor: ");
            double q7v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o terceiro valor: ");
            double q7v3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double q7soma = q7v2 + q7v3;

            if (q7v1 > soma)
            {
                Console.WriteLine("O primeiro valor é maior que a soma do segundo com o terceiro valor.");
            }
            else
            {
                Console.WriteLine("O primeiro valor não é maior que a soma do segundo com o terceiro valor.");
            }

            /* Exercicio 9*/
            /*Ler um nome do teclado e ver se é igual ao seu nome. Imprimir conforme o caso: “NOME
              CORRETO” ou “NOME INCORRETO”.*/

            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();
            if (nome == "João Paulo")
            {
                Console.WriteLine("NOME CORRETO");
            }
            else
            {
                Console.WriteLine("NOME INCORRETO");
            }

            /* Exercicio 10*/
            /* Ler 2 números inteiros do teclado (A e B), verificar e imprimir qual deles é o maior, ou a
                mensagem “A=B” caso sejam iguais.*/

            Console.Write("Informe o valor inteiro de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor inteiro de B: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("A é maior que B.");
            }
            else if (b > a)
            {
                Console.WriteLine("B é maior que A.");
            }
            else if (a == b)
            {
                Console.WriteLine("A = B");
            }


            /* Exercicio 11*/
            /*Que gere o preço de um carro ao consumidor e os valores pagos pelo imposto e pelo lucro
              do distribuidor, sabendo o custo de fábrica do carro e que são pagos: a) de imposto: 45%
               sobre o custo do carro; b) de lucro do distribuidor: 12% sobre o custo do carro.*/
            Console.Write("Informe o preço do carro: ");
            double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = p * 45 / 100;
            double lucro = p * 12 / 100;

            Console.WriteLine("O imposto a ser pago é de " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O lucro do distribuidor é de " + lucro.ToString("F2", CultureInfo.InvariantCulture));

            /* Exercicio 12*/
            /*  Leia a velocidade máxima permitida em uma avenida e a velocidade com que o motorista
                estava dirigindo nela e calcule a multa que uma pessoa vai receber, sabendo que são pagos:
                a) 50 reais se o motorista estiver ultrapassar em até 10km/h a velocidade permitida (ex.:
                velocidade máxima: 50km/h; motorista a 60km/h ou a 56km/h); b) 100 reais, se o motorista
                ultrapassar de 11 a 30 km/h a velocidade permitida. c) 200 reais, se estiver acima de 31km/h
                da velocidade permitida.*/

            Console.Write("Informe a velocidade máxima permitida na avenida: ");
            int vM = int.Parse(Console.ReadLine());
            Console.Write("Informe a velocidade percorrida: ");
            int vP = int.Parse(Console.ReadLine());

            int multa = vP - vM;

            if (multa > 0 && multa <= 10)
            {
                Console.WriteLine("O valor da multa é de R$50,00.");
            }
            else if (multa > 11 && multa <= 30)
            {
                Console.WriteLine("O valor da multa é de R$100,00.");
            }
            else if (multa > 31)
            {
                Console.WriteLine("O valor da multa é de R$200,00.");
            }


            /* Exercicio 13*/
            /*Sabendo que latão é constituído de 70% de cobre e 30% de zinco, indique a quantidade de
            cada um desses componentes para se obter uma certa quantidade de latão (requerida pelo
            usuário).*/

            Console.Write("Informe um número inteiro: ");
            int q12n1 = int.Parse(Console.ReadLine());
            Console.Write("Informe outro número inteiro: ");
            int q12n2 = int.Parse(Console.ReadLine());
            if (q12n2 != 0)
            {
                int quociente = q12n1 / q12n2;
                Console.WriteLine($"O quociente de {q12n1} por {q12n2} é igual a {quociente}");
            }
            else
            {
                Console.WriteLine("DIVISÃO POR ZERO");
            }

            /* Exercicio 15*/
            /*Ler três valores e determinar o maior dentre eles.*/
            Console.WriteLine("Informe o valor de A: ");
            double q15a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o valor de B: ");
            double q15b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o valor de C: ");
            double q15c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (q15a > q15b && q15a > q15c)
            {
                Console.WriteLine("Maior valor: A");
            }
            else if (q15b > q15a && q15b > q15c)
            {
                Console.WriteLine("Maior valor: B");
            }
            else if (q15c > q15a && q15c > q15b)
            {
                Console.WriteLine("Maior valor: C");
            }

            /*-Exercicio 16 */
            /* Ler três valores e colocá-los em ordem crescente.*/
            Console.Write("Informe o 1° valor: ");
            int q16v1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o 2° valor: ");
            int q16v2 = int.Parse(Console.ReadLine());
            Console.Write("Informe o 3° valor: ");
            int q16v3 = int.Parse(Console.ReadLine());
            int maior;
            int medio;
            int menor;

            if ((q16v1 > q16v2) && (q16v1 > q16v3))
            {

                maior = q16v1;
                if (q16v2 > q16v3)
                {
                    medio = q16v2;
                    menor = q16v3;
                }
                else
                {
                    medio = q16v3;
                    menor = q16v2;
                }
                Console.WriteLine($"{menor}, {medio}, {maior}");
            }
            if ((q16v2 > q16v1) && (q16v2 > q16v3))
            {

                maior = q16v2;
                if (q16v1 > q16v3)
                {
                    medio = q16v1;
                    menor = q16v3;
                }
                else
                {
                    medio = q16v3;
                    menor = q16v1;
                }
                Console.WriteLine($"{menor}, {medio}, {maior}");
            }
            if ((q16v3 > q16v1) && (q16v3 > q16v2))
            {

                maior = q16v3;
                if (q16v2 > q16v1)
                {
                    medio = q16v2;
                    menor = q16v1;
                }
                else
                {
                    medio = q16v1;
                    menor = q16v2;
                }
                Console.WriteLine($"{menor}, {medio}, {maior}");

                /* Exercicio 17 */
                /* Ler os três coeficientes de uma equação de segundo grau e determinar suas raízes.*/
                Console.Write("Informe o valor de A: ");
                double q17v1 = double.Parse(Console.ReadLine());
                Console.Write("Informe o valor de B: ");
                double q17v2 = double.Parse(Console.ReadLine());
                Console.Write("Informe o valor de C:");
                double q17v3 = double.Parse(Console.ReadLine());
                double q17delta = q17v2 * q17v2 - 4 * q17v1 * q17v3;

                if (q17delta >= 0)
                {
                    double q17r1 = (-q17v2 + Math.Sqrt(q17delta) / (2 * q17v1));
                    double q17r2 = (-q17v2 - Math.Sqrt(q17delta) / (2 * q17v1));

                }

                else
                {
                    Console.WriteLine("Não existem raízes reais");
                }

                /* Exercicio 18
                 * três valores do teclado e dizer se eles formam um triângulo. Caso afirmativo, dizer seu
                   tipo (equilátero, isósceles ou escaleno).*/

                /* Exercicio 19 
                 * Ler 4 números inteiros e calcular a soma dos que forem par.*/
                Console.Write("Programa que soma numeros pares ");
                double q19soma = 0;
                int q19;
                for (q19 = 1; q19 <= 4; q19++)
                {
                    Console.Write("Informe um valor: ");
                    double q19num = double.Parse(Console.ReadLine());
                    if (q19num % 2 == 0)
                    {
                        q19soma = q19soma + q19num;

                    }
                }

                /* Exercicio 20
                 * Que informe se um dado ano é ou não bissexto. Obs: um ano é bissexto se ele for divisível
                    por 400 ou se ele for divisível por 4 e não por 100.*/

                Console.Write("Programa que aponta se o ano é bissexto ");
                Console.Write("Informe o ano: ");
                double q20ano = double.Parse(Console.ReadLine());
                
                if (q20ano % 400 == 0 || q20ano % 4 == 0 && q20ano % 100 =! 0 )
                {
                    Console.Write("Ano bissexto!");
                }
                else
                {
                    Console.Write("Ano convencional!");
                }

            }
        }
    }
}