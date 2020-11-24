using System;

namespace Atv18
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1) Uma variável do tipo int receber null 
            Nullable<int> q1 = null;

            // 2) Uma variável do tipo long receber null
            long? q2 = null;

            // 3) Uma variável do tipo ushort receber null
            Nullable <ushort> q3 = null;

            // 4) Uma variável do tipo double receber null
            Nullable<double> q4 = null;

            // 5) Uma variável do tipo int receber 34, caso o valor da questão 1 for null.
            int q5 = q1 ?? 34;

            // 6) Uma variável do tipo long receber 65000000, caso o valor da questão 2 seja null.
            long q6 = q2 ?? 65000000;

            // 7) Uma variável do tipo ushort receber 500, caso o valor da questão 3 seja null.
            ushort q7 = q3 ?? 500;

            // 8) Uma variável do tipo double receber 7.50, caso o valor da questão 4 seja null 
            double q8 = q4 ?? 7.50;

            // 9) Utilizando o método GetValueOrDefault. Exiba o valor da questão 5.
            Console.WriteLine(q5.GetValueOrDefault());

            // 10) Utilizando o método HasValue. Exiba o valor da questão 6.
            Console.WriteLine(q6.HasValue);

            // 11) Utilizando o método Value. Exiba o valor da questão 7. 
            Console.WriteLine(q7.Value); 


            
        }
    }
}
