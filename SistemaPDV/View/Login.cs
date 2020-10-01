using System;
using System.Windows.Forms;
using Bussiness;

namespace SistemaPDV

{
    public partial class frmLogin : Form
    {
        int erro = 0;

        public frmLogin()
        {
            InitializeComponent();
            txtUser.Focus();
            MainControlClass.Transparencia(this, txtUser);
        }

        private void Login()
        {
            if (ViewModelLogon.Logar(txtUser.Text, txtPass.Text))
            {
                erro = 1;
                MenuPrincipal.logou = true;
                this.Close();
            }
            else
            {
                label3.Enabled = true;
                label3.Text = "Usuário ou senha inválido, por favor tente novamente.";
                erro++;
                if (erro == 3)
                {
                    MessageBox.Show("Usuário " + txtUser.Text + " bloqueado!\n Entre em contato com o administrador do sistema.",
                        "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}