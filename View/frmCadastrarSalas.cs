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
    public partial class frmCadastrarSalas : Form
    {
        private int status = 0;
        private Espaco sala = new Espaco();
        private List<Equipamento> ListaEquipamento = new List<Equipamento>();

        public frmCadastrarSalas(List<Equipamento> ListaEquipamento)
        {
            
            InitializeComponent();
            this.ListaEquipamento = ListaEquipamento;

            foreach (Equipamento equip in ListaEquipamento)
            {
                if ((equip.status == "Disponível") && equip.quantidade > 0)
                {
                    cbxEquipamento.Items.Add(equip.descricao);
                }
            }
        }
        public frmCadastrarSalas(int status , Espaco sala,List<Equipamento> ListaEquipamento)
        {
            this.status = status;
            this.sala = sala;
            InitializeComponent();
            this.ListaEquipamento = ListaEquipamento;

            foreach (Equipamento equip in ListaEquipamento)
            {
                if ((equip.status == "Disponível") && equip.quantidade > 0)
                {
                    cbxEquipamento.Items.Add(equip.descricao);
                }
            }
        }
        private void frmCadastrarSalas_Load(object sender, EventArgs e)
        {
            

            if (status != 0)
            {
                edtNome.Text = sala.nome;
                edtCapacidade.Text = sala.capacidade.ToString();
                cbxSituacao.Text = sala.situacao;
                cbxEquipamento.Text = sala.equipamento.descricao;
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

        private void edtCapacidade_KeyPress(object sender, KeyPressEventArgs e)
        {
               if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                        (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
          
                if ((edtNome.Text == "") || (edtCapacidade.Text == "") || (cbxSituacao.Text == "") || (cbxEquipamento.Text == ""))
                {
                    MessageBox.Show("Existem dados nos campos faltando ! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    Equipamento escolhido = ListaEquipamento.Find(equip => equip.descricao == cbxEquipamento.Text);
                    if (status == 0) 
                    {
                        Espaco sala = new Espaco(edtNome.Text, Int32.Parse(edtCapacidade.Text), cbxSituacao.Text, escolhido);
                        this.Tag = sala;
                        this.DialogResult = DialogResult.OK;
                        escolhido.quantidade--;
                        MessageBox.Show("Espaço cadastrado ! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                }
                else
                {
                    sala.nome = edtNome.Text;
                    sala.capacidade = Int32.Parse(edtCapacidade.Text);
                    sala.situacao = cbxSituacao.Text;
                    sala.equipamento.quantidade++;
                    sala.equipamento = escolhido;
                    sala.equipamento.quantidade--;
                    MessageBox.Show("Espaço atualizado ! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar sala: " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        
    }
}
