using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_04.Entidades
{
    class VIP : Ingressos
    {
        
        public VIP()
        {

        }

        public VIP (double valor, int id, double adicional ) : base (valor, id)
        {
            VALOR = valor + adicional;
            ID = id;
            
        }



    }
}
