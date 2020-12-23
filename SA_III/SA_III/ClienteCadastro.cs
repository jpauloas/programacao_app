using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SA_III
{
    class ClienteCadastro
    {
        Conexao conexao = new Conexao(); 
        MySqlCommand comando = new MySqlCommand();


        public string mensagem;

        public string NOME { get; set; }

        public string CPF { get; set; }

        public string TELEFONE { get; set; }

        public string ENDERECO { get; set; }

        public ClienteCadastro(string nome, string cpf, string telefone, string endereco)
        {

            NOME = nome;
            CPF = cpf;
            TELEFONE = telefone;
            ENDERECO = endereco;

            // Comando MySQL
            comando.CommandText = "insert into cliente (nome, cpf, telefone, endereco) values (@nome, @cpf, @telefone, @endereco)";

            // Parametros
            comando.Parameters.AddWithValue("@nome", NOME);
            comando.Parameters.AddWithValue("@cpf", CPF);
            comando.Parameters.AddWithValue("@telefone", TELEFONE);
            comando.Parameters.AddWithValue("@endereco", ENDERECO);


            // Conexao com o banco 
            try
            {
                //Conecta com o banco
                comando.Connection = conexao.conectar();

                //Execução do comando
                comando.ExecuteNonQuery();

                // Desconecta o banco
                conexao.desligar();

                // Mensagem de sucesso no cadastro
                this.mensagem = ("Cadastrado com Sucesso!");
            }

            catch (MySqlException)
            {
                this.mensagem = ("Erro ao se conectar com o Banco de dados!");

            }

        }
    }
}
