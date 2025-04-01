using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab2
{
    public class StackListener
    {
        private DataGridView dataGridView;
        private TextBox objCount;

        public StackListener(StackTransportCompany stack, DataGridView dataGridView, TextBox objCount)
        {
            this.dataGridView = dataGridView;
            this.objCount = objCount;

            stack.StackAdded += (TransportCompany company) =>
            {
                int rowIndex = dataGridView.Rows.Add();
                dataGridView.Rows[rowIndex].Cells[0].Value = company.name;
                dataGridView.Rows[rowIndex].Cells[1].Value = company.price.ToString();
                dataGridView.Rows[rowIndex].Cells[2].Value = company.transportedMass.ToString();
                dataGridView.Rows[rowIndex].Cells[3].Value = company.ratingCalculationStrategy.TypeOfRating();
                dataGridView.Rows[rowIndex].Cells[4].Value = company.rating.ToString();
                dataGridView.Rows[rowIndex].Cells[5].Value = company.completedOrders.ToString();
                dataGridView.Rows[rowIndex].Cells[6].Value = company.phoneNumber;
                dataGridView.Rows[rowIndex].Cells[7].Value = company.email;
                dataGridView.Rows[rowIndex].Cells[8].Value = company.DoWork();
                objCount.Text = TransportCompany.countObj.ToString();
            };

            stack.StackRemoved += () =>
            {
                if (dataGridView.Rows.Count > 0)
                    dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 1); ;

                objCount.Text = TransportCompany.countObj.ToString();
            };
        }
    }
}
