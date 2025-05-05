using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public class Controller
    {
        private StackTransportCompany companies;
        private TransportCompany prototype;

        public Controller()
        {
            companies = new StackTransportCompany();
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
        public void SaveChanges(int idx, string selectedStrategy, string selectedMethod)
        {

            var transportCompanies = companies.GetTransportCompanies().Reverse().ToList();
            var company = transportCompanies[idx];


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
        public Stack<TransportCompany> GetAll()
        {
            return companies.GetTransportCompanies();
        }
    }
}
