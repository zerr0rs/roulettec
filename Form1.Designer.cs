namespace ruletka_home_edition
{
	partial class Rullete
	{

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		public void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.button10 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button6 = new System.Windows.Forms.Button();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(169, 204);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Играть";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(94, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F);
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(135, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 26);
			this.label4.TabIndex = 4;
			this.label4.Text = "label4";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(347, 207);
			this.textBox1.MaxLength = 10;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(702, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "БАЛАНС";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(702, 87);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "label6";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(296, 275);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(45, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "+25";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(347, 275);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(45, 23);
			this.button3.TabIndex = 9;
			this.button3.Text = "+100";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(402, 275);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(45, 23);
			this.button4.TabIndex = 10;
			this.button4.Text = "+500";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(453, 275);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(45, 23);
			this.button5.TabIndex = 11;
			this.button5.Text = "+5000";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(484, 200);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(62, 17);
			this.radioButton1.TabIndex = 12;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Чётное";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(484, 223);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(76, 17);
			this.radioButton2.TabIndex = 13;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Не чётное";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(347, 233);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(100, 23);
			this.button10.TabIndex = 18;
			this.button10.Text = "Сбросить";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(641, 301);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(132, 61);
			this.button6.TabIndex = 19;
			this.button6.Text = "Авто игра (метод мартенгейла)";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// timer2
			// 
			this.timer2.Interval = 1;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.1F);
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(185, 132);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(0, 51);
			this.label8.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(753, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 13);
			this.label7.TabIndex = 22;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(753, 34);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(31, 13);
			this.label9.TabIndex = 23;
			this.label9.Text = "Вход";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// Rullete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "Rullete";
			this.Text = "Rullete";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.Button button2;
		public System.Windows.Forms.Button button3;
		public System.Windows.Forms.Button button4;
		public System.Windows.Forms.Button button5;
		public System.Windows.Forms.RadioButton radioButton1;
		public System.Windows.Forms.RadioButton radioButton2;
		public System.Windows.Forms.Button button10;
		public System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
	}
}

