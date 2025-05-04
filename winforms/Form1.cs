using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Register register = new Register();
            register.TopLevel = false;
            register.FormBorderStyle = FormBorderStyle.None;   
            register.Dock = DockStyle.Fill;

            panel3.Controls.Add(register);
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Login login = new Login();
            login.TopLevel = false;
            login.FormBorderStyle = FormBorderStyle.None;
            login.Dock = DockStyle.Fill;

            panel3.Controls.Add(login);
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Calculator calculator = new Calculator();
            calculator.TopLevel = false;
            calculator.FormBorderStyle = FormBorderStyle.None;
            calculator.Dock = DockStyle.Fill;

            panel3.Controls.Add(calculator);
            calculator.Show();
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label1.Visible = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH : mm : ss");
        }
        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString("HH : mm : ss");
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString("HH : mm : ss");
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
