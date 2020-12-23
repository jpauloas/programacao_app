
namespace SA_III
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtquestao = new System.Windows.Forms.Label();
            this.btnfuncionario = new System.Windows.Forms.Button();
            this.btncliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtquestao
            // 
            this.txtquestao.AutoSize = true;
            this.txtquestao.Font = new System.Drawing.Font("NewsGoth Cn BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquestao.Location = new System.Drawing.Point(78, 429);
            this.txtquestao.Name = "txtquestao";
            this.txtquestao.Size = new System.Drawing.Size(46, 16);
            this.txtquestao.TabIndex = 10;
            this.txtquestao.Text = "Você é...";
            this.txtquestao.Click += new System.EventHandler(this.txtquestao_Click);
            // 
            // btnfuncionario
            // 
            this.btnfuncionario.Font = new System.Drawing.Font("NewsGoth Cn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfuncionario.Location = new System.Drawing.Point(81, 484);
            this.btnfuncionario.Name = "btnfuncionario";
            this.btnfuncionario.Size = new System.Drawing.Size(266, 28);
            this.btnfuncionario.TabIndex = 9;
            this.btnfuncionario.Text = "Funcionário";
            this.btnfuncionario.UseVisualStyleBackColor = true;
            this.btnfuncionario.Click += new System.EventHandler(this.btnfuncionario_Click);
            // 
            // btncliente
            // 
            this.btncliente.Font = new System.Drawing.Font("NewsGoth Cn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.Location = new System.Drawing.Point(81, 448);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(266, 28);
            this.btncliente.TabIndex = 8;
            this.btncliente.Text = "Cliente";
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 541);
            this.Controls.Add(this.txtquestao);
            this.Controls.Add(this.btnfuncionario);
            this.Controls.Add(this.btncliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtquestao;
        private System.Windows.Forms.Button btnfuncionario;
        private System.Windows.Forms.Button btncliente;
    }
}

