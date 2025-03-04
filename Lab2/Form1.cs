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

namespace Lab2
{
    public partial class Form1 : Form
    {
        private StackTransportCompany companies;
        private StackListener stackListener;

        public Form1()
        {
            InitializeComponent();
            companies = new StackTransportCompany();
            InitializeListView();

            stackListener = new StackListener(companies, listView1, objCount);
        }

        private void InitializeListView()
        {
            listView1.Columns.Add("Название компании");
            listView1.Columns.Add("Цена");
            listView1.Columns.Add("Масса");
            listView1.Columns.Add("Рейтинг");
            listView1.Columns.Add("Количество заказов");
            listView1.Columns.Add("Номер телефона");
            listView1.Columns.Add("Почта");
            listView1.View = View.Details;
        }
            
        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name.Text))
                    throw new MyException("Фирма должна иметь название");

                if (string.IsNullOrWhiteSpace(phoneNumber.Text))
                    throw new MyException("Фирма должна иметь номер");
                if (!Regex.IsMatch(phoneNumber.Text.Trim(), @"^\d{11}$"))
                    throw new MyException("Номер должен состоять из 11 цифр и не содержать буквы или символы");

                if (!Regex.IsMatch(email.Text.Trim(), @"^[a-zA-Z0-9_]+@mail\.ru$"))
                    throw new MyException("Неверный формат почты");

                TransportCompany firm = new TransportCompany((int)price.Value,
                    (float)transportedMass.Value,
                    name.Text,
                    (float)rating.Value,
                    (int)completedOrders.Value,
                    phoneNumber.Text,
                    email.Text);
                objCount.Text = TransportCompany.countObj.ToString();
                
                companies.AddCompany(firm);
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                TransportCompany.countObj--;
                companies.DeleteCompany();
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach(var company in companies.GetTransportCompanies())
            {
                var listItem = new ListViewItem(company.name);
                listItem.SubItems.Add(company.price.ToString());
                listItem.SubItems.Add(company.transportedMass.ToString());
                listItem.SubItems.Add(company.rating.ToString());
                listItem.SubItems.Add(company.completedOrders.ToString());
                listItem.SubItems.Add(company.phoneNumber);
                listItem.SubItems.Add(company.email);
                listView1.Items.Insert(0, listItem);
            }
        }
    }
}
