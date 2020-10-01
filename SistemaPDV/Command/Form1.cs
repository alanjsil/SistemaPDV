using System;
using System.Windows.Forms;

namespace SistemaPDV
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void OnClick(object sender, EventArgs e)
		{
			if (sender is Button)
			{
				Button btn = sender as Button;
				if (btn.Parent == this)
					MessageBox.Show(string.Format("I am {0} from the main form.", btn.Name));
				else if (btn.Parent == userControl11)
					MessageBox.Show(string.Format("I am {0} from the user control.", btn.Name));
			}
		}
	}
}
