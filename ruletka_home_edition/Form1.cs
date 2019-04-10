using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ruletka_home_edition
{
	public partial class Rullete : Form
	{
		public Rullete()
		{
			InitializeComponent();
			label1.Text = "-";
			label2.Text = "-";
			label3.Text = "-";
			label4.Text = "-";
			textBox1.Text = stavka.ToString();
			label6.Text = balans.ToString();

		}
		public static string connString = @"Data Source=DESKTOP-FS4I3IA;Initial Catalog=zerrrors;Integrated Security=True";
		//Присваивание переменных
		public static int balans = 1000, stavka = 25;
		int USLOVIE1;
		public static int fixtimer1 = 0;
		public static string USERNAME, USERLOGIN = "Вход";   // f3 рофлы

		public void UpdateTable()
		{
			string	SqlText = "UPDATE [Users] SET [balans]=" + "\'" + balans.ToString() + "\'" + " WHERE [Users].[login]=" + "\'" + USERNAME + "\'";
			MyExecuteNonQuery(SqlText);
		}

		public void MyExecuteNonQuery(string SqlText) //возвращает кол-во обработанных данных
		{
			SqlConnection cn; // экземпляр класса типа SqlConnection
			SqlCommand cmd;

			// выделение памяти с инициализацией строки соединения с базой данных
			cn = new SqlConnection(connString);
			cn.Open(); // открыть подключение
			cmd = cn.CreateCommand(); // задать SQL-команду
			cmd.CommandText = SqlText; // задать командную строку
			cmd.ExecuteNonQuery(); // выполнить SQL-команду
			cn.Close(); // закрыть подключение
						//Запуск игры
		}
			public void button1_Click(object sender, EventArgs e)
		{
			if (balans != 0)
			{
				int q;
				Random rand1 = new Random((int)DateTime.Now.Ticks & 0x0000126);
				q = rand1.Next(1, 36);
				metod(null, null, null, q, stavka);
				timer1.Enabled = true;
			}
			else
			{
				MessageBox.Show("Недостаточно средств");
				textBox1.Text = null;
				Form2 f2 = new Form2();
				f2.Show();
			}
		}


		//загрузка формы
		private void Form1_Load(object sender, EventArgs e)
		{
			Form3 f3 = new Form3();
			f3.Show();
			f3.Focus();
		}
		//Назаначение ставки
		private void button3_Click(object sender, EventArgs e)
		{
			stavka = stavka + 100;
			textBox1.Text = stavka.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			stavka = stavka + 500;
			textBox1.Text = stavka.ToString();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			stavka = stavka + 5000;
			textBox1.Text = stavka.ToString();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			stavka = 0;
			textBox1.Text = stavka.ToString();
		}


		private void button6_Click(object sender, EventArgs e)
		{
			if (balans == 0)
			{
                timer2.Enabled = false;
                MessageBox.Show("Недостаточно средств");
				Form2 f2 = new Form2();
				f2.Show();
              

            }
			else
			{
				if (timer2.Enabled == false)
				{
					timer2.Enabled = true;
				}
				else
				{
					timer2.Enabled = false;
				}
			}
		}

		//timer2
		public void timer2_Tick(object sender, EventArgs e)
		{

			label6.Text = balans.ToString();
			textBox1.Text = stavka.ToString();
			int q,q1,q2,q3,q4,q5;
	

			//рандом из рандомов
			Random rand1 = new Random((int)DateTime.Now.Ticks & 0x0000126);
			q1 = rand1.Next(1, 36);

			Random rand2 = new Random((int)DateTime.Now.Ticks & 0x1042000);
			q2 = rand2.Next(1, 36);

			Random rand3 = new Random((int)DateTime.Now.Ticks & 0x00600011);
			q3 = rand3.Next(1, 36);

			Random rand4 = new Random((int)DateTime.Now.Ticks & 0x0940050);
			q4 = rand4.Next(1, 36);

			Random rand5 = new Random();
			q5 = rand5.Next(1, 36);


			Random rand6 = new Random();
			var arr1 = new[] {q1,q2,q3,q4,q5};
			q = arr1[rand6.Next(arr1.Length)];

		


			if (radioButton1.Checked)
			{
				if (USLOVIE1 == 1)
				{
					stavka = 25;
					radioButton2.Checked = true;
				}
				if (USLOVIE1 == 2)
				{
					stavka = stavka * 2;
				}

			}

			if (radioButton2.Checked)
			{
				if (USLOVIE1==3)
				{
					stavka = 25;
					radioButton1.Checked = true;
				}
				if (USLOVIE1==4)
				{
					stavka = stavka * 2;
				}
			}
			textBox1.Text = stavka.ToString();

			metod(null, null, null, q, stavka);



		}

		private void button2_Click(object sender, EventArgs e)
		{
			stavka = stavka + 25;
			textBox1.Text = stavka.ToString();
		}
		//метод ввода в текстбокс только цифр 
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{

			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
			{
				e.Handled = true;
			}





		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				stavka = Convert.ToInt32(textBox1.Text);
				if (stavka > balans)
				{
					stavka = balans;
					textBox1.Text = null;
					textBox1.Text = stavka.ToString();
				}
			}
			catch
			{
				textBox1.Text = stavka.ToString();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{

			label7.Text = USERNAME;
			label9.Text = USERLOGIN;

			label6.Text = balans.ToString();
			if (balans == 0 && fixtimer1 ==0)
			{
				timer2.Enabled = false;
				textBox1.Text = null;
				stavka = 0;
				fixtimer1 = 1;
				MessageBox.Show("Недостаточно средств");
				Form2 f2 = new Form2();
				f2.Show();

			}
			
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (timer2.Interval < 3000)
			{
				timer2.Interval = timer2.Interval + 50;
			}
			else
			{
				timer2.Interval = 3000;
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (timer2.Interval >= 51)
			{
				timer2.Interval = timer2.Interval - 50;
			}
			else
			{
				timer2.Interval = 1;
			}
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			try
			{
				string SqlText = "SELECT [Users].[login], [Users].[balans] FROM [Users] ORDER BY [Users].[balans] DESC";
				SqlDataAdapter da = new SqlDataAdapter(SqlText, connString);
				DataSet ds = new DataSet();
				da.Fill(ds, "[newtable]".ToString());
				dataGridView1.DataSource = ds.Tables["[newtable]"].DefaultView;
				label10.Visible = false;
			}
			catch
			{
				label10.Visible = true;
			}
		}

		private void label9_Click(object sender, EventArgs e)
		{

			if (USERLOGIN == "Вход" || USERLOGIN == "")
			{
				Form3 f3 = new Form3();
				f3.Show();
			}
			if (USERLOGIN == "Выход")
			{
				balans = 1000;
				USERLOGIN = "Вход";
				USERNAME = "";
			}
		}


		//metod
		public int metod(string a, string b, string c,int q, int stavka)
		{

			
			//Рандомизирование
			//string a = null, b = null, c = null;

			//Последовательное заполнение label-ov
			//перенос чисел в промежуточные переменные
			a = label4.Text;
			label4.Text = q.ToString();

			b = label3.Text;
			label3.Text = a;

			c = label2.Text;
			label2.Text = b;

			label1.Text = c;



			if (balans == 0)
			{
				timer2.Enabled = false;
				textBox1.Text = null;
			}
			//проверка баланса и условия победы, поражения
			if (balans >= stavka)
			{

				if (radioButton1.Checked)
				{
					if (q % 2 == 0)
					{
						balans = balans + stavka;
						label8.Text = "Вы выиграли "+stavka+" руб";
						label8.ForeColor = Color.Green;
						USLOVIE1 = 1;
						try
						{
							UpdateTable();
						}
						catch
						{
							MessageBox.Show("Не удалось установить соединение с сервером");
						}

					}
					if (q % 2 !=0)
					{
						balans = balans - stavka;
						label8.Text = "Вы проиграли " + stavka + " руб";
						label8.ForeColor = Color.Red;
						USLOVIE1 = 2;
						try
						{
							UpdateTable();
						}
						catch
						{
							MessageBox.Show("Не удалось установить соединение с сервером");
						}

					}

				}
				if (radioButton2.Checked)
				{
					if (q % 2 != 0)
					{
						balans = balans + stavka;
						label8.Text = "Вы выиграли " + stavka + " руб";
						label8.ForeColor = Color.Green;
						USLOVIE1 = 3;
						try
						{
							UpdateTable();
						}
						catch
						{
							MessageBox.Show("Не удалось установить соединение с сервером");
						}

					}
					if (q%2==0)
					{
						balans = balans - stavka;
						label8.Text = "Вы проиграли " + stavka + " руб";
						label8.ForeColor = Color.Red;
						USLOVIE1 = 4;
						try
						{
							UpdateTable();
						}
						catch
						{
							MessageBox.Show("Не удалось установить соединение с сервером");
						}

					}
				}
				else
				{
					textBox1.Text = null;
				}
				return USLOVIE1;
			}
			return q;
			
		}
		

	}
}
