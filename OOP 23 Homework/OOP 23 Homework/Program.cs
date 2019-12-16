using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_23_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue mq = new MyQueue();

            mq.Enqueue(new Customer(1, "Lucas", 1978, "Endor", 66));
            mq.Enqueue(new Customer(2, "Mike", 1989, "The Streets", 24));
            mq.Enqueue(new Customer(3, "Jared", 1992, "In His House", 966));
            mq.Enqueue(new Customer(4, "Logan", 1474, "Firelink", 700));

            Console.WriteLine(mq.WhoIsInSpot(0));
            Console.WriteLine(mq.WhoIsInSpot(1));
            Console.WriteLine(mq.WhoIsInSpot(2));
            Console.WriteLine(mq.WhoIsInSpot(3));

            mq.SortByTotalPurchases();
            Console.WriteLine("===========================================================");
            Console.WriteLine("sorting customers by total purchases...");

            Console.WriteLine(mq.WhoIsInSpot(0));
            Console.WriteLine(mq.WhoIsInSpot(1));
            Console.WriteLine(mq.WhoIsInSpot(2));
            Console.WriteLine(mq.WhoIsInSpot(3));

            mq.SortByProtection();
            Console.WriteLine("===========================================================");
            Console.WriteLine("sorting customers by protection...");

            Console.WriteLine(mq.WhoIsInSpot(0));
            Console.WriteLine(mq.WhoIsInSpot(1));
            Console.WriteLine(mq.WhoIsInSpot(2));
            Console.WriteLine(mq.WhoIsInSpot(3));

            mq.SortByTotalPurchases();
            Console.WriteLine("===========================================================");
            Console.WriteLine("sorting customers by total purchases...");

            Console.WriteLine(mq.WhoIsInSpot(0));
            Console.WriteLine(mq.WhoIsInSpot(1));
            Console.WriteLine(mq.WhoIsInSpot(2));
            Console.WriteLine(mq.WhoIsInSpot(3));

            mq.SortByBirthYear();
            Console.WriteLine("===========================================================");
            Console.WriteLine("sorting customers by birth year...");

            Console.WriteLine(mq.WhoIsInSpot(0));
            Console.WriteLine(mq.WhoIsInSpot(1));
            Console.WriteLine(mq.WhoIsInSpot(2));
            Console.WriteLine(mq.WhoIsInSpot(3));
            Console.WriteLine(mq.WhoIsInSpot(4));

            mq.AniRakSheela(new Customer(542, "Karen", 1675, "Karenland", 0));
            Console.WriteLine("===========================================================");
            Console.WriteLine("customer has a question...");

            Console.WriteLine(mq.WhoIsInSpot(0));
            Console.WriteLine(mq.WhoIsInSpot(1));
            Console.WriteLine(mq.WhoIsInSpot(2));
            Console.WriteLine(mq.WhoIsInSpot(3));
            Console.WriteLine(mq.WhoIsInSpot(4));

            mq.SortByBirthYear();
            Console.WriteLine("===========================================================");
            Console.WriteLine("sorting customers by birth year...");

            Console.WriteLine(mq.WhoIsInSpot(0));
            Console.WriteLine(mq.WhoIsInSpot(1));
            Console.WriteLine(mq.WhoIsInSpot(2));
            Console.WriteLine(mq.WhoIsInSpot(3));
            Console.WriteLine(mq.WhoIsInSpot(4));

            mq.DequeueProtectzia();
            Console.WriteLine("===========================================================");
            Console.WriteLine("dequeueing customers by protection...");

            Console.WriteLine(mq.WhoIsInSpot(0));
            Console.WriteLine(mq.WhoIsInSpot(1));
            Console.WriteLine(mq.WhoIsInSpot(2));
            Console.WriteLine(mq.WhoIsInSpot(3));
            Console.WriteLine(mq.WhoIsInSpot(4));


        }
    }
}
