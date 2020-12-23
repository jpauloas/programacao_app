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

    public partial class Form3_Tela_Funcionario : Form
    {
        Thread b5;   // Direciona para p Cadastro de exames
        Thread b9;  // Direciona para o Cadastro de Veterinarios
        Thread b0; // retorna a tela inicial
        Thread b7; // retorna a tela de Dados funcionarios


        public Form3_Tela_Funcionario()
        {
            InitializeComponent();
        }


        private void btnretornar_Click(object sender, EventArgs e) // Seleção de Retorno
        {
            this.Close();
            b0 = new Thread(abrircliente); // fechar janela inicial
            b0.SetApartmentState(ApartmentState.STA); // configura o Apartament da Thread antes dela se iniciada
            b0.Start();
        }
        private void abrircliente(object obj)
        {
            Application.Run(new Form1()); // Abre nova janela
        }


        private void btnmarcar_Click(object sender, EventArgs e)
        {
            this.Close();
            b7 = new Thread(abrirbanco); // fechar janela inicial
            b7.SetApartmentState(ApartmentState.STA); // configura o Apartament da Thread antes dela se iniciada
            b7.Start();
        }
        private void abrirbanco(object obj)
        {
            Application.Run(new Form7_Telabanco()); // Abre nova janela
        }

        private void bntnovocadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            b9 = new Thread(cadastrarveterinario); // fechar janela inicial
            b9.SetApartmentState(ApartmentState.STA); // configura o Apartament da Thread antes dela se iniciada
            b9.Start();
        }


        private void cadastrarveterinario(object obj)
        {
            Application.Run(new Form9_NovoCadastroVeterinario()); // Abre nova janela
        }

    
    

        private void btnconsultasmarcadas_Click(object sender, EventArgs e) // Marcar exame
        {
            this.Close();
            b5 = new Thread(marcarexame); // fechar janela inicial
            b5.SetApartmentState(ApartmentState.STA); // configura o Apartament da Thread antes dela se iniciada
            b5.Start();
        }


        private void marcarexame(object obj)
        {
            Application.Run(new Form5_ResultadoExames()); // Abre nova janela
        }

             
    }
    
}
