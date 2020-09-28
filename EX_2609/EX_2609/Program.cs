using System;

namespace EX_2609
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  1 )  Crie uma variável e imprima na tela cada um dos tipos de dados da tabela  */
            string ex01 = "bool" +
                "   byte " +
                "   sbyte" +
                "   char  " +
                "   decimal " +
                "   double" +
                "   float" +
                "   int" +
                "   uint" +
                "   long" +
                "   ulong" +
                "   short" +
                "   ushort";
            Console.WriteLine(ex01);

            /*  2 ) Exiba na tela o número da sua casa  */
            string ex02 = "Numero:  310";
            Console.WriteLine(ex02);

            /*  3 ) Exiba na tela o número de habitantes da terra.   */
            string ex03 = "Numero de habitantes:  7.735.084.676";
            Console.WriteLine(ex03);

            /*  4 ) Imprima na tela o valor do salário que você gostaria de receber. */
            string ex04 = "Salário:   3500";
            Console.WriteLine(ex04);

            /*  5 ) Exiba na tela o número do seu telefone celular*/
            string ex05 = "Celular:   31996073528";
            Console.WriteLine(ex05);

            /*  6 ) Imprima na tela o seu nome completo */
            string ex06 = "Nome:  João Paulo Araujo Souto";
            Console.WriteLine(ex06);

            /*  7 ) Faça um comentário qualquer no seu código. */
            /* Questao 03: comentário */

            /*  8 ) Utilizando Unicode e o tipo de dados char. Imprima na tela a letra R.*/
            char ex08 = U + 0052;
            Console.WriteLine(ex08);

            /*  9 ) Exiba na tela o valor máximo do data type ulong */
            string ex09 = "O valor máximo para tipo Ulong é de: 18,446,744,073,709,551,615";
            Console.WriteLine(ex09);

            /* 10 ) Exiba na tela o valor mínimo do data type long */
            string ex10 = "O valor minimo para tipo Long é de: -9,223,372,036,854,775,808";
            Console.WriteLine(ex10);
        }
    }
}
