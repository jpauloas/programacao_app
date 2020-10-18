using System;
using System.Collections.Generic;
using System.Text;

namespace Atv11
{
    class Q02
    {
        public double SALARIO;
        public double IMPOSTO;
        public string NOME;

        public void AumentarSalario (double aumento)
        {
            SALARIO = SALARIO + SALARIO * (aumento/100) - IMPOSTO;
          
         }




    }
}
