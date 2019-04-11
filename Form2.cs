using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ruletka_home_edition
{
    public partial class Form2 : Form
    {
		//delegate
		public Form2()
        {
            InitializeComponent();
		}
		//присваивание переменной
		public static int a1;

		private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            trackBar1.Visible = true;
            button3.Visible = true;
        }

		//закрытие формы при отказе займа
		public void button2_Click(object sender, EventArgs e)
		{
			Close();

		}
		//изначальное присвоение переменной для корректного отображения
		private void Form2_Load(object sender, EventArgs e)
		{
		
			a1 = 1500;
			label3.Text = a1.ToString();
		}
		//рофланусловие(рофланпомойка)
		public void trackBar1_Scroll(object sender, EventArgs e)
		{
			 a1=1500;
			if (trackBar1.Value==0 && trackBar1.Value != 2)
			{
				a1 = 1500;
			}
			
			else
			{
				a1 = 5000;
			}
			if (trackBar1.Value==1)
			{
				a1 = 3000;
			}
			label3.Text = a1.ToString();
		}
		//долг у мафии
		public void button3_Click(object sender, EventArgs e)
		{
			Rullete f1 = new Rullete();
			Rullete.fixtimer1 = 0;
			Rullete.balans = a1;
			Rullete.stavka = 0;
			f1.UpdateTable();
			
			Close();

		}
	}
}
