using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_04.Entidades
{
    class Normal : Ingressos
    {

        public Normal (double valor, int id) : base(valor, id)
        {
            VALOR = valor;
            ID = id;
            
        }

        public override string ToString()
        {
            return VALOR.ToString( "Valor: " + VALOR);
        }
        

    }
            
}
