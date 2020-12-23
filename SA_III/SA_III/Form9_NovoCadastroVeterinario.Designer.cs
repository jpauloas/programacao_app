
namespace SA_III
{
    partial class Form9_NovoCadastroVeterinario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnretornar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.Especialidade = new System.Windows.Forms.GroupBox();
            this.radioHT = new System.Windows.Forms.RadioButton();
            this.radioV = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lista = new System.Windows.Forms.ListBox();
            this.Sexo = new System.Windows.Forms.GroupBox();
            this.radioO = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.comboEC = new System.Windows.Forms.ComboBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Especialidade.SuspendLayout();
            this.Sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(402, 495);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 36);
            this.btnLimpar.TabIndex = 41;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnretornar
            // 
            this.btnretornar.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretornar.Location = new System.Drawing.Point(763, 495);
            this.btnretornar.Name = "btnretornar";
            this.btnretornar.Size = new System.Drawing.Size(130, 36);
            this.btnretornar.TabIndex = 40;
            this.btnretornar.Text = "Retornar";
            this.btnretornar.UseVisualStyleBackColor = true;
            this.btnretornar.Click += new System.EventHandler(this.btnretornar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(556, 495);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(130, 36);
            this.btnCadastrar.TabIndex = 39;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Especialidade
            // 
            this.Especialidade.Controls.Add(this.radioHT);
            this.Especialidade.Controls.Add(this.radioV);
            this.Especialidade.Controls.Add(this.radioC);
            this.Especialidade.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Especialidade.Location = new System.Drawing.Point(402, 183);
            this.Especialidade.Name = "Especialidade";
            this.Especialidade.Size = new System.Drawing.Size(491, 71);
            this.Especialidade.TabIndex = 38;
            this.Especialidade.TabStop = false;
            this.Especialidade.Text = "Especialidade";
            // 
            // radioHT
            // 
            this.radioHT.AutoSize = true;
            this.radioHT.Location = new System.Drawing.Point(361, 34);
            this.radioHT.Name = "radioHT";
            this.radioHT.Size = new System.Drawing.Size(130, 29);
            this.radioHT.TabIndex = 2;
            this.radioHT.TabStop = true;
            this.radioHT.Text = "Higiene e Tosa";
            this.radioHT.UseVisualStyleBackColor = true;
            // 
            // radioV
            // 
            this.radioV.AutoSize = true;
            this.radioV.Location = new System.Drawing.Point(182, 30);
            this.radioV.Name = "radioV";
            this.radioV.Size = new System.Drawing.Size(69, 29);
            this.radioV.TabIndex = 1;
            this.radioV.TabStop = true;
            this.radioV.Text = "Visita";
            this.radioV.UseVisualStyleBackColor = true;
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Location = new System.Drawing.Point(15, 34);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(86, 29);
            this.radioC.TabIndex = 0;
            this.radioC.TabStop = true;
            this.radioC.Text = "Cirurgia";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(36, 269);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(309, 33);
            this.txtCpf.TabIndex = 37;
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 25;
            this.lista.Location = new System.Drawing.Point(402, 270);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(491, 204);
            this.lista.TabIndex = 36;
            // 
            // Sexo
            // 
            this.Sexo.Controls.Add(this.radioO);
            this.Sexo.Controls.Add(this.radioM);
            this.Sexo.Controls.Add(this.radioF);
            this.Sexo.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sexo.Location = new System.Drawing.Point(402, 104);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(491, 73);
            this.Sexo.TabIndex = 35;
            this.Sexo.TabStop = false;
            this.Sexo.Text = "Sexo:";
            // 
            // radioO
            // 
            this.radioO.AutoSize = true;
            this.radioO.Location = new System.Drawing.Point(387, 32);
            this.radioO.Name = "radioO";
            this.radioO.Size = new System.Drawing.Size(104, 29);
            this.radioO.TabIndex = 2;
            this.radioO.TabStop = true;
            this.radioO.Text = "Outro Sexo";
            this.radioO.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(182, 32);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(102, 29);
            this.radioM.TabIndex = 1;
            this.radioM.TabStop = true;
            this.radioM.Text = "Masculino";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(8, 32);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(93, 29);
            this.radioF.TabIndex = 0;
            this.radioF.TabStop = true;
            this.radioF.Text = "Feminino";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("NewsGoth Cn BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 32);
            this.label6.TabIndex = 33;
            this.label6.Text = "Médico(a) Veterinário(a)";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(36, 346);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(309, 33);
            this.txtTelefone.TabIndex = 32;
            // 
            // comboEC
            // 
            this.comboEC.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEC.FormattingEnabled = true;
            this.comboEC.Location = new System.Drawing.Point(36, 495);
            this.comboEC.Name = "comboEC";
            this.comboEC.Size = new System.Drawing.Size(309, 33);
            this.comboEC.TabIndex = 31;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(36, 197);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(309, 33);
            this.txtData.TabIndex = 30;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(36, 422);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(309, 33);
            this.txtEndereco.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Endereço";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(36, 127);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(309, 33);
            this.txtNome.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "EstadoCivil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "DataNascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NewsGoth Cn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome";
            // 
            // Form9_NovoCadastroVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 575);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnretornar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.Especialidade);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.comboEC);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form9_NovoCadastroVeterinario";
            this.Text = "Form9_NovoCadastroVeterinario";
            this.Especialidade.ResumeLayout(false);
            this.Especialidade.PerformLayout();
            this.Sexo.ResumeLayout(false);
            this.Sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnretornar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox Especialidade;
        private System.Windows.Forms.RadioButton radioHT;
        private System.Windows.Forms.RadioButton radioV;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.GroupBox Sexo;
        private System.Windows.Forms.RadioButton radioO;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.ComboBox comboEC;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}