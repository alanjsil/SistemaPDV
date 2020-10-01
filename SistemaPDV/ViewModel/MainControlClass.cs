using System.Drawing;
using System.Windows.Forms;

namespace SistemaPDV
{
    class MainControlClass
    {        
        public static void Transparencia(Control c, TextBox t)
        {
            //Deixa o fundo transparente
            foreach (Control i in c.Controls)
            {
                if (i is Label)
                {
                    i.BackColor = Color.Transparent;
                }
            }
            t.Focus();
        }
    }
}