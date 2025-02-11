using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        TransportCompany firm;

        public Form1()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name.Text))
                    throw new MyException("Фирма должна иметь название");

                if (string.IsNullOrWhiteSpace(phoneNumber.Text))
                    throw new MyException("Фирма должна иметь номер");
                if (!Regex.IsMatch(phoneNumber.Text.Trim(), @"^\d{11}$"))
                    throw new MyException("Номер должен состоять из 11 цифр и не содержать буквы или символы");

                if (!Regex.IsMatch(email.Text.Trim(), @"^[a-zA-Z0-9_]+@mail\.ru$"))
                    throw new MyException("Неверный формат почты");

                firm = new TransportCompany((int)price.Value,
                    (float)transportedMass.Value,
                    name.Text,
                    (float)rating.Value,
                    (int)completedOrders.Value,
                    phoneNumber.Text,
                    email.Text);

                info.Text = firm.ToString();

                objCount.Text = TransportCompany.countObj.ToString();
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }            
        }

        private void nameShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (firm == null)
                    throw new MyException("Объект класса не создан");
                info.Text = firm.PrintName();
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void priceHex_Click(object sender, EventArgs e)
        {
            try
            {
                if (firm == null)
                    throw new MyException("Объект класса не создан");
                info.Text = "Цена перевозки в шестнадцатеричном представлении: " + firm.PriceToHex();
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
