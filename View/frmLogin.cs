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
    public partial class frmLogin : Form
    {
        private List<Usuario> Pessoa = new List<Usuario>();
        private Boolean cadastro = false;
        private Usuario logado = new Usuario();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!(VerificaCadastro(edtUser.Text, edtSenha.Text))) { MessageBox.Show("Usuário / Senha Inválidos !","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error); return; }
            frmPrincipal FormPrincipal = new frmPrincipal();
            Pessoa.Add(logado);
            FormPrincipal.Tag = Pessoa;
            FormPrincipal.ShowDialog();
        }

        private Boolean VerificaCadastro(String usuario , string senha)
        {
            try
            {
                foreach (Usuario user in Pessoa)
                {
                    if (usuario == user.User && senha == user.Senha)
                    {
                        logado.User = user.User;
                        logado.Senha = user.Senha;
                        logado.CPF = user.CPF;
                        logado.adress = user.adress;
                        return true; 
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro no login : " + e, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro Form = new frmCadastro();
            if(Form.ShowDialog() == DialogResult.OK)
            {
                Pessoa.Add((Usuario)Form.Tag);
                cadastro = true;
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnEntrar_Click(null, null);
                    break;
              
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
