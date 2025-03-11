using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class TransportCompany
    {
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
        }

        public TransportCompany(int price) : this()
        {
            this.price = price;
        }

        public TransportCompany(int price, string name) : this(price)
        {
            this.name = name;
        }

        public TransportCompany(int price, float transportedMass, string name, float rating, int completedOrders, string phoneNumber, string email) : this(price, name)
        {
            this.transportedMass = transportedMass;
            this.rating = rating;
            this.completedOrders = completedOrders;
            this.phoneNumber = phoneNumber;
            this.email = email;
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
    }
}
