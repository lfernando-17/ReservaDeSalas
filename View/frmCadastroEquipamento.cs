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
    public partial class frmCadastroEquipamento : Form
    {
        private int status = 0;
        private Equipamento equip = new Equipamento();
        public frmCadastroEquipamento()
        {
            InitializeComponent();
        }

        public frmCadastroEquipamento(int status, Equipamento equip)
        {
            this.status = 1;
            this.equip = equip;
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if ((cbxStatus.Text == "") || (edtDescricao.Text == "") || (edtQuantidade.Text == ""))
            {
                MessageBox.Show("Existem dados nos campos faltando ! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (status == 0)
                {
                    Equipamento equip = new Equipamento(cbxStatus.Text, edtDescricao.Text, Int32.Parse(edtQuantidade.Text));
                    this.Tag = equip;
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Equipamento cadastrado ! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    equip.status = cbxStatus.Text;
                    equip.descricao = edtDescricao.Text;
                    equip.quantidade = Int32.Parse(edtQuantidade.Text);
                    MessageBox.Show("Equipamento atualizado ! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar equipamento : " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmCadastroEquipamento_Load(object sender, EventArgs e)
        {
            if (status != 0)
            {
                cbxStatus.Text = equip.status;
                edtDescricao.Text = equip.descricao;
                edtQuantidade.Text = equip.quantidade.ToString();
            }
        }
    }
}
