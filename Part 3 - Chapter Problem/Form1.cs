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
        string age;
        string height;
        public BasicInput()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = txtName.Text;
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            age = txtAge.Text;
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            height = txtHeight.Text;
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            int lifeExp = System.Convert.ToInt32(age);
            double dblHeight = System.Convert.ToDouble(height);
            lblMessage.Text = ($"Hello {name}, you have {82 - lifeExp} years left until you die. You are {2.72 - dblHeight} m shorter than the tallest person in the world ");
        }
    }
}
