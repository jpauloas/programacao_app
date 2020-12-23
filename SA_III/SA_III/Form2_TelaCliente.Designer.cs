
namespace SA_III
{
    partial class Form2_TelaCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnvisualizar = new System.Windows.Forms.Button();
            this.bntnovocadastro = new System.Windows.Forms.Button();
            this.btnmarcar = new System.Windows.Forms.Button();
            this.btnconsultasmarcadas = new System.Windows.Forms.Button();
            this.btnretornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NewsGoth Cn BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Novo por aqui? ";
            // 
            // btnvisualizar
            // 
            this.btnvisualizar.Font = new System.Drawing.Font("NewsGoth Cn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvisualizar.Location = new System.Drawing.Point(73, 345);
            this.btnvisualizar.Name = "btnvisualizar";
            this.btnvisualizar.Size = new System.Drawing.Size(266, 28);
            this.btnvisualizar.TabIndex = 10;
            this.btnvisualizar.Text = "Visualizar Perfil";
            this.btnvisualizar.UseVisualStyleBackColor = true;
            // 
            // bntnovocadastro
            // 
            this.bntnovocadastro.Font = new System.Drawing.Font("NewsGoth Cn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntnovocadastro.Location = new System.Drawing.Point(73, 415);
            this.bntnovocadastro.Name = "bntnovocadastro";
            this.bntnovocadastro.Size = new System.Drawing.Size(266, 28);
            this.bntnovocadastro.TabIndex = 9;
            this.bntnovocadastro.Text = "Novo Cadastro";
            this.bntnovocadastro.UseVisualStyleBackColor = true;
            this.bntnovocadastro.Click += new System.EventHandler(this.bntnovocadastro_Click);
            // 
            // btnmarcar
            // 
            this.btnmarcar.Font = new System.Drawing.Font("NewsGoth Cn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarcar.Location = new System.Drawing.Point(73, 274);
            this.btnmarcar.Name = "btnmarcar";
            this.btnmarcar.Size = new System.Drawing.Size(266, 28);
            this.btnmarcar.TabIndex = 8;
            this.btnmarcar.Text = "Marcar Consulta";
            this.btnmarcar.UseVisualStyleBackColor = true;
            this.btnmarcar.Click += new System.EventHandler(this.btnmarcar_Click);
            // 
            // btnconsultasmarcadas
            // 
            this.btnconsultasmarcadas.Font = new System.Drawing.Font("NewsGoth Cn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultasmarcadas.Location = new System.Drawing.Point(73, 309);
            this.btnconsultasmarcadas.Name = "btnconsultasmarcadas";
            this.btnconsultasmarcadas.Size = new System.Drawing.Size(266, 28);
            this.btnconsultasmarcadas.TabIndex = 7;
            this.btnconsultasmarcadas.Text = "Consultas Marcadas";
            this.btnconsultasmarcadas.UseVisualStyleBackColor = true;
            this.btnconsultasmarcadas.Click += new System.EventHandler(this.btnconsultasmarcadas_Click);
            // 
            // btnretornar
            // 
            this.btnretornar.Font = new System.Drawing.Font("NewsGoth Cn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretornar.Location = new System.Drawing.Point(73, 472);
            this.btnretornar.Name = "btnretornar";
            this.btnretornar.Size = new System.Drawing.Size(266, 28);
            this.btnretornar.TabIndex = 13;
            this.btnretornar.Text = "Retornar";
            this.btnretornar.UseVisualStyleBackColor = true;
            this.btnretornar.Click += new System.EventHandler(this.btnretornar_Click);
            // 
            // Form2_TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 532);
            this.Controls.Add(this.btnretornar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvisualizar);
            this.Controls.Add(this.bntnovocadastro);
            this.Controls.Add(this.btnmarcar);
            this.Controls.Add(this.btnconsultasmarcadas);
            this.Name = "Form2_TelaCliente";
            this.Text = "Form2_TelaCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvisualizar;
        private System.Windows.Forms.Button bntnovocadastro;
        private System.Windows.Forms.Button btnmarcar;
        private System.Windows.Forms.Button btnconsultasmarcadas;
        private System.Windows.Forms.Button btnretornar;
    }
}