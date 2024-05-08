using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressbar p = new progressbar();
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
                {
                    p.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
            }
            else {
                    MessageBox.Show("Fill all the values","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "Show")
            {
                linkLabel1.Text = "Hide";
                textBox2.PasswordChar = '\0';
            }
            else
            {
                linkLabel1.Text = "Hide";
                textBox2.PasswordChar = '*';
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetpassword fp = new forgetpassword();
            fp.Show();
            this.Hide();
        }
    }
}
