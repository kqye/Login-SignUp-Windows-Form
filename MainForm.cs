namespace LoginSignUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login;
            string user = "username";
            string pass;
            string password = "pass";


            login = Convert.ToString(textBox1.Text);
            pass = Convert.ToString(textBox2.Text);

            if (login == user && pass == password)
            {
                MessageBox.Show("Login Successfully");
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }
    }
}
