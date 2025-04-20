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

            controller = new Controller(dataGridView1, objCount);
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

        private void showAll_Click(object sender, EventArgs e)
        {
            controller.ShowAll(dataGridView1);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            controller.SaveChanges(dataGridView1);
        }

        private void generate_100000_objects_Click(object sender, EventArgs e)
        {
            controller.Generate10000Objects(dataGridView1, objCount);
        }
    }
}
