
namespace View
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tHora = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalReserva = new System.Windows.Forms.Label();
            this.btnConsultaEquipamentos = new System.Windows.Forms.ToolStripButton();
            this.btnConsultaSalas = new System.Windows.Forms.ToolStripButton();
            this.btnConsultaReserva = new System.Windows.Forms.ToolStripButton();
            this.btnDiagrama = new System.Windows.Forms.ToolStripButton();
            this.btnCadastrar = new System.Windows.Forms.ToolStripButton();
            this.btnConsulta = new System.Windows.Forms.ToolStripButton();
            this.btnEquipamento = new System.Windows.Forms.ToolStripButton();
            this.btnSalas = new System.Windows.Forms.ToolStripButton();
            this.btnReserva = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTempo);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 93);
            this.panel1.TabIndex = 0;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(874, 32);
            this.lblTempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(110, 26);
            this.lblTempo.TabIndex = 1;
            this.lblTempo.Text = "00:00:00";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(56, 32);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(123, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Bem vindo";
            // 
            // tHora
            // 
            this.tHora.Interval = 1000;
            this.tHora.Tick += new System.EventHandler(this.tHora_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrar,
            this.btnConsulta,
            this.btnEquipamento,
            this.btnSalas,
            this.btnReserva});
            this.toolStrip1.Location = new System.Drawing.Point(9, 95);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(432, 57);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConsultaEquipamentos,
            this.btnConsultaSalas,
            this.btnConsultaReserva,
            this.btnDiagrama});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(919, 133);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(85, 284);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(922, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consultas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblTotalReserva);
            this.panel2.Location = new System.Drawing.Point(-2, 469);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 63);
            this.panel2.TabIndex = 2;
            // 
            // lblTotalReserva
            // 
            this.lblTotalReserva.AutoSize = true;
            this.lblTotalReserva.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReserva.Location = new System.Drawing.Point(26, 18);
            this.lblTotalReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalReserva.Name = "lblTotalReserva";
            this.lblTotalReserva.Size = new System.Drawing.Size(268, 26);
            this.lblTotalReserva.TabIndex = 0;
            this.lblTotalReserva.Text = "Foram feitas 0 Reservas";
            // 
            // btnConsultaEquipamentos
            // 
            this.btnConsultaEquipamentos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConsultaEquipamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaEquipamentos.Image")));
            this.btnConsultaEquipamentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultaEquipamentos.Name = "btnConsultaEquipamentos";
            this.btnConsultaEquipamentos.Padding = new System.Windows.Forms.Padding(0, 0, 30, 15);
            this.btnConsultaEquipamentos.Size = new System.Drawing.Size(83, 69);
            this.btnConsultaEquipamentos.Text = "toolStripButton1";
            this.btnConsultaEquipamentos.ToolTipText = "Consultar Equipamentos";
            this.btnConsultaEquipamentos.Click += new System.EventHandler(this.btnConsultaEquipamentos_Click);
            // 
            // btnConsultaSalas
            // 
            this.btnConsultaSalas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConsultaSalas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaSalas.Image")));
            this.btnConsultaSalas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultaSalas.Name = "btnConsultaSalas";
            this.btnConsultaSalas.Padding = new System.Windows.Forms.Padding(0, 0, 30, 15);
            this.btnConsultaSalas.Size = new System.Drawing.Size(83, 69);
            this.btnConsultaSalas.Text = "toolStripButton2";
            this.btnConsultaSalas.ToolTipText = "Consultar Salas";
            this.btnConsultaSalas.Click += new System.EventHandler(this.btnConsultaSalas_Click);
            // 
            // btnConsultaReserva
            // 
            this.btnConsultaReserva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConsultaReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaReserva.Image")));
            this.btnConsultaReserva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultaReserva.Name = "btnConsultaReserva";
            this.btnConsultaReserva.Padding = new System.Windows.Forms.Padding(0, 0, 30, 15);
            this.btnConsultaReserva.Size = new System.Drawing.Size(83, 69);
            this.btnConsultaReserva.Text = "toolStripButton3";
            this.btnConsultaReserva.ToolTipText = "Consultar Reserva";
            this.btnConsultaReserva.Click += new System.EventHandler(this.btnConsultaReserva_Click);
            // 
            // btnDiagrama
            // 
            this.btnDiagrama.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDiagrama.Image = ((System.Drawing.Image)(resources.GetObject("btnDiagrama.Image")));
            this.btnDiagrama.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDiagrama.Name = "btnDiagrama";
            this.btnDiagrama.Size = new System.Drawing.Size(83, 54);
            this.btnDiagrama.Text = "toolStripButton1";
            this.btnDiagrama.ToolTipText = "Consultar Diagrama";
            this.btnDiagrama.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(84, 54);
            this.btnCadastrar.Text = "toolStripButton1";
            this.btnCadastrar.ToolTipText = "Cadastrar Usuários";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(0);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnConsulta.Size = new System.Drawing.Size(84, 57);
            this.btnConsulta.Text = "toolStripButton1";
            this.btnConsulta.ToolTipText = "Consultar Usuários";
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnEquipamento
            // 
            this.btnEquipamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEquipamento.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipamento.Image")));
            this.btnEquipamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEquipamento.Name = "btnEquipamento";
            this.btnEquipamento.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnEquipamento.Size = new System.Drawing.Size(84, 54);
            this.btnEquipamento.Text = "toolStripButton1";
            this.btnEquipamento.ToolTipText = "Cadastrar Equipamentos";
            this.btnEquipamento.Click += new System.EventHandler(this.btnEquipamento_Click);
            // 
            // btnSalas
            // 
            this.btnSalas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalas.Image = ((System.Drawing.Image)(resources.GetObject("btnSalas.Image")));
            this.btnSalas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnSalas.Size = new System.Drawing.Size(84, 54);
            this.btnSalas.Text = "toolStripButton2";
            this.btnSalas.ToolTipText = "Cadastrar Salas";
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnReserva.Image")));
            this.btnReserva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnReserva.Size = new System.Drawing.Size(84, 54);
            this.btnReserva.Text = "toolStripButton3";
            this.btnReserva.ToolTipText = "Cadastrar Reserva";
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::View.Properties.Resources.unnamed;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1013, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Timer tHora;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCadastrar;
        private System.Windows.Forms.ToolStripButton btnConsulta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton btnEquipamento;
        private System.Windows.Forms.ToolStripButton btnSalas;
        private System.Windows.Forms.ToolStripButton btnReserva;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnConsultaEquipamentos;
        private System.Windows.Forms.ToolStripButton btnConsultaSalas;
        private System.Windows.Forms.ToolStripButton btnConsultaReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalReserva;
        private System.Windows.Forms.ToolStripButton btnDiagrama;
    }
}