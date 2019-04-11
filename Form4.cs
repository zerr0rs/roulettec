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
using System.Configuration;

namespace ruletka_home_edition
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
		}
		string connString = @"Data Source=DESKTOP-FS4I3IA;Initial Catalog=zerrrors;Integrated Security=True";

		


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
        }

        protected async void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
				SqlConnection sqlConnection;
				sqlConnection = new SqlConnection(connString);
				await sqlConnection.OpenAsync();

				Dictionary<string, string> db = new Dictionary<string, string>();

				SqlCommand getUsers = new SqlCommand("SELECT [login], [password] FROM [Users]", sqlConnection);
				SqlDataReader sqlReader = null;
				try
				{
					sqlReader = await getUsers.ExecuteReaderAsync();
					while (await sqlReader.ReadAsync())
					{
						db.Add(Convert.ToString(sqlReader["login"]), Convert.ToString(sqlReader["password"]));

					}

				}
				catch{	}
				finally
				{
					if (sqlReader != null)
						sqlReader.Close();
				}
				
				if (!db.Keys.Contains(textBox1.Text))
				{
					string SqlText;
					SqlText = "INSERT INTO [Users] ([login], [password]) VALUES ("; // INSERT - добавление
					SqlText = SqlText + "\'" + textBox1.Text + "\', ";
					SqlText = SqlText + "\'" + textBox2.Text + "\')";

					// выполнить SQL-команду
					MyExecuteNonQuery(SqlText);
					MessageBox.Show("Вы успешно зарегестрировались");
					Form3 f3 = new Form3();
					f3.Show();
					f3.textBox1.Text = textBox1.Text.ToString();
					f3.textBox2.Text = textBox2.Text.ToString();
					Close();

				}
				else
				{
					MessageBox.Show("Такой логин уже есть!");
				}

            }
            else
            {
                MessageBox.Show("Введите логин и пароль");
            }
        }

	}
}
