using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_04.Entidades
{
    class CamaroteInferior : VIP
    {
        public int CADEIRA; 

        public CamaroteInferior()
        {

        }

        public CamaroteInferior(double valor, int id, double adicional, int cadeira) : base(valor, id, adicional)
        {
            VALOR = valor + adicional;
            ID = id;
            CADEIRA = cadeira;

        }

        public override string ToString()
        {
            return CADEIRA.ToString();

        }

    }
}
