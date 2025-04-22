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
        public event GetAll GetAllCalled;
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
            MessageBox.Show(RemoveClicked.Invoke());
            TransportCompany.countObj--;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                string selectedStrategy = dataGridView1.Rows[i].Cells[3].Value.ToString();
                string selectedMethod = dataGridView1.Rows[i].Cells[8].Value.ToString();
                SaveChangesClicked.Invoke(i, selectedStrategy, selectedMethod);
            }
            ShowAll();
            MessageBox.Show("Изменения успешно сохранены", "Сохранить");
        }

        private void ShowAll()
        {
            dataGridView1.Rows.Clear();

            foreach (var company in GetAllCalled.Invoke().Reverse())
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = company.name;
                dataGridView1.Rows[rowIndex].Cells[1].Value = company.price.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = company.transportedMass.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = company.ratingCalculationStrategy.TypeOfRating();
                dataGridView1.Rows[rowIndex].Cells[4].Value = company.rating.ToString();
                dataGridView1.Rows[rowIndex].Cells[5].Value = company.completedOrders.ToString();
                dataGridView1.Rows[rowIndex].Cells[6].Value = company.phoneNumber;
                dataGridView1.Rows[rowIndex].Cells[7].Value = company.email;
                dataGridView1.Rows[rowIndex].Cells[8].Value = company.DoWork();
            }
        }
    }
}
