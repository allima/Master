namespace FormHome
{
    partial class FormCorretorManutencao
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
            this.txtb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_telefone = new System.Windows.Forms.TextBox();
            this.txtb_rg = new System.Windows.Forms.TextBox();
            this.txtb_cpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bnt_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_endereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtb_nome
            // 
            this.txtb_nome.Location = new System.Drawing.Point(194, 23);
            this.txtb_nome.Name = "txtb_nome";
            this.txtb_nome.Size = new System.Drawing.Size(179, 20);
            this.txtb_nome.TabIndex = 1;
            this.txtb_nome.TextChanged += new System.EventHandler(this.txtb_nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtb_telefone
            // 
            this.txtb_telefone.Location = new System.Drawing.Point(194, 175);
            this.txtb_telefone.Name = "txtb_telefone";
            this.txtb_telefone.Size = new System.Drawing.Size(179, 20);
            this.txtb_telefone.TabIndex = 5;
            this.txtb_telefone.TextChanged += new System.EventHandler(this.txtb_telefone_TextChanged);
            // 
            // txtb_rg
            // 
            this.txtb_rg.Location = new System.Drawing.Point(194, 99);
            this.txtb_rg.Name = "txtb_rg";
            this.txtb_rg.Size = new System.Drawing.Size(179, 20);
            this.txtb_rg.TabIndex = 3;
            this.txtb_rg.TextChanged += new System.EventHandler(this.txtb_rg_TextChanged);
            // 
            // txtb_cpf
            // 
            this.txtb_cpf.Location = new System.Drawing.Point(194, 137);
            this.txtb_cpf.Name = "txtb_cpf";
            this.txtb_cpf.Size = new System.Drawing.Size(179, 20);
            this.txtb_cpf.TabIndex = 4;
            this.txtb_cpf.TextChanged += new System.EventHandler(this.txtb_cpf_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RG";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bnt_salvar
            // 
            this.bnt_salvar.Location = new System.Drawing.Point(76, 266);
            this.bnt_salvar.Name = "bnt_salvar";
            this.bnt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bnt_salvar.TabIndex = 7;
            this.bnt_salvar.Text = "Salvar";
            this.bnt_salvar.UseVisualStyleBackColor = true;
            this.bnt_salvar.Click += new System.EventHandler(this.bnt_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(217, 266);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(373, 266);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 23);
            this.btnfechar.TabIndex = 9;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Endereço";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtb_endereco
            // 
            this.txtb_endereco.Location = new System.Drawing.Point(194, 61);
            this.txtb_endereco.Name = "txtb_endereco";
            this.txtb_endereco.Size = new System.Drawing.Size(179, 20);
            this.txtb_endereco.TabIndex = 2;
            this.txtb_endereco.TextChanged += new System.EventHandler(this.txtb_endereco_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtb_email
            // 
            this.txtb_email.Location = new System.Drawing.Point(194, 213);
            this.txtb_email.Name = "txtb_email";
            this.txtb_email.Size = new System.Drawing.Size(179, 20);
            this.txtb_email.TabIndex = 6;
            this.txtb_email.TextChanged += new System.EventHandler(this.txtb_email_TextChanged);
            // 
            // FormCorretorManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 322);
            this.Controls.Add(this.txtb_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtb_endereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.bnt_salvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_cpf);
            this.Controls.Add(this.txtb_rg);
            this.Controls.Add(this.txtb_telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_nome);
            this.Controls.Add(this.label1);
            this.Name = "FormCorretorManutencao";
            this.Text = "FormCorretorManutecao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_telefone;
        private System.Windows.Forms.TextBox txtb_rg;
        private System.Windows.Forms.TextBox txtb_cpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bnt_salvar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_endereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb_email;
    }
}