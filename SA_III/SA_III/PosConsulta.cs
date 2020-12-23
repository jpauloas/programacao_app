using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace SA_III
{
    class PosConsulta
    {

        Conexao conexao = new Conexao();
        MySqlCommand comando = new MySqlCommand();
        public string mensagem;


        public string IDPET { get; set; }
        public string NOMEPET { get; set; }
        public string DATACONSULTA { get; set; }
        public string MEDICO { get; set; }
        public string TIPOPET { get; set; }
        public string OBSERVACOES { get; set; }
        public string TIPOEXAME { get; set; }
        public string DATAEXAME { get; set; }
        public string DATARESULTADO { get; set; }
        public string DESCRICAOMEDICAMENTO { get; set; }

        public PosConsulta(string IdPet, string NomePet, string DataConsulta, string Medico, string TipoPet, string Observacoes, string TipoExame, string DataExame, string DataResultado, string DescricaoMedicamentos)
        {

            IDPET = IdPet;
            NOMEPET = NomePet;
            DATACONSULTA = DataConsulta;
            MEDICO = Medico;
            TIPOPET = TipoPet;
            OBSERVACOES = Observacoes;
            TIPOEXAME = TipoExame;
            DATAEXAME = DataExame;
            DATARESULTADO = DataResultado;
            DESCRICAOMEDICAMENTO = DescricaoMedicamentos;


            // Comando MySQL
            comando.CommandText = "insert into posconsulta (idpet, nomepet, dataconsulta, medico, tipopet, observacoes, tipoexame, dataexame, dataresultado, descricaomedicamento) values (@idpet, @nomepet, @dataconsulta, @medico, @tipopet, @observacoes, @tipoexame, @dataexame, @dataresultado, @descricaomedicamento)";

            // Parametros
            comando.Parameters.AddWithValue("@idpet", IDPET);
            comando.Parameters.AddWithValue("@nomepet", NOMEPET);
            comando.Parameters.AddWithValue("@dataconsulta", DATACONSULTA);
            comando.Parameters.AddWithValue("@medico", MEDICO);
            comando.Parameters.AddWithValue("@tipopet", TIPOPET);
            comando.Parameters.AddWithValue("@observacoes", OBSERVACOES);
            comando.Parameters.AddWithValue("@tipoexame", TIPOEXAME);
            comando.Parameters.AddWithValue("@dataexame", DATAEXAME);
            comando.Parameters.AddWithValue("@dataresultado", DATARESULTADO);
            comando.Parameters.AddWithValue("@descricaomedicamento", DESCRICAOMEDICAMENTO);



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
