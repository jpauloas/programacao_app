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
    public partial class Form5_ResultadoExames : Form
    {
        Thread b3; // retorna a tela anterior

        public Form5_ResultadoExames()
        {
            InitializeComponent();

            // Adicionando itens no combobox de tipo de exame
            comboTE.Items.Add("Eletrocardiograma");
            comboTE.Items.Add("Exame de Fezes");
            comboTE.Items.Add("Exame de Urina");
            comboTE.Items.Add("Função Hepática");
            comboTE.Items.Add("Hemograma");
            comboTE.Items.Add("Ultrassonagrafia Abdominal");

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            // Caso os campos estiverem vazios, mostrar a mensagem
            if (txtIdPet.Text == "")
            {
                MessageBox.Show("Preencha o campo Id.");
                txtIdPet.Focus(); // Dar foco no campo que precisa ser preenchido
                return; // Para finalizar o método e não executar mais nada
            }
            if (txtNomePet.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome.");
                txtNomePet.Focus(); // Dar foco no campo que precisa ser preenchido
                return; // Para finalizar o método e não executar mais nada
            }


            string tipo = " ";
            if (radioGato.Checked) // Se o campo estiver selecionado, retorna true ou false
            {
                tipo = "Gato";
            }
            else if (radioCachorro.Checked)
            {
                tipo = "Cachorro";
            }
            else if (radioAve.Checked)
            {
                tipo = "Ave";
            }
            else
            {
                tipo = "Coelho";
            }

            PosConsulta pc = new PosConsulta(txtIdPet.Text, txtNomePet.Text, txtDataConsultaPet.Text, txtMedico.Text, tipo, richTextObs.Text, comboTE.SelectedItem.ToString(), txtDataExame.Text, txtDataResultado.Text, richTextDescricao.Text);
                   
        }

        private void btnretorno_Click(object sender, EventArgs e)
        {
            this.Close();
            b3 = new Thread(abrirfuncionario); // fechar janela inicial
            b3.SetApartmentState(ApartmentState.STA); // configura o Apartament da Thread antes dela se iniciada
            b3.Start();
        }
        private void abrirfuncionario(object obj)
        {
            Application.Run(new Form3_Tela_Funcionario()); // Abre nova janela
        }

    }
}
