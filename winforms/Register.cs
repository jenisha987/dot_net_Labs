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
            string province = comboBox1.Text;
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
            comboBox1.SelectedIndex = -1;
            txtContact.Clear();
            comboBox2.Items.Clear();
            comboBox2.SelectedIndex = -1;

        }

        Dictionary<string, List<string>> provinceDistrictMap = new Dictionary<string, List<string>>()
        {
            { "Gandaki", new List<string> { "Pokhara", "Lamjung", "Gorkha", "Baglung", "Tanahun" } },
            { "Bagmati", new List<string> { "Kathmandu", "Lalitpur", "Bhaktapur", "Chitwan", "Makwanpur" } },
            { "Lumbini", new List<string> { "Rupandehi", "Kapilvastu", "Dang", "Palpa", "Gulmi" } },
            { "Karnali", new List<string> { "Jumla", "Mugu", "Humla", "Surkhet", "Dolpa" } }
        };

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProvince = comboBox1.SelectedItem?.ToString();

            comboBox2.Items.Clear();

            if (!string.IsNullOrEmpty(selectedProvince) && provinceDistrictMap.ContainsKey(selectedProvince))
            {
                comboBox2.Items.AddRange(provinceDistrictMap[selectedProvince].ToArray());
                comboBox2.SelectedIndex = -1;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Gandaki");
            comboBox1.Items.Add("Bagmati");
            comboBox1.Items.Add("Lumbini");
            comboBox1.Items.Add("Karnali");
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

       
    }
}
