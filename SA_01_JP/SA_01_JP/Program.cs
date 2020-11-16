using System;

namespace SA_01_JP
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] nomecliente = new string[10]; // variavel para a sessão de cadastro de cliente
            string[] nomeproduto = new string[10]; // variavel para cadastro de produto
            int[] qtd_vendida = new int[10];
            int[] qtd_estoque = new int[10];
            int[] ID_cliente = new int[10];
            int[] ID_venda = new int[10];
            int[] ID_produto = new int[10];
            int[] ID_produto_vendido = new int[10];
            int[] CPF_cliente_venda = new int[10];
            double[] valor_venda = new double[10];
            bool sequencia = true;

            Console.WriteLine(" ----------------------  Padaria Pão do Céu   ----------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Programa de controle de vendas");
            Console.WriteLine(" ");

            while (sequencia == true)
            {
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Cliente ");
                Console.WriteLine("2 - Vendas");
                Console.WriteLine("3 - Produto");
                Console.WriteLine("4 - Estatisticas");
                Console.WriteLine("0 - Encerrar programa");

                int resposta = int.Parse(Console.ReadLine());



                if (resposta == 1)
                {
                    Console.WriteLine(" ------ Cliente ---------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Cadastro de cliente");
                    Console.WriteLine(" ");
                    Console.WriteLine("Deseja cadastrar quantos clientes? ");
                    Console.WriteLine("Numero máximo de clientes: 10");
                    int ic = int.Parse(Console.ReadLine());
                    int i;
                    for (i = 0; i < ic; i++)
                    {
                        Console.WriteLine("Nome:  ");
                        nomecliente[i] = Console.ReadLine();
                        Console.WriteLine("CPF:  ");
                        ID_cliente[i] = int.Parse(Console.ReadLine());

                    }

                }

                else if (resposta == 2)
                {
                    Console.WriteLine(" ------ Vendas ---------");  // Registro de vendas //
                    Console.WriteLine(" ");
                    Console.WriteLine("Cadastro de vendas");
                    Console.WriteLine(" ");
                    Console.WriteLine("Quantas vendas deseja cadastrar? ");
                    Console.WriteLine("Numero máximo de vendas: 10");
                    int iv = int.Parse(Console.ReadLine()); // variavel auxiliar //
                    int i;
                    for (i = 0; i < iv; i++) // codigo para o cadastro, cada venda comportaria um produto. Por questões de praticidade coloquei um numero maximo de cadastros //
                    {
                        Console.WriteLine("ID da venda:  ");
                        ID_venda[i] = int.Parse(Console.ReadLine());  // variavel que armazena o ID da venda
                        Console.WriteLine("CPF do cliente:  ");
                        CPF_cliente_venda[i] = int.Parse(Console.ReadLine()); // Cadastro do cpf do cliente na nota
                        Console.WriteLine("ID do produto vendido:  ");
                        ID_produto_vendido[i] = int.Parse(Console.ReadLine());// variavel que armazena o ID do prduto vendido
                        Console.WriteLine("Quantidade vendida:  ");
                        qtd_vendida[i] = int.Parse(Console.ReadLine()); // variavel que armazena a quantidade do produto vendido
                        Console.WriteLine("Valor da venda:  ");
                        valor_venda[i] = double.Parse(Console.ReadLine()); // variavel que armazena o valor final da venda
                    }

                }

                else if (resposta == 3)
                {
                    Console.WriteLine(" ------ Produto ---------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Cadastro de produto");
                    Console.WriteLine(" ");
                    Console.WriteLine("Quantos produtos deseja cadastrar? ");
                    Console.WriteLine("Numero máximo de produtos: 10");
                    int ip = int.Parse(Console.ReadLine());
                    int i;
                    for (i = 0; i < ip; i++)
                    {

                        Console.WriteLine("ID do produto:  ");
                        ID_produto[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Quantidade em estoque:  ");
                        qtd_estoque[i] = int.Parse(Console.ReadLine());

                    }

                }

                else if (resposta == 4)
                {
                    Console.WriteLine(" -------- Estatistica ---------"); // Opção de analise dos cadastros realizados
                    Console.WriteLine(" ");
                    Console.WriteLine("Marque a opção desejada");
                    Console.WriteLine("1 - Maior venda ");
                    Console.WriteLine("2 - Menor venda");
                    Console.WriteLine("3 - Produto mais vendido");
                    Console.WriteLine("4 - Produto menos vendido");
                    Console.WriteLine("5 - Vendas por cliente ");
                    Console.WriteLine("6 - Vendas por produto ");

                    Console.WriteLine(" ");
                    Console.WriteLine("Marque a opção desejada");
                    int resp;
                    resp = int.Parse(Console.ReadLine());

                    if (resp == 1) // Maior Venda //
                    {
                        Console.WriteLine("Maior Venda");
                        int i;
                        int venda = ID_venda[0];
                        double maior = valor_venda[0]; // Variavel que será preenchida com o maior valor //
                        for (i = 0; i < 10; i++) // Codigo de analise, faz o ensaio ate os 10 valores cadastrados //
                        {

                            if (valor_venda[i] > maior) // Quando o valor da quanidade é maior que o valor armazenado na variavel ele passa a preencher a própria variável Maior //
                            {
                                maior = valor_venda[i]; // preenchimento da maior venda
                                venda = ID_venda[i]; // preenchimento do ID da maior venda
                            }
                            Console.WriteLine($"A maior venda foi a do ID {venda}, com valor de R$ {maior}."); // Mensagem de resposta
                        }

                    }

                    if (resp == 2)
                    {
                        Console.WriteLine("Menor Venda"); // Menor Venda //
                        int i;
                        int venda = ID_venda[0];
                        double menor = valor_venda[0]; // Variavel que será preenchida com o maior valor //
                        for (i = 0; i < 10; i++) // Codigo de analise, faz o ensaio ate os 10 valores cadastrados //
                        {

                            if (valor_venda[i] < menor) // Quando o valor da quanidade é menor que o valor armazenado na variavel ele passa a preencher a própria variável menor //
                            {
                                menor = valor_venda[i]; // preenchimento da maior venda
                                venda = ID_venda[i]; // preenchimento do ID da maior venda
                            }
                            Console.WriteLine($"A maior venda foi a do ID {venda}, com valor de R$ {menor}."); // Mensagem de resposta
                        }


                    }

                    if (resp == 3) // Produto mais vendido //
                    {
                        Console.WriteLine("Produto mais vendido");
                        int i;
                        int maior = qtd_vendida[0]; // Variavel que será preenchida com o maior valor //
                        string NomeProduto = nomeproduto[0];
                        for (i = 0; i < 10; i++) // Codigo de analise, faz o ensaio ate os 10 valores cadastrados //
                        {

                            if (qtd_vendida[i] > maior) // Quando o valor da quanidade é maior que o valor armazenado na variavel ele passa a preencher a própria variável Maior //
                            {
                                maior = qtd_vendida[i];
                                NomeProduto = nomeproduto[i];
                            }
                            Console.WriteLine($"O produto mais vendido em uma venda foi {NomeProduto}, com {maior} unidades vendidas.");
                        }

                    }

                    if (resp == 4) // Produto menos vendido //
                    {
                        Console.WriteLine("Produto menos vendido");
                        int i;
                        string NomeProduto = nomeproduto[0];
                        int menor = qtd_vendida[0]; // Variavel que será preenchida com o maior valor //

                        for (i = 0; i < 10; i++) // Codigo de analise, faz o ensaio ate os 10 valores cadastrados //
                        {

                            if (qtd_vendida[i] < menor) // Quando o valor da quanidade é maior que o valor armazenado na variavel ele passa a preencher a própria variável Maior //
                            {
                                menor = qtd_vendida[i];
                                NomeProduto = nomeproduto[i];
                            }
                            Console.WriteLine($"O produto menos vendido em uma venda foi {NomeProduto}, com {menor} unidades vendidas.");
                        }
                    }

                    if (resp == 5) // Vendas por Cliente  //
                    {
                        Console.WriteLine("Vendas por cliente");
                        int i, y;

                        for (i = 0; i < 10; i++)
                        {
                            for (y = 0; y < 10; y++)
                            {
                                if (ID_cliente[i] == CPF_cliente_venda[y]) // Interseção de dados quando o valor do ID do cadastro de clientes é igual ao valor do CPF da nota //
                                {
                                    Console.WriteLine($"Cliente: {nomecliente[i]}; realizou a compra da venda {ID_venda[y]}; no valor de R$ {valor_venda[y]}. "); // resultados
                                }

                            }
                        }

                    }

                    if (resp == 5) // Vendas por produto  //
                    {
                        Console.WriteLine("Vendas por produto");
                        int i, y;

                        for (i = 0; i < 10; i++)
                        {
                            for (y = 0; y < 10; y++) // Codigo de analise, faz o ensaio ate os 10 valores cadastrados 
                            {
                                if (ID_produto[i] == ID_produto_vendido[y]) // Interseção de dados quando o valor do ID do cadastro de clientes é igual ao valor do CPF da nota //
                                {
                                    Console.WriteLine($"Produto: {nomeproduto[i]}; teve {qtd_vendida[y]} unidades vendidas na venda {ID_venda[y]}. "); // resultados
                                }

                            }
                        }

                    }
                }
                else if (resposta == 0)
                {
                    sequencia = false;
                }
            }
        }
    }
}