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
	public static string connString = @"workstation id=123123123.mssql.somee.com;packet size=4096;user id=zimper983_SQLLogin_1;pwd=r95xrx3xf7;data source=123123123.mssql.somee.com;persist security info=False;initial catalog=123123123";



        private void authorization()
		{
			string a = textBox1.Text.ToString();
			string b = textBox2.Text.ToString();
			string USERNAME;
			string SqlText = "SELECT * FROM [Users] WHERE [Users].[login]=" + "\'" + a + "\'" + " AND [Users].[password]=" + "\'" + b + "\'";

				try
			{
			
				SqlDataAdapter da = new SqlDataAdapter(SqlText, connString);
				DataSet ds = new DataSet();
				da.Fill(ds, "[newtable]".ToString());
				dataGridView1.DataSource = ds.Tables["[newtable]"].DefaultView;



				if (dataGridView1.Rows[0].Cells[0].Value != null)
				{
					if (dataGridView1.Rows[0].
						Cells[0].Value.ToString().Length != 0)
					{
						if ((dataGridView1.Rows[0].Cells[2].Value).ToString() == "")
						{
							Rullete.balans = 1000;
						}
						else
						{
							Rullete.balans = Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value);
						}
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



        private void button2_Click(object sender, EventArgs e)
        {
			Close();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            authorization();

        }
    }
}
