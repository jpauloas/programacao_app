using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_04._2._1
{
    class Cachorro : Animal
    {
        public string LATE { get; set; }

        public Cachorro(string nome, string raca, string late) : base (nome, raca)
        {
              LATE = late;
        }

    }
}
