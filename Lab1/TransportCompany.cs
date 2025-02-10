using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class TransportCompany
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
            name = "Undefined";
            rating = 0;
            completedOrders = 0;
            phoneNumber = "Undefined";
            email = "Undefined";
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
            return "\tТрансопртная компания:\n" + "Название   " + name + "\nцена грузоперевозки   " + price + "\nМасса перевезенных грузов   " + transportedMass +  "\nРейтинг   " + rating + "\nКоличество выполненных заказов   " + completedOrders + "\nНомер компании   " + phoneNumber + "\nПочта компании   " + email;
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }

        public void PriceToHex()
        {
            string hexPrice = price.ToString("X");
            Console.WriteLine(hexPrice);
        }


    }
}
