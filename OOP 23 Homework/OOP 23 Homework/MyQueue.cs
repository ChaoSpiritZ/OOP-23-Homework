using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_23_Homework
{
    public class MyQueue
    {
        private List<Customer> customers = new List<Customer>();
        public int Count
        {
            get
            {
                return customers.Count;
            }
        }

        public void Enqueue(Customer customer)
        {
            customers.Add(customer);
        }

        public Customer Dequeue()
        {
            if(customers.Count > 0)
            {
                Customer customer = customers[0];
                customers.RemoveAt(0);
                return customer;
            }
            return null;
        }

        public void Init(List<Customer> newCustomerList)
        {
            customers = newCustomerList;
        }

        public void Clear()
        {
            customers.Clear();
        }

        public Customer WhoIsNext()
        {
            if (customers.Count > 0)
            {
                return customers[0];
            }
            return null;
        }

        public Customer WhoIsInSpot(int index)
        {
            if (index >= 0 && index < customers.Count)
            {
                return customers[index];
            }
            else
            {
                return null;
            }
        }

        public void SortByProtection()
        {
            customers.Sort(new SortCustomerByProtection());
        }

        public void SortByTotalPurchases()
        {
            customers.Sort(new SortCustomerByTotalPurchases());
        }

        public void SortByBirthYear()
        {
            customers.Sort(new SortCustomerByBirthYear());
        }

        public List<Customer> DequeueCustomers(int amount)
        {
            if (amount > 0 && amount <= customers.Count)
            {
                List<Customer> queuedCustomers = new List<Customer>();
                for (int i = 0; i < amount; i++)
                {
                    queuedCustomers.Add(customers[0]);
                    customers.RemoveAt(0);
                }
                return queuedCustomers;
            }
            return null;
        }

        public void AniRakSheela(Customer customer)
        {
            customers.Insert(0, customer);
        }

        public Customer DequeueProtectzia()
        {
            if (customers.Count > 0)
            {
                List<Customer> customersDupe = new List<Customer>();
                foreach (Customer item in customers)
                {
                    customersDupe.Add(item);
                }
                SortByProtection();
                Customer customer = customers[0];
                customersDupe.Remove(customer);
                customers = customersDupe;
                return customer;
            }
            return null;
        }
    }
}
