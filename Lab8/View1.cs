using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Collections;

namespace Lab2
{
    public partial class View1 : Form, IView
    {
        public event Add AddClicked;
        public event Remove RemoveClicked;
        public event Generate_100000_Oblects Generate_100000_objs_clicked;
        public event ShowAll ShowAllClicked;
        public event SaveChanges SaveChangesClicked;

        public string NameCompany => name.Text;
        public int Price => (int)price.Value;
        public float TransportedMass => (float)transportedMass.Value;
        public int CompletedOrders => (int)completedOrders.Value;
        public string PhoneNumber => phoneNumber.Text;
        public string Email => email.Text;



        public View1()
        {
            InitializeComponent();
            var presenter = new Presenter(dataGridView1, objCount, this);
        }

        private void create_Click(object sender, EventArgs e)
        {
            AddClicked.Invoke(Price, TransportedMass, NameCompany,  CompletedOrders, PhoneNumber, Email);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            RemoveClicked.Invoke();
            TransportCompany.countObj--;
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            ShowAllClicked.Invoke(dataGridView1);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveChangesClicked.Invoke(dataGridView1);
        }

        private void generate_100000_objects_Click(object sender, EventArgs e)
        {
            Generate_100000_objs_clicked.Invoke(dataGridView1, objCount);
        }
    }
}
