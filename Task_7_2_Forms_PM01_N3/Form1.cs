using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7_2_Forms_PM01_N3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				String s = textBox1.Text;
				string[] str = s.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
				String max = "";
				int index = 0;
				for (int i = 0; i < str.Length; i++)
				{
					if (str[i].Length > max.Length)
					{
						max = str[i];
						index = i;
					}
				}
				textBox2.Text = string.Format(max);
			}
			catch
			{
				textBox2.Text = string.Format("Неизвестная ошибка");
			}

		}
	}
}
