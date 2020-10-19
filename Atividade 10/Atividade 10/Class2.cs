using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_10
{
     
    class Media_funcionarios
   {
            public string Nome1;
            public string Nome2;

            public double Salario1;
            public double Salario2;

            public double resultado()
            {

                double resultado = (Salario1 + Salario2) / 2;
                return resultado;
            }
    }
}
