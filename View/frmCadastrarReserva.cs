using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
namespace View
{
    public partial class frmCadastrarReserva : Form
    {
        private int status = 0;
        private List<Espaco> ListaSalas = new List<Espaco>();
        private Reserva Reserva = new Reserva();
        public frmCadastrarReserva(List<Espaco> ListaSalas)
        {
            InitializeComponent();
            this.ListaSalas = ListaSalas;
            foreach (Espaco sala in ListaSalas)
            {
                if ((sala.situacao == "Disponível"))
                {
                    cbxSala.Items.Add(sala.nome);
                }
            }
        }

        public frmCadastrarReserva(int status , Reserva Reserva , List<Espaco> ListaSalas)
        {
            this.status = status;
            this.Reserva = Reserva;
            InitializeComponent();
            this.ListaSalas = ListaSalas;
            foreach (Espaco sala in ListaSalas)
            {
                if ((sala.situacao == "Disponível"))
                {
                    cbxSala.Items.Add(sala.nome);
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if ((edtnome.Text == "") || (edt_hora.Text == "") || (edt_inicio.Text == "") || (edt_fim.Text == "") || (cbxSala.Text == ""))
            {
                MessageBox.Show("Existem dados nos campos faltando ! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Espaco escolhido = ListaSalas.Find(equip => equip.nome == cbxSala.Text);
                if (status == 0)
                {
                    Reserva Reserva = new Reserva(edtnome.Text, edt_inicio.Text, edt_fim.Text, edt_hora.Text, escolhido);
                    this.Tag = Reserva;
                    this.DialogResult = DialogResult.OK;
                    escolhido.situacao = "Indisponível";
                    MessageBox.Show("Reserva cadastrada com sucesso ! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    Reserva.nome = edtnome.Text;
                    Reserva.dt_inicio = edt_inicio.Text;
                    Reserva.dt_fim = edt_fim.Text;
                    Reserva.hora = edt_hora.Text;
                    Reserva.Sala.situacao = "Disponível";
                    Reserva.Sala = escolhido;
                    Reserva.Sala.situacao = "Indisponível";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar reserva : " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCadastrarReserva_Load(object sender, EventArgs e)
        {
            if (status != 0)
            {
                edtnome.Text = Reserva.nome;
                edt_inicio.Text = Reserva.dt_inicio;
                edt_fim.Text = Reserva.dt_fim;
                edt_hora.Text = Reserva.hora;
                cbxSala.Text = Reserva.Sala.nome;
            }
        }

        private void Verifica(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                     (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnEnviar_Click(null, null);
                    break;

                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
