using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace SA_III
{

    public partial class Form8_NovoCadastro : Form
    {
        Thread b2;
        public Form8_NovoCadastro()
        {
            InitializeComponent();
        }

        private void botaocadastrar_Click(object sender, EventArgs e) 
        {

            if (txtnome.Text == "") // Verificação de vazio no campo NOME
            {
                MessageBox.Show("Preencha o campo Nome!");
                txtnome.Focus();
                return;

            }

            if (txtcpf.Text == "")// Verificação de vazio no campo CPF
            {
                MessageBox.Show("Preencha o campo CPF!");
                txtcpf.Focus();
                return;

            }

            if (txttelefone.Text == "")// Verificação de vazio no campo TELEFONE
            {
                MessageBox.Show("Preencha o campo Telefone!");
                txttelefone.Focus();
                return;
            }

            if (txtendereco.Text == "") // Verificação de vazio no campo ENDEREÇO
            {
                MessageBox.Show("Preencha o campo Endereço!");
                txtendereco.Focus();
                return;
            }

            ClienteCadastro novocadastro = new ClienteCadastro(txtnome.Text, txtcpf.Text, txttelefone.Text, txtendereco.Text);

        }

        private void btnretornar_Click(object sender, EventArgs e) // Seleção de retornar a pagina anterior
        {
            this.Close();
            b2 = new Thread(abrircliente); // fechar janela inicial
            b2.SetApartmentState(ApartmentState.STA); // configura o Apartament da Thread antes dela se iniciada
            b2.Start();
        }
        private void abrircliente(object obj)
        {
            Application.Run(new Form2_TelaCliente()); // Abre nova janela
        }



    }
    
}
