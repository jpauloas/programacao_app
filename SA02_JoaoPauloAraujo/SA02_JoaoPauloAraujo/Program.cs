using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace SA_02_Joao_Paulo_A_Souto
{
    class Program
    {
        static void Main(string[] args)
        {
            int id_receita; // Variavel que armazena o ID das receitas, sendo 1x1
            string nome_receita; //Variavel que armazena o nome das  receitas  , sendo 1x1
            double tempo_receita; //Variavel que armazena o tempo das receitas  , sendo 1x1
            int categoria_receita; //Variavel que armazena a categoria das  receitas  , sendo 1x1
            int dificuldade_receita; //Variavel que armazena a dificuldade das  receitas  , sendo 1x1
            string nome_ingrediente; //Variavel que armazena os ingredientes das  receitas  , sendo 1x10
            string cotacao_ingrediente; //Variavel que armazena a cotação dos ingredientes das  receitas  , sendo 1x10
            string descricao_receita;
            double preco_receita;
            int porcao;
            int escolha;
            string preparo_receita;
            int selecao; // Variavel que determina a escolha do primeiro menu sobre a receita
            int selecao02; // Variavel que determina o tipo de visualização sobre a receita
            int selecao_resposta;
            int cont_receita, cont_ingrediente; // contadores para cadastros de receitas e ingredientes
            int num; // variavel 

            List<Cadastro_Receitas> receitas = new List<Cadastro_Receitas>();
            List<Cadastro_Ingrediente> ingredientes = new List<Cadastro_Ingrediente>();

            Console.Clear();

            do
            {
                Menu_Principal:
                Console.WriteLine(" ");
                Console.WriteLine("Programa de Gestão de receitas de culinárias");
                Console.WriteLine(" ");
                Console.WriteLine("");
                Console.WriteLine("Atividades: ");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Novo cadastro");
                Console.WriteLine("2 - Visualizar receita ");
                Console.WriteLine("3 - Editar receita ");
                Console.WriteLine("4 - Excluir receita ");
                Console.WriteLine("0 - Sair");
                Console.WriteLine(" ");
                Console.WriteLine("");
                Console.Write("Digite a opção desejada: ");
                selecao = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (selecao)
                {

                    case 1:
                        Console.Clear();
                        menu_cadastro_receitas:
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("----------- Cadastro de receitas ----------- ");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("Cadastro Receita");
                        Console.WriteLine("");
                        Console.Write("ID receita: ");
                        id_receita = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.Write("Nome: ");
                        nome_receita = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Categoria da receita: ");
                        Console.WriteLine("1 -  Sobremessas ");
                        Console.WriteLine("2 -  Almoço ");
                        Console.WriteLine("3 -  Lanche  ");
                        Console.WriteLine("4 -  Janta ");
                        Console.WriteLine("5 -  Ceia ");
                        Console.WriteLine("6 -  Sucos/Vitaminas/Bebidas ");
                        categoria_receita = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Nivel de dificuldade: ");
                        Console.WriteLine("1 -  Fácil ");
                        Console.WriteLine("2 -  Moderado ");
                        Console.WriteLine("3 -  Difícil  ");
                        Console.WriteLine("");
                        Console.WriteLine("Digite a opção desejada: ");
                        dificuldade_receita = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("Modo de preparo");
                        Console.WriteLine("");
                        Console.WriteLine("Descrição da receita: ");
                        descricao_receita = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Metodo de preparo: ");
                        preparo_receita = Console.ReadLine();
                        Console.WriteLine("Tempo estimado de preparo (em horas): ");
                        tempo_receita = double.Parse(Console.ReadLine());
                        Console.WriteLine("Custo estimado: ");
                        preco_receita = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Porções individuais: ");
                        porcao = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        receitas.Add(new Cadastro_Receitas(id_receita, nome_receita, tempo_receita, categoria_receita, dificuldade_receita, descricao_receita, preparo_receita,
                                                            preco_receita, porcao));

                        menu_cadastro_ingrediente:
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("Cadastro de Ingredientes");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Nome do Ingrediente: ");
                        nome_ingrediente = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Cotação do ingrediente:");
                        cotacao_ingrediente = Console.ReadLine();
                        Console.WriteLine("");
                        ingredientes.Add(new Cadastro_Ingrediente(nome_ingrediente, cotacao_ingrediente, id_receita));


                        Console.WriteLine("Deseja cadastrar outro ingrediente a esta receita?");
                        Console.WriteLine("1 - SIM");
                        Console.WriteLine("2 - NAO");
                        Console.WriteLine("");
                        Console.WriteLine("Insira sua resposta:");
                        selecao_resposta = int.Parse(Console.ReadLine());

                        if (selecao_resposta == 1)
                        {
                            goto menu_cadastro_ingrediente;
                        }

                        Console.WriteLine("Deseja cadastrar outra receita?");
                        Console.WriteLine("1 - SIM");
                        Console.WriteLine("2 - NAO");
                        Console.WriteLine("");
                        Console.WriteLine("Insira sua resposta:");
                        selecao_resposta = int.Parse(Console.ReadLine());

                        if (selecao_resposta == 1)
                        {
                            goto menu_cadastro_receitas;
                        }

                        break;

                    case 2:
                        catalogo:
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("----------- Visualização de receitas ----------- ");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Escolha uma opção:  ");
                        Console.WriteLine("");
                        Console.WriteLine("1 - Listar todas");
                        Console.WriteLine("2 - Listar por Categoria");
                        Console.WriteLine("3 - Listar por nivel de dificuldade");
                        Console.WriteLine("4 - Todas");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Digite sua opção: ");
                        selecao02 = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________________");
                        switch (selecao02)
                        {
                            case 1:

                                foreach (var contador_rec in receitas)
                                {
                                    Console.WriteLine(contador_rec);
                                    Console.WriteLine("");
                                    foreach (var contador_ing in ingredientes)
                                    {
                                        if (contador_ing.ID_RECEITA_INGREDIENTE == contador_rec.ID_RECEITA)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("_____________________________________________________");
                                            Console.WriteLine("");
                                            Console.WriteLine(contador_ing);
                                            Console.WriteLine("");
                                            Console.WriteLine("_____________________________________________________");
                                            Console.WriteLine("");
                                        }
                                    }

                                }
                                Console.WriteLine("");
                                Console.WriteLine("_____________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("Deseja fazer outra busca?");
                                Console.WriteLine("1 - SIM");
                                Console.WriteLine("2 - NAO");
                                Console.WriteLine("");
                                Console.WriteLine("Insira sua resposta:");
                                selecao_resposta = int.Parse(Console.ReadLine());

                                if (selecao_resposta == 1)
                                {
                                    goto catalogo;
                                }
                                if (selecao_resposta == 2)
                                {
                                    goto Menu_Principal;
                                }
                                break;

                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("_____________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("Escolha uma opção de categorias  ");
                                Console.WriteLine(" ");
                                Console.WriteLine("1 -  Sobremessas ");
                                Console.WriteLine("2 -  Almoço ");
                                Console.WriteLine("3 -  Lanche  ");
                                Console.WriteLine("4 -  Janta ");
                                Console.WriteLine("5 -  Ceia ");
                                Console.WriteLine("6 -  Sucos/Vitaminas/Bebidas ");
                                Console.WriteLine(" ");
                                escolha = int.Parse(Console.ReadLine());

                                List<Cadastro_Receitas> receitas_selecionadas_02 = receitas.FindAll(x => x.DIFICULDADE_RECEITA == escolha);

                                foreach (Cadastro_Receitas r in receitas_selecionadas_02)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine(receitas_selecionadas_02);
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                }


                                Console.WriteLine("");
                                Console.WriteLine("_____________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("Deseja fazer outra busca?");
                                Console.WriteLine("1 - SIM");
                                Console.WriteLine("2 - NAO");
                                Console.WriteLine("");
                                Console.WriteLine("Insira sua resposta:");
                                selecao_resposta = int.Parse(Console.ReadLine());

                                if (selecao_resposta == 1)
                                {
                                    goto catalogo;
                                }
                                if (selecao_resposta == 2)
                                {
                                    goto Menu_Principal;
                                }

                                break;

                            case 3:
                                Console.WriteLine("");
                                Console.WriteLine("_____________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("Escolha uma opção de categorias  ");
                                Console.WriteLine(" ");
                                Console.WriteLine("1 -  Fácil ");
                                Console.WriteLine("2 -  Médio ");
                                Console.WriteLine("3 -  Díficil  ");

                                Console.WriteLine(" ");
                                escolha = int.Parse(Console.ReadLine());

                                List<Cadastro_Receitas> receitas_selecionadas_03 = receitas.FindAll(x => x.CATEGORIA_RECEITA == escolha);

                                foreach (Cadastro_Receitas r in receitas_selecionadas_03)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine(receitas_selecionadas_03);
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                }

                                Console.WriteLine("");
                                Console.WriteLine("_____________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("Deseja fazer outra busca?");
                                Console.WriteLine("1 - SIM");
                                Console.WriteLine("2 - NAO");
                                Console.WriteLine("");
                                Console.WriteLine("Insira sua resposta:");
                                selecao_resposta = int.Parse(Console.ReadLine());

                                if (selecao_resposta == 1)
                                {
                                    goto catalogo;
                                }
                                if (selecao_resposta == 2)
                                {
                                    goto Menu_Principal;
                                }


                                break;
                        }
                        break;
                }

            } while (selecao != 0);
        }
    }
}