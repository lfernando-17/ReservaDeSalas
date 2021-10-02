
namespace View
{
    partial class frmCadastrarReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarReserva));
            this.label1 = new System.Windows.Forms.Label();
            this.edtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_inicio = new System.Windows.Forms.MaskedTextBox();
            this.edt_fim = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_hora = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxSala = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Evento :";
            // 
            // edtnome
            // 
            this.edtnome.Location = new System.Drawing.Point(45, 67);
            this.edtnome.Name = "edtnome";
            this.edtnome.Size = new System.Drawing.Size(216, 27);
            this.edtnome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data do Inicio :";
            // 
            // edt_inicio
            // 
            this.edt_inicio.Location = new System.Drawing.Point(346, 67);
            this.edt_inicio.Mask = "00/00/0000";
            this.edt_inicio.Name = "edt_inicio";
            this.edt_inicio.Size = new System.Drawing.Size(180, 27);
            this.edt_inicio.TabIndex = 3;
            this.edt_inicio.ValidatingType = typeof(System.DateTime);
            this.edt_inicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            // 
            // edt_fim
            // 
            this.edt_fim.Location = new System.Drawing.Point(346, 142);
            this.edt_fim.Mask = "00/00/0000";
            this.edt_fim.Name = "edt_fim";
            this.edt_fim.Size = new System.Drawing.Size(180, 27);
            this.edt_fim.TabIndex = 4;
            this.edt_fim.ValidatingType = typeof(System.DateTime);
            this.edt_fim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Final  :";
            // 
            // edt_hora
            // 
            this.edt_hora.Location = new System.Drawing.Point(45, 142);
            this.edt_hora.Mask = "90:00";
            this.edt_hora.Name = "edt_hora";
            this.edt_hora.Size = new System.Drawing.Size(216, 27);
            this.edt_hora.TabIndex = 2;
            this.edt_hora.ValidatingType = typeof(System.DateTime);
            this.edt_hora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hora :";
            // 
            // cbxSala
            // 
            this.cbxSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSala.FormattingEnabled = true;
            this.cbxSala.Location = new System.Drawing.Point(45, 228);
            this.cbxSala.Name = "cbxSala";
            this.cbxSala.Size = new System.Drawing.Size(216, 28);
            this.cbxSala.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sala :";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(275, 301);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(102, 49);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmCadastrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 374);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxSala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edt_hora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edt_fim);
            this.Controls.Add(this.edt_inicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtnome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadastrarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Reserva";
            this.Load += new System.EventHandler(this.frmCadastrarReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox edt_inicio;
        private System.Windows.Forms.MaskedTextBox edt_fim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox edt_hora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnviar;
    }
}