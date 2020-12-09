using System;
using System.Collections.Generic;
using System.Text;

namespace SA_02_Joao_Paulo_A_Souto
{
    class Cadastro_Ingrediente
    {
        public string COTACAO_INGREDIENTE { get; set; }

        public string INGREDIENTES_RECEITA { get; set; }

        public int ID_RECEITA_INGREDIENTE { get; set; }


        public Cadastro_Ingrediente(string ingrediente_receita, string cotacao_ingrediente, int id_receita)
        {

            INGREDIENTES_RECEITA = ingrediente_receita;
            COTACAO_INGREDIENTE = cotacao_ingrediente;
            ID_RECEITA_INGREDIENTE = id_receita;
        }
        public override string ToString()
        {
            return "Nome do ingrediente: " + INGREDIENTES_RECEITA +
                "\n Cotação: " + COTACAO_INGREDIENTE;
           

        }
    }
}
