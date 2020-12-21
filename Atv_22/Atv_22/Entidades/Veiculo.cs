using System;
using System.Collections.Generic;
using System.Text;

namespace Atv_22.Entidades
{
    class Veiculo
    {
        public int PLACA { get; set; }

        public string COMBUSTIVEL {get; set;} 

        public bool ALUGUEL { get; set; }

        public Veiculo ( int placa, string combustivel, bool aluguel)
        {
            PLACA = placa;
            COMBUSTIVEL = combustivel;
            ALUGUEL = aluguel;
        }

        public void Emprestimo (bool aluguel)
        {

        }


    }
}
