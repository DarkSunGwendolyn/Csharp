using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class View2 : IView
    {

        public event Add AddClicked;
        public event Remove RemoveClicked;
        public event GetAll GetAllCalled;
        public event SaveChanges SaveChangesClicked;

        public string NameCompany { get; private set; }
        public int Price { get; private set; }
        public float TransportedMass { get; private set; }
        public int CompletedOrders { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }

        public View2()
        {
            var presenter = new Presenter(this);
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Добавить компанию");
                Console.WriteLine("2. Удалить последнюю компанию");
                Console.WriteLine("3. Показать все компании");
                Console.WriteLine("4. Изменить стратегию и метод доставки");
                Console.WriteLine("0. Выход");

                Console.Write("Выбор: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        try
                        {
                            ReadCompanyInput();
                            AddClicked?.Invoke(Price, TransportedMass, NameCompany, CompletedOrders, PhoneNumber, Email);
                            Console.WriteLine("Компания добавлена.");
                            break;
                        }
                        catch (MyException ex)
                        {
                            Console.WriteLine(ex.Message);
                            break;
                        }
                    case "2":
                        Console.WriteLine(RemoveClicked?.Invoke());
                        break;
                    case "3":
                        var companies = GetAllCalled?.Invoke();
                        PrintCompanies(companies);
                        break;
                    case "4":
                        Console.Write("Введите индекс компании (0 — первая): ");
                        int index = int.Parse(Console.ReadLine());

                        Console.Write("Выберите стратегию (По заказам / По цене / Комбин.): ");
                        string strategy = Console.ReadLine();

                        Console.Write("Выберите метод доставки (Track / Ship / Air): ");
                        string methodInput = Console.ReadLine();
                        string method = null;
                        switch (methodInput)
                        {
                            case "Track":
                                method = new TrackTransport().Deliver();
                                break;
                            case "Ship":
                                method = new ShipTransport().Deliver();
                                break;
                            case "Air":
                                method = new AirTransport().Deliver();
                                break;
                            default:
                                Console.WriteLine("Неверный ввод");
                                break;
                        }
                        SaveChangesClicked?.Invoke(index, strategy, method);
                        Console.WriteLine("Изменения сохранены.");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод.");
                        break;
                }
            }
        }

        private void ReadCompanyInput()
        {
            Console.Write("Название компании: ");
            NameCompany = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(NameCompany))
                throw new MyException("Название компании не может быть пустым.");

            Console.Write("Цена: ");
            if (!int.TryParse(Console.ReadLine(), out int price) || price < 0)
                throw new MyException("Некорректная цена.");
            Price = price;

            Console.Write("Перевезённая масса: ");
            if (!float.TryParse(Console.ReadLine(), out float mass) || mass < 0)
                throw new MyException("Некорректная масса.");
            TransportedMass = mass;

            Console.Write("Количество завершённых заказов: ");
            if (!int.TryParse(Console.ReadLine(), out int orders) || orders < 0)
                throw new MyException("Некорректное количество заказов.");
            CompletedOrders = orders;

            Console.Write("Телефон (11 цифр): ");
            PhoneNumber = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(PhoneNumber) || PhoneNumber.Length != 11 || !PhoneNumber.All(char.IsDigit))
                throw new MyException("Некорректный номер телефона.");

            Console.Write("Email (@mail.ru): ");
            Email = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Email) || !Email.EndsWith("@mail.ru"))
                throw new MyException("Некорректный email. Должен заканчиваться на @mail.ru.");
        }


        private void PrintCompanies(Stack<TransportCompany> companies)
        {
            if (companies == null || companies.Count == 0)
            {
                Console.WriteLine("\nСписок компаний пуст.");
                return;
            }

            Console.WriteLine("\nСписок компаний:");
            var list = companies.Reverse().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                var c = list[i];
                Console.WriteLine($"[{i}] {c.name} | Цена: {c.price} | Масса: {c.transportedMass} | Заказов: {c.completedOrders} | Рейтинг: {c.rating} | Стратегия: {c.ratingCalculationStrategy.TypeOfRating()} | Метод: {c.DoWork()}");
            }
        }
    }
}
