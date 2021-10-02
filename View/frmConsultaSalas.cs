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
    public partial class frmConsultaSalas : Form
    {
        private List<Espaco> ListaSalas = new List<Espaco>();
        private List<Equipamento> ListaEquipamento = new List<Equipamento>();
        private DataTable Pessoas = new DataTable();
        private DataTable tabela;
        public frmConsultaSalas(List<Equipamento> ListaEquipamento)
        {
            this.ListaEquipamento = ListaEquipamento;
            InitializeComponent();
        }

        private void frmConsultaSalas_Load(object sender, EventArgs e)
        {
            ListaSalas = (List<Espaco>)this.Tag;
            tabela = PopularQuery();
            dgvSalas.DataSource = tabela;
        }
        private DataTable PopularQuery()
        {
            try
            {
                Pessoas = new DataTable();
                Pessoas.Columns.Add("ID", typeof(int));
                Pessoas.Columns.Add("Nome", typeof(string));
                Pessoas.Columns.Add("Situação", typeof(string));
                Pessoas.Columns.Add("Capacidade", typeof(int));
                Pessoas.Columns.Add("ID Equipamento", typeof(int));
                Pessoas.Columns.Add("Descrição Equipamento", typeof(string));

                foreach (Espaco sala in ListaSalas)
                {
                    Pessoas.Rows.Add( sala.id , sala.nome,sala.situacao ,sala.capacidade,sala.equipamento.id,sala.equipamento.descricao);
                }
                return Pessoas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar form : " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            foreach (Espaco sala in ListaSalas)
            {
                if (sala.id.ToString() == dgvSalas.CurrentRow.Cells[0].Value.ToString())
                {
                    var form = new frmCadastrarSalas(1, sala, ListaEquipamento);
                    form.ShowDialog();
                    frmConsultaSalas_Load(sender, e);
                    break;

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (Espaco sala in ListaSalas)
            {
                if (sala.id.ToString() == dgvSalas.CurrentRow.Cells[0].Value.ToString())
                {
                    if (sala.situacao == "Indisponível")
                    {
                        MessageBox.Show("Sala em uso !", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        return;
                    }

                    if (MessageBox.Show("Tem certeza que deseja deletar essa sala?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        foreach (DataRow row in tabela.Select())
                        {
                            if (row["ID"].ToString().Equals(dgvSalas.CurrentRow.Cells[0].Value.ToString()))
                            {
                                tabela.Rows.Remove(row);
                            }
                            tabela.AcceptChanges();
                        }
                        dgvSalas.Update();
                        dgvSalas.Refresh();
                        sala.equipamento.quantidade++;
                        ListaSalas.Remove(sala);
                        break;
                    }
                }
            }
        }
    }
}
