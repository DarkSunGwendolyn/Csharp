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
            this.view.GetAllCalled += GetAll;
            this.view.SaveChangesClicked += SaveChanges;

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

        public string DeleteCompany()
        {
            try
            {
                companies.DeleteCompany();
                return "Компания успешно удалена";
            }
            catch (MyException ex)
            {
                return ex.Message;
            }
        }

        public Stack<TransportCompany> GetAll()
        {
            return companies.GetTransportCompanies();
        }

        public void SaveChanges(int index, string selectedStrategy, string selectedMethod)
        {
            var transportCompanies = companies.GetTransportCompanies().Reverse().ToList();

            TransportCompany company = transportCompanies[index];

            if (selectedStrategy == "По заказам")
                company.ratingCalculationStrategy = new OrderBasedRating();
            else if (selectedStrategy == "По цене")
                company.ratingCalculationStrategy = new PriceBasedRating();
            else if (selectedStrategy == "Комбин.")
                company.ratingCalculationStrategy = new MixedRating();
            company.RecalculateRating();

            if (selectedMethod == new TrackTransport().Deliver())
                company.deliverMethod = new TrackTransport();
            else if (selectedMethod == new ShipTransport().Deliver())
                company.deliverMethod = new ShipTransport();
            else if (selectedMethod == new AirTransport().Deliver())
                company.deliverMethod = new AirTransport();
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
