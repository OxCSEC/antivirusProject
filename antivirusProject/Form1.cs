namespace antivirusProject
{
	public partial class Form1 : Form
	{
		public Point mouseLocation2;
		public Form1()
		{
			
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			UserNameInput.Text = "ozgur";
			PasswordInput.Text = "123456";
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if(UserNameInput.Text == "ozgur")
			{
				if(PasswordInput.Text == "123456")
				{
					// form2 object
					Form2 frm = new Form2();
					frm.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Wrong Password or Username");
				}
			}
			else
			{
				MessageBox.Show("Wrong Password or Username");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			mouseLocation2 = new Point(-e.X, -e.Y);
			
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if(e.Button== MouseButtons.Left)
			{
				Point mousePose = Control.MousePosition;
				mousePose.Offset(mouseLocation2.X, mouseLocation2.Y);
				Location = mousePose;
					
			}
		}
	}
}