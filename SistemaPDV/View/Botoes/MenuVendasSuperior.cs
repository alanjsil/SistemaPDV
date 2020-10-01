using System;
using System.Windows.Forms;

namespace SistemaPDV.View.Botoes
{
    public partial class MenuVendasSuperior : UserControl
    {
        ViewModelBase ViewModel = new ViewModelBase();
        Vendas janela;
        Control control;

        public MenuVendasSuperior()
        {
            InitializeComponent();
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            janela = new Vendas();
            janela.ShowDialog();
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            control = new UserControl1();
            control.Dock = DockStyle.Fill;
            MenuPrincipal.content.Controls.Add(control);
        }
    }
}
