using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class StackTransportCompany
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

        public Stack<TransportCompany> GetTransportCompanies()
        {
            return transportCompanies;
        }

        public void AddCompany(TransportCompany company)
        {
            transportCompanies.Push(company);
            StackAdded?.Invoke(company);
        }

        public void DeleteCompany()
        {
            if (transportCompanies.Count == 0)
                throw new MyException("Стек пуст");

            TransportCompany top = transportCompanies.Pop();
            StackRemoved?.Invoke();
        }
    }
}
