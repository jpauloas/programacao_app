using System;
using System.Collections.Generic;
using System.Text;

namespace SA02_JOAO_PAULO_ARAUJO
{
        class Cadastro_Receitas
        {
            public int ID_RECEITA { get; set; } // Atributo que atua como chave primária 

            public string NOME_RECEITA { get; set; } // Atributo que armazena o nome da receita

            public double TEMPO_RECEITA { get; set; } // Atributo que armazena o tempo de preparo da receita

            public int CATEGORIA_RECEITA { get; set; } // Atributo que armazena a categoria da receita

            public int DIFICULDADE_RECEITA { get; set; } // Atributo que armazena o nivel de dificuldade de preparo da receita

            public string DESCRICAO_RECEITA { get; set; } // Atributo que armazena a descrição sobre a receita

            public string PREPARO_RECEITA { get; set; } // Atributo que armazena o modo de preparo da receita

            public double PRECO_RECEITA { get; set; } // Atributo que armazena o valor da receita

            public int PORCAO { get; set; } // Atributo que armazena o numero de porções que rende a receita

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

            public override string ToString() // retornos
            {
                return "Nome da receita: " + NOME_RECEITA +
                    "\n Tempo de preparo: " + TEMPO_RECEITA +
                    "\n Categoria: " + CATEGORIA_RECEITA +
                    "\n Nivel de dificuldade: " + DIFICULDADE_RECEITA +
                    "\n Descrição da receita: " + DESCRICAO_RECEITA +
                    "\n Modo de preparo: " + PREPARO_RECEITA +
                    "\n Valor: " + PRECO_RECEITA +
                    "\n Porções: " + PORCAO;

            }
        }

}
