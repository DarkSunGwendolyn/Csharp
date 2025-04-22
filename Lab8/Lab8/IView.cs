using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public delegate void Add(int price, float transportedMass, string name,int completedOrders, string phoneNumber, string email);
    public delegate string Remove();
    public delegate Stack<TransportCompany> GetAll();
    public delegate void SaveChanges(int index, string selectedStrategy, string selectedMethod);
    public interface IView
    {
        string NameCompany { get; }
        int Price { get; }

        float TransportedMass { get; }

        int CompletedOrders { get; }

        string PhoneNumber { get; }

        string Email { get; }

        event Add AddClicked;

        event Remove RemoveClicked;

        event GetAll GetAllCalled;

        event SaveChanges SaveChangesClicked;

    }
}
