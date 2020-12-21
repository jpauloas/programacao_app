using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_04._1.Entidades
{
    class Administrativo : Assistente
    {
        public bool TURNO { get; set; } // se o turno for noturno == true, se não == false
        public double ADICIONAL { get; set; }

        public double SALARIO { get; set; } 

        public Administrativo(int matricula, bool turno, double adicional, double salario) : base(matricula)
        {
            MATRICULA = matricula;
            TURNO = turno;

            if (turno == true)
            {
                ADICIONAL = adicional;
            }

            else
            {
                ADICIONAL = 0; 
            }

            SALARIO = salario + adicional;


        }

    }
}
