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
    public partial class Form1 : Form
    {

        Thread b1;
        Thread b2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btncliente_Click(object sender, EventArgs e) // Seleção CLiente
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


        private void btnfuncionario_Click(object sender, EventArgs e) // Seleção Funcionario
        {
            this.Close(); // fechar janela inicial 
            b1 = new Thread(abrirfuncionario); // Inicia o mettodo
            b1.SetApartmentState(ApartmentState.STA); // configura o Apartament da Thread antes dela se iniciada
            b1.Start();
        }
        private void abrirfuncionario(object obj) // Metodo para abrir janela de funcionários
        {
            Application.Run(new Form3_Tela_Funcionario()); // Abre nova janela
        }

        private void txtquestao_Click(object sender, EventArgs e)
        {

        }
    }
}
