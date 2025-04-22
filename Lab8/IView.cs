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
    public delegate void Remove();
    public delegate void ShowAll(DataGridView table);
    public delegate void SaveChanges(DataGridView table);
    public delegate void Generate_100000_Oblects(DataGridView table, TextBox objCount);
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

        event Generate_100000_Oblects Generate_100000_objs_clicked;

        event ShowAll ShowAllClicked;

        event SaveChanges SaveChangesClicked;

    }
}
