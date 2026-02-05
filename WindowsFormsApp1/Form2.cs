using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       private void  numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string proizvod = txtNaziv.Text + "," + comboBox1.Text + ", " + numericUpDown1.Value + ", " + textBox1.Text + ", " + checkBox1.Text;
            Admin.SaveProizvod(proizvod);
            MessageBox.Show("Proizvod je uspješno spremljen!");
            txtNaziv.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
            numericUpDown1.Text = "";
            checkBox1.Checked = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Hrana");
            comboBox1.Items.Add("Piće");
            comboBox1.Items.Add("potrepstine");
            comboBox1.Items.Add("Ostalo");


        }

       
    }
}
