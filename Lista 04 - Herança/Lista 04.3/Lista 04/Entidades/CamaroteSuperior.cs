using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_04.Entidades
{
    class CamaroteSuperior : VIP
    {

        public int CADEIRA;

        public CamaroteSuperior()
        {

        }

        public CamaroteSuperior(double valor, int id, double adicional, int cadeira) : base(valor, id, adicional)
        {
            VALOR = valor + adicional + 40;
            ID = id;
            CADEIRA = cadeira;

        }


        public override string ToString()
        {
            return CADEIRA.ToString();

        }
    }
}
