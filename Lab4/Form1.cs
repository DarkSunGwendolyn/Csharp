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

namespace Lab2
{
    public partial class Form1 : Form
    {
        private TransportCompany prototype = null;
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
            listView1.Columns.Add("Способ перевозки");
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

                if (method.SelectedIndex == -1)
                    throw new MyException("Выберите способ перевозки");

                TransportCompany firm;
                ITransportMethod curMethod = null;
                switch (method.SelectedItem.ToString())
                {
                    case ("Кораблем"):
                        curMethod = new ShipTransport();
                        break;
                    case ("Грузовиком"):
                        curMethod = new TrackTransport();
                        break;
                    case ("Самолетом"):
                        curMethod = new AirTransport();
                        break;
                }

                if (prototype == null)
                {
                    prototype = new LogisticCompany(
                        (int)price.Value,
                        (float)transportedMass.Value,
                        name.Text,
                        (float)rating.Value,
                        (int)completedOrders.Value,
                        phoneNumber.Text,
                        email.Text,
                        curMethod
                    );
                }

                firm = (LogisticCompany)prototype.Clone();

                firm.price = (int)price.Value;
                firm.transportedMass = (float)transportedMass.Value;
                firm.name = name.Text;
                firm.rating = (float)rating.Value;
                firm.completedOrders = (int)completedOrders.Value;
                firm.phoneNumber = phoneNumber.Text;
                firm.email = email.Text;
                firm.deliverMethod = curMethod;

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
                listItem.SubItems.Add(company.DoWork());
                listView1.Items.Insert(0, listItem);
            }
        }

        private void generate_100000_objects_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int elementCount = 5000;

            TransportCompany baseCompany = new LogisticCompany(
                rand.Next(1000, 10000),
                (float)rand.NextDouble() * 100,
                "BaseCompany",
                (float)(rand.NextDouble() * 5),
                rand.Next(0, 1000),
                "89990000000",
                "basecompany@mail.ru",
                new TrackTransport()
            );

            // Для StackTransportCompany
            int start = Environment.TickCount;
            for (int i = 0; i < elementCount; i++)
            {
                ITransportMethod curMethod = null;
                switch (rand.Next(3))
                {
                    case 0:
                        curMethod = new ShipTransport();
                        break;
                    case 1:
                        curMethod = new TrackTransport();
                        break;
                    case 2:
                        curMethod = new AirTransport();
                        break;
                }
                TransportCompany clonedCompany = (TransportCompany)baseCompany.Clone();
                clonedCompany.transportedMass = (float)rand.NextDouble() * 100;
                clonedCompany.name = "Company" + i;
                clonedCompany.price = rand.Next(1000, 10000);
                clonedCompany.phoneNumber = "8999" + rand.Next(1000000, 9999999);
                clonedCompany.email = "company" + i + "@mail.ru";
                clonedCompany.deliverMethod = curMethod;

                companies.AddCompany(clonedCompany);
            }
            int insertionTimeCollection = Environment.TickCount - start;

            start = Environment.TickCount;
            foreach (var company in companies.GetTransportCompanies())
            {
                var temp = company.price;
            }
            int sequentialReadTimeCollection = Environment.TickCount - start;

            var allCompanies = companies.GetTransportCompanies().ToArray();
            start = Environment.TickCount;
            for (int i = 0; i < elementCount; i++)
            {
                var temp = allCompanies[rand.Next(0, elementCount)].price;
            }
            int randomReadTimeCollection = Environment.TickCount - start;


            // Для Array
            TransportCompany[] companyArray = new TransportCompany[elementCount];

            start = Environment.TickCount;
            for (int i = 0; i < elementCount; i++)
            {
                ITransportMethod curMethod = null;
                switch (rand.Next(3))
                {
                    case 0:
                        curMethod = new ShipTransport();
                        break;
                    case 1:
                        curMethod = new TrackTransport();
                        break;
                    case 2:
                        curMethod = new AirTransport();
                        break;
                }

                companyArray[i] = new LogisticCompany(
                    rand.Next(1000, 10000),
                    (float)rand.NextDouble() * 100,
                    "Company" + i,
                    (float)(rand.NextDouble() * 5),
                    rand.Next(0, 1000),
                    "8999" + rand.Next(1000000, 9999999),
                    "company" + i + "@mail.ru",
                    curMethod
                    );
            }
            int insertionTimeArray = Environment.TickCount - start;

            start = Environment.TickCount;
            for (int i = 0; i < elementCount; i++)
            {
                var temp = companyArray[i].price;
            }
            int sequentialReadTimeArray = Environment.TickCount - start;

            start = Environment.TickCount;
            for (int i = 0; i < elementCount; i++)
            {
                var temp = companyArray[rand.Next(0, elementCount)].price;
            }
            int randomReadTimeArray = Environment.TickCount - start;


            // Результаты для своей коллекции
            listView1.Items.Clear();

            var collectionResultItem = new ListViewItem("StackTransportCompany");
            collectionResultItem.SubItems.Add("Вставка: " + insertionTimeCollection + " мс");
            collectionResultItem.SubItems.Add("Последоват. выборка: " + sequentialReadTimeCollection + " мс");
            collectionResultItem.SubItems.Add("Случайная выборка: " + randomReadTimeCollection + " мс");
            listView1.Items.Add(collectionResultItem);

            // Результаты для Array
            var arrayResultItem = new ListViewItem("Array");
            arrayResultItem.SubItems.Add("Вставка: " + insertionTimeArray + " мс");
            arrayResultItem.SubItems.Add("Последоват. выборка: " + sequentialReadTimeArray + " мс");
            arrayResultItem.SubItems.Add("Случайная выборка: " + randomReadTimeArray + " мс");
            listView1.Items.Add(arrayResultItem);

            MessageBox.Show("Генерация и замеры завершены!");
        }
    }
}
