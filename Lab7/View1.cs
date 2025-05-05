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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Collections;

namespace Lab2
{
    public partial class View1 : Form
    {

        
        private Controller controller;

        public View1()
        {
            InitializeComponent();

            controller = new Controller();
        }

        private void create_Click(object sender, EventArgs e)
        {
            try {
                controller.CreateCompany(
                            (int)price.Value,
                            (float)transportedMass.Value,
                            name.Text,
                            (int)completedOrders.Value,
                            phoneNumber.Text,
                            email.Text);

                objCount.Text = TransportCompany.countObj.ToString();
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            controller.DeleteCompany();
            TransportCompany.countObj--;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                string selectedStrategy = dataGridView1.Rows[i].Cells[3].Value.ToString();
                string selectedMethod = dataGridView1.Rows[i].Cells[8].Value.ToString();
                controller.SaveChanges(i, selectedStrategy, selectedMethod);
            }
            ShowAll();
            MessageBox.Show("Изменения успешно сохранены", "Сохранить");
        }

        private void ShowAll()
        {
            dataGridView1.Rows.Clear();

            foreach (var company in controller.GetAll().Reverse())
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = company.name;
                dataGridView1.Rows[rowIndex].Cells[1].Value = company.price.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = company.transportedMass.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = company.ratingCalculationStrategy.TypeOfRating();
                dataGridView1.Rows[rowIndex].Cells[4].Value = company.rating.ToString();
                dataGridView1.Rows[rowIndex].Cells[5].Value = company.completedOrders.ToString();
                dataGridView1.Rows[rowIndex].Cells[6].Value = company.phoneNumber;
                dataGridView1.Rows[rowIndex].Cells[7].Value = company.email;
                dataGridView1.Rows[rowIndex].Cells[8].Value = company.DoWork();
            }
        }
    }
}
