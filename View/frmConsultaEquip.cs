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
    public partial class frmConsultaEquip : Form
    {
        private List<Equipamento> ListaEquipamento = new List<Equipamento>();
        private DataTable Pessoas = new DataTable();
        private DataTable tabela;
        public frmConsultaEquip()
        {
            InitializeComponent();
        }

        private void frmConsultaEquip_Load(object sender, EventArgs e)
        {
            ListaEquipamento = (List<Equipamento>)this.Tag;
            tabela = PopularQuery();
            dgvEquipamento.DataSource = tabela;
        }
        private DataTable PopularQuery()
        {
            try
            {
                Pessoas = new DataTable();
                Pessoas.Columns.Add("ID", typeof(int));
                Pessoas.Columns.Add("Descrição", typeof(string));
                Pessoas.Columns.Add("Status", typeof(string));
                Pessoas.Columns.Add("Quantidade", typeof(int));
                foreach (Equipamento equip in ListaEquipamento)
                {
                    Pessoas.Rows.Add(equip.id,equip.descricao,equip.status,equip.quantidade);
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
            foreach (Equipamento equip in ListaEquipamento)
            {
                if (equip.id.ToString() == dgvEquipamento.CurrentRow.Cells[0].Value.ToString())
                {
                    var form = new frmCadastroEquipamento(1, equip);
                    form.ShowDialog();
                    frmConsultaEquip_Load(sender, e);
                    break;

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (Equipamento equip in ListaEquipamento)
            {
                if (equip.id.ToString() == dgvEquipamento.CurrentRow.Cells[0].Value.ToString())
                {

                    if (equip.status == "Indisponível")
                    {
                        MessageBox.Show("Equipamento em uso !", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        return;
                    }

                    if (MessageBox.Show("Tem certeza que deseja deletar esse equipamento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        foreach (DataRow row in tabela.Select())
                        {
                            if (row["ID"].ToString().Equals(dgvEquipamento.CurrentRow.Cells[0].Value.ToString()))
                            {
                                tabela.Rows.Remove(row);
                            }
                            tabela.AcceptChanges();
                        }
                        dgvEquipamento.Update();
                        dgvEquipamento.Refresh();
                        ListaEquipamento.Remove(equip);
                        break;
                    }
                }
            }
        }
    }
}
