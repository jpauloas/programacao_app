using System;
using System.Collections.Generic;
using System.Text;

namespace Atv_22.Entidades
{
    class Aquatico : Veiculo
    {
        public string MODELO { get; set; }

        public int PASSAGEIROS { get; set; }

        public string LICENCA { get; set; }


        public Aquatico(int placa, string combustivel, bool aluguel, string modelo, int passageiros, string licenca) : base(placa, combustivel, aluguel)
        {
            MODELO = modelo;
            PASSAGEIROS = passageiros;
            LICENCA = licenca;
        }

        public void Legalizacao(string licenca)
        {
            LICENCA = licenca;
        }



    }
}
