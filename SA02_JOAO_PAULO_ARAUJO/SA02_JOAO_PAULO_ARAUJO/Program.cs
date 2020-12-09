using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace SA02_JOAO_PAULO_ARAUJO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variaveis armazenadoras
            int id_receita; // Variavel que armazena o ID das receitas
            string nome_receita; //Variavel que armazena o nome das  receitas
            double tempo_receita; //Variavel que armazena o tempo das receitas
            int categoria_receita; //Variavel que armazena a categoria das  receitas
            int dificuldade_receita; //Variavel que armazena a dificuldade das  receitas
            string nome_ingrediente; //Variavel que armazena os ingredientes das  receitas
            string cotacao_ingrediente; //Variavel que armazena a cotação dos ingredientes das  receitas
            string descricao_receita; // Variavel que armazena a descrição da receita
            double preco_receita; // Variável que armazena o valor estimado da produção da receita
            int porcao; // Variavel que armazena o numero de porções que são servidas pela receita
            string preparo_receita; // Variável que armazena o modo de preparo da receita
            string unidade_ingrediente; // Variavel que armazena a unidade de medida da cotação

            //Variaveis auxiliadoras
            int escolha; // Variavel que auxilia no menu de busca, armazenando a resposta do usuário
            int escolha02; // Variavel que auxilia no menu de edição de receita, em um sub menu proprio
            int selecao; // Variavel que determina a escolha do primeiro menu sobre a receita
            int selecao02; // Variavel que determina o tipo de visualização sobre a receita
            int selecao_resposta; // Variavel que determina o retorno ao menu de cadastro, de acordo com a resposta do usuário



            List<Cadastro_Receitas> receitas = new List<Cadastro_Receitas>(); // Lista da classe Cadastro_Receita
            List<Cadastro_Ingrediente> ingredientes = new List<Cadastro_Ingrediente>(); // Lista da classe Cadastro_Ingrediente



            do
            {
                Menu_Principal: // Primeiro menu, onde são mostradas as opções 
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("_____________________________________________________");
                Console.WriteLine("");
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

                Console.WriteLine("");
                Console.WriteLine("_____________________________________________________");
                Console.WriteLine("");

                Console.Clear();

                switch (selecao)
                {

                    case 1:

                        menu_cadastro_receitas: // Sessão de cadastro de receitas
                        Console.Clear();

                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("               Cadastro de receitas");
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Cadastro Receita");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.Write("ID receita: ");
                        id_receita = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
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
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.Write("Digite a opção desejada: ");
                        categoria_receita = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Nivel de dificuldade: ");
                        Console.WriteLine("1 -  Fácil ");
                        Console.WriteLine("2 -  Moderado ");
                        Console.WriteLine("3 -  Difícil  ");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.Write("Digite a opção desejada: ");
                        dificuldade_receita = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Console.Clear();
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("                Modo de preparo");
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Descrição da receita: ");
                        descricao_receita = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Metodo de preparo: ");
                        preparo_receita = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Tempo estimado de preparo (em minutos): ");
                        tempo_receita = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.Write("Custo estimado: R$ ");
                        preco_receita = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Porções individuais: ");
                        porcao = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        receitas.Add(new Cadastro_Receitas(id_receita, nome_receita, tempo_receita, categoria_receita, dificuldade_receita, descricao_receita, preparo_receita,
                                                            preco_receita, porcao));

                        menu_cadastro_ingrediente: // Menu de cadastro de ingredientes
                        Console.Clear();

                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("              Cadastro de Ingredientes");
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________________");

                        Console.WriteLine("");
                        Console.WriteLine("Nome do Ingrediente: ");
                        nome_ingrediente = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Cotação do ingrediente:");
                        cotacao_ingrediente = Console.ReadLine();
                        Console.WriteLine("Unidade de medida:");
                        unidade_ingrediente = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("");


                        ingredientes.Add(new Cadastro_Ingrediente(nome_ingrediente, cotacao_ingrediente, unidade_ingrediente, id_receita)); // Envio das informações para a lista, em uma nova instanciação

                        Console.Clear();

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

                        Console.Clear();

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
                        catalogo: // Sessão de visualização de dados
                        Console.Clear();


                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("             Visualização de receitas");
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("Escolha uma opção:  ");
                        Console.WriteLine("");
                        Console.WriteLine("1 - Listar todas");
                        Console.WriteLine("2 - Listar por Categoria");
                        Console.WriteLine("3 - Listar por nivel de dificuldade");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.Write("Digite a opção desejada: ");
                        selecao02 = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________________");
                        switch (selecao02)
                        {
                            case 1: // Sessão de visualização de todas as receitas
                                Console.Clear();
                                Console.WriteLine("_____________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("                   Todas as receitas");
                                Console.WriteLine("");
                                Console.WriteLine("_____________________________________________________");


                                foreach (var r in receitas)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine(r);
                                    Console.WriteLine("");
                                    foreach (var i in ingredientes)
                                    {
                                        if (i.ID_RECEITA_INGREDIENTE == r.ID_RECEITA)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine(i);
                                            Console.WriteLine("");
                                        }
                                    }
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

                            case 2: // Sessão de visualização por categoria
                                Console.Clear();

                                Console.WriteLine("_____________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("                Receitas por categoria ");
                                Console.WriteLine("");
                                Console.WriteLine("_____________________________________________________");

                                Console.WriteLine("");
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
                                Console.WriteLine(" ");
                                Console.Write("Digite a opção desejada: ");
                                escolha = int.Parse(Console.ReadLine());

                                foreach (var r in receitas)
                                {
                                    if (r.CATEGORIA_RECEITA == escolha)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("_____________________________________________________");
                                        Console.WriteLine("");
                                        Console.WriteLine(r);
                                        Console.WriteLine("");
                                        foreach (var i in ingredientes)
                                        {
                                            if (i.ID_RECEITA_INGREDIENTE == r.ID_RECEITA)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine(i);
                                                Console.WriteLine("");
                                            }
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("_____________________________________________________");
                                        Console.WriteLine("");
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

                            case 3: // visualização de receitas por nivel
                                Console.Clear();

                                Console.WriteLine("");
                                Console.WriteLine("_____________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("                 Receitas por nível");
                                Console.WriteLine("");
                                Console.WriteLine("_____________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("Escolha uma opção de categorias  ");
                                Console.WriteLine(" ");
                                Console.WriteLine("1 -  Fácil ");
                                Console.WriteLine("2 -  Médio ");
                                Console.WriteLine("3 -  Díficil  ");

                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.Write("Digite a opção desejada: ");
                                escolha = int.Parse(Console.ReadLine());

                                foreach (var r in receitas)
                                {
                                    if (r.DIFICULDADE_RECEITA == escolha)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("_____________________________________________________");
                                        Console.WriteLine("");
                                        Console.WriteLine(r);
                                        Console.WriteLine("");
                                        foreach (var i in ingredientes)
                                        {
                                            if (i.ID_RECEITA_INGREDIENTE == r.ID_RECEITA)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine(i);
                                                Console.WriteLine("");
                                            }
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("_____________________________________________________");
                                        Console.WriteLine("");
                                    }

                                }
                                Console.WriteLine("");
                                Console.WriteLine("_____________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("Deseja fazer outra busca?");
                                Console.WriteLine("1 - SIM");
                                Console.WriteLine("2 - NAO");
                                Console.WriteLine("");
                                Console.Write("Insira sua resposta: ");
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

                    case 3: // Sessão de edição
                        Console.Clear();

                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("                 Edição de receita");
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o ID da receita que deseja alterar: ");
                        escolha = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("");

                        var alteracao = receitas.Find(x => x.ID_RECEITA == escolha);

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("");

                            menu_edicao_receita:
                            Console.WriteLine("O que deseja alterar? : ");

                            Console.WriteLine("1 -  Nome da receita ");
                            Console.WriteLine("2 -  Tempo ");
                            Console.WriteLine("3 -  Categoria  ");
                            Console.WriteLine("4 -  Dificuldade  ");
                            Console.WriteLine("5 -  Descrição da receita ");
                            Console.WriteLine("6 -  Modo de preparo ");
                            Console.WriteLine("7 -  Preço  ");
                            Console.WriteLine("8 -  Porções  ");
                            Console.WriteLine("9 -  Sair  ");
                            Console.WriteLine("");
                            Console.WriteLine("Digite a opção desejada: ");
                            escolha02 = int.Parse(Console.ReadLine());

                            switch (escolha02)
                            {
                                case 1: // sessão de alteração do valor do nome

                                    Console.Clear();
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("                     Alterar nome");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("Digite a opção desejada: ");

                                    alteracao.NOME_RECEITA = Console.ReadLine(); // Alteração dos valores

                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("             Alteração realizada com sucesso!");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("Deseja fazer outra alteração nesta mesma receita??");
                                    Console.WriteLine("1 - SIM");
                                    Console.WriteLine("2 - NAO");
                                    Console.WriteLine("");
                                    Console.Write("Insira sua resposta: ");
                                    selecao_resposta = int.Parse(Console.ReadLine());

                                    if (selecao_resposta == 1)
                                    {
                                        goto menu_edicao_receita;
                                    }
                                    


                                    break;

                                case 2: // sessão de alteração do valor do tempo

                                    Console.Clear();
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("                     Alterar Tempo");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("Digite a opção desejada (unidade em minutos): ");

                                    alteracao.TEMPO_RECEITA = double.Parse(Console.ReadLine()); // Alteração dos valores

                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("             Alteração realizada com sucesso!");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("Deseja fazer outra alteração nesta mesma receita??");
                                    Console.WriteLine("1 - SIM");
                                    Console.WriteLine("2 - NAO");
                                    Console.WriteLine("");
                                    Console.Write("Insira sua resposta: ");
                                    selecao_resposta = int.Parse(Console.ReadLine());

                                    if (selecao_resposta == 1)
                                    {
                                        goto menu_edicao_receita;
                                    }



                                    break;

                                case 3: // sessão de alteração do valor do numero da categoria geral

                                    Console.Clear();
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("                     Alterar Categoria");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("Categorias existentes: ");
                                    Console.WriteLine("");
                                    Console.WriteLine("1 -  Sobremessas ");
                                    Console.WriteLine("2 -  Almoço ");
                                    Console.WriteLine("3 -  Lanche  ");
                                    Console.WriteLine("4 -  Janta ");
                                    Console.WriteLine("5 -  Ceia ");
                                    Console.WriteLine("6 -  Sucos/Vitaminas/Bebidas ");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("Digite a opção desejada: ");

                                    alteracao.CATEGORIA_RECEITA = int.Parse(Console.ReadLine()); // Alteração dos valores

                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("             Alteração realizada com sucesso!");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("Deseja fazer outra alteração nesta mesma receita??");
                                    Console.WriteLine("1 - SIM");
                                    Console.WriteLine("2 - NAO");
                                    Console.WriteLine("");
                                    Console.Write("Insira sua resposta: ");
                                    selecao_resposta = int.Parse(Console.ReadLine());

                                    if (selecao_resposta == 1)
                                    {
                                        goto menu_edicao_receita;
                                    }
                                   

                                    break;

                                case 4: // sessão de alteração do valor do numero da categoria da dificuldade

                                    Console.Clear();
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("                     Alterar Dificuldade");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("Categorias existentes: ");
                                    Console.WriteLine("");
                                    Console.WriteLine("1 -  Fácil ");
                                    Console.WriteLine("2 -  Médio ");
                                    Console.WriteLine("3 -  Díficil  ");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("Digite a opção desejada: ");

                                    alteracao.CATEGORIA_RECEITA = int.Parse(Console.ReadLine()); // Alteração dos valores

                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("             Alteração realizada com sucesso!");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("Deseja fazer outra alteração nesta mesma receita??");
                                    Console.WriteLine("1 - SIM");
                                    Console.WriteLine("2 - NAO");
                                    Console.WriteLine("");
                                    Console.Write("Insira sua resposta: ");

                                    selecao_resposta = int.Parse(Console.ReadLine());

                                    if (selecao_resposta == 1)
                                    {
                                        goto menu_edicao_receita;
                                    }
                                   
                                    break;

                                case 5:

                                    Console.Clear();
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("                     Alterar Descrição");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("Digite uma nova descrição: ");

                                    alteracao.DESCRICAO_RECEITA = Console.ReadLine(); // Alteração dos valores

                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("             Alteração realizada com sucesso!");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("Deseja fazer outra alteração nesta mesma receita??");
                                    Console.WriteLine("1 - SIM");
                                    Console.WriteLine("2 - NAO");
                                    Console.WriteLine("");
                                    Console.Write("Insira sua resposta: ");

                                    selecao_resposta = int.Parse(Console.ReadLine());

                                    if (selecao_resposta == 1)
                                    {
                                        goto menu_edicao_receita;
                                    }
                                   

                                    break;

                                case 6: // sessão de alteração do valor do numero de modo de preparo

                                    Console.Clear();
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("                  Alterar Modo de Preparo");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("Digite um novo modo de preparo:  ");

                                    alteracao.PREPARO_RECEITA = Console.ReadLine(); // Alteração dos valores

                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("             Alteração realizada com sucesso!");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("Deseja fazer outra alteração nesta mesma receita??");
                                    Console.WriteLine("1 - SIM");
                                    Console.WriteLine("2 - NAO");
                                    Console.WriteLine("");
                                    Console.Write("Insira sua resposta: ");

                                    selecao_resposta = int.Parse(Console.ReadLine());

                                    if (selecao_resposta == 1)
                                    {
                                        goto menu_edicao_receita;
                                    }
                                   

                                    break;

                                case 7: // sessão de alteração do valor do numero de custo

                                    Console.Clear();
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("                  Alterar o valor do Custo");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.Write("Insira o novo valor do custo estimado: R$ ");

                                    alteracao.PRECO_RECEITA = double.Parse(Console.ReadLine()); // Alteração dos valores

                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("             Alteração realizada com sucesso!");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("Deseja fazer outra alteração nesta mesma receita??");
                                    Console.WriteLine("1 - SIM");
                                    Console.WriteLine("2 - NAO");
                                    Console.WriteLine("");
                                    Console.Write("Insira sua resposta: ");
                                    selecao_resposta = int.Parse(Console.ReadLine());

                                    if (selecao_resposta == 1)
                                    {
                                        goto menu_edicao_receita;
                                    }
                                    

                                    break;

                                case 8: // sessão de alteração do valor do numero de porções

                                    Console.Clear();
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("                  Alterar o numero de porções");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.Write("Insira o novo valor estimado de porções:  ");

                                    alteracao.PORCAO = int.Parse(Console.ReadLine()); // Alteração dos valores

                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("             Alteração realizada com sucesso!");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("_____________________________________________________");
                                    Console.WriteLine("");
                                    Console.WriteLine("Deseja fazer outra alteração nesta mesma receita??");
                                    Console.WriteLine("1 - SIM");
                                    Console.WriteLine("2 - NAO");
                                    Console.WriteLine("");
                                    Console.Write("Insira sua resposta: ");
                                    selecao_resposta = int.Parse(Console.ReadLine());

                                    if (selecao_resposta == 1)
                                    {
                                        goto menu_edicao_receita;
                                    }
                                  

                                    break;

                            }

                        } while (escolha02 != 9);

                        break;

                    case 4:// Sessão de exclusão de registros
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("                 Exclusão de receita");
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o ID da receita que deseja excluir: ");
                        escolha = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("");
                        var remocao_receita = receitas.RemoveAll(x => x.ID_RECEITA == escolha); // Remõção de todos os cadastros onde o ID_RECEITA é igual ao ID digitado
                        var remocao_ingrediente = ingredientes.RemoveAll(x => x.ID_RECEITA_INGREDIENTE == escolha); // Remoção de todos os cadastros onde o ID_RECEITA_INGREDIENTE é igual ao ID digitado
                        break;
                }

            } while (selecao != 0);
        }
    }
}