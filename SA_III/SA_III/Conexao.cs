using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SA_III
{
    public class Conexao
    {
        MySqlConnection conexao = new MySqlConnection();

        public Conexao()
        {
            conexao.ConnectionString = ("server=localhost; port=3306; User Id= root; database=bd_sa03;");
        }

        public MySqlConnection conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();

            }

            return conexao;
        }

        public MySqlConnection desligar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();

            }

            return conexao;
        }
    }
}
