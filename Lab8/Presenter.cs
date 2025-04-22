using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public class Presenter
    {
        private IView view;
        private StackTransportCompany companies;
        private TransportCompany prototype;
        private StackListener listener;

        public Presenter(DataGridView dataGridView, TextBox objCount, IView view)
        {
            companies = new StackTransportCompany();
            listener = new StackListener(companies, dataGridView, objCount);
            this.view = view;
            this.view.AddClicked += CreateCompany;
            this.view.RemoveClicked += DeleteCompany;
            this.view.ShowAllClicked += ShowAll;
            this.view.SaveChangesClicked += SaveChanges;
            this.view.Generate_100000_objs_clicked += Generate10000Objects;

        }

        public void CreateCompany(int price, float transportedMass, string name, int completedOrders, string phoneNumber, string email)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new MyException("Фирма должна иметь название");

            if (!Regex.IsMatch(phoneNumber.Trim(), @"^\d{11}$"))
                throw new MyException("Номер должен состоять из 11 цифр");

            if (!Regex.IsMatch(email.Trim(), @"^[a-zA-Z0-9_]+@mail\.ru$"))
                throw new MyException("Неверный формат почты");

            if (prototype == null)
            {
                prototype = new LogisticCompany(
                        price,
                        transportedMass,
                        name,
                        completedOrders,
                        phoneNumber,
                        email,
                        new TrackTransport()
                    );
            }

            TransportCompany firm = (TransportCompany)prototype.Clone();
            firm.price = price;
            firm.transportedMass = transportedMass;
            firm.name = name;
            firm.completedOrders = completedOrders;
            firm.phoneNumber = phoneNumber;
            firm.email = email;
            firm.RecalculateRating();

            companies.AddCompany(firm);
        }

        public void DeleteCompany()
        {
            try
            {
                companies.DeleteCompany();
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        public void ShowAll(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            foreach (var company in companies.GetTransportCompanies().Reverse())
            {
                int rowIndex = dataGridView.Rows.Add();
                dataGridView.Rows[rowIndex].Cells[0].Value = company.name;
                dataGridView.Rows[rowIndex].Cells[1].Value = company.price.ToString();
                dataGridView.Rows[rowIndex].Cells[2].Value = company.transportedMass.ToString();
                dataGridView.Rows[rowIndex].Cells[3].Value = company.ratingCalculationStrategy.TypeOfRating();
                dataGridView.Rows[rowIndex].Cells[4].Value = company.rating.ToString();
                dataGridView.Rows[rowIndex].Cells[5].Value = company.completedOrders.ToString();
                dataGridView.Rows[rowIndex].Cells[6].Value = company.phoneNumber;
                dataGridView.Rows[rowIndex].Cells[7].Value = company.email;
                dataGridView.Rows[rowIndex].Cells[8].Value = company.DoWork();
            }
        }

        public void SaveChanges(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                var transportCompanies = companies.GetTransportCompanies().Reverse().ToList();
                if (i >= transportCompanies.Count)
                    break;

                TransportCompany company = transportCompanies[i];

                string selectedStrategy = dataGridView.Rows[i].Cells[3].Value.ToString();
                if (selectedStrategy == "По заказам")
                    company.ratingCalculationStrategy = new OrderBasedRating();
                else if (selectedStrategy == "По цене")
                    company.ratingCalculationStrategy = new PriceBasedRating();
                else if (selectedStrategy == "Комбин.")
                    company.ratingCalculationStrategy = new MixedRating();
                company.RecalculateRating();
                dataGridView.Rows[i].Cells[4].Value = company.rating;

                string selectedMethod = dataGridView.Rows[i].Cells[8].Value.ToString();
                if (selectedMethod == new TrackTransport().Deliver())
                    company.deliverMethod = new TrackTransport();
                else if (selectedMethod == new ShipTransport().Deliver())
                    company.deliverMethod = new ShipTransport();
                else if (selectedMethod == new AirTransport().Deliver())
                    company.deliverMethod = new AirTransport();
            }

            MessageBox.Show("Все изменения сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Generate10000Objects(DataGridView dataGridView, TextBox objCount)
        {
            int elementCount = 10000;

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
                rand.Next(0, 2000),
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
                clonedCompany.price = rand.Next(100, 1000);
                clonedCompany.phoneNumber = "8999" + rand.Next(1000000, 9999999);
                clonedCompany.email = "company" + i + "@mail.ru";
                clonedCompany.RecalculateRating();

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


            TransportCompany[] companyArray = new TransportCompany[elementCount];

            start = Environment.TickCount;
            for (int i = 0; i < elementCount; i++)
            {
                companyArray[i] = new LogisticCompany(
                    rand.Next(100, 1000),
                    (float)rand.NextDouble() * 100,
                    "Company" + i,
                    rand.Next(0, 2000),
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

            dataGridView.Rows.Clear();

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

    public class StackListener
    {
        private DataGridView dataGridView;
        private TextBox objCount;

        public StackListener(StackTransportCompany stack, DataGridView dataGridView, TextBox objCount)
        {
            this.dataGridView = dataGridView;
            this.objCount = objCount;

            stack.StackAdded += (TransportCompany company) =>
            {
                int rowIndex = dataGridView.Rows.Add();
                dataGridView.Rows[rowIndex].Cells[0].Value = company.name;
                dataGridView.Rows[rowIndex].Cells[1].Value = company.price.ToString();
                dataGridView.Rows[rowIndex].Cells[2].Value = company.transportedMass.ToString();
                dataGridView.Rows[rowIndex].Cells[3].Value = company.ratingCalculationStrategy.TypeOfRating();
                dataGridView.Rows[rowIndex].Cells[4].Value = company.rating.ToString();
                dataGridView.Rows[rowIndex].Cells[5].Value = company.completedOrders.ToString();
                dataGridView.Rows[rowIndex].Cells[6].Value = company.phoneNumber;
                dataGridView.Rows[rowIndex].Cells[7].Value = company.email;
                dataGridView.Rows[rowIndex].Cells[8].Value = company.DoWork();
                objCount.Text = TransportCompany.countObj.ToString();
            };

            stack.StackRemoved += () =>
            {
                if (dataGridView.Rows.Count > 0)
                    dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 1); ;

                objCount.Text = TransportCompany.countObj.ToString();
            };
        }
    }
}
