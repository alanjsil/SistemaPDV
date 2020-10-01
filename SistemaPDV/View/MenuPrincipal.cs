using SistemaPDV.View;
using SistemaPDV.View.Botoes;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace SistemaPDV
{
    public partial class MenuPrincipal : Form
    {
        ViewModelBase ViewModel = new ViewModelBase();
        public static bool logou;
        public static UserControl janela;
        public static Control content;

        public MenuPrincipal()
        {
            InitializeComponent();
            janela = new MenuVendasSuperior();
            ViewModel.NovaPagina(janela, PainelMenuSuperior);
            content = Conteudo;
            //doLogin();
        }

        #region Funções Criadas
        private void doLogin()
        {
            Form janela = new Form();
            janela = new frmLogin();
            janela.ShowDialog();
            if (logou == false)
            {
                MessageBox.Show("Aplicação será Encerrada.", "Informação do Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }

        private void MenuPrincipal_Activated(object sender, EventArgs e)
        {
            Verifica();
        }

        internal void Verifica()
        {

        }

        private void Fechar(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Sair do Sistema?", "Sair do Sistema", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                System.Windows.Application.Current.Shutdown();
            else
            {
                e.Cancel = true;
            }
        }
        #endregion

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            janela = new MenuVendasSuperior();
            ViewModel.NovaPagina(janela, PainelMenuSuperior);
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            janela = new Produtos();
            ViewModel.NovaPagina(janela, PainelMestre);
        }

        private void BtnOrcamento_Click(object sender, EventArgs e)
        {
            string a, s, d, f;
            a = Bussiness.HastToSenha.HashValueSHA1("alan");
            s = Bussiness.HastToSenha.HashValueSHA1("Alan");
            d = Bussiness.HastToSenha.GenerateSaltedSHA1("Alan");
            f = Bussiness.HastToSenha.GenerateSaltedSHA1("Alan");
            
            Debug.Print(a);
            Debug.Print(s);
            Debug.Print(d);
            Debug.Print(f);
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            janela = new UserControl1();
            ViewModel.NovaPagina(janela, PainelMestre);
        }
    }
}
