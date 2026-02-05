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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
          string kriterij = txtUpit.Text;
            List<string> rezultati = Admin.SearchByNameOrCategory(kriterij);
            List<string> filtriraniProizvodi = new List<string>();
            foreach (string proizvod in rezultati)
            {
                lstStavke.Items.Add(proizvod);
            }
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> SviProizvodi = Admin.GetAllAsStrings();
            lstStavke.Items.Clear();
            foreach (string proizvod in SviProizvodi)
            {
                lstStavke.Items.Add(proizvod);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
