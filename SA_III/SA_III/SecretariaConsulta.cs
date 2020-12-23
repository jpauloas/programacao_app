using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SA_III
{
    public class SecretariaConsulta
    {
        Conexao conexao = new Conexao();
        MySqlCommand comando_consulta = new MySqlCommand();
        public string mensagem;


        public string NOMEPET { get; set; }


        public string DATA { get; set; }


        public string HORA { get; set; }


        public string TIPO { get; set; }


        public string CPF { get; set; }


        public string MEDICO { get; set; }


        public string ESPECIALIDADE { get; set; }


        public SecretariaConsulta(string nomepet, string cpf, string especialidade, string medico, string tipo, string hora, string data )
        {

            NOMEPET = nomepet;
            CPF = cpf;


            HORA = hora;
            DATA = data;
            ESPECIALIDADE = especialidade;
            MEDICO = medico;
            TIPO = tipo;

            // Comando MySQL
            comando_consulta.CommandText = "insert into consultas (nomepet, cpf, especialidade, medico, tipo, hora, dia ) values (@nomepet, @cpf, @especialidade, @medico, @tipo, @hora, @dia )";

            // Parametros
            comando_consulta.Parameters.AddWithValue("@nomepet", NOMEPET);
            comando_consulta.Parameters.AddWithValue("@cpf", CPF);
            comando_consulta.Parameters.AddWithValue("@especialidade", ESPECIALIDADE);
            comando_consulta.Parameters.AddWithValue("@medico", MEDICO);
            comando_consulta.Parameters.AddWithValue("@tipo", TIPO);
            comando_consulta.Parameters.AddWithValue("@hora", HORA);
            comando_consulta.Parameters.AddWithValue("@dia", DATA);

            // Conexao com o banco 
            try
            {
                //Conecta com o banco
                comando_consulta.Connection = conexao.conectar();

                //Execução do comando
                comando_consulta.ExecuteNonQuery();

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
