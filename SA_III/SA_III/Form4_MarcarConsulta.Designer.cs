
namespace SA_III
{
    partial class Form4_MarcarConsulta
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
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txthora = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.boxmedico = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.boxespecialidade = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiocoelho = new System.Windows.Forms.RadioButton();
            this.radioave = new System.Windows.Forms.RadioButton();
            this.radiocachorro = new System.Windows.Forms.RadioButton();
            this.radiogato = new System.Windows.Forms.RadioButton();
            this.txtdata = new System.Windows.Forms.DateTimePicker();
            this.txttitulo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtanimal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnretornar = new System.Windows.Forms.Button();
            this.erroanimal = new System.Windows.Forms.Label();
            this.erroespecialidade = new System.Windows.Forms.Label();
            this.erromedico = new System.Windows.Forms.Label();
            this.errodata = new System.Windows.Forms.Label();
            this.errohorario = new System.Windows.Forms.Label();
            this.errocpf = new System.Windows.Forms.Label();
            this.errotipo = new System.Windows.Forms.Label();
            this.txtsucesso = new System.Windows.Forms.Label();
            this.txterro = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("NewsGoth Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(47, 313);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(286, 30);
            this.txtcpf.TabIndex = 60;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("NewsGoth Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(43, 293);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 22);
            this.label14.TabIndex = 59;
            this.label14.Text = "CPF: ";
            // 
            // txthora
            // 
            this.txthora.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.txthora.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txthora.Font = new System.Drawing.Font("NewsGoth Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txthora.Location = new System.Drawing.Point(47, 238);
            this.txthora.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.txthora.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(286, 30);
            this.txthora.TabIndex = 58;
            this.txthora.Value = new System.DateTime(2020, 12, 22, 2, 3, 3, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("NewsGoth Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(43, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 22);
            this.label13.TabIndex = 57;
            this.label13.Text = "Horário:";
            // 
            // boxmedico
            // 
            this.boxmedico.Font = new System.Drawing.Font("NewsGoth Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxmedico.FormattingEnabled = true;
            this.boxmedico.Location = new System.Drawing.Point(386, 166);
            this.boxmedico.Name = "boxmedico";
            this.boxmedico.Size = new System.Drawing.Size(286, 30);
            this.boxmedico.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("NewsGoth Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(382, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 22);
            this.label12.TabIndex = 55;
            this.label12.Text = "Médico:";
            // 
            // boxespecialidade
            // 
            this.boxespecialidade.Font = new System.Drawing.Font("NewsGoth Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxespecialidade.FormattingEnabled = true;
            this.boxespecialidade.Location = new System.Drawing.Point(386, 95);
            this.boxespecialidade.Name = "boxespecialidade";
            this.boxespecialidade.Size = new System.Drawing.Size(286, 30);
            this.boxespecialidade.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.radiocoelho);
            this.groupBox1.Controls.Add(this.radioave);
            this.groupBox1.Controls.Add(this.radiocachorro);
            this.groupBox1.Controls.Add(this.radiogato);
            this.groupBox1.Font = new System.Drawing.Font("NewsGoth Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(386, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 100);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // radiocoelho
            // 
            this.radiocoelho.AutoSize = true;
            this.radiocoelho.Location = new System.Drawing.Point(220, 25);
            this.radiocoelho.Name = "radiocoelho";
            this.radiocoelho.Size = new System.Drawing.Size(70, 26);
            this.radiocoelho.TabIndex = 3;
            this.radiocoelho.TabStop = true;
            this.radiocoelho.Text = "Coelho";
            this.radiocoelho.UseVisualStyleBackColor = true;
            // 
            // radioave
            // 
            this.radioave.AutoSize = true;
            this.radioave.Location = new System.Drawing.Point(220, 61);
            this.radioave.Name = "radioave";
            this.radioave.Size = new System.Drawing.Size(50, 26);
            this.radioave.TabIndex = 2;
            this.radioave.TabStop = true;
            this.radioave.Text = "Ave";
            this.radioave.UseVisualStyleBackColor = true;
            // 
            // radiocachorro
            // 
            this.radiocachorro.AutoSize = true;
            this.radiocachorro.Location = new System.Drawing.Point(0, 61);
            this.radiocachorro.Name = "radiocachorro";
            this.radiocachorro.Size = new System.Drawing.Size(84, 26);
            this.radiocachorro.TabIndex = 1;
            this.radiocachorro.TabStop = true;
            this.radiocachorro.Text = "Cachorro";
            this.radiocachorro.UseVisualStyleBackColor = true;
            // 
            // radiogato
            // 
            this.radiogato.AutoSize = true;
            this.radiogato.Location = new System.Drawing.Point(0, 25);
            this.radiogato.Name = "radiogato";
            this.radiogato.Size = new System.Drawing.Size(57, 26);
            this.radiogato.TabIndex = 0;
            this.radiogato.TabStop = true;
            this.radiogato.Text = "Gato";
            this.radiogato.UseVisualStyleBackColor = true;
            // 
            // txtdata
            // 
            this.txtdata.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.txtdata.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtdata.Font = new System.Drawing.Font("NewsGoth Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdata.Location = new System.Drawing.Point(47, 166);
            this.txtdata.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.txtdata.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(286, 30);
            this.txtdata.TabIndex = 52;
            this.txtdata.Value = new System.DateTime(2020, 12, 22, 2, 3, 3, 0);
            // 
            // txttitulo
            // 
            this.txttitulo.AutoSize = true;
            this.txttitulo.Font = new System.Drawing.Font("NewsGoth Cn BT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.Location = new System.Drawing.Point(43, 25);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(161, 32);
            this.txttitulo.TabIndex = 51;
            this.txttitulo.Text = "Marcar Consulta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("NewsGoth Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(382, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 22);
            this.label8.TabIndex = 50;
            this.label8.Text = "Especialidade:";
            // 
            // txtanimal
            // 
            this.txtanimal.Font = new System.Drawing.Font("NewsGoth Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanimal.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtanimal.Location = new System.Drawing.Point(47, 95);
            this.txtanimal.Name = "txtanimal";
            this.txtanimal.Size = new System.Drawing.Size(286, 30);
            this.txtanimal.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("NewsGoth Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 22);
            this.label10.TabIndex = 48;
            this.label10.Text = "Data consulta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("NewsGoth Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 22);
            this.label11.TabIndex = 47;
            this.label11.Text = "Nome do animal:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("NewsGoth Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(568, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 34);
            this.button2.TabIndex = 46;
            this.button2.Text = "Marcar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnretornar
            // 
            this.btnretornar.Font = new System.Drawing.Font("NewsGoth Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretornar.Location = new System.Drawing.Point(386, 349);
            this.btnretornar.Name = "btnretornar";
            this.btnretornar.Size = new System.Drawing.Size(104, 34);
            this.btnretornar.TabIndex = 61;
            this.btnretornar.Text = "Retornar";
            this.btnretornar.UseVisualStyleBackColor = true;
            this.btnretornar.Click += new System.EventHandler(this.btnretornar_Click);
            // 
            // erroanimal
            // 
            this.erroanimal.AutoSize = true;
            this.erroanimal.Font = new System.Drawing.Font("NewsGoth Cn BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroanimal.ForeColor = System.Drawing.Color.Red;
            this.erroanimal.Location = new System.Drawing.Point(46, 128);
            this.erroanimal.Name = "erroanimal";
            this.erroanimal.Size = new System.Drawing.Size(9, 14);
            this.erroanimal.TabIndex = 62;
            this.erroanimal.Text = " ";
            // 
            // erroespecialidade
            // 
            this.erroespecialidade.AutoSize = true;
            this.erroespecialidade.Font = new System.Drawing.Font("NewsGoth Cn BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroespecialidade.ForeColor = System.Drawing.Color.Red;
            this.erroespecialidade.Location = new System.Drawing.Point(388, 128);
            this.erroespecialidade.Name = "erroespecialidade";
            this.erroespecialidade.Size = new System.Drawing.Size(9, 14);
            this.erroespecialidade.TabIndex = 63;
            this.erroespecialidade.Text = " ";
            // 
            // erromedico
            // 
            this.erromedico.AutoSize = true;
            this.erromedico.Font = new System.Drawing.Font("NewsGoth Cn BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erromedico.ForeColor = System.Drawing.Color.Red;
            this.erromedico.Location = new System.Drawing.Point(390, 199);
            this.erromedico.Name = "erromedico";
            this.erromedico.Size = new System.Drawing.Size(9, 14);
            this.erromedico.TabIndex = 64;
            this.erromedico.Text = " ";
            // 
            // errodata
            // 
            this.errodata.AutoSize = true;
            this.errodata.Font = new System.Drawing.Font("NewsGoth Cn BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errodata.ForeColor = System.Drawing.Color.Red;
            this.errodata.Location = new System.Drawing.Point(46, 199);
            this.errodata.Name = "errodata";
            this.errodata.Size = new System.Drawing.Size(9, 14);
            this.errodata.TabIndex = 65;
            this.errodata.Text = " ";
            // 
            // errohorario
            // 
            this.errohorario.AutoSize = true;
            this.errohorario.Font = new System.Drawing.Font("NewsGoth Cn BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errohorario.ForeColor = System.Drawing.Color.Red;
            this.errohorario.Location = new System.Drawing.Point(47, 271);
            this.errohorario.Name = "errohorario";
            this.errohorario.Size = new System.Drawing.Size(9, 14);
            this.errohorario.TabIndex = 66;
            this.errohorario.Text = " ";
            // 
            // errocpf
            // 
            this.errocpf.AutoSize = true;
            this.errocpf.Font = new System.Drawing.Font("NewsGoth Cn BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errocpf.ForeColor = System.Drawing.Color.Red;
            this.errocpf.Location = new System.Drawing.Point(47, 346);
            this.errocpf.Name = "errocpf";
            this.errocpf.Size = new System.Drawing.Size(9, 14);
            this.errocpf.TabIndex = 67;
            this.errocpf.Text = " ";
            // 
            // errotipo
            // 
            this.errotipo.AutoSize = true;
            this.errotipo.Font = new System.Drawing.Font("NewsGoth Cn BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errotipo.ForeColor = System.Drawing.Color.Red;
            this.errotipo.Location = new System.Drawing.Point(383, 329);
            this.errotipo.Name = "errotipo";
            this.errotipo.Size = new System.Drawing.Size(9, 14);
            this.errotipo.TabIndex = 68;
            this.errotipo.Text = " ";
            // 
            // txtsucesso
            // 
            this.txtsucesso.AutoSize = true;
            this.txtsucesso.Font = new System.Drawing.Font("NewsGoth Cn BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsucesso.ForeColor = System.Drawing.Color.Green;
            this.txtsucesso.Location = new System.Drawing.Point(512, 394);
            this.txtsucesso.Name = "txtsucesso";
            this.txtsucesso.Size = new System.Drawing.Size(0, 16);
            this.txtsucesso.TabIndex = 69;
            // 
            // txterro
            // 
            this.txterro.AutoSize = true;
            this.txterro.Font = new System.Drawing.Font("NewsGoth Cn BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txterro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txterro.Location = new System.Drawing.Point(512, 413);
            this.txterro.Name = "txterro";
            this.txterro.Size = new System.Drawing.Size(0, 16);
            this.txterro.TabIndex = 70;
            // 
            // Form4_MarcarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 707);
            this.Controls.Add(this.txterro);
            this.Controls.Add(this.txtsucesso);
            this.Controls.Add(this.errotipo);
            this.Controls.Add(this.errocpf);
            this.Controls.Add(this.errohorario);
            this.Controls.Add(this.errodata);
            this.Controls.Add(this.erromedico);
            this.Controls.Add(this.erroespecialidade);
            this.Controls.Add(this.erroanimal);
            this.Controls.Add(this.btnretornar);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.boxmedico);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.boxespecialidade);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtanimal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Name = "Form4_MarcarConsulta";
            this.Text = "Form4_MarcarConsulta";
            this.Load += new System.EventHandler(this.Form4_MarcarConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker txthora;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox boxmedico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox boxespecialidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiocoelho;
        private System.Windows.Forms.RadioButton radioave;
        private System.Windows.Forms.RadioButton radiocachorro;
        private System.Windows.Forms.RadioButton radiogato;
        private System.Windows.Forms.DateTimePicker txtdata;
        private System.Windows.Forms.Label txttitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtanimal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnretornar;
        private System.Windows.Forms.Label erroanimal;
        private System.Windows.Forms.Label erroespecialidade;
        private System.Windows.Forms.Label erromedico;
        private System.Windows.Forms.Label errodata;
        private System.Windows.Forms.Label errohorario;
        private System.Windows.Forms.Label errocpf;
        private System.Windows.Forms.Label errotipo;
        private System.Windows.Forms.Label txtsucesso;
        private System.Windows.Forms.Label txterro;
    }
}