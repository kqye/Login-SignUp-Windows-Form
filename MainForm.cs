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
//FORM 2 CODE
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LoginSignUp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Form1().Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbUser.Text == "" || txtbLast.Text == "" || txtbUserIdw.Text == "")
            {
                MessageBox.Show("Incomplete Sign Up");
            }
            else if (txtbPass.Text == txtbConfirm.Text)
            {
                MessageBox.Show("Welcome " + txtbUserIdw.Text);
                this.Hide();
                //new Form3().Show();
            }
            else if (txtbPass.Text != txtbConfirm.Text)
            {
                MessageBox.Show("Passwords do not match");
                txtbPass.Text = "";
                txtbConfirm.Text = "";
            }

        }
    }
}

