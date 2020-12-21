using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_04._2._1
{

    class Gato : Animal
    {
        public string MIA { get; set; }

        public Gato(string nome, string raca, string late, string mia) : base(nome, raca)
        {

            MIA = mia;
        }
    }
    
}
