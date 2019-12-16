using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_23_Homework
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Address { get; set; }
        public int Protection { get; set; }
        public int TotalPurchases { get; set; }


        public Customer(int id, string name, int birthYear, string address, int protection)
        {
            Id = id;
            Name = name;
            BirthYear = birthYear;
            Address = address;
            Protection = protection;
            TotalPurchases = 0;
        }

        public override string ToString()
        {
            return $"Customer --- ID: {Id}, Name: {Name}, Birth Year: {BirthYear}, " +
                   $"Address: {Address}, Protection: {Protection}, Total Purchases: {TotalPurchases}";
        }
    }

    public class SortCustomerByProtection : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            if(x.Protection == y.Protection)
            {
                return 0;
            }
            else if(x.Protection > y.Protection)
            {
                return -1;
            }
            return 1;
        }
    }

    public class SortCustomerByTotalPurchases : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            if (x.TotalPurchases == y.TotalPurchases)
            {
                return 0;
            }
            else if (x.TotalPurchases > y.TotalPurchases)
            {
                return -1;
            }
            return 1;
        }
    }

    public class SortCustomerByBirthYear : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            if (x.BirthYear == y.BirthYear)
            {
                return 0;
            }
            else if (x.BirthYear > y.BirthYear)
            {
                return 1;
            }
            return -1;
        }
    }
}
