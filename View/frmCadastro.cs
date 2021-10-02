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
    public partial class frmCadastro : Form
    {
        private int status =0;
        private Usuario user = new Usuario();
        public frmCadastro()
        {
            InitializeComponent();
        }

        public frmCadastro(int status,Usuario user)
        {
            this.status = status;
            this.user = user;
            InitializeComponent();
        }

        private void edtNumero_KeyPress(object sender, KeyPressEventArgs e)
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
                    btnCadastrar_Click(null, null);
                    break;

                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if ( edtNome.Text == "" || edtCPF.Text == "" || edtRua.Text == "" || edtBairro.Text == "" || 
                edtNumero.Text == ""|| edtCidade.Text == "" || cbxEstado.Text == "")
            {
                MessageBox.Show("Existem dados nos campos faltando ! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (status == 0) {
                    Endereco adress = new Endereco();
                    adress.Estado = cbxEstado.Text;
                    adress.Rua = edtRua.Text;
                    adress.Numero = Int32.Parse(edtNumero.Text);
                    adress.Bairro = edtBairro.Text;
                    adress.Bairro = edtCidade.Text;

                    user.User = edtNome.Text;
                    user.CPF = Int64.Parse(edtCPF.Text.Replace("-",""));
                    user.Senha = edtSenha.Text;
                    user.adress = adress;

                    this.DialogResult = DialogResult.OK;
                    this.Tag = user;
                    MessageBox.Show("Usuário cadastrado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    user.adress.Estado = cbxEstado.Text;
                    user.adress.Rua = edtRua.Text;
                    user.adress.Numero = Int32.Parse(edtNumero.Text);
                    user.adress.Bairro = edtBairro.Text;
                    user.adress.Bairro = edtCidade.Text;

                    user.User = edtNome.Text;
                    user.CPF = Int64.Parse(edtCPF.Text.Replace("-", ""));
                    user.Senha = edtSenha.Text;
                    user.Senha = edtConfirmeSenha.Text;
                    MessageBox.Show("Usuário atualizado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no login : " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edtConfirmeSenha_Leave(object sender, EventArgs e)
        {
            if ((edtSenha.Text != "") && (edtSenha.Text != edtConfirmeSenha.Text))
            {
                MessageBox.Show("Senha errada !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                edtConfirmeSenha.Text = "";
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if(status != 0)
            {
                cbxEstado.Text = user.adress.Estado;
                edtRua.Text = user.adress.Rua;
                edtNumero.Text = user.adress.Numero.ToString();
                edtBairro.Text = user.adress.Bairro;
                edtCidade.Text = user.adress.Bairro;
                edtNome.Text = user.User;
                edtCPF.Text = user.CPF.ToString();
                edtSenha.Text = user.Senha;
            }
        }

      
    }
}
