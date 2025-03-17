using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface ITransportMethod
    {
        string Deliver();
    }

    public class ShipTransport: ITransportMethod
    {
        public string Deliver()
        {
            return "Перевозка кораблем";
        }
    }

    public class TrackTransport: ITransportMethod
    {
        public string Deliver()
        {
            return "Перевозка грузовиком";
        }
    }

    public class AirTransport: ITransportMethod
    {
        public string Deliver()
        {
            return "Перевозка самолетом";
        }
    }
    public abstract class TransportCompany : ICloneable
    {
        protected ITransportMethod deliverMethod;
        protected int price { get; set; }
        protected float transportedMass { get; set; }
        protected string name { get; set; }
        protected float rating { get; set; }
        protected int completedOrders { get; set; }
        protected string phoneNumber { get; set; }
        protected string email { get; set; }

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

        public TransportCompany(int price, float transportedMass, string name, float rating, int completedOrders, string phoneNumber, string email, ITransportMethod transportMethod) : this(price, name)
        {
            this.transportedMass = transportedMass;
            this.rating = rating;
            this.completedOrders = completedOrders;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.deliverMethod = transportMethod;
        }

        public object Clone()
        {
            countObj++;
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "\tТрансопртная компания" + "\nНазвание: " + name + "\nЦена грузоперевозки: " + price + "\nМасса перевезенных грузов: " + transportedMass +  "\nРейтинг: " + rating + "\nКоличество выполненных заказов: " + completedOrders + "\nНомер компании: " + phoneNumber + "\nПочта компании: " + email;
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

        public virtual void DoWork()
        {
            deliverMethod.Deliver();
        }
    }

    public class LogisticCompany: TransportCompany
    {
        public LogisticCompany(int price, float transportedMass, string name, float rating, 
            int completedOrders, string phoneNumber, string email, 
            ITransportMethod transportMethod) : base(price, transportedMass, name, rating, completedOrders, phoneNumber, email, transportMethod)
        {

        }
    }
}
