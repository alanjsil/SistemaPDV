using System;
using System.Windows.Forms;

namespace SistemaPDV
{
    public partial class UserControl1 : UserControl
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

        public UserControl1()
        {
            InitializeComponent();
            User01.Click += OnClick;
            button2.Click += OnClick;
        }

        private void User01_Click(object sender, EventArgs e)
        {
            string salt = Bussiness.HastToSenha.CriarSalt(4);
            string senhahash = Bussiness.HastToSenha.SenhaComSalt(TEXTO.Text, salt);
            txtSHA1.Text = Bussiness.HastToSenha.HashValueSHA1(TEXTO.Text);
            txtSHA256.Text = Bussiness.HastToSenha.HashValueSHA256(TEXTO.Text);
            txtSHA384.Text = Bussiness.HastToSenha.HashValueSHA384(TEXTO.Text);
            txtSalt.Text = Bussiness.HastToSenha.CriarSalt(4);
            textBox4.Text = senhahash;
        }

        private void btSHA1_Click(object sender, EventArgs e)
        {
            txtSHA1.Text = Bussiness.HastToSenha.HashValueSHA1(TEXTO.Text);
        }

        private void btSHA256_Click(object sender, EventArgs e)
        {
            txtSHA256.Text = Bussiness.HastToSenha.HashValueSHA256(TEXTO.Text);
        }             

        private void btSHA384_Click(object sender, EventArgs e)
        {
            txtSHA384.Text = Bussiness.HastToSenha.HashValueSHA384(TEXTO.Text);
        }
    }
}
