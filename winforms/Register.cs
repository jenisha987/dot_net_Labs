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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = radioMale.Checked ? "Male" : radioFemale.Checked ? "Female" : "";
            int age = (int)numericAge.Value;
            string province = txtProvince.Text;
            string contact = txtContact.Text.Trim();

            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(gender) ||
                age <= 0 ||
                string.IsNullOrEmpty(province) ||
                string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Success message
                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            radioMale.Checked = false;
            radioFemale.Checked = false;
            numericAge.Value = 0;
            txtProvince.Clear();
            txtContact.Clear();
        }
    }
}
