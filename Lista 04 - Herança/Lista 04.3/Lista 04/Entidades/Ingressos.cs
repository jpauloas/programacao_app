using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_04.Entidades
{
    class Ingressos
    {
        public double VALOR {get;set;}
        public int ID { get; set; }

        public Ingressos()
        {
           
        }

        public Ingressos(double valor, int id)
        {
            VALOR = valor;
            ID = id;
        }

        public void ImprimeValor()
        {
            Console.WriteLine(VALOR);
        }
    }
}
