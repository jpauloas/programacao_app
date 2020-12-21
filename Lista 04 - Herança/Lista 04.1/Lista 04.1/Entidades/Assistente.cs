using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_04._1.Entidades
{
    class Assistente : Funcionario
    {
        public int MATRICULA { get; set; }

        public Assistente(int matricula) : base()
        {
            MATRICULA = matricula; 
        }

        public override string ToString()
        {
            return MATRICULA.ToString();
        }

    }
}
