using System;
using System.Collections.Generic;
using System.Text;

namespace SA_02_Joao_Paulo_A_Souto
{

    class Cadastro_Receitas
    {
        public int ID_RECEITA { get; set; }

        public string NOME_RECEITA { get; set; }

        public double TEMPO_RECEITA { get; set; }

        public int CATEGORIA_RECEITA { get; set; }

        public int DIFICULDADE_RECEITA { get; set; }

        public string DESCRICAO_RECEITA { get; set; }

        public string PREPARO_RECEITA { get; set; }

        public double PRECO_RECEITA { get; set; }

        public int PORCAO { get; set; }

        public Cadastro_Receitas(int id_receita, string nome_receita, double tempo_receita,
                                   int categoria_receita, int dificuldade_receita, string descricao_receita, string preparo_receita,
                                   double preco_receita, int porcao)
        {
            ID_RECEITA = id_receita;
            NOME_RECEITA = nome_receita;
            TEMPO_RECEITA = tempo_receita;
            CATEGORIA_RECEITA = categoria_receita;
            DIFICULDADE_RECEITA = dificuldade_receita;
            DESCRICAO_RECEITA = descricao_receita;
            PREPARO_RECEITA = preparo_receita;
            PRECO_RECEITA = preco_receita;
            PORCAO = porcao;

        }

        public override string ToString()
        {
            return "Nome da receita: " + NOME_RECEITA +
                "\n Tempo de preparo: " + TEMPO_RECEITA +
                "\n Categoria: " + CATEGORIA_RECEITA +
                "\n Nivel de dificuldade: " + DIFICULDADE_RECEITA +
                "\n Descrição da receita: " + DESCRICAO_RECEITA +
                "\n Modo de preparo: " + DESCRICAO_RECEITA +
                "\n Valor: " + DESCRICAO_RECEITA +
                "\n Porções: " + DESCRICAO_RECEITA;
                    
        }
    }

}
