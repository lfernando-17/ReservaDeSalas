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
    public partial class frmConsulta : Form
    {
        private List<Usuario> ListaUsuario = new List<Usuario>();
        private DataTable Pessoas = new DataTable();
        private DataTable tabela;
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

            ListaUsuario = (List<Usuario>)this.Tag;
            tabela = PopularQuery();
            dgvPessoas.DataSource = tabela;
        }
        private DataTable PopularQuery()
        {
            try
            {
                Pessoas = new DataTable();
                Pessoas.Columns.Add("CPF", typeof(long));
                Pessoas.Columns.Add("Usuário", typeof(string));
                Pessoas.Columns.Add("Rua", typeof(string));
                Pessoas.Columns.Add("Bairro", typeof(string));
                Pessoas.Columns.Add("Estado", typeof(string));
                foreach (Usuario user in ListaUsuario) 
                {
                    Pessoas.Rows.Add(user.CPF, user.User, user.adress.Rua, user.adress.Bairro, user.adress.Estado);
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
            
            foreach (Usuario user in ListaUsuario)
            {
                if(user.CPF.ToString() == dgvPessoas.CurrentRow.Cells[0].Value.ToString())
                {
                    var form = new frmCadastro(1,user);
                    form.ShowDialog();
                    frmConsulta_Load(sender, e);
                    break;
                   
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (Usuario user in ListaUsuario)
            {
                if (user.CPF.ToString() == dgvPessoas.CurrentRow.Cells[0].Value.ToString())
                {
                if (MessageBox.Show("Tem certeza que deseja deletar esse usuário ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        foreach (DataRow row in tabela.Select())
                        {
                            if (row["CPF"].ToString().Equals(dgvPessoas.CurrentRow.Cells[0].Value.ToString()))
                            {
                                tabela.Rows.Remove(row);
                            }
                            tabela.AcceptChanges();
                        }
                        dgvPessoas.Update();
                        dgvPessoas.Refresh();
                        ListaUsuario.Remove(user);
                        break;
                    }
                }
            }
        }

    }
}
