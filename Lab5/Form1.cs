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
    public partial class Form1 : Form
    {
        private TransportCompany prototype = null;
        private StackTransportCompany companies;
        private StackListener stackListener;

        public Form1()
        {
            InitializeComponent();
            companies = new StackTransportCompany();

            transportMethodColumn.DataSource = new List<string>
            {
                new TrackTransport().Deliver(),
                new ShipTransport().Deliver(),
                new AirTransport().Deliver()
            };

            stackListener = new StackListener(companies, dataGridView1, objCount);
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

                TransportCompany firm;

                if (prototype == null)
                {
                    prototype = new LogisticCompany(
                        (int)price.Value,
                        (float)transportedMass.Value,
                        name.Text,
                        (int)completedOrders.Value,
                        phoneNumber.Text,
                        email.Text,
                        new TrackTransport()
                    );
                }

                firm = (LogisticCompany)prototype.Clone();

                firm.price = (int)price.Value;
                firm.transportedMass = (float)transportedMass.Value;
                firm.name = name.Text;
                firm.completedOrders = (int)completedOrders.Value;
                firm.phoneNumber = phoneNumber.Text;
                firm.email = email.Text;
                firm.RecalculateRating();

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
            ShowAll();
        }

        private void ShowAll()
        {
            dataGridView1.Rows.Clear();

            foreach (var company in companies.GetTransportCompanies().Reverse())
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

        private void save_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var transportCompanies = companies.GetTransportCompanies().Reverse().ToList();
                if (i >= transportCompanies.Count)
                    break;

                TransportCompany company = transportCompanies[i];

                string selectedStrategy = dataGridView1.Rows[i].Cells[3].Value.ToString();
                if (selectedStrategy == "По заказам")
                    company.ratingCalculationStrategy = new OrderBasedRating();
                else if (selectedStrategy == "По цене")
                    company.ratingCalculationStrategy = new PriceBasedRating();
                else if (selectedStrategy == "Комбин.")
                    company.ratingCalculationStrategy = new MixedRating();
                company.RecalculateRating();
                dataGridView1.Rows[i].Cells[4].Value = company.rating;

                string selectedMethod = dataGridView1.Rows[i].Cells[7].Value.ToString();
                if (selectedMethod == new TrackTransport().Deliver())
                    company.deliverMethod = new TrackTransport();
                else if (selectedMethod == new ShipTransport().Deliver())
                    company.deliverMethod = new ShipTransport();
                else if (selectedMethod == new AirTransport().Deliver())
                    company.deliverMethod = new AirTransport();
            }

            MessageBox.Show("Все изменения сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void generate_100000_objects_Click(object sender, EventArgs e)
        {
            int elementCount = 5000;

            Random rand = new Random();

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
            TransportCompany baseCompany = new LogisticCompany(
                rand.Next(100, 1000),
                (float)rand.NextDouble() * 100,
                "BaseCompany",
                rand.Next(0, 1000),
                "89990000000",
                "basecompany@mail.ru",
                curMethod
            );

            // Для StackTransportCompany
            int start = Environment.TickCount;
            for (int i = 0; i < elementCount; i++)
            {
                TransportCompany clonedCompany = (TransportCompany)baseCompany.Clone();
                clonedCompany.transportedMass = (float)rand.NextDouble() * 100;
                clonedCompany.name = "Company" + i;
                clonedCompany.price = rand.Next(1000, 10000);
                clonedCompany.phoneNumber = "8999" + rand.Next(1000000, 9999999);
                clonedCompany.email = "company" + i + "@mail.ru";

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
                companyArray[i] = new LogisticCompany(
                    rand.Next(100, 1000),
                    (float)rand.NextDouble() * 100,
                    "Company" + i,
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

            dataGridView1.Rows.Clear();

            string results = "Результаты для StackTransportCompany:\n" +
                 $"Вставка: {insertionTimeCollection} мс\n" +
                 $"Последоват. выборка: {sequentialReadTimeCollection} мс\n" +
                 $"Случайная выборка: {randomReadTimeCollection} мс\n\n" +

                 "Результаты для Array:\n" +
                 $"Вставка: {insertionTimeArray} мс\n" +
                 $"Последоват. выборка: {sequentialReadTimeArray} мс\n" +
                 $"Случайная выборка: {randomReadTimeArray} мс";

            objCount.Text = TransportCompany.countObj.ToString();

            MessageBox.Show(results, "Результаты тестирования", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
