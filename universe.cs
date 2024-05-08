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
    public partial class universe : Form
    {
        public universe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Likhith" && textBox2.Text == "1234")
            {
                MessageBox.Show("Login Successfully");
            }
            else
            {
                MessageBox.Show("Password marthoda shade");
            }
        }
    }
}
