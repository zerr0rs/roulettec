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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}
		string connString = @"Data Source=DESKTOP-FS4I3IA;Initial Catalog=zerrrors;Integrated Security=True";
		private void authorization()
		{
			string USERNAME;
			string SqlText = "SELECT * FROM [Users] WHERE [Users].[login]=" + textBox1.Text + " AND [Users].[password]=" + textBox2.Text + "";

			try
			{
				SqlDataAdapter da = new SqlDataAdapter(SqlText, connString);
				DataSet ds = new DataSet();
				da.Fill(ds, "[Users]");
				dataGridView1.DataSource = ds.Tables["[Users]"].DefaultView;



				if (dataGridView1.Rows[0].Cells[0].Value != null)
				{
					if (dataGridView1.Rows[0].
						Cells[0].Value.ToString().Length != 0)
					{
						USERNAME = textBox1.Text;
						MessageBox.Show("добро пожаловать " + USERNAME);
						Rullete.USERNAME = USERNAME;
						Rullete.USERLOGIN = "Выход";
						Close();
					}
				}
				else
				{
					MessageBox.Show("неправильный логин или пароль");
				}
			}

			catch
			{
				MessageBox.Show("повторите попытку");
			}



		}


		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			authorization();
		}
		private void Form3_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			authorization();
		}
	}
}
