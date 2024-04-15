/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 15/04/2024
 * Time: 7:06 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace windowsform
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			string login; 
			string user = "boset";
			string pass; 
			string password = "dino";
			
			
				login = Convert.ToString(textBox1.Text);
				pass = Convert.ToString(textBox2.Text);
				
				if(login==user&&pass==password)
				{
					MessageBox.Show("Login Successfully");
				}
				else
				{
					MessageBox.Show("Login Failed"); 
				}
				//if(login!=user||pass!=password)
				//{
				//	MessageBox.Show("Invalid Username");
				//}
				//else
				//{
				//	MessageBox.Show("Login Failed");
				//}
				//if(login==user&&pass==password)
				//{
				//	MessageBox.Show("Invalid Password");
				//}
				//else
				//{
				//	MessageBox.Show("Login Failed");
				//}
				//if(login==user&&pass==password)
				//MessageBox.Show("Invalid Account");
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
