using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_04._1.Entidades
{
    class Tecnico : Assistente
    {
        public double ADICIONAL { get; set; }
        public double SALARIO { get; set; }


        public Tecnico(int matricula, double salario, double adicional) : base(matricula)
        {
            MATRICULA = matricula;
            ADICIONAL = adicional;
            SALARIO = salario + adicional;

        }

    }
}
