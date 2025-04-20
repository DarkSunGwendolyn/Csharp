using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    // Паттерн Мост
    public interface ITransportMethod
    {
        string Deliver();
    }

    public class ShipTransport : ITransportMethod
    {
        public string Deliver()
        {
            return "Перевозка кораблем";
        }
    }

    public class TrackTransport : ITransportMethod
    {
        public string Deliver()
        {
            return "Перевозка грузовиком";
        }
    }

    public class AirTransport : ITransportMethod
    {
        public string Deliver()
        {
            return "Перевозка самолетом";
        }
    }

    // Паттерн Стратегия
    public interface IRatingCalculationStrategy
    {
        float CalculateRating(TransportCompany company);
        string TypeOfRating();
    }

    public class OrderBasedRating : IRatingCalculationStrategy
    {
        public float CalculateRating(TransportCompany company)
        {
            if (company.completedOrders == 0)
                return 0;

            return (float)Math.Round(10 * (1 - Math.Exp(-company.completedOrders / 50.0)), 2);
        }
        public string TypeOfRating()
        {
            return "По заказам";
        }
    }

    public class PriceBasedRating : IRatingCalculationStrategy
    {
        public float CalculateRating(TransportCompany company)
        {
            if (company.price == 0)
                return 0;

            return (float)Math.Round(10 * (1 - company.price / 2100.0f) * (1 - company.price / 2100.0f), 2);
        }
        public string TypeOfRating()
        {
            return "По цене";
        }
    }

    public class MixedRating : IRatingCalculationStrategy
    {
        public float CalculateRating(TransportCompany company)
        {
            float orderRating = new OrderBasedRating().CalculateRating(company);
            float priceRating = new PriceBasedRating().CalculateRating(company);

            return (float)Math.Round(0.6 * orderRating + 0.4 * priceRating, 2);
        }
        public string TypeOfRating()
        {
            return "Комбин.";
        }
    }



    public abstract class TransportCompany : ICloneable
    {
        public ITransportMethod deliverMethod { get; set; }
        public IRatingCalculationStrategy ratingCalculationStrategy { get; set; }
        public int price { get; set; }
        public float transportedMass { get; set; }
        public string name { get; set; }
        public float rating { get; set; }
        public int completedOrders { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public static int countObj = 0;

        public TransportCompany()
        {
            price = 0;
            transportedMass = 0;
            name = "";
            rating = 0;
            completedOrders = 0;
            phoneNumber = "";
            email = "";
            countObj++;
            deliverMethod = null;
        }

        public TransportCompany(int price) : this()
        {
            this.price = price;
        }

        public TransportCompany(int price, string name) : this(price)
        {
            this.name = name;
        }

        public TransportCompany(int price,
            float transportedMass,
            string name,
            int completedOrders,
            string phoneNumber,
            string email,
            ITransportMethod transportMethod) : this(price, name)
        {
            this.transportedMass = transportedMass;
            this.completedOrders = completedOrders;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.deliverMethod = transportMethod;
            this.ratingCalculationStrategy = new MixedRating();
            RecalculateRating();
        }

        public object Clone()
        {
            countObj++;
            return this.MemberwiseClone();
        }

        public virtual void RecalculateRating()
        {
            rating = ratingCalculationStrategy.CalculateRating(this);
        }

        public override string ToString()
        {
            return "\tТрансопртная компания" + "\nНазвание: " + name + "\nЦена грузоперевозки: " + price + "\nМасса перевезенных грузов: " + transportedMass + "\nРейтинг: " + rating + "\nКоличество выполненных заказов: " + completedOrders + "\nНомер компании: " + phoneNumber + "\nПочта компании: " + email;
        }

        public string PrintName()
        {
            if (string.IsNullOrEmpty(name))
                return "У фирмы нет названия";
            return "Название фирмы: " + name;
        }

        public string PriceToHex()
        {
            return Convert.ToString(price, 16);
        }

        public virtual string DoWork()
        {
            return deliverMethod.Deliver();
        }
    }

    public class LogisticCompany : TransportCompany
    {
        public LogisticCompany() { }

        public LogisticCompany(int price) : base(price) { }

        public LogisticCompany(int price,
            float transportedMass,
            string name,
            int completedOrders,
            string phoneNumber,
            string email,
            ITransportMethod transportMethod) : base(price, transportedMass, name, completedOrders,
                                                     phoneNumber, email, transportMethod)
        { }

        public override string DoWork()
        {
            return deliverMethod.Deliver();
        }

        public override void RecalculateRating()
        {
            rating = ratingCalculationStrategy.CalculateRating(this);
        }
    }



    public class StackTransportCompany
    {
        private Stack<TransportCompany> transportCompanies;

        public delegate void AddToStack(TransportCompany company);
        public delegate void RemoveFromStack();

        public event AddToStack StackAdded;
        public event RemoveFromStack StackRemoved;

        public StackTransportCompany()
        {
            this.transportCompanies = new Stack<TransportCompany>();
        }

        public Stack<TransportCompany> GetTransportCompanies()
        {
            return transportCompanies;
        }

        public void AddCompany(TransportCompany company)
        {
            transportCompanies.Push(company);
            StackAdded?.Invoke(company);
        }

        public void DeleteCompany()
        {
            if (transportCompanies.Count == 0)
                throw new MyException("Стек пуст");

            TransportCompany top = transportCompanies.Pop();
            StackRemoved?.Invoke();
        }
    }



    public class MyException : Exception
    {
        public MyException(string message) : base(message) { }
    }
}
