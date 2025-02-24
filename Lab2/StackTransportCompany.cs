using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class StackTransportCompany
    {
        private Stack<TransportCompany> transportCompanies;

        public delegate void AddToStack(TransportCompany company);
        public delegate void RemoveFromStack();

        public event AddToStack StackAdded;
        public event RemoveFromStack StackRemoved;

        public StackTransportCompany()
        {
            this.transportCompanies = new Stack<TransportCompany>();

        }
        public void AddCompany(TransportCompany company)
        {
            transportCompanies.Push(company);
            StackAdded(company);
        }

        public void DeleteCompany()
        {
            if (transportCompanies.Count > 0)
            {
                TransportCompany top = transportCompanies.Pop();
                StackRemoved();
            }
            else
            {
                throw new MyException("Стек пуст");
            }
        }
    }
}
