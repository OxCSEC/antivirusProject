using antivirusProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace antivirusProject
{
	public partial class Form2 : Form
	{
		public Point mouseLocation;
		public Form2()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			mouseLocation = new Point(-e.X, -e.Y);
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Point mousePose = Control.MousePosition;
				mousePose.Offset(mouseLocation.X, mouseLocation.Y);
				Location = mousePose;

			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Class1 tarama = new Class1();
			tarama.Main();
			string textFromFile = File.ReadAllText("print.txt");

			// RichTextBox'a metni ekle
			richTextBox1.Text = textFromFile;
			
		}
	}
}
