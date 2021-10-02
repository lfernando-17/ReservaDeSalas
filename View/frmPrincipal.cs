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
    public partial class frmPrincipal : Form
    {
        private List<Usuario> ListaUsuario = new List<Usuario>();
        private Usuario ListaUsuarioLogado = new Usuario();
        private List<Equipamento> ListaEquipamento = new List<Equipamento>();
        private List<Espaco> ListaEspaco = new List<Espaco>();
        private List<Reserva> ListaReservas= new List<Reserva>();
        public frmPrincipal()
        {  
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                tHora.Enabled = true;
                ListaUsuario = (List<Usuario>)this.Tag;
                ListaUsuarioLogado = ListaUsuario[ListaUsuario.Count - 1];
                ListaUsuario.RemoveAt(ListaUsuario.Count - 1);
                lblTotalReserva.Text = "Foram feitas "+ListaReservas.Count+" Reservas";
                lblName.Text = "Bem vindo " + ListaUsuarioLogado.User;
   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar form : " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro Form = new frmCadastro();
            if (Form.ShowDialog() == DialogResult.OK)
            {
                ListaUsuario.Add((Usuario)Form.Tag);
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsulta Form = new frmConsulta();
            Form.Tag = ListaUsuario;
            Form.ShowDialog();
        }

        private void btnEquipamento_Click(object sender, EventArgs e)
        {
            var Form = new frmCadastroEquipamento();
            if (Form.ShowDialog() == DialogResult.OK)
            {
                ListaEquipamento.Add((Equipamento)Form.Tag);
            }
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            frmCadastrarSalas Form = new frmCadastrarSalas(ListaEquipamento);
            Form.Tag = ListaEquipamento; 
            if (Form.ShowDialog() == DialogResult.OK)
            {
                ListaEspaco.Add((Espaco)Form.Tag);
            }
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            frmCadastrarReserva Form = new frmCadastrarReserva(ListaEspaco);
            Form.Tag = ListaEspaco;
            if (Form.ShowDialog() == DialogResult.OK)
            {
                ListaReservas.Add((Reserva)Form.Tag);
                lblTotalReserva.Text = "Foram feitas " + ListaReservas.Count + " Reservas";
            }
        }

        private void btnConsultaEquipamentos_Click(object sender, EventArgs e)
        {
            frmConsultaEquip Form = new frmConsultaEquip();
            Form.Tag = ListaEquipamento;
            Form.ShowDialog();
        }

        private void btnConsultaSalas_Click(object sender, EventArgs e)
        {
            frmConsultaSalas Form = new frmConsultaSalas(ListaEquipamento);
            Form.Tag = ListaEspaco;
            Form.ShowDialog();
        }

        private void btnConsultaReserva_Click(object sender, EventArgs e)
        {
            frmConsultaReserva Form = new frmConsultaReserva(ListaEspaco);
            Form.Tag = ListaReservas;
            Form.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmDiagrama Form = new frmDiagrama();
            Form.ShowDialog();
        }
    }
}
