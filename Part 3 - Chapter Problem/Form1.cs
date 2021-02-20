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
            double dblHeight = System.Convert.ToDouble(height);
            lblMessage.Text = ($"Hello {name}, you have {82 - age} years left until you die. You are {2.72 - dblHeight} m shorter than the tallest person in the world ");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            nudAge.Minimum = 0;
            age = Convert.ToInt32(nudAge.Value);
        }
    }
}
