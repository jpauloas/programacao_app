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
    public partial class Form9_NovoCadastroVeterinario : Form
    {
        Thread b3;

        public Form9_NovoCadastroVeterinario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Caso os campos estiverem vazios, mostrar a mensagem
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome.");
                txtNome.Focus(); // Dar foco no campo que precisa ser preenchido
                return; // Para finalizar o método e não executar mais nada
            }
            if (txtTelefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo Telefone.");
                txtTelefone.Focus(); // Dar foco no campo que precisa ser preenchido
                return;
            }

            string sexo = " ";

            if (radioM.Checked) // Se o campo estiver selecionado, retorna true ou false
            {
                sexo = "M";
            }
            else if (radioF.Checked)
            {
                sexo = "F";
            }
            else
            {
                sexo = "O";
            }
            string especialidade = " ";

            if (radioC.Checked) // Se o campo estiver selecionado, retorna true ou false
            {
                especialidade = "Cirurgia";
            }
            else if (radioV.Checked)
            {
                especialidade = "Visita";
            }
            else
            {
                especialidade = "Higiene e Tosa";
            }
            // Instanciando o objeto 

            Veterinario v = new Veterinario(txtNome.Text, txtData.Text, txtCpf.Text, txtTelefone.Text, txtEndereco.Text, comboEC.SelectedItem.ToString(), sexo, especialidade );

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtData.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            comboEC.SelectedIndex = 0;
            radioM.Checked = false;
            radioF.Checked = false;
            radioO.Checked = false;
            radioC.Checked = false;
            radioV.Checked = false;
            radioHT.Checked = false;
            txtNome.Focus();
        }

        private void btnretornar_Click(object sender, EventArgs e)
        {
            this.Close(); // fechar janela inicial 
            b3 = new Thread(abrirfuncionario); // Inicia o mettodo
            b3.SetApartmentState(ApartmentState.STA); // configura o Apartament da Thread antes dela se iniciada
            b3.Start();
        }
        private void abrirfuncionario(object obj) // Metodo para abrir janela de funcionários
        {
            Application.Run(new Form3_Tela_Funcionario()); // Abre nova janela
        }


    }
}
