using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3___Chapter_Problem
{
    public partial class BasicInput : Form
    {
        string name;
        int age;
        string height;
        public BasicInput()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = txtName.Text;
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            height = txtHeight.Text;
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            double dblHeight;
            double.TryParse(height, out dblHeight);
            dblHeight = Math.Round(dblHeight, 2);
            lblMessage.Text = ($"Hello {name}, you are {82 - age} years below life expectancy");
            lblMessage2.Text = ($"and you're {2.72 - dblHeight} m shorter than the tallest person in the world ");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            nudAge.Minimum = 0;
            nudAge.Maximum = 82;
            age = Convert.ToInt32(nudAge.Value);
        }
    }
}
