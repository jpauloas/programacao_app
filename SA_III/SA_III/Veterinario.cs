using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SA_III
{
    class Veterinario
    {
        Conexao conexao = new Conexao();
        MySqlCommand comando = new MySqlCommand();
        public string mensagem;

        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string EstadoCivil { get; set; }
        public string Sexo { get; set; }
        public string Especialidade { get; set; }

        public Veterinario(string nome, string datanascimento, string cpf, string telefone, string endereco, string estadocivil, string sexo, string especialidade)
        {

            Nome = nome;
            DataNascimento = datanascimento;
            Cpf = cpf;
            Telefone = telefone;
            Endereco = endereco;
            EstadoCivil = estadocivil;
            Sexo = sexo;
            Especialidade = especialidade;

            // Comando MySQL
            comando.CommandText = "insert into veterinario (nome, datanascimento, cpf, telefone, endereco, estadocivil, sexo, especialidade) values (@nome, @datanascimento, @cpf, @telefone, @endereco, @estadocivil, @sexo, @especialidade)";

            // Parametros
            comando.Parameters.AddWithValue("@nome", Nome);
            comando.Parameters.AddWithValue("@datanascimento", DataNascimento);
            comando.Parameters.AddWithValue("@cpf", Cpf);
            comando.Parameters.AddWithValue("@telefone", Telefone);
            comando.Parameters.AddWithValue("@endereco", Endereco);
            comando.Parameters.AddWithValue("@endereco", EstadoCivil);
            comando.Parameters.AddWithValue("@sexo", Sexo);
            comando.Parameters.AddWithValue("@especialidade", Especialidade);

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
