using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7_1_Forms_PM01_N3
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
				String substr1 = textBox2.Text;
				String substr2 = textBox3.Text;

				String news = s.Replace(substr1, substr2);
				if (s == news)
				{
					textBox4.Text = string.Format("Строка не была изменена");
					return;
				}
				textBox4.Text = string.Format(news);
			}
			catch
			{
				textBox4.Text = string.Format("Неизвестная ошибка");
			}
			
        }
    }
}
