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
    public partial class frmConsultaReserva : Form
    {
        private List<Espaco> ListaSalas = new List<Espaco>();
        private List<Reserva> ListaReservas = new List<Reserva>();
        private DataTable Pessoas = new DataTable();
        private DataTable tabela;
        public frmConsultaReserva(List<Espaco> ListaSalas)
        {
            this.ListaSalas = ListaSalas;
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (Reserva reserva in ListaReservas)
            {
                if (reserva.id.ToString() == dgvReserva.CurrentRow.Cells[0].Value.ToString())
                {
                    if (MessageBox.Show("Tem certeza que deseja deletar essa reserva?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        foreach (DataRow row in tabela.Select())
                        {
                            if (row["ID"].ToString().Equals(dgvReserva.CurrentRow.Cells[0].Value.ToString()))
                            {
                                tabela.Rows.Remove(row);
                            }
                            tabela.AcceptChanges();
                        }
                        dgvReserva.Update();
                        dgvReserva.Refresh();
                        reserva.Sala.situacao = "Disponível";
                        ListaReservas.Remove(reserva);
                        break;
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            foreach (Reserva reserva in ListaReservas)
            {
                if (reserva.id.ToString() == dgvReserva.CurrentRow.Cells[0].Value.ToString())
                {
                    var form = new frmCadastrarReserva(1, reserva, ListaSalas);
                    form.ShowDialog();
                    frmConsultaReserva_Load(sender, e);
                    break;

                }
            }
        }

        private void frmConsultaReserva_Load(object sender, EventArgs e)
        {
            ListaReservas = (List<Reserva>)this.Tag;
            tabela = PopularQuery();
            dgvReserva.DataSource = tabela;
        }

        private DataTable PopularQuery()
        {
            try
            {
                Pessoas = new DataTable();
                Pessoas.Columns.Add("ID", typeof(int));
                Pessoas.Columns.Add("Nome", typeof(string));
                Pessoas.Columns.Add("Data Inicio", typeof(string));
                Pessoas.Columns.Add("DataFim", typeof(string));
                Pessoas.Columns.Add("Hora", typeof(string));
                Pessoas.Columns.Add("Código da Sala", typeof(int));
                Pessoas.Columns.Add("Nome da Sala", typeof(string));

                foreach (Reserva reserva in ListaReservas)
                {
                    Pessoas.Rows.Add(
                        reserva.id,
                        reserva.nome,
                        reserva.dt_inicio,
                        reserva.dt_fim,
                        reserva.hora,
                        reserva.Sala.id,
                        reserva.Sala.nome);
                }
                return Pessoas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar form : " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
