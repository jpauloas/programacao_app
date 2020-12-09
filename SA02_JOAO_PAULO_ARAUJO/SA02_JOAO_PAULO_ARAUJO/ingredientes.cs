using System;
using System.Collections.Generic;
using System.Text;

namespace SA02_JOAO_PAULO_ARAUJO
{
    class Cadastro_Ingrediente
    {
        public string COTACAO_INGREDIENTE { get; set; } // Atributo que armazena a cotação/quantidade de ingrediente 

        public string INGREDIENTES_RECEITA { get; set; } // Atributo que armazena o nome do ingrediente

        public string UNIDADE_INGREDIENTE { get; set; }  // Atributo que armazena a unidade de medida do ingrediente

        public int ID_RECEITA_INGREDIENTE { get; set; } // Atributo que atua como chave estrageira e conecta as informações desta classe com a classe "Cadastro_Receita" 


        public Cadastro_Ingrediente(string ingrediente_receita, string cotacao_ingrediente, string unidade_ingrediente, int id_receita)
        {

            INGREDIENTES_RECEITA = ingrediente_receita;
            COTACAO_INGREDIENTE = cotacao_ingrediente;
            ID_RECEITA_INGREDIENTE = id_receita;
            UNIDADE_INGREDIENTE = unidade_ingrediente;
        }
        public override string ToString() // retorno
        {
            return "Nome do ingrediente: " + INGREDIENTES_RECEITA +
                "\n Cotação: " + COTACAO_INGREDIENTE + "\n Unidade de medida: " + UNIDADE_INGREDIENTE;



        }
    }
}