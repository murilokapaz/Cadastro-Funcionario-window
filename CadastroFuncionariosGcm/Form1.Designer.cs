namespace CadastroFuncionariosGcm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblGraduacao = new System.Windows.Forms.Label();
            this.txtGraduacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeGuerra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdioSim = new System.Windows.Forms.RadioButton();
            this.rdioNao = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(21, 28);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(52, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(115, 25);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(172, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(20, 59);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(115, 59);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(172, 20);
            this.txtQtd.TabIndex = 3;
            // 
            // lblGraduacao
            // 
            this.lblGraduacao.AutoSize = true;
            this.lblGraduacao.Location = new System.Drawing.Point(19, 96);
            this.lblGraduacao.Name = "lblGraduacao";
            this.lblGraduacao.Size = new System.Drawing.Size(60, 13);
            this.lblGraduacao.TabIndex = 4;
            this.lblGraduacao.Text = "Graduação";
            // 
            // txtGraduacao
            // 
            this.txtGraduacao.Location = new System.Drawing.Point(115, 96);
            this.txtGraduacao.Name = "txtGraduacao";
            this.txtGraduacao.Size = new System.Drawing.Size(172, 20);
            this.txtGraduacao.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome de Guerra";
            // 
            // txtNomeGuerra
            // 
            this.txtNomeGuerra.Location = new System.Drawing.Point(115, 132);
            this.txtNomeGuerra.Name = "txtNomeGuerra";
            this.txtNomeGuerra.Size = new System.Drawing.Size(172, 20);
            this.txtNomeGuerra.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome Completo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(115, 167);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(172, 20);
            this.txtNome.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ativo?";
            // 
            // rdioSim
            // 
            this.rdioSim.AutoSize = true;
            this.rdioSim.Location = new System.Drawing.Point(24, 237);
            this.rdioSim.Name = "rdioSim";
            this.rdioSim.Size = new System.Drawing.Size(42, 17);
            this.rdioSim.TabIndex = 11;
            this.rdioSim.TabStop = true;
            this.rdioSim.Text = "Sim";
            this.rdioSim.UseVisualStyleBackColor = true;
            // 
            // rdioNao
            // 
            this.rdioNao.AutoSize = true;
            this.rdioNao.Location = new System.Drawing.Point(69, 237);
            this.rdioNao.Name = "rdioNao";
            this.rdioNao.Size = new System.Drawing.Size(45, 17);
            this.rdioNao.TabIndex = 12;
            this.rdioNao.TabStop = true;
            this.rdioNao.Text = "Não";
            this.rdioNao.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.Location = new System.Drawing.Point(185, 237);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(102, 42);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 317);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.rdioNao);
            this.Controls.Add(this.rdioSim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeGuerra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGraduacao);
            this.Controls.Add(this.lblGraduacao);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cadastro de Funcionários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblGraduacao;
        private System.Windows.Forms.TextBox txtGraduacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeGuerra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdioSim;
        private System.Windows.Forms.RadioButton rdioNao;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

