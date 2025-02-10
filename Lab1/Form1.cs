using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        TransportCompany firm = new TransportCompany();
        public Form1()
        {
            InitializeComponent();
            label8.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firm.price = (int)numericUpDown1.Value;
            if(float.TryParse(textBox4.Text, out float transportedMass))
            {
                firm.transportedMass = transportedMass;
            }
            firm.name = textBox1.Text;
            if (float.TryParse(textBox5.Text, out float firmRating))
            {
                firm.rating = firmRating;
            }
            firm.completedOrders = (int)numericUpDown4.Value;
            firm.phoneNumber = textBox2.Text;
            firm.email = textBox3.Text;
            label8.Text = firm.ToString();
            label8.Show();
        }
    }
}
