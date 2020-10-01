using System;
using System.Windows.Forms;

namespace SistemaPDV.ViewControl.Botoes
{
    public partial class BarraSuperior : UserControl
    {
        [NonSerialized]
        private EventHandler fClick;
        public event EventHandler Click
        {
            add { fClick += value; }
            remove { fClick -= value; }
        }

        protected void OnClick(object sender, EventArgs e)
        {
            EventHandler handler = fClick;
            if (fClick != null)
                handler(sender, e);
        }

        public BarraSuperior()
        {
            InitializeComponent();
            PaginaAnteriorCommand.Click += OnClick;
            PaginaSeguinteCommand.Click += OnClick;
            AlterarCommand.Click += OnClick;
            ExcluirCommand.Click += OnClick;
            ImprimirCommand.Click += OnClick;
            Filtro.Click += OnClick;
            LocalizarCommand.Click += OnClick;
            Exportar.Click += OnClick;
            InserirCommand.Click += OnClick;
        }
        }
}