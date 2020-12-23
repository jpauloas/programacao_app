using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SA_III
{
    public partial class Form6_ConsultasMarcadas : Form
    {
        public Form6_ConsultasMarcadas()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; User Id= root; database=bd_sa03;");
                conexao.Open();

                MySqlCommand busca = new MySqlCommand("select nome, telefone, endereco from cliente where cpf = ?", conexao); ;
                busca.Parameters.Clear();
                busca.Parameters.Add("@cpf", MySqlDbType.String).Value = txtcpf.Text;

                // Recebe o conteudo que vem do banco
                busca.CommandType = CommandType.Text;
                MySqlDataReader dados;
                dados = busca.ExecuteReader();
                dados.Read();

                txtnome.Text = dados.GetString(0);
                txttelefone.Text = dados.GetString(1);
                txtendereco.Text = dados.GetString(2);

                conexao.Close();


            }

            catch
            {

            }
        }
    }
}