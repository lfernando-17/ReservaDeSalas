
namespace View
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edtRua = new System.Windows.Forms.TextBox();
            this.edtNumero = new System.Windows.Forms.TextBox();
            this.edtSenha = new System.Windows.Forms.TextBox();
            this.edtConfirmeSenha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.edtBairro = new System.Windows.Forms.TextBox();
            this.edtCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.edtCPF = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário :";
            // 
            // edtNome
            // 
            this.edtNome.Location = new System.Drawing.Point(54, 56);
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(163, 20);
            this.edtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Confirme a Senha :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Senha :";
            // 
            // edtRua
            // 
            this.edtRua.Location = new System.Drawing.Point(22, 49);
            this.edtRua.Name = "edtRua";
            this.edtRua.Size = new System.Drawing.Size(164, 24);
            this.edtRua.TabIndex = 5;
            // 
            // edtNumero
            // 
            this.edtNumero.Location = new System.Drawing.Point(238, 49);
            this.edtNumero.Name = "edtNumero";
            this.edtNumero.Size = new System.Drawing.Size(164, 24);
            this.edtNumero.TabIndex = 6;
            this.edtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtNumero_KeyPress);
            // 
            // edtSenha
            // 
            this.edtSenha.Location = new System.Drawing.Point(269, 56);
            this.edtSenha.Name = "edtSenha";
            this.edtSenha.PasswordChar = '*';
            this.edtSenha.Size = new System.Drawing.Size(164, 20);
            this.edtSenha.TabIndex = 3;
            // 
            // edtConfirmeSenha
            // 
            this.edtConfirmeSenha.Location = new System.Drawing.Point(269, 128);
            this.edtConfirmeSenha.Name = "edtConfirmeSenha";
            this.edtConfirmeSenha.PasswordChar = '*';
            this.edtConfirmeSenha.Size = new System.Drawing.Size(164, 20);
            this.edtConfirmeSenha.TabIndex = 4;
            this.edtConfirmeSenha.Leave += new System.EventHandler(this.edtConfirmeSenha_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxEstado);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.edtBairro);
            this.groupBox1.Controls.Add(this.edtCidade);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.edtRua);
            this.groupBox1.Controls.Add(this.edtNumero);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 255);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "AC(“Acre”)",
            "AL(“Alagoas”)",
            "AM(“Amazonas”)",
            "AP(“Amapá”)",
            "BA(“Bahia”)",
            "CE(“Ceará”)",
            "DF(“Distrito Federal”)",
            "ES(“Espirito Santo”)",
            "GO(“Goias”)",
            "MA(“Maranhão”,",
            "MG(“Minas Gerais”)",
            "MS(“Mato Grosso Sul”)",
            "MT(“Mato Grosso”)",
            "PA(“Pará”)",
            "PB(“Paraiba”)",
            "PE(“Pernanbuco”)",
            "PI(“Piaui”)",
            "PR(“Parana”)",
            "RJ(“Rio de Janeiro”)",
            "RN(“Rio Grande do Norte”)",
            "RO(“Rondônia”)",
            "RR(“Roraima”)",
            "RS(“Rio Grande do Sul”)",
            "SC(“Santa Catarina”)",
            "SE(“Sergipe”)",
            "SP(“São Paulo”)",
            "TO(“Tocantins”)"});
            this.cbxEstado.Location = new System.Drawing.Point(22, 177);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(164, 26);
            this.cbxEstado.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bairro";
            // 
            // edtBairro
            // 
            this.edtBairro.Location = new System.Drawing.Point(238, 112);
            this.edtBairro.Name = "edtBairro";
            this.edtBairro.Size = new System.Drawing.Size(164, 24);
            this.edtBairro.TabIndex = 8;
            // 
            // edtCidade
            // 
            this.edtCidade.Location = new System.Drawing.Point(22, 112);
            this.edtCidade.Name = "edtCidade";
            this.edtCidade.Size = new System.Drawing.Size(164, 24);
            this.edtCidade.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cidade";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(173, 426);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(129, 50);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // edtCPF
            // 
            this.edtCPF.Location = new System.Drawing.Point(55, 128);
            this.edtCPF.Mask = "000-000-000-00";
            this.edtCPF.Name = "edtCPF";
            this.edtCPF.Size = new System.Drawing.Size(162, 20);
            this.edtCPF.TabIndex = 2;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 529);
            this.Controls.Add(this.edtCPF);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.edtConfirmeSenha);
            this.Controls.Add(this.edtSenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtRua;
        private System.Windows.Forms.TextBox edtNumero;
        private System.Windows.Forms.TextBox edtSenha;
        private System.Windows.Forms.TextBox edtConfirmeSenha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edtBairro;
        private System.Windows.Forms.TextBox edtCidade;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox edtCPF;
    }
}