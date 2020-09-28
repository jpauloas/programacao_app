using System;

namespace aula0925
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TipodeDado nomeDaVariavel = valor; */
            sbyte x = 1;
            
            Console.WriteLine("Hello World!"); /*escreve*/
            Console.WriteLine(x); /*exibe o valor de x*/

            byte y = 255;
            y++; /*adiciona mais um a variavel*/
            Console.WriteLine(y); /*vai imprimir 0, pois y so suporta ate 255 como byte*/

            sbyte z = 127;
            z++;
            Console.WriteLine(z)

            long n3 = 2147483648L;
            Console.WriteLine(n2);

            bool completo = false;
            Console.WriteLine(completo);

            bool incompleto = true;
            Console.WriteLine(incompleto);

            char genero = 'M';
            Console.WriteLine(incompleto);

            char letra = '\u0057';
            Console.WriteLine(letra);

            float n5 = 4.2f; /*precisa colocar f dps pois indica floatinh*/

            double n4 = 5.9;
            Console.WriteLine (n4)

            string nome = "João Paulo"; /*qnd um caracter aspa simples, mais de um aspas duplas*/
            Console.WriteLine(nome)

            nome = "Paulo"; /*nao declara dnv, apenas usa*/

            object obj1 = "nome";

            object obj2 = 5.7; /*recebe sem precisar declarar







        }
    }
}
