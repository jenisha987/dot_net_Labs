using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string operation = "";
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            operation = "add";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            operation = "subtract";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation = "multiply";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation = "divide";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1, num2, result = 0;

            try
            {
                num1 = Convert.ToInt32(txtNum1.Text);
                num2 = Convert.ToInt32(txtNum2.Text);
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (operation == "add")
            {
                result = num1 + num2;
            }
            else if (operation == "subtract")
            {
                result = num1 - num2;
            }
            else if (operation == "multiply")
            {
                result = num1 * num2;
            }
            else if (operation == "divide")
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero.", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                result = num1 / num2;
            }
            else
            {
                MessageBox.Show("Please select an operation.", "No Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtResult.Text = result.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResult.Clear();
            operation = "";
        }

        
    }
}
