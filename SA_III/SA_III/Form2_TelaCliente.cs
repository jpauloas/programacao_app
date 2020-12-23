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
    public partial class Form2_TelaCliente : Form
    {

        Thread b4; // Botão Marcar Consulta
        Thread b6; // Botão Consultas Marcadas
        Thread b8; // Botão Novo Cadastro
        Thread b0; // Botão Retorno

        public Form2_TelaCliente()
        {
            InitializeComponent();
        }

        private void btnmarcar_Click(object sender, EventArgs e) // Seleção Marcar Consulta
        {

            this.Close();
            b4 = new Thread(abrirmarcarconsulta); // fechar janela inicial
            b4.SetApartmentState(ApartmentState.STA); // configura o Apartament da Thread antes dela se iniciada
            b4.Start();
        }
        private void abrirmarcarconsulta(object obj)
        {
            Application.Run(new Form4_MarcarConsulta()); // Abre nova janela
        }






        private void btnconsultasmarcadas_Click(object sender, EventArgs e) // Seleção Consulta Marcada
        {
            this.Close();
            b6 = new Thread(consultasmarcadas); // fechar janela inicial
            b6.SetApartmentState(ApartmentState.STA); // configura o Apartament da Thread antes dela se iniciada
            b6.Start();
        }
        private void consultasmarcadas(object obj)
        {
            Application.Run(new Form6_ConsultasMarcadas ()); // Abre nova janela
        }






        private void bntnovocadastro_Click(object sender, EventArgs e) // Seleção Novo Cadastro
        {
            this.Close();
            b8 = new Thread(novocadastro); // fechar janela inicial
            b8.SetApartmentState(ApartmentState.STA); // configura o Apartament da Thread antes dela se iniciada
            b8.Start();
        }
        private void novocadastro(object obj)
        {
            Application.Run(new Form8_NovoCadastro()); // Abre nova janela
        }

        private void btnretornar_Click(object sender, EventArgs e)
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
    }
    
    
}
