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
    public partial class Form4_MarcarConsulta : Form
    {

        Thread b2;

        public Form4_MarcarConsulta()
        {
            InitializeComponent();

            // Cadastro de Consultas 
            boxespecialidade.Items.Add("Cirurgia");
            boxespecialidade.Items.Add("Higiene e tosa");
            boxespecialidade.Items.Add("Visita");

            boxespecialidade.SelectedIndex = 0;

            boxmedico.Items.Add("Dta.Agatha Ferreira");
            boxmedico.Items.Add("Dta.Luisa Barros");
            boxmedico.Items.Add("Dt.Igor Henrique Teixeira");

            boxmedico.SelectedIndex = 0;

        }

        private void TelaMarcarConsulta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // CADASTRO DE CONSULTA //

            bool erro = false;
            erroanimal.Text = " ";
            errocpf.Text = " ";
            errodata.Text = " ";
            erroespecialidade.Text = "";
            erromedico.Text = "";
            errotipo.Text = "";
            txterro.Text = " ";
            txtsucesso.Text = " ";


            if (txtanimal.Text == "") // Verificação de vazio no campo NOME ANIMAL
            {
                erroanimal.Text = "Insira o nome do seu pet!";
                erro = true;
                return;
            }

            if (txtcpf.Text == "   ,   ,   -") // Verificação de vazio no campo CPF
            {
                errocpf.Text = "Insira o seu CPF!"; 
                erro = true;
                return;

            }

            if (txtdata.Text is null) // Verificação de vazio no campo DATA
            {
                txtdata.Text = "Insira uma data!";
                erro = true;
                return;
            }

            if (txthora.Text is null) // Verificação de vazio no campo HORA
            {
                errohorario.Text = "Insira um horário!";
                erro = true;
                return;
            }

            if (boxespecialidade is null) // Verificação de vazio no campo ESOECIALIDADE
            {
                erroespecialidade.Text = "Escolha uma especialidade!";
                erro = true;
                return;
            }

            if (boxmedico is null)
            {
                erromedico.Text = "Escolha um médico!";
                erro = true;
                return;
            }

            string tipo = " ";

            if (radiogato.Checked)
            {
                tipo = "Gato";
                erro = false;
            }

            else if (radiocachorro.Checked)
            {
                tipo = "Cachorro";
                erro = false;
            }

            else if (radiocoelho.Checked)
            {
                tipo = "Coelho"; 
                erro = false;
            }

            else if (radioave.Checked)
            {
                tipo = "Ave";
                erro = false;
            }

            if (tipo == " ")
            {
                errotipo.Text = "Escolha um tipo!";
                erro = true;
                return;
            }

            if (erro == false)
            {
                SecretariaConsulta c = new SecretariaConsulta(txtanimal.Text, txtcpf.Text, boxespecialidade.SelectedItem.ToString(), boxmedico.SelectedItem.ToString(), tipo, txthora.Text, txtdata.Text);
                txtsucesso.Text = "Cadastro realizado com sucesso! ";

            }

            else
            {
                txterro.Text = "Preencha corretamente os dados! ";
                return;
            }

        }

        private void btnretornar_Click(object sender, EventArgs e)
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

        private void Form4_MarcarConsulta_Load(object sender, EventArgs e)
        {

        }
    }
    
}
